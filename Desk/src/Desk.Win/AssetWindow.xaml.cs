using Desk.Infrastructure.Data;
using Desk.Win.Services;
using Microsoft.EntityFrameworkCore;
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
using System.Windows.Shapes;

namespace Desk.Win
{
    /// <summary>
    /// Interaction logic for AssetWindow.xaml
    /// </summary>
    public partial class AssetWindow : Window
    {
        private readonly AssetService _assetService;

        public AssetWindow()
        {
            InitializeComponent();
            //_assetService = new AssetService();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var assetTypes = await _assetService.GetAssetTypesAsync();
            AssetType.ItemsSource = assetTypes;
        }
    }
}
