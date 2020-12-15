﻿using Desk.WinForm.Services;
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
            cmnNotifyExit.Click += CmnNotifyExit_Click;
        }

        private void CmnNotifyExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnsItemAsset_Click(object sender, EventArgs e)
        {
            AssetHomeForm assetHomeForm = new AssetHomeForm();
            assetHomeForm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // 隐藏任务栏图标
                ShowInTaskbar = false;
                // 图标显示在托盘栏
                icnMain.Icon = SystemIcons.Application;
                icnMain.Visible = true;
            }
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
    }
}
