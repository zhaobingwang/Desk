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
    public class AssetCategoryManager : DomainService
    {
        private readonly IAssetCategoryRepository _assetCategoryRepository;

        public AssetCategoryManager(IAssetCategoryRepository assetCategoryRepository)
        {
            _assetCategoryRepository = assetCategoryRepository;
        }

        public async Task<AssetCategory> CreateAsync([NotNull] string name, Guid parentId, bool isDeleted)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));
            var existCategory = await _assetCategoryRepository.FindByNameAsync(name);
            if (existCategory != null)
            {
                throw new AssetCategoryAlreadyExistException(name);
            }
            return new AssetCategory(GuidGenerator.Create(), name, parentId, isDeleted);
        }

        public async Task ChangeNameAsync([NotNull] AssetCategory assetCategory, [NotNull] string newName)
        {
            Check.NotNull(assetCategory, nameof(assetCategory));
            Check.NotNullOrWhiteSpace(newName, nameof(newName));

            var existingCategory = await _assetCategoryRepository.FindByNameAsync(newName);
            if (existingCategory != null && existingCategory.Id != assetCategory.Id)
            {
                throw new AssetCategoryAlreadyExistException(newName);
            }

            assetCategory.ChangeName(newName);
        }
    }
}
