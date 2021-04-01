using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Desk.Assets
{
    public interface IAssetRecordRepository : IRepository<AssetRecord, Guid>
    {
        Task<bool> TodayRecordExistAsync(Guid categoryId, DateTime? today = null);
    }
}
