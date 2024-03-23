using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PLAYGROUND
{
    public class VElement
    {

        public List<VPoint> VPoints;
        public List<VPole> VPoles;
        public int GlassX { get; set; }
        public int GlassY { get; set; }
        public int GlassWidth { get; set; }
        public int GlassHeight { get; set; }

        public VElement() 
        {
            VPoints = new List<VPoint>();
            VPoles = new List<VPole>();
        }

        public bool IsPointInsideGlass(Vec2 point)
    {
        return point.X >= GlassX && point.X <= GlassX + GlassWidth &&
               point.Y >= GlassY && point.Y <= GlassY + GlassHeight;
    }

        public void AddGlass(int x, int y, int width, int height)
        {
            GlassX = x;
            GlassY = y;
            GlassWidth = width;
            GlassHeight = height;
        }

        public void addPoint(float x,float y,int id, bool pin, int sizeOfRadius)
        {
            VPoints.Add(new VPoint(x, y, id, pin, sizeOfRadius));
        }

        public void drawRectangle(int x, int y, int width, int height)
        {
            VPoints.Clear(); 
            VPoints.Add(new VPoint(x, y, 0, true, 0));
            VPoints.Add(new VPoint(x + width, y, 0, true, 0)); 
            VPoints.Add(new VPoint(x, y + height, 0, true, 0)); 
            VPoints.Add(new VPoint(x + width, y + height, 0, true, 0)); 
        }

        public void addPole(int i1, int i2, float length)
        {
            VPoles.Add(new VPole(VPoints[i1], VPoints[i2],length));

        }
        public void HandleBallCollisionWithGlass(VPoint ball)
        {
            // Verificar si la pelota está dentro del vaso
            if (IsPointInsideGlass(ball.pos))
            {
                // Calcular la distancia entre el borde del vaso y el centro de la pelota
                float distX = Math.Min(Math.Abs(ball.pos.X - GlassX), Math.Abs(ball.pos.X - (GlassX + GlassWidth)));
                float distY = Math.Min(Math.Abs(ball.pos.Y - GlassY), Math.Abs(ball.pos.Y - (GlassY + GlassHeight)));

                // Si la distancia es menor que el radio de la pelota, ajustar la posición de la pelota
                if (distX < ball.radius)
                {
                    if (ball.pos.X < GlassX + GlassWidth / 2)
                        ball.pos.X = GlassX + ball.radius;
                    else
                        ball.pos.X = GlassX + GlassWidth - ball.radius;
                }
                if (distY < ball.radius)
                {
                    if (ball.pos.Y < GlassY + GlassHeight / 2)
                        ball.pos.Y = GlassY + ball.radius;
                    else
                        ball.pos.Y = GlassY + GlassHeight - ball.radius;
                }
            }
        }

        public void Render(System.Drawing.Graphics g, int Canvasw, int Canvash)
        {
            for(int i = 0; i < VPoints.Count; i++)
            {
                VPoints[i].Render(Canvasw, Canvash, g, VPoints, VPoles);
            }

            for (int i = 0; i < VPoles.Count; i++)
            {
                VPoles[i].Render(g,Canvasw, Canvash);
            }
        }
    }
}