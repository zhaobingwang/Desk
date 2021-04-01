using Desk.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Desk.Assets
{
    public class EFCoreAssetRecordRepository : EfCoreRepository<DeskDbContext, AssetRecord, Guid>, IAssetRecordRepository
    {
        public EFCoreAssetRecordRepository(IDbContextProvider<DeskDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<bool> TodayRecordExistAsync(Guid categoryId, DateTime? today = null)
        {
            if (today == null)
            {
                today = DateTime.Today;
            }
            var dbSet = await GetDbSetAsync();
            var count = dbSet.Count(
                x => x.CreationTime.StartOfCurrentDay() == today.Value.StartOfCurrentDay() &&
                x.CategoryId == categoryId);
            return count > 0;
        }
    }
}
