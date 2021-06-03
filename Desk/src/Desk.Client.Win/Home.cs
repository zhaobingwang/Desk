using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.Client.Win
{
    public partial class Home : Form
    {
        HubConnection chathubConnection;
        HubConnection notifyhubConnection;
        public Home()
        {
            InitializeComponent();

            chathubConnection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/chatHub")
                .Build();

            chathubConnection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await chathubConnection.StartAsync();
            };

            notifyhubConnection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/notifyHub")
                .Build();

            notifyhubConnection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await chathubConnection.StartAsync();
            };

            BindEvent4ToolStripMenuItem();
        }

        #region Event
        private void BindEvent4ToolStripMenuItem()
        {
            cmnNotifyExit.Click += CmnNotifyExit_Click;
        }

        private void CmnNotifyExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
        private async void Home_Load(object sender, EventArgs e)
        {
            notifyhubConnection.On<string>("dev", (message) =>
            {
                Invoke(new EventHandler(delegate
                {
                    richTextBox1.AppendText($"#Got a message: {message} at {DateTime.Now}\n");
                }));
            });

            chathubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                Invoke(new EventHandler(delegate
                {
                    var newMessage = $"{user}: {message}";
                    MessageBox.Show(newMessage);
                }));
            });

            //await chathubConnection.StartAsync();

            //await chathubConnection.InvokeAsync("SendMessage", "aaa", "cccc");

            await notifyhubConnection.StartAsync();

        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            // 最小化
            if (WindowState == FormWindowState.Minimized)
            {
                MinimizedWindow();
            }
        }

        private void notifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                DefaultWindow();
            }
        }

        private void DefaultWindow()
        {
            // 还原窗体显示    
            WindowState = FormWindowState.Normal;
            // 激活窗体并给予它焦点
            Activate();
            // 任务栏区显示图标
            ShowInTaskbar = true;
            // 托盘区图标隐藏
            notifyIconMain.Visible = false;
        }
        private void MinimizedWindow()
        {
            // 隐藏任务栏图标
            ShowInTaskbar = false;
            // 图标显示在托盘栏
            //icnMain.Icon = SystemIcons.Application;
            notifyIconMain.Visible = true;
        }
    }
}
