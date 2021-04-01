using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Desk.Assets
{
    public class AssetCategoryNotFoundException : BusinessException
    {
        public AssetCategoryNotFoundException(Guid id) : base(DeskDomainErrorCodes.AssetCategoryNotFound)
        {
            WithData("id", id);
        }
    }
}
