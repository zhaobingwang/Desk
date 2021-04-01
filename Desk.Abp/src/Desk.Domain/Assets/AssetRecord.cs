using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Desk.Assets
{
    public class AssetRecord : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public Guid CategoryId { get; set; }
        public bool IsDeleted { get; set; }

        public AssetRecord(Guid id, [NotNull] string name, float price, Guid categoryId, bool isDeleted) : base(id)
        {
            SetName(name);
            CategoryId = categoryId;
            IsDeleted = isDeleted;
            Price = price;
        }

        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(name), maxLength: AssetConsts.MaxRecordNameLength);
        }

        internal AssetRecord ChangePrice(float price)
        {
            Price = price;
            return this;
        }
    }
}
