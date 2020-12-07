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
    public partial class Home : BaseForm
    {
        private readonly ILogger<Home> _logger;
        private readonly DeskDbContext _dbContext;
        private readonly AssetForm _assetForm;
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

            SendBalloonTip("测试", $"通知：{DateTime.Now}");
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // 隐藏任务栏图标
                ShowInTaskbar = false;
            }
        }
    }
}
