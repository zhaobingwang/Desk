using Desk.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Desk.Assets
{
    [Authorize(DeskPermissions.AssetCategories.Default)]
    public class AssetCategoryAppService : DeskAppService, IAssetCategoryAppService
    {
        private readonly IAssetCategoryRepository _assetCategoryRepository;
        private readonly AssetCategoryManager _assetCategoryManager;

        public AssetCategoryAppService(IAssetCategoryRepository assetCategoryRepository, AssetCategoryManager assetCategoryManager)
        {
            _assetCategoryRepository = assetCategoryRepository;
            _assetCategoryManager = assetCategoryManager;
        }

        [Authorize(DeskPermissions.AssetCategories.Create)]
        public async Task<AssetCategoryDto> CreateAsync(CreateAssetCategoryDto input)
        {
            var assetCategory = await _assetCategoryManager.CreateAsync(input.Name, input.ParentId, false);
            await _assetCategoryRepository.InsertAsync(assetCategory);

            return ObjectMapper.Map<AssetCategory, AssetCategoryDto>(assetCategory);
        }

        [Authorize(DeskPermissions.AssetCategories.Delete)]
        public async Task DeleteAsync(Guid id)
        {
            // if it's root category, delete all.
            var acs = await _assetCategoryRepository.GetIncludeParentIdAsync(id);
            acs.ForEach(x => x.IsDeleted = true);
            await _assetCategoryRepository.UpdateManyAsync(acs);
        }

        public async Task<AssetCategoryDto> GetAsync(Guid id)
        {
            var ac = await _assetCategoryRepository.GetAsync(id);
            return ObjectMapper.Map<AssetCategory, AssetCategoryDto>(ac);
        }

        public async Task<PagedResultDto<AssetCategoryDto>> GetListAsync(GetAssetCategoryListDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(AssetCategory.Name);
            }

            var queryable = _assetCategoryRepository.AsQueryable();

            //var query = from ac1 in queryable
            //            join ac2 in queryable on ac1.ParentId equals ac2.Id
            //            select new AssetCategoryDto { Id = ac1.Id, Name = ac1.Name, ParentId = ac1.ParentId, ParentName = ac2.Name };

            var query = from ac1 in queryable
                        where ac1.IsDeleted == false
                        join ac2 in queryable on ac1.ParentId equals ac2.Id into tmp
                        from ac in tmp.DefaultIfEmpty()
                        select new AssetCategoryDto { Id = ac1.Id, Name = ac1.Name, ParentId = ac1.ParentId, ParentName = ac.Name == null ? "Root" : ac.Name };

            query = query
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);

            var queyryResult = await AsyncExecuter.ToListAsync(query);

            var acDtos = queyryResult.ToList();
            var totalCount = await _assetCategoryRepository.CountUnDeletedAsync();
            return new PagedResultDto<AssetCategoryDto>(totalCount, acDtos);

            //var ac = await _assetCategoryRepository.GetListAsync(input.SkipCount, input.MaxResultCount, input.Sorting, input.Filter);

            //var totalCount = input.Filter == null
            //    ? await _assetCategoryRepository.CountAsync()
            //    : await _assetCategoryRepository.CountAsync(ac => ac.Name.Contains(input.Filter));

            //return new PagedResultDto<AssetCategoryDto>(totalCount, ObjectMapper.Map<List<AssetCategory>, List<AssetCategoryDto>>(ac));
        }
        public async Task<List<AssetCategoryDto>> GetRootListAsync()
        {
            var ac = await _assetCategoryRepository.GetRootAsync();
            return ObjectMapper.Map<List<AssetCategory>, List<AssetCategoryDto>>(ac);
        }

        [Authorize(DeskPermissions.AssetCategories.Edit)]
        public async Task UpdateAsync(Guid id, UpdateAssetCategoryDto input)
        {
            var ac = await _assetCategoryRepository.GetAsync(id);

            if (ac.Name != input.Name)
            {
                await _assetCategoryManager.ChangeNameAsync(ac, input.Name);
            }

            ac.ParentId = input.ParentId;

            await _assetCategoryRepository.UpdateAsync(ac);
        }
    }
}
