using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desk.Gist.WPF.GraphicsAndMultimedia.Animation
{
    /// <summary>
    /// Interaction logic for SimpleAnimationGist.xaml
    /// </summary>
    public partial class SimpleAnimationGist : Window
    {
        public SimpleAnimationGist()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, RoutedEventArgs e)
        {

            DoubleAnimation daX = new DoubleAnimation();
            DoubleAnimation daY = new DoubleAnimation();

            daX.From = 0;
            daY.From = 0;

            var rnd = new Random();
            daX.To = rnd.NextDouble() * (gridMain.Width - ellipse.Width);
            daY.To = rnd.NextDouble() * (gridMain.Height - ellipse.Height);

            Duration duration = new Duration(TimeSpan.FromMilliseconds(100));
            daX.Duration = duration;
            daY.Duration = duration;

            tt.BeginAnimation(TranslateTransform.XProperty, daX);
            tt.BeginAnimation(TranslateTransform.YProperty, daY);
        }
    }
}
