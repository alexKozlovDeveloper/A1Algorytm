using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using MapObjects.Constant;

namespace MapObjects.MapEntityes
{
    public class MapCell
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public Image Image { get; set; }

        public MapCell(int x, int y, int height = MapConstant.CellHeight, int width = MapConstant.CellWidth)
        {
            Height = height;
            Width = width;

            X = x;
            Y = y;

            Image = new Image
            {
                Height = Height,
                Width = Width,
                //Margin = new Thickness(50, 50, 0, 0),
                Source = new BitmapImage(new Uri(@"D:\images\Green.jpg"))
            };
        }
    }
}
