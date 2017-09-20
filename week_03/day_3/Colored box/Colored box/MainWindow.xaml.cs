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
using GreenFox;

namespace Colored_box
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.LawnGreen);
            foxDraw.DrawLine(100, 50, 200, 50);

            foxDraw.StrokeColor(Colors.BlueViolet);
            foxDraw.DrawLine(100, 100, 200, 100);

            foxDraw.StrokeColor(Colors.MediumSpringGreen);
            foxDraw.DrawLine(100, 50, 100, 100);

            foxDraw.StrokeColor(Colors.MediumOrchid);
            foxDraw.DrawLine(200, 50, 200, 100);

            
            // draw a box that has different colored lines on each edge.
        }
    }
}
