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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1.UserControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            Storyboard spinStoryboard = Resources["busRouteSBKey"] as Storyboard;
            meme4.BeginStoryboard(spinStoryboard);

            //fullyLoaded = true;
        }

        private void planCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (fullyLoaded == true) {
                ComboBoxItem currentItem = (ComboBoxItem)planCB.SelectedItem;
                switch (currentItem.Content.ToString())
                {
                    case "Suggested (new) Bus Route":
                        meme4.Visibility = Visibility.Visible;
                        mapGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WPFUIApp;component/Images/TrafficRoute_Bus.png", UriKind.Absolute)));
                        break;
                    case "Existing Route":
                        meme4.Visibility = Visibility.Hidden;
                        mapGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WPFUIApp;component/Images/TrafficRoute_MRT.png", UriKind.Absolute)));
                        break;
                    case "Both Routes":
                        meme4.Visibility = Visibility.Visible;
                        mapGrid.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WPFUIApp;component/Images/TrafficRoute_full.png", UriKind.Absolute)));
                        break;
                    default:
                        break;
                }
            //}
        }

    }
}
