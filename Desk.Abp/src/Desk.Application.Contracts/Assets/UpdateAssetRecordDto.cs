using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Desk.Assets
{
    public class UpdateAssetRecordDto
    {
        //[Required]
        //[StringLength(AssetConsts.MaxRecordNameLength)]
        //public string Name { get; set; }
        public float Price { get; set; }
        public Guid CategoryId { get; set; }
        //public bool IsDeleted { get; set; }
    }
}
