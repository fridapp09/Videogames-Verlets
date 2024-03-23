using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLAYGROUND
{
    public class VPoint
    {
        public Vec2 pos, old, vel, gravity;
        public float mass, radius, diameter, friction = 0.97f, groundFriction = 0.7f;
        Color color;
        Brush brush;
        public bool IsPinned;
        public int Id;

        public VPoint(float x, float y, int Id, bool pin, int sizeOfBall)
        {
            Init(x, y, Id, pin, sizeOfBall);
        }
        public void Init(float x, float y, int Id, bool pin, int sizeOfBall)
        {
            pos = new Vec2(x, y);
            old = new Vec2(x, y); // Inicializar old con la misma posición que pos
            friction = 0.97f;
            groundFriction = 0.7f;
            gravity = new Vec2(0, 1);
            radius = 15;
            diameter = radius * 2;
            color = Color.MediumPurple;
            brush = new SolidBrush(color);
            mass = 1;
            this.Id = Id;
            IsPinned = pin;
        }

        public void Update(int CANVAS_WIDTH, int CANVAS_HEIGHT)
        {

            if (!IsPinned)
            {
                Vec2 vel = pos - old;
                vel = vel * (this.friction);// if point touches ground set groundFriction
                if (pos.Y >= CANVAS_HEIGHT - radius && vel.MagSQR() > 0.000001)
                {
                    var m = vel.MagSQR();
                    vel.X /= m;
                    vel.Y /= m;
                    vel = vel * (m * this.groundFriction);
                }
                old = new Vec2(this.pos.X, this.pos.Y);
                pos = pos + vel;
                pos = pos + gravity;
            }

        }

        public void Constraint(int CANVAS_WIDTH, int CANVAS_HEIGHT, List<VPoint> pts)
        {
            foreach (VPoint pt in pts)
            {
                if (pt != this)
                {
                    float minDist = radius + pt.radius;
                    Vec2 distVec = pt.pos - pos;
                    float distSqr = distVec.MagSQR();
                    if (distSqr < minDist * minDist)
                    {
                        float dist = (float)Math.Sqrt(distSqr);
                        float overlap = 0.5f * (minDist - dist);
                        Vec2 correction = distVec * (overlap / dist);
                        pos -= correction;
                        pt.pos += correction;
                    }
                }
            }

            // Check collision with walls
            if (pos.X > CANVAS_WIDTH - radius)
            {
                pos.X = CANVAS_WIDTH - radius;
            }
            else if (pos.X < radius)
            {
                pos.X = radius;
            }
            if (pos.Y > CANVAS_HEIGHT - radius)
            {
                pos.Y = CANVAS_HEIGHT - radius;
            }
            else if (pos.Y < radius)
            {
                pos.Y = radius;
            }
        }public void Render(int CANVAS_WIDTH, int CANVAS_HEIGHT, Graphics g, List<VPoint> pts, List<VPole> poles)
        {
            Update(CANVAS_WIDTH, CANVAS_HEIGHT);
            HandleCollisionsWithInclinedLines(poles);
            Constraint(CANVAS_WIDTH, CANVAS_HEIGHT, pts);
            g.FillEllipse(brush, pos.X - radius, pos.Y - radius, diameter, diameter);
        }

        public void HandleCollisionsWithInclinedLines(List<VPole> poles)
        {
            foreach (VPole pole in poles)
            {
                float distance = DistanceFromPointToLine(this.pos, pole.startPoint.pos, pole.endPoint.pos);
                if (distance <= this.radius)
                {
                    Vec2 direction = DirectionFromPointToLine(this.pos, pole.startPoint.pos, pole.endPoint.pos);
                    this.pos += direction * (this.radius - distance);
                }
            }
        }


        public float DistanceFromPointToLine(Vec2 point, Vec2 lineStart, Vec2 lineEnd)
        {
            float A = point.X - lineStart.X;
            float B = point.Y - lineStart.Y;
            float C = lineEnd.X - lineStart.X;
            float D = lineEnd.Y - lineStart.Y;

            float dot = A * C + B * D;
            float len_sq = C * C + D * D;
            float param = dot / len_sq;

            float xx, yy;

            if (param < 0)
            {
                xx = lineStart.X;
                yy = lineStart.Y;
            }
            else if (param > 1)
            {
                xx = lineEnd.X;
                yy = lineEnd.Y;
            }
            else
            {
                xx = lineStart.X + param * C;
                yy = lineStart.Y + param * D;
            }

            float dx = point.X - xx;
            float dy = point.Y - yy;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        public Vec2 DirectionFromPointToLine(Vec2 point, Vec2 lineStart, Vec2 lineEnd)
        {
            float A = point.X - lineStart.X;
            float B = point.Y - lineStart.Y;
            float C = lineEnd.X - lineStart.X;
            float D = lineEnd.Y - lineStart.Y;

            float dot = A * C + B * D;
            float len_sq = C * C + D * D;
            float param = dot / len_sq;

            float xx, yy;

            if (param < 0)
            {
                xx = lineStart.X;
                yy = lineStart.Y;
            }
            else if (param > 1)
            {
                xx = lineEnd.X;
                yy = lineEnd.Y;
            }
            else
            {
                xx = lineStart.X + param * C;
                yy = lineStart.Y + param * D;
            }

            float dx = point.X - xx;
            float dy = point.Y - yy;
            float length = (float)Math.Sqrt(dx * dx + dy * dy);

            if (length > 0)
            {
                dx /= length;
                dy /= length;
            }

            return new Vec2(dx, dy);
        }
    }
}
