using Desk.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Desk.Assets
{
    [Authorize(DeskPermissions.AssetRecords.Default)]
    public class AssetRecordAppService : DeskAppService, IAssetRecordAppService
    {
        private readonly IAssetRecordRepository _assetRecordRepository;
        private readonly AssetRecordManager _assetRecordManager;

        public AssetRecordAppService(IAssetRecordRepository assetRecordRepository, AssetRecordManager assetRecordManager)
        {
            _assetRecordRepository = assetRecordRepository;
            _assetRecordManager = assetRecordManager;
        }

        [Authorize(DeskPermissions.AssetRecords.Create)]
        public async Task<AssetRecordDto> CreateAsync(CreateAssetRecordDto input)
        {
            var recordExists = _assetRecordRepository.TodayRecordExistAsync(input.CategoryId);
            throw new AssetRecordAlreadyExistException(input.CategoryId, DateTime.Now);

            var ar = await _assetRecordManager.CreateAsync(input.CategoryId, input.Price);
            await _assetRecordRepository.InsertAsync(ar);
            return ObjectMapper.Map<AssetRecord, AssetRecordDto>(ar);
        }

        [Authorize(DeskPermissions.AssetCategories.Delete)]
        public async Task DeleteAsync(Guid id)
        {
            var ar = await _assetRecordRepository.GetAsync(id);
            ar.IsDeleted = true;
            await _assetRecordRepository.UpdateAsync(ar);
        }

        public async Task<AssetRecordDto> GetAsync(Guid id)
        {
            var ar = await _assetRecordRepository.GetAsync(id);
            return ObjectMapper.Map<AssetRecord, AssetRecordDto>(ar);
        }

        public async Task<PagedResultDto<AssetRecordDto>> GetListAsync(GetAssetRecordListDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(AssetRecord.Name);
            }

            var queryable = _assetRecordRepository.AsQueryable();

            var query = from ar in queryable
                        where ar.IsDeleted == false
                        select ar;

            query = query
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);

            var queryResult = await AsyncExecuter.ToListAsync(query);

            var arDtos = ObjectMapper.Map<List<AssetRecord>, List<AssetRecordDto>>(queryResult.ToList());
            var totalCount = _assetRecordRepository.Count(x => x.IsDeleted == false);
            return new PagedResultDto<AssetRecordDto>(totalCount, arDtos);
        }

        [Authorize(DeskPermissions.AssetRecords.Edit)]
        public async Task UpdateAsync(Guid id, UpdateAssetRecordDto input)
        {
            //var ar = await _assetRecordRepository.GetAsync(id);
            //ar.CategoryId = input.CategoryId;

            var ar = await _assetRecordManager.CreateAsync(id, input.CategoryId, input.Price);
            await _assetRecordRepository.UpdateAsync(ar);
        }
    }
}
