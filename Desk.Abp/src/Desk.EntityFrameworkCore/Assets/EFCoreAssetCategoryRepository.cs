using Desk.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Desk.Assets
{
    public class EFCoreAssetCategoryRepository : EfCoreRepository<DeskDbContext, AssetCategory, Guid>, IAssetCategoryRepository
    {
        public EFCoreAssetCategoryRepository(IDbContextProvider<DeskDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<int> CountUnDeletedAsync()
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.IsDeleted == false).CountAsync();
        }

        public async Task<AssetCategory> FindByNameAsync(string name)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(ac => ac.Name == name);
        }

        public async Task<List<AssetCategory>> GetListAsync(int skipCount, int maxResultCount, string sorting, string filter = null)
        {
            var dbSet = await GetDbSetAsync();
            var ac = await dbSet
                .WhereIf(!filter.IsNullOrWhiteSpace(), ac => ac.Name.Contains(filter))
                .OrderBy(sorting)
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();

            return ac;
        }

        public async Task<List<AssetCategory>> GetRootAsync(bool isDeleted = false)
        {
            var dbSet = await GetDbSetAsync();
            var ac = await dbSet
                .Where(x => x.ParentId == Guid.Empty && x.IsDeleted == isDeleted)
                .ToListAsync();
            return ac;
        }
    }
}
