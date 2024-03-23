using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLAYGROUND
{
    public class Vec2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vec2(float x, float y)
        {
            this.Y = (float)y;
            this.X = (float)x;
        }

        public static Vec2 operator -(Vec2 v)
        {
            return new Vec2(-v.X, -v.Y);
        }

        public static Vec2 operator +(Vec2 a, Vec2 b)
        {
            return new Vec2(a.X + b.X, a.Y + b.Y);
        }

        public static Vec2 operator -(Vec2 a, Vec2 b)
        {
            return new Vec2(a.X - b.X, a.Y - b.Y);
        }

        public static Vec2 operator *(float a, Vec2 v)
        {
            return new Vec2(a * v.X, a * v.Y);
        }

        public static Vec2 operator *(Vec2 v, float a)
        {
            return new Vec2(a * v.X, a * v.Y);
        }

        public static Vec2 operator /(Vec2 v, float a)
        {
            return new Vec2(v.X/a, v.Y/a);
        }

        public float MagSQR()
        {
           float f = (X * X) + (Y * Y);
           return f;
        }

        public float Length()
        {
            float f = (float)Math.Sqrt((X * X) + (Y * Y));
            return f;
        }

        // Método para calcular la magnitud (longitud) del vector
        public float Mag()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }

        // Método para normalizar el vector (hacer que su longitud sea 1)
        public Vec2 Normalize()
        {
            float mag = Mag();
            return new Vec2(X / mag, Y / mag);
        }

        // Método para calcular el vector perpendicular a este
        public Vec2 Perpendicular()
        {
            return new Vec2(-Y, X);
        }

        public static float Dot(Vec2 v1, Vec2 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public float Distance(Vec2 a)
        {
            float f = (float)Math.Sqrt(Math.Pow(X - a.X, 2) + Math.Pow(Y - a.Y, 2));
            return f;
        }
    }
}
