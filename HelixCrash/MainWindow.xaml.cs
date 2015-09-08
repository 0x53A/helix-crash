using HelixToolkit.Wpf;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelixCrash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var material = MaterialHelper.CreateMaterial(Colors.Aqua);

            var builder = new MeshBuilder();
            builder.AddTriangle(new Point3D(0, 0, 0), new Point3D(0, 10, 100), new Point3D(100, 0, 0));
            var mesh = builder.ToMesh();
            var geo = new GeometryModel3D { Geometry = mesh, Material = material , Transform = null};
            var model = new ModelVisual3D { Content = geo, Transform = null };
            _visual.Children.Add(model);
        }
    }
}
