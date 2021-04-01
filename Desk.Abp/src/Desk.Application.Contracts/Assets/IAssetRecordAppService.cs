using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Desk.Assets
{
    public interface IAssetRecordAppService : IApplicationService
    {
        Task<AssetRecordDto> GetAsync(Guid id);
        Task<PagedResultDto<AssetRecordDto>> GetListAsync(GetAssetRecordListDto input);
        Task<AssetRecordDto> CreateAsync(CreateAssetRecordDto input);
        Task UpdateAsync(Guid id, UpdateAssetRecordDto input);
        Task DeleteAsync(Guid id);
    }
}
