using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.Demo.Client.WinformApp
{
    public partial class OpenCVForm : Form
    {
        public OpenCVForm()
        {
            InitializeComponent();
        }

        private void OpenCVForm_Load(object sender, EventArgs e)
        {
            OpenCVDemo.CutFace("face.jpg");
        }
    }
}
