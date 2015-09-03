using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MapObjects.Constant;

namespace MapObjects.MapEntityes
{
    public class Map
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Grid Grid { get; set; }

        public List<List<MapCell>> Cells { get; set; }

        private Random _random;

        public Map(int height, int width, Grid grid)
        {
            _random = new Random();

            Height = height;
            Width = width;

            Grid = grid;

            InitCells(Height, Width);
            InitGrid(MapConstant.GridHeight, MapConstant.GridWidth);
        }

        private void InitGrid(int gridHeight, int gridWidth)
        {
            Grid.Height = gridHeight;
            Grid.Width = gridWidth;

            foreach (var verticalCells in Cells)
            {
                foreach (var cell in verticalCells)
                {
                    Grid.Children.Add(cell.Image);
                }
            }
        }

        private void InitCells(int height, int width)
        {
            Cells = new List<List<MapCell>>();

            for (int i = 0; i < width; i++)
            {
                var items = new List<MapCell>();

                for (int j = 0; j < height; j++)
                {
                    items.Add(new MapCell(i, j, GetRandomUri()));
                }

                Cells.Add(items);
            }
        }

        private Uri GetRandomUri()
        {
            var r = _random.Next(0, 2);

            if (r == 1)
            {
                return MapConstant.GreenImageUri;
            }
            else
            {
                return MapConstant.BluImageUri;
            }
        }

    }
}
