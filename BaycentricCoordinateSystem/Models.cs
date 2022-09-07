using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using ObjLoader;
using ObjLoader.Loader.Loaders;

namespace BaycentricCoordinateSystem
{
    public partial class Models : Form
    {
        public Models()
        {
            InitializeComponent();
        }

        private void Models_Load(object sender, EventArgs e)
        {
            ObjLoaderFactory factory = new ObjLoaderFactory();
            var objLoader = factory.Create();

            
        }
    }
}
