using System;
using System.Text;
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

namespace _20._09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunButton(object sender, System.Windows.Input.MouseEventArgs e)
        {
            double maxLeft = MainCanvas.ActualWidth - runButton.ActualWidth;
            double maxTop = MainCanvas.ActualHeight - runButton.ActualHeight;

            double randomLeft = random.NextDouble() * maxLeft;
            double randomTop = random.NextDouble() * maxTop;

            leftAnimation.To = randomLeft;
            topAnimation.To = randomTop;
        }
    }
}