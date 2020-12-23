using AngleSharp.Html.Parser;
using Sophon.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.WinForm
{
    public partial class SpiderForm : Form
    {
        public SpiderForm()
        {
            InitializeComponent();
        }

        private async void btnGetRegionCode_Click(object sender, EventArgs e)
        {
            var url = "http://www.mca.gov.cn/article/sj/xzqh/2020/2020/2020112010001.html";
            var httpClient = new HttpClient();
            try
            {
                var responseHtml = await httpClient.GetStringAsync(url);
                var parser = new HtmlParser();
                var document = await parser.ParseDocumentAsync(responseHtml);

                var columnsCodes = document.QuerySelectorAll("table tbody tr td:nth-child(2)");
                var columnsNames = document.QuerySelectorAll("table tbody tr td:nth-child(3)");
                var totalCount = columnsCodes.Count();
                var regionInfo = new List<RegionInfo>();
                for (int i = 0; i < totalCount; i++)
                {
                    // 第一行标题头
                    if (i == 0)
                        continue;
                    var code = columnsCodes[i].TextContent?.Trim();
                    var name = columnsNames[i].TextContent?.Trim();
                    if (code.IsNullOrWhiteSpace() || name.IsNullOrWhiteSpace())
                    {
                        continue;
                    }
                    regionInfo.Add(new RegionInfo
                    {
                        Code = code,
                        Name = name
                    });
                }
                var json = JsonUtil.ToJson(regionInfo);
                File.WriteAllText("region.json", json, Encoding.UTF8);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    class RegionInfo
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
