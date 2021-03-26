using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Desk.Assets
{
    public class UpdateAssetCategoryDto
    {
        [Required]
        [StringLength(AssetConsts.MaxCategoryNameLength)]
        public string Name { get; set; }
        public Guid ParentId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
