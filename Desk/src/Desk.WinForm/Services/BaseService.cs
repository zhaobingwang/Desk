using Desk.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desk.WinForm.Services
{
    public class BaseService
    {
        protected string ConnectionString { get; }
        protected DeskDbContextV2 DeskDbContext { get; }
        public BaseService()
        {
            ConnectionString = "Data Source = C:\\LocalDB\\SQLite\\Desk.db";
            DeskDbContext = new DeskDbContextV2(ConnectionString);
        }
    }
}
