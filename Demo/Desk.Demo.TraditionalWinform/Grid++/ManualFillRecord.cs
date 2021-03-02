using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gregn6Lib;

namespace Desk.Demo.TraditionalWinform.Grid__
{
    public partial class ManualFillRecord : Form
    {
        private GridppReport Report;
        private IGRParameter HosName;
        private IGRParameter UserName;
        private IGRParameter QRCode;
        private IGRParameter RegDept;
        private IGRParameter RegNo;
        private IGRParameter WaitingTime;
        private IGRParameter WaitingPosition;
        public ManualFillRecord()
        {
            InitializeComponent();

            Report = new GridppReport();

            Report.LoadFromFile(@"Files\template.grf");

            Report.Initialize += Report_Initialize;
            Report.FetchRecord += Report_FetchRecord;
        }

        private void Report_Initialize()
        {
            HosName = Report.ParameterByName("HosName");
            UserName = Report.ParameterByName("UserName");
            QRCode = Report.ParameterByName("QRCode");
            RegDept = Report.ParameterByName("RegDept");
            RegNo = Report.ParameterByName("RegNo");
            WaitingTime = Report.ParameterByName("WaitingTime");
            WaitingPosition = Report.ParameterByName("WaitingPosition");
        }

        private void Report_FetchRecord()
        {
            HosName.AsString = "某某某医院";

            Report.DetailGrid.Recordset.Append();
            UserName.AsString = "张三";
            QRCode.AsString = "123456";
            RegDept.AsString = "皮肤科";
            RegNo.AsString = "10";
            WaitingTime.AsString = "2021-03-03 10:30";
            WaitingPosition.AsString = "门诊二楼-A区";
            Report.DetailGrid.Recordset.Post();
        }

        private void ManualFillRecord_Load(object sender, EventArgs e)
        {
            Report.PrintPreview(true);
        }
    }
}
