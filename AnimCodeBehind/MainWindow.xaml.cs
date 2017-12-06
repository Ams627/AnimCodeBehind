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

namespace AnimCodeBehind
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var storyboard = tb.FindResource("SBSmaller");
            if (storyboard is BeginStoryboard sb)
            {
                sb.Storyboard.Begin();
            }
        }

        private void tb_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var storyboard = tb.FindResource("SBSmaller");
            if (storyboard is BeginStoryboard sb)
            {
                sb.Storyboard.Begin();
            }

        }

        private void tb_MouseOut(object sender, MouseEventArgs e)
        {
            var storyboard = tb.FindResource("SBBigger");
            if (storyboard is BeginStoryboard sb)
            {
                sb.Storyboard.Begin();
            }

        }
    }
}
