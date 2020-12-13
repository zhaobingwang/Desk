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

namespace Desk.WinForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            BindEvent();
        }

        private void BindEvent()
        {
            mnsItemAsset.Click += MnsItemAsset_Click;
        }

        private void MnsItemAsset_Click(object sender, EventArgs e)
        {
            AssetHomeForm assetHomeForm = new AssetHomeForm();
            assetHomeForm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }
    }
}
