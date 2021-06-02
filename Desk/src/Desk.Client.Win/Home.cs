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
        }

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
    }
}
