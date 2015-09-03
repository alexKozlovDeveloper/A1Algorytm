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

        public MapCell(int x, int y, Uri imageUri ,int height = MapConstant.CellHeight, int width = MapConstant.CellWidth)
        {
            Height = height;
            Width = width;

            X = x;
            Y = y;

            InitImage(imageUri);
        }

        private void InitImage(Uri imageUri)
        {
            Image = new Image
            {
                Height = Height,
                Width = Width,
                Source = new BitmapImage(imageUri),
                Margin = new Thickness(X * (Width) - MapConstant.GridWidth, Y * (Height) - MapConstant.GridHeight, 0, 0)
            };
        }
    }
}
