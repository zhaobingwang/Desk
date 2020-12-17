using Desk.WinForm.Services;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.WinForm
{
    public class SharedChart
    {
        private AssetService assetService;
        public SharedChart()
        {
            assetService = new AssetService();
        }

        public async Task LoadTotalAssetLineChartAsync(LiveCharts.WinForms.CartesianChart cartesianChartAsset)
        {
            cartesianChartAsset.AxisX = new AxesCollection();
            cartesianChartAsset.AxisY = new AxesCollection();

            var totalAssetsByDay = await assetService.GetAssetsAsync();

            var values = totalAssetsByDay.Select(x => Convert.ToDouble(x.Total));
            var labels = totalAssetsByDay.Select(x => x.Day).ToList();


            cartesianChartAsset.Series = new SeriesCollection {
                new LineSeries
                {
                    Title = "总资产",
                    Values =new ChartValues<double>(values)
                }
            };

            cartesianChartAsset.AxisX.Add(new Axis
            {
                Title = "天",
                Labels = labels
            });

            cartesianChartAsset.AxisY.Add(new Axis
            {
                Title = "金额",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChartAsset.LegendLocation = LegendLocation.Right;
        }
    }
}
