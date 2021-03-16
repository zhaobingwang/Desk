using AutoMapper;
using Desk.Gist.ABPDemo.Books;

namespace Desk.Gist.ABPDemo
{
    public class ABPDemoApplicationAutoMapperProfile : Profile
    {
        public ABPDemoApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
            CreateMap<BookDto, CreateUpdateBookDto>();
        }
    }
}
