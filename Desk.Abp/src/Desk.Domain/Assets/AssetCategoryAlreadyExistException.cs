using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Desk.Assets
{
    public class AssetCategoryAlreadyExistException : BusinessException
    {
        public AssetCategoryAlreadyExistException(string name) : base(DeskDomainErrorCodes.AssetCategoryAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
