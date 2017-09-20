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

namespace CenterBoxFunction
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
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            Random random = new Random();

            int size = random.Next(200);
            for (int i = 0; i < 3; i++)
            {
                Square(foxDraw, random.Next(200), (Color.FromArgb((byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255),(byte)random.Next(255))));

            }

        }

        public void Square(FoxDraw draw, int size, Color color)
        {
            Point coord = new Point(canvas.Height /2 - size/2, canvas.Width/2 - size/2);
            List<Point> points = new List<Point>();
            points.Add(coord);
            points.Add(new Point(coord.X + size, coord.Y));
            points.Add(new Point(coord.X + size, coord.Y + size));
            points.Add(new Point(coord.X, coord.Y + size));

            draw.FillColor(color);
            draw.DrawPolygon(points);
        }
    }
}
