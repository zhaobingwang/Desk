using Desk.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desk.Win
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AppSettings AppSettings { get; }
        private readonly DeskDbContext _dbContext;
        private readonly ILogger<MainWindow> _logger;

        public MainWindow(DeskDbContext dbContext, IOptions<AppSettings> appSettings, ILogger<MainWindow> logger)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _logger = logger;
            AppSettings = appSettings.Value;
        }

        private void MenuItem_Version_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _logger.LogTrace("trace");
            _logger.LogDebug("debug");
            _logger.LogInformation("information");
            _logger.LogWarning("warning");
            _logger.LogError("error");
            _logger.LogCritical("critical");
            
            var tmp = _dbContext.AssetRecords.Count();
            MessageBox.Show(tmp.ToString());
        }
    }
}
