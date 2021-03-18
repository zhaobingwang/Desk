using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desk.Gist.ABPDemo.Authors
{
    public class AuthorAppService_Tests : ABPDemoApplicationTestBase
    {
        private readonly IAuthorAppService _authorAppService;
        public AuthorAppService_Tests()
        {
            _authorAppService = GetRequiredService<IAuthorAppService>();
        }

        [Fact]
        public async Task Should_Get_All_Authors_Without_Any_Filter()
        {
            var result = await _authorAppService.GetListAsync(new GetAuthorListDto());

            result.TotalCount.ShouldBeGreaterThanOrEqualTo(2);
            result.Items.ShouldContain(author => author.Name == "刘慈欣");
            result.Items.ShouldContain(author => author.Name == "钱钟书");
        }

        [Fact]
        public async Task Should_Get_Filtered_Authors()
        {
            var result = await _authorAppService.GetListAsync(new GetAuthorListDto { Filter = "刘" });

            result.TotalCount.ShouldBeGreaterThanOrEqualTo(1);
            result.Items.ShouldContain(author => author.Name == "刘慈欣");
            result.Items.ShouldNotContain(author => author.Name == "钱钟书");
        }

        [Fact]
        public async Task Should_Create_A_New_Author()
        {
            var authorDto = await _authorAppService.CreateAsync(new CreateAuthorDto
            {
                Name = "鲁迅",
                BirthDate = new DateTime(1881, 9, 25),
                ShortBio = "鲁迅，原名周樟寿，后改名周树人，字豫山，后改字豫才，浙江绍兴人。著名文学家、思想家、革命家、民主战士，新文化运动的重要参与者，中国现代文学的奠基人之一。"
            });

            authorDto.Id.ShouldNotBe(Guid.Empty);
            authorDto.Name.ShouldBe("鲁迅");
        }

        [Fact]
        public async Task Should_Not_Allow_To_Create_Duplicate_Author()
        {
            await Assert.ThrowsAsync<AuthorAlreadyExistsException>(async () =>
            {
                await _authorAppService.CreateAsync(
                    new CreateAuthorDto
                    {
                        Name = "刘慈欣",
                        BirthDate = new DateTime(1963, 6, 23),
                        ShortBio = "刘慈欣（Cixin Liu），1963年6月出生于北京，祖籍河南省信阳市罗山，山西人 [1]  ，本科学历，高级工程师， [2]  科幻作家，中国作家协会会员、第九届全委会委员， [3]  中国科普作家协会会员，山西省作家协会副主席 [4-5]  ，阳泉市作家协会副主席，同时也是中国科幻小说代表作家之一。"
                    }
                );
            });
        }
    }
}
