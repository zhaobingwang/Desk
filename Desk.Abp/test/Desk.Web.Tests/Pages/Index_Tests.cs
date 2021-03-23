using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Desk.Pages
{
    public class Index_Tests : DeskWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
