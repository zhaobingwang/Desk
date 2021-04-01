using System;
using System.Collections.Generic;
using System.Text;

namespace Desk.Assets
{
    public class AssetRecordDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public Guid CategoryId { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
