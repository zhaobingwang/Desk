using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Infrastructure.Entities
{
    public class AssetType
    {
        public string Code { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// 分类方法
        /// 0：默认
        /// </summary>
        public string Method { get; set; }
    }
}
