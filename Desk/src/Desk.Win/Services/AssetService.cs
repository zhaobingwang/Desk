using Desk.Infrastructure.Data;
using Desk.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Win.Services
{
    public class AssetService
    {
        private readonly DeskDbContext _dbContext;

        public AssetService(DeskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<AssetType>> GetAssetTypesAsync()
        {
            return await _dbContext.AssetTypes.ToListAsync();
        }
    }
}
