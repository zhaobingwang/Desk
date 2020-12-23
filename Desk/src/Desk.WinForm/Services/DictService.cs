using Desk.Infrastructure.Data;
using Desk.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.WinForm.Services
{
    public class DictService : BaseService
    {
        private DeskDbContextV2 db;
        public DictService()
        {
            db = DeskDbContext;
        }

        public async Task AddDictType(SysDictType sysDictType)
        {
            await db.SysDictTypes.AddAsync(sysDictType);
            await db.SaveChangesAsync();
        }

        public async Task AddDicts(List<SysDict> sysDicts)
        {
            await db.SysDicts.AddRangeAsync(sysDicts);
            await db.SaveChangesAsync();
        }
    }
}
