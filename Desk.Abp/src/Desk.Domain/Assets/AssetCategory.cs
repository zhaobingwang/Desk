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
    public class AssetCategory : AuditedAggregateRoot<Guid>
    {
        public string Name { get; private set; }
        public Guid ParentId { get; set; }
        public bool IsDeleted { get; set; }

        internal AssetCategory(Guid id, [NotNull] string name, Guid parentId, bool isDeleted) : base(id)
        {
            SetName(name);
            ParentId = parentId;
            IsDeleted = isDeleted;
        }

        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(name), maxLength: AssetConsts.MaxCategoryNameLength);
        }

        internal AssetCategory ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }
    }
}
