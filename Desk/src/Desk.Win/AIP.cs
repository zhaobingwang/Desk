using Desk.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.Win
{
    /// <summary>
    /// automatic investment plan 
    /// </summary>
    public partial class AIP : Form
    {
        public AIP()
        {
            InitializeComponent();
        }

        private void AIP_Load(object sender, EventArgs e)
        {
            txtAnnualYield.Text = "12";
            txtMonthlyAmount.Text = "2000";
            txtMonth.Text = "240";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var monthAmount = Convert.ToDouble(txtMonthlyAmount.Text.Trim());
            var annualYield = Convert.ToDouble(txtAnnualYield.Text.Trim()) / 100;
            var monthlyTield = annualYield / 12;
            var month = Convert.ToDouble(txtMonth.Text.Trim());
            var result = MathCalculator.SumOfGeometricProgression(monthAmount, 1 + monthlyTield, month);
            lblResult.Text = result.ToString("C");
            //lblResult.Text = result.ToString("C",CultureInfo.CurrentCulture);
            //lblResult.Text = result.ToString("C3", CultureInfo.CurrentCulture);
            //lblResult.Text = result.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
