using Desk.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
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
    public partial class Home : Form
    {
        private readonly ILogger<Home> _logger;
        private readonly DeskDbContext _dbContext;
        private readonly AssetForm _assetForm;
        private readonly IConfiguration _configuration;
        public Home(ILogger<Home> logger, DeskDbContext dbContext, AssetForm assetForm)
        {
            _logger = logger;
            _dbContext = dbContext;
            _assetForm = assetForm;
            InitializeComponent();
            mnsItemAsset.Click += MnsItemAsset_Click;
        }

        private void MnsItemAsset_Click(object sender, EventArgs e)
        {
            _assetForm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var count = _dbContext.AssetTypes.Count();
            //MessageBox.Show(count.ToString());
            _logger.LogInformation("打开了Home");
        }
    }
}
