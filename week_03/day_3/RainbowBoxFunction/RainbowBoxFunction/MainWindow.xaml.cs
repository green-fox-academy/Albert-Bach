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


namespace RainbowBoxFunction
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

            for (int size = 300; size >=0; size-= 10)
            {
                Square(foxDraw, size, RandomColor(random));
            }
        }

        public Color RandomColor(Random random)
        {
            return Color.FromArgb((byte)random.Next(255), 
                                  (byte)random.Next(255), 
                                  (byte)random.Next(255), 
                                  (byte)random.Next(255));
        }

        public void Square(FoxDraw draw, int size, Color color)
        {
            Point coord = new Point(canvas.Height / 2 - size / 2, canvas.Width / 2 - size / 2);
            List<Point> points = new List<Point>
            {
                coord,
                new Point(coord.X + size, coord.Y),
                new Point(coord.X + size, coord.Y + size),
                new Point(coord.X, coord.Y + size)
            };

            draw.FillColor(color);
            draw.DrawPolygon(points);
        }
    }
}
