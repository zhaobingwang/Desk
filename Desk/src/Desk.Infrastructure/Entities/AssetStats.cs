using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Entities
{
    /// <summary>
    /// Asset statistics
    /// </summary>
    public class AssetStats
    {
        public int Id { get; set; }
        public decimal TotalAsset { get; set; }
        public string Keyword { get; set; }
        public StatsType StatsType { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
