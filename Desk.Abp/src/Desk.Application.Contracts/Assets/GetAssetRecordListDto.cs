using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Desk.Assets
{
    public class GetAssetRecordListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
