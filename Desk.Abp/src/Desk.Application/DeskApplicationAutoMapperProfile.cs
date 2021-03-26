using AutoMapper;
using Desk.Assets;

namespace Desk
{
    public class DeskApplicationAutoMapperProfile : Profile
    {
        public DeskApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<AssetCategory, AssetCategoryDto>();
        }
    }
}
