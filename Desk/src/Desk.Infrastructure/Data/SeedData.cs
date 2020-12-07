using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desk.Infrastructure.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Desk.Infrastructure.Data
{
    public static class SeedData
    {
        public static async Task SeedAsync(IServiceProvider provider)
        {
            var dbContext = provider.GetService<DeskDbContext>();
            if (!dbContext.AssetTypes.Any())
            {
                await dbContext.AssetTypes.AddRangeAsync(GetAssetType());
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
    }
}
