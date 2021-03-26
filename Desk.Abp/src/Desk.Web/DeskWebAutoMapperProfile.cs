using AutoMapper;
using Desk.Assets;

namespace Desk.Web
{
    public class DeskWebAutoMapperProfile : Profile
    {
        public DeskWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.CreateAssetCategoryViewModel
            CreateMap<Pages.AssetCategories.CreateModalModel.CreateAssetCategoryViewModel, CreateAssetCategoryDto>();
        }
    }
}
