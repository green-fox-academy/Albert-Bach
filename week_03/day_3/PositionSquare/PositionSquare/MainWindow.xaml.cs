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

namespace PositionSquare
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
            Random random = new Random();
            Point coord = new Point(random.Next(300), random.Next(300));

            int sizeChange = 50;

            for (int i = 0; i < 3; i++)
            {
                Square(foxDraw, new Point(random.Next(50) +10, random.Next(50) +10), sizeChange);

            }

        }

        public void Square(FoxDraw draw, Point coord, int sizeChange)
        {
            List<Point> points = new List<Point>();
            points.Add(coord);
            points.Add(new Point(coord.X + sizeChange, coord.Y));
            points.Add(new Point(coord.X + sizeChange, coord.Y + sizeChange));
            points.Add(new Point(coord.X, coord.Y + sizeChange));

            draw.DrawPolygon(points);
        }
    }
}