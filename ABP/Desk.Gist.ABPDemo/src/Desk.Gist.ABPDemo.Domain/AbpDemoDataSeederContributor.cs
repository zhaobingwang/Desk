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

        public AbpDemoDataSeederContributor(IRepository<Book, Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepository.GetCountAsync() <= 0)
            {
                await _bookRepository.InsertAsync(
                    new Book
                    {
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
                        Name = "五年高考·三年模拟",
                        Type = BookType.未知,
                        PublishDate = new DateTime(2008, 1, 1),
                        Price = 26.00f
                    },
                    autoSave: true
                );
            }
        }
    }
}
