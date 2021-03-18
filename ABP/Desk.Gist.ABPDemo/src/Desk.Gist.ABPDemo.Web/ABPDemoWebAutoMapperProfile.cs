using AutoMapper;
using Desk.Gist.ABPDemo.Authors;

namespace Desk.Gist.ABPDemo.Web
{
    public class ABPDemoWebAutoMapperProfile : Profile
    {
        public ABPDemoWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.

            CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel,
                      CreateAuthorDto>();

            // ADD THESE NEW MAPPINGS
            CreateMap<AuthorDto, Pages.Authors.EditModalModel.EditAuthorViewModel>();
            CreateMap<Pages.Authors.EditModalModel.EditAuthorViewModel,
                      UpdateAuthorDto>();
        }
    }
}
