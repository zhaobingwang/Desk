using Desk.Gist.ABPDemo.Authors;
using Desk.Gist.ABPDemo.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Desk.Gist.ABPDemo
{
    public class AbpDemoDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, Guid> _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly AuthorManager _authorManager;

        public AbpDemoDataSeederContributor(
            IRepository<Book, Guid> bookRepository,
            IAuthorRepository authorRepository,
            AuthorManager authorManager)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _authorManager = authorManager;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepository.GetCountAsync() > 0)
            {
                return;
            }


            #region 作者种子数据

            var liucixin = await _authorRepository.InsertAsync(
                 await _authorManager.CreateAsync("刘慈欣", new DateTime(1963, 6, 23), "刘慈欣（Cixin Liu），1963年6月出生于北京，祖籍河南省信阳市罗山，山西人 [1]  ，本科学历，高级工程师， [2]  科幻作家，中国作家协会会员、第九届全委会委员， [3]  中国科普作家协会会员，山西省作家协会副主席 [4-5]  ，阳泉市作家协会副主席，同时也是中国科幻小说代表作家之一。")
             );
            var qianzhongshu = await _authorRepository.InsertAsync(
                await _authorManager.CreateAsync("钱钟书", new DateTime(1910, 11, 21), "钱锺书（1910年11月21日—1998年12月19日），原名仰先，字哲良，后改名锺书，字默存，号槐聚，曾用笔名锺书君，江苏无锡人，中国现代作家、文学研究家，与饶宗颐并称“南饶北钱”。 [1]")
            );
            #endregion

            #region 书籍种子数据
            await _bookRepository.InsertAsync(
                    new Book
                    {
                        AuthorId = liucixin.Id,
                        Name = "三体Ⅱ·黑暗森林",
                        Type = BookType.文学,
                        PublishDate = new DateTime(2008, 5, 1),
                        Price = 32.00f
                    },
                    autoSave: true
                );
            await _bookRepository.InsertAsync(
                new Book
                {
                    AuthorId = qianzhongshu.Id,
                    Name = "围城",
                    Type = BookType.文学,
                    PublishDate = new DateTime(1946, 1, 1),
                    Price = 39.00f
                },
                autoSave: true
            );
            #endregion
        }

    }
}
