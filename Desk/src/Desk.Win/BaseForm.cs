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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 发送Windows气泡通知
        /// </summary>
        public void SendBalloonTip(string title, string text, ToolTipIcon toolTipIcon = ToolTipIcon.Info)
        {
            // TODO: Introduce custom ICON
            icnMain.Icon = SystemIcons.Application;
            icnMain.Visible = true;
            icnMain.ShowBalloonTip(10000, title, text, toolTipIcon);
        }

        private void icnMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // 还原窗体显示    
                WindowState = FormWindowState.Normal;
                // 激活窗体并给予它焦点
                Activate();
                // 任务栏区显示图标
                ShowInTaskbar = true;
                // 托盘区图标隐藏
                icnMain.Visible = false;
            }
        }

        private void BaseForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // 隐藏任务栏图标
                ShowInTaskbar = false;
                // 图标显示在托盘栏
                icnMain.Visible = true;
            }
        }

        //private bool IsInHome()
        //{
        //    //"Desk.Win.Home, Text: BaseForm";
        //}
    }
}
