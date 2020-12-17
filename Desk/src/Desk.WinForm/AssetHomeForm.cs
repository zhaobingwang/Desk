using Desk.Infrastructure.Entities;
using Desk.WinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Windows.Media;

namespace Desk.WinForm
{
    public partial class AssetHomeForm : Form
    {
        private AssetService assetService;
        SharedChart sharedChart;
        public AssetHomeForm()
        {
            InitializeComponent();

            assetService = new AssetService();
            sharedChart = new SharedChart();
        }

        private async void AssetHomeForm_Load(object sender, EventArgs e)
        {
            var assetTypes = await assetService.GetAssetTypesAsync();
            cmbAssetType.DataSource = await assetService.GetAssetTypesAsync();
            cmbAssetType.DisplayMember = $"{nameof(AssetType.Name)}";
            cmbAssetType.ValueMember = $"{nameof(AssetType.Code)}";

            await LoadAssetRecordsAsync();
            await LoadAssetStatisticsAsync();
            await sharedChart.LoadTotalAssetLineChartAsync(cartesianChartAsset);
        }

        private async void btnAddAsset_Click(object sender, EventArgs e)
        {
            var typeCode = cmbAssetType.SelectedValue.ToString();
            var typeName = cmbAssetType.Text;
            var total = Convert.ToDecimal(txtAssetTotal.Text.Trim());

            var assetRecord = await assetService.TodayAssetRecordsExist(typeCode);
            var exist = assetRecord != null;
            if (exist)
            {
                if (MessageBox.Show($"当日存在{typeName}，是否更新", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    assetRecord.TotalAsset = total;
                    await assetService.UpdateAssetRecord(assetRecord);
                }
            }
            else
            {
                await assetService.AddAssetRecord(typeCode, typeName, total);
            }


            await LoadAssetRecordsAsync();
            await LoadAssetStatisticsAsync();
            await sharedChart.LoadTotalAssetLineChartAsync(cartesianChartAsset);
        }

        private async Task LoadAssetRecordsAsync()
        {
            var assetRecords = await assetService.GetAssetRecordsAsync();
            dgvAssetRecords.DataSource = assetRecords.OrderByDescending(x => x.CreateTime).ToList();
        }

        private async Task LoadAssetStatisticsAsync()
        {
            var statistics = await assetService.GetAssetsAsync();
            dgvAssetStatistics.DataSource = statistics;
        }
    }
}
