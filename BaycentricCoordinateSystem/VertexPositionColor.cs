using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaycentricCoordinateSystem
{
    /// <summary>
    /// Represents a Vertex as a position and color
    /// </summary>
    class VertexPositionColor
    {
        public Point Position { get; set; }
        public Color Color { get; set; }

        public VertexPositionColor(int x, int y, Color color)
        {
            Position = new Point(x, y);
            Color = color;
        }
    }
}
