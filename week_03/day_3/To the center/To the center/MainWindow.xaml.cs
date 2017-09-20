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

namespace To_the_center
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

            Point point1 = new Point(10, 30);
            Point point2 = new Point(10, 60);
            Point point3 = new Point(10, 50);

            ToTheMiddle(foxDraw, point1);
            ToTheMiddle(foxDraw, point2);
            ToTheMiddle(foxDraw, point3);
        }

        public void ToTheMiddle( FoxDraw Line, Point point)
            {
                var startPoint = new Point(0, 0);
                var endPoint = new Point(150, 150);
                Line.DrawLine(point, endPoint);
            }
        
    }
}