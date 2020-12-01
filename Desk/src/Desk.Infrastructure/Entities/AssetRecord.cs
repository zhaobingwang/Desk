using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Entities
{
    public class AssetRecord
    {
        public int Id { get; set; }

        public string TypeCode { get; set; }

        public string TypeName { get; set; }

        public decimal TotalAsset { get; set; }

        public DateTime CreateTime { get; set; }

        public IsDeleted IsDeleted { get; set; }
    }
}
