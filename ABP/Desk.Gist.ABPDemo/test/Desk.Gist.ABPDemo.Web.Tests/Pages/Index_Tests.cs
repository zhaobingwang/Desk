﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Desk.Gist.ABPDemo.Pages
{
    public class Index_Tests : ABPDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
