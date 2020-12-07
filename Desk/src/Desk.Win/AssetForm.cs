using Desk.Infrastructure.Data;
using Desk.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.Win
{
    public partial class AssetForm : BaseForm
    {
        private readonly DeskDbContext _dbContext;

        public AssetForm(DeskDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }


        //private void AssetForm_Load(object sender, EventArgs e)
        private async void AssetForm_Load(object sender, EventArgs e)
        {
            var assetTypes = await _dbContext.AssetTypes.Where(x => x.Method == "0").ToListAsync();
            cmbAssetType.DataSource = assetTypes;
            cmbAssetType.DisplayMember = "Name";
            cmbAssetType.ValueMember = "Code";

            var assets = await _dbContext.AssetRecords.ToListAsync();
            dgvAssetRecords.DataSource = assets;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var typeCode = cmbAssetType.SelectedValue.ToString();
            var typeName = cmbAssetType.SelectedText.ToString();
            var total = Convert.ToDecimal(txtAssetTotal.Text.Trim());
            await _dbContext.AssetRecords.AddAsync(new AssetRecord
            {
                TypeCode = typeCode,
                TypeName = typeName,
                IsDeleted = Infrastructure.IsDeleted.No,
                TotalAsset = total,
                CreateTime = DateTime.Now,
            });
            await _dbContext.SaveChangesAsync();
        }
    }
}
