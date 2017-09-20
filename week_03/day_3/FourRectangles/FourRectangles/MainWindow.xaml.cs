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

namespace FourRectangles
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
            

            int sizeHorizontal = random.Next(20)+10;
            int sizeVertical = random.Next(20)+10;

            for (int i = 0; i < 4; i++)
            {
                RectangleMaker(foxDraw, new Point(random.Next(300), random.Next(300)), random.Next(50) + 50, random.Next(50) + 50, (Color.FromRgb((byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255))));
                
            }

        }

        public void RectangleMaker(FoxDraw draw, Point coord, int sizeHorizontal, int sizeVertical, Color color)
        {
        List<Point> points = new List<Point>();
        points.Add(coord);
        points.Add(new Point(coord.X + sizeHorizontal, coord.Y));
        points.Add(new Point(coord.X + sizeHorizontal, coord.Y + sizeVertical));
        points.Add(new Point(coord.X, coord.Y + sizeVertical));

        draw.FillColor(color);
        draw.DrawPolygon(points);
        }
    }
}
