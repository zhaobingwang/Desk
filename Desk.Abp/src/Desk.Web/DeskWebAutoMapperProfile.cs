using AutoMapper;
using Desk.Assets;

namespace Desk.Web
{
    public class DeskWebAutoMapperProfile : Profile
    {
        public DeskWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.CreateAssetCategoryViewModel

            // Asset-Category
            CreateMap<Pages.AssetCategories.CreateModalModel.CreateAssetCategoryViewModel, CreateAssetCategoryDto>();
            CreateMap<AssetCategoryDto, Pages.AssetCategories.EditModalModel.EditAssetCategotyViewModel>();
            CreateMap<Pages.AssetCategories.EditModalModel.EditAssetCategotyViewModel, UpdateAssetCategoryDto>();

            // Asset-Record
            CreateMap<Pages.AssetRecords.CreateModalModel.CreateAssetRecordViewModel, CreateAssetRecordDto>();
            CreateMap<Pages.AssetRecords.EditModalModel.EditAssetRecordViewModel, UpdateAssetRecordDto>();
            CreateMap<AssetRecordDto, Pages.AssetRecords.EditModalModel.EditAssetRecordViewModel>();
        }
    }
}
