using Desk.Infrastructure.Data;
using Desk.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Desk.WinForm.Services
{
    public class AssetService : BaseService
    {
        private DeskDbContextV2 db;
        public AssetService()
        {
            db = DeskDbContext;
        }
        public async Task<List<AssetType>> GetAssetTypesAsync()
        {
            var result = await db.AssetTypes.ToListAsync();
            return result;
        }

        public async Task<List<AssetStatistics>> GetAssetAsync()
        {
            var assetRecords = await db.AssetRecords.ToListAsync();
            var result = assetRecords.GroupBy(x => x.CreateTime.ToString("yyyy-MM-dd")).Select(x => new AssetStatistics { Day = x.Key, Total = x.Sum(y => y.TotalAsset) });
            return result.ToList();
        }

        public async Task<List<AssetRecord>> GetAssetRecordsAsync()
        {
            var result = await db.AssetRecords.Where(x => x.CreateTime >= DateTime.Now.AddDays(-30)).ToListAsync();
            return result;
        }

        public async Task<AssetRecord> TodayAssetRecordsExist(string typeCode)
        {
            var now = DateTime.Now;
            var result = await db.AssetRecords
                .FirstOrDefaultAsync(
                    x => x.CreateTime.Year == now.Year &&
                    x.CreateTime.Month == now.Month &&
                    x.CreateTime.Day == now.Day &&
                    x.TypeCode == typeCode);
            return result;
        }

        public async Task AddAssetRecord(string typeCode, string typeName, decimal total)
        {
            await db.AssetRecords.AddAsync(new AssetRecord
            {
                TypeCode = typeCode,
                TypeName = typeName,
                TotalAsset = total,
                CreateTime = DateTime.Now,
                IsDeleted = Infrastructure.IsDeleted.No,
            });

            await db.SaveChangesAsync();
        }
        public async Task UpdateAssetRecord(AssetRecord assetRecord)
        {
            db.AssetRecords.Update(assetRecord);

            await db.SaveChangesAsync();
        }
    }

    public class AssetStatistics
    {
        public string Day { get; set; }
        public decimal Total { get; set; }
    }
}
