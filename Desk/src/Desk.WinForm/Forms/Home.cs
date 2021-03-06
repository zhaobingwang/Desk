﻿using Desk.WinForm.Services;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.WinForm
{
    public partial class Home : Form
    {
        SharedChart sharedChart;
        public Home()
        {
            InitializeComponent();

            BindEvent();
            sharedChart = new SharedChart();
        }


        private void BindEvent()
        {
            // 首页菜单栏项目点击事件
            mnsItemAsset.Click += MnsItemAsset_Click;
            mnsItemSpider.Click += MnsItemSpider_Click;

            // 通知栏图标右键项目点击事件
            cmnNotifyExit.Click += CmnNotifyExit_Click;
            cmnNotifyAddAsset.Click += CmnNotifyAddAsset_Click;
            cmnNotifySpider.Click += CmnNotifySpider_Click;
        }

        private void CmnNotifySpider_Click(object sender, EventArgs e)
        {
            OpenSpiderForm();
        }

        private void MnsItemSpider_Click(object sender, EventArgs e)
        {
            OpenSpiderForm();
        }

        private void CmnNotifyAddAsset_Click(object sender, EventArgs e)
        {
            OpenAssetForm();
        }

        private void CmnNotifyExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnsItemAsset_Click(object sender, EventArgs e)
        {
            OpenAssetForm();
        }

        private void OpenAssetForm()
        {
            AssetHomeForm assetHomeForm = new AssetHomeForm();
            assetHomeForm.StartPosition = FormStartPosition.CenterScreen;
            assetHomeForm.Show();
        }

        private void OpenSpiderForm()
        {
            SpiderForm spiderForm = new SpiderForm();
            spiderForm.StartPosition = FormStartPosition.CenterScreen;
            spiderForm.Show();
        }

        private async void Home_Load(object sender, EventArgs e)
        {
            await sharedChart.LoadTotalAssetLineChartAsync(cartesianChartAsset);
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // 隐藏任务栏图标
                ShowInTaskbar = false;
                // 图标显示在托盘栏
                //icnMain.Icon = SystemIcons.Application;
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
