using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaycentricCoordinateSystem
{
    class Triangle
    {
        public VertexPositionColor[] Vertices = new VertexPositionColor[3];
        public int[] xs;
        public int[] ys;

        public Triangle(VertexPositionColor[] vertices)
        {
            Vertices = vertices;
            xs = new int[] { Vertices[0].Position.X, Vertices[1].Position.X, Vertices[2].Position.X };
            ys = new int[] { Vertices[0].Position.Y, Vertices[1].Position.Y, Vertices[2].Position.Y };
        }

        public int Area => CalculateTriangleArea();

        public int CalculateTriangleArea(int[] xs, int[] ys)
        {
            var area = (xs[0] - xs[2]) * (ys[1] - ys[0]) - (xs[0] - xs[1]) * (ys[2] - ys[0]);
            //var area = 0.5f * Math.Abs(xs[0] * (ys[1] - ys[2]) + xs[1] * (ys[2] - ys[0]) + xs[2] * (ys[0] - ys[1]));
            return Math.Abs(area) / 2;
        }

        public int CalculateTriangleArea()
        {
            return CalculateTriangleArea(xs, ys);
        }

        public (float, float, float) GetLambdas(Point point)
        {
            float lambda1 = CalculateTriangleArea(new int[] { point.X, xs[1], xs[2] }, new int[] { point.Y, ys[1], ys[2] }) / (float)Area;
            float lambda2 = CalculateTriangleArea(new int[] { xs[0], point.X, xs[2] }, new int[] { ys[0], point.Y, ys[2] }) / (float)Area;
            float lambda3 = CalculateTriangleArea(new int[] { xs[0], xs[1], point.X }, new int[] { ys[0], ys[1], point.Y }) / (float)Area;

            //1 - (lambda1 + lambda2); 
            return (lambda1, lambda2, lambda3);
        }

        public Color GetPointColor(Point point)
        {
            (float, float, float) lambdas = GetLambdas(point);
            var lambda1 = lambdas.Item1;
            var lambda2 = lambdas.Item2;
            var lambda3 = lambdas.Item3;

            //var r = lambda1 * colors[0].R + lambda2 * colors[0].G + lambda3 * colors[0].B;
            //var g = lambda1 * colors[1].R + lambda2 * colors[1].G + lambda3 * colors[1].B;
            //var b = lambda1 * colors[2].R + lambda2 * colors[2].G + lambda3 * colors[2].B;

            float r = lambda1 * Vertices[0].Color.R + lambda2 * Vertices[1].Color.R + lambda3 * Vertices[2].Color.R;
            float g = lambda1 * Vertices[0].Color.G + lambda2 * Vertices[1].Color.G + lambda3 * Vertices[2].Color.G;
            float b = lambda1 * Vertices[0].Color.B + lambda2 * Vertices[1].Color.B + lambda3 * Vertices[2].Color.B;

            return Color.FromArgb((int)r, (int)g, (int)b);
        }
        public bool ContainedInTriangle(Point point)
        {
            var lambdas = GetLambdas(point);

            var sum = lambdas.Item1 + lambdas.Item2 + lambdas.Item3;

            if (Math.Abs(1 - sum) <= 0.0001f) return true;
            return false;

            bool anyNegative = lambdas.Item1 < 0 || lambdas.Item2 < 0 || lambdas.Item3 < 0;
            bool anyGreaterThanOne = lambdas.Item1 > 1 || lambdas.Item2 > 1 || lambdas.Item3 > 1;

            return !anyNegative && !anyGreaterThanOne;
        }
    }
}
