using Desk.Gist.ABPDemo.Books;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Desk.Gist.ABPDemo.Web.Pages.Books
{
    public class CreateModalModel : ABPDemoPageModel
    {
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public CreateModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public void OnGet()
        {
            Book = new CreateUpdateBookDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}
