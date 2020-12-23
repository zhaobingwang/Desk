using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desk.Infrastructure.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Desk.Infrastructure.Data
{
    public static class SeedDataV2
    {
        public static async Task SeedAsync(string connectionString)
        {
            var dbContext = new DeskDbContextV2(connectionString);
            if (!dbContext.AssetTypes.Any())
            {
                await dbContext.AssetTypes.AddRangeAsync(GetAssetType());
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.SysDictTypes.Any())
            {
                await dbContext.SysDictTypes.AddRangeAsync(GetDictTypes());
                await dbContext.SaveChangesAsync();
            }
        }

        private static List<AssetType> GetAssetType()
        {
            List<AssetType> assetTypes = new List<AssetType>();
            assetTypes.Add(new AssetType
            {
                Code = "ALIPAY_TOTAL",
                Name = "支付宝总资产",
                Method = "0",
            });
            assetTypes.Add(new AssetType
            {
                Code = "WX_TOTAL",
                Name = "微信总资产",
                Method = "0",
            });
            assetTypes.Add(new AssetType
            {
                Code = "QIEMAN_TOTAL",
                Name = "且慢总资产",
                Method = "0",
            });
            assetTypes.Add(new AssetType
            {
                Code = "BANK_TOTAL",
                Name = "银行总资产",
                Method = "0",
            });
            assetTypes.Add(new AssetType
            {
                Code = "COMMON_RESERVE_FUND_TOTAL",
                Name = "公积金总资产",
                Method = "0",
            });

            return assetTypes;
        }

        private static List<SysDictType> GetDictTypes()
        {
            var now = DateTime.Now;
            List<SysDictType> dictTypes = new List<SysDictType>();
            dictTypes.Add(new SysDictType
            {

                Code = "REGION-CODE-ABOVE-COUNTY-LEVEL-CN",
                Name = "中华人民共和国县以上行政区划代码",
                Description = "中华人民共和国县以上行政区划代码",
                InternalVersion = "1.0",
                IsBuiltin = YesOrNo.Yes,
                Status = Status.Normal,
                CreateTime = now,
                CreateUser = "System",
                UpdateTime = now,
                UpdateUser = "System"
            });

            return dictTypes;
        }
    }
}
