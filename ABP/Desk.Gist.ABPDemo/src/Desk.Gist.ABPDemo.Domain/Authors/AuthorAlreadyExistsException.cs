using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Desk.Gist.ABPDemo.Authors
{
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name) : base(ABPDemoDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
