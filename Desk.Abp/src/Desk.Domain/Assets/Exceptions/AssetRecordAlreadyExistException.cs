using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Validation;

namespace Desk.Assets
{
    public class AssetRecordAlreadyExistException : BusinessException, IHasValidationErrors
    {
        private List<ValidationResult> validationResults = new List<ValidationResult>();
        public AssetRecordAlreadyExistException(Guid categoryId, DateTime today) : base(DeskDomainErrorCodes.AssetRecordyAlreadyExists)
        {
            WithData("category", new Tuple<Guid, DateTime>(categoryId, today.StartOfCurrentDay()));
            validationResults.Add(new ValidationResult("当日此类型资产记录已存在，不允许重复新增", new List<string> { categoryId.ToString() }));
        }

        public IList<ValidationResult> ValidationErrors
        {
            get
            {
                return validationResults;
            }
        }
    }
}
