using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaycentricCoordinateSystem
{


    public partial class Form1 : Form
    {
        Color[] colors = new Color[3];

        Graphics graphics;


        Bitmap map;

        Triangle triangle;
        
        //value at p: (A1x1 + A2x2 + A3x3) / A
        //the triangle can be shaded by weighting the color of each vertex with the corresponding baycentric (lambda) value

        public Form1()
        {
            InitializeComponent();

            map = new Bitmap(400, 400);
            graphics = Graphics.FromImage(map);
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VertexPositionColor[] vertices = new VertexPositionColor[]
            {
                new VertexPositionColor(200, 100, Color.Red),
                new VertexPositionColor(400, 100, Color.Green),
                new VertexPositionColor(300, 200, Color.Blue)
            };

            triangle = new Triangle(vertices);
        }
        private void DrawButton_Click(object sender, EventArgs e)
        {
            float minX = Math.Min(triangle.Vertices[0].Position.X, Math.Min(triangle.Vertices[1].Position.X, triangle.Vertices[2].Position.X)) ;
            float minY = Math.Min(triangle.Vertices[0].Position.Y, Math.Min(triangle.Vertices[1].Position.Y, triangle.Vertices[2].Position.Y));

            float maxX = Math.Max(triangle.Vertices[0].Position.X, Math.Max(triangle.Vertices[1].Position.X, triangle.Vertices[2].Position.X));
            float maxY = Math.Max(triangle.Vertices[0].Position.Y, Math.Max(triangle.Vertices[1].Position.Y, triangle.Vertices[2].Position.Y));

            for (int y = (int)minY; y < maxY; y++)
            {
                for(int x = (int)minX; x < maxX; x++)
                {
                    Point point = new Point(x, y);
                    if (triangle.ContainedInTriangle(point))
                    {
                        Color color = triangle.GetPointColor(point, colors);
                        map.SetPixel(x - (int)minX, y - (int)minY, color);
                    }
                }
            }

            trianglePictureBox.Image = map;

        }
    }
}
