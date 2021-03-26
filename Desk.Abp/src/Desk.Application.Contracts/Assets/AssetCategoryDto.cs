using System;
using System.Collections.Generic;
using System.Text;

namespace Desk.Assets
{
    public class AssetCategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ParentId { get; set; }
        public string ParentName { get; set; }
    }
}
