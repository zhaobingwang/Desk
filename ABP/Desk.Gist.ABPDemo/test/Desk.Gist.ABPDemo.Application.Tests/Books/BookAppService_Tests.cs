using Desk.Gist.ABPDemo.Authors;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace Desk.Gist.ABPDemo.Books
{
    public class BookAppService_Tests : ABPDemoApplicationTestBase
    {
        private readonly IBookAppService _bookAppService;
        private readonly IAuthorAppService _authorAppService;
        public BookAppService_Tests()
        {
            _bookAppService = GetRequiredService<IBookAppService>();
            _authorAppService = GetRequiredService<IAuthorAppService>();
        }

        [Fact]
        public async Task Should_Get_List_Of_Books()
        {
            // Act
            var result = await _bookAppService.GetListAsync(
                new PagedAndSortedResultRequestDto()
            );

            // Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(b => b.Name == "三体Ⅱ·黑暗森林" &&
                                            b.AuthorName == "刘慈欣");
        }

        [Fact]
        public async Task Should_Create_A_Valid_Book()
        {
            var authors = await _authorAppService.GetListAsync(new GetAuthorListDto());
            var firstAuthor = authors.Items.First();
            // Act
            var result = await _bookAppService.CreateAsync(
                new CreateUpdateBookDto
                {
                    AuthorId = firstAuthor.Id,
                    Name = "测试",
                    Price = 28,
                    PublishDate = DateTime.Now,
                    Type = BookType.文学
                }
            );

            // Assert
            result.Id.ShouldNotBe(Guid.Empty);
            result.Name.ShouldBe("测试");
        }

        [Fact]
        public async Task Should_Not_Create_A_Book_Without_Name()
        {
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _bookAppService.CreateAsync(new CreateUpdateBookDto
                {
                    Name = "",
                    Price = 28,
                    PublishDate = DateTime.Now,
                    Type = BookType.科技
                });
            });

            exception.ValidationErrors.ShouldContain(err => err.MemberNames.Any(men => men == "Name"));
        }
    }
}
