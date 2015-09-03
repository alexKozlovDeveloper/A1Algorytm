using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using MapObjects.Constant;
using MapObjects.MapEntityes;

namespace TestA1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Image _img;
        private Map _map;

        public MainWindow()
        {
            InitializeComponent();

            //_img = new Image
            //{
            //    Height = 10,
            //    Width = 10,
            //    Margin = new Thickness(50, 50, 0, 0),
            //    Source = new BitmapImage(MapConstant.GreenImageUri)
            //};

            //GridMain.Children.Add(_img);

            _map = new Map(10, 10, GridMain);

            

            //var map = new Map(100, 100, GridMain);
        }
    }
}
