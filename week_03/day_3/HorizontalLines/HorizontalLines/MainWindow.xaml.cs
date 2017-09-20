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

namespace HorizontalLines
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

            Horizontal(foxDraw, 10, 10);
            Horizontal(foxDraw, 20, 20);
            Horizontal(foxDraw, 30, 30);

        }
        public void Horizontal (FoxDraw Line, int x, int y)
        {
            Line.DrawLine(new Point(x, y), new Point(x + 50, y));
        }
    }
}

