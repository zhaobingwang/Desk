using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Desk.Assets
{
    public class AssetRecordNotFoundException : BusinessException
    {
        public AssetRecordNotFoundException(Guid id) : base(DeskDomainErrorCodes.AssetRecordNotFound)
        {
            WithData("id", id);
        }
    }
}
