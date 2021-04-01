using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace Desk.Assets
{
    public class AssetRecordManager : DomainService
    {
        private readonly IAssetRecordRepository _assetRecordRepository;
        private readonly IAssetCategoryRepository _assetCategoryRepository;

        public AssetRecordManager(IAssetRecordRepository assetRecordRepository, IAssetCategoryRepository assetCategoryRepository)
        {
            _assetRecordRepository = assetRecordRepository;
            _assetCategoryRepository = assetCategoryRepository;
        }

        public async Task<AssetRecord> CreateAsync([NotNull] Guid categoryId, float price, bool isDeleted = false)
        {
            var ac = await _assetCategoryRepository.GetAsync(categoryId);
            if (ac == null)
            {
                throw new AssetCategoryNotFoundException(categoryId);
            }
            return new AssetRecord(GuidGenerator.Create(), ac.Name, price, categoryId, isDeleted);
        }

        public async Task<AssetRecord> CreateAsync(Guid id, [NotNull] Guid categoryId, float price, bool isDeleted = false)
        {
            var ac = await _assetCategoryRepository.GetAsync(categoryId);
            var ar = await _assetRecordRepository.GetAsync(id);
            if (ac == null)
            {
                throw new AssetCategoryNotFoundException(categoryId);
            }
            if (ac == null)
            {
                throw new AssetRecordNotFoundException(id);
            }
            ar.Price = price;
            ar.IsDeleted = isDeleted;
            return ar;
        }
    }
}
