using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.WinForm
{
    public partial class ResxToolForm : Form
    {
        public ResxToolForm()
        {
            InitializeComponent();
        }

        private void ResxToolForm_Load(object sender, EventArgs e)
        {
            IResourceWriter writer = new ResourceWriter("myResources.resources");
        }
    }
}
