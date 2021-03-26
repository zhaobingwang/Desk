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
    }
}
