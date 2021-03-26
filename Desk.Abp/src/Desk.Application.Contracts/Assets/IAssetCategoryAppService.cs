using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Desk.Assets
{
    public interface IAssetCategoryAppService
    {
        Task<AssetCategoryDto> GetAsync(Guid id);
        Task<PagedResultDto<AssetCategoryDto>> GetListAsync(GetAssetCategoryListDto input);
        Task<AssetCategoryDto> CreateAsync(CreateAssetCategoryDto input);
        Task UpdateAsync(Guid id, UpdateAssetCategoryDto input);
        Task DeleteAsync(Guid id);

        Task<List<AssetCategoryDto>> GetRootListAsync();
    }
}
