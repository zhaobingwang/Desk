using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Desk.Assets
{
    public class AssetRecord : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public Guid CategoryId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
