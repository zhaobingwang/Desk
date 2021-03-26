using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Desk.Assets
{
    public interface IAssetCategoryRepository : IRepository<AssetCategory, Guid>
    {
        Task<AssetCategory> FindByNameAsync(string name);
        Task<List<AssetCategory>> GetListAsync(int skipCount, int maxResultCount, string sorting, string filter = null);
        Task<List<AssetCategory>> GetRootAsync(bool isDeleted = false);

        Task<int> CountUnDeletedAsync();
    }
}
