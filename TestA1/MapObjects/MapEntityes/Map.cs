using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MapObjects.MapEntityes
{
    public class Map
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Grid Grid { get; set; }

        public List<List<MapCell>> Cells { get; set; }

        public Map(int height, int width, Grid grid)
        {
            Height = height;
            Width = width;

            Grid = grid;
        }

    }
}
