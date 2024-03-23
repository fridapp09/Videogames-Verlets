using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLAYGROUND
{
    public class VPole
    {
        float stiffness, damp, length, tot, m1, m2, dist, diff;
        Vec2 dxy, dx, dy, offset;
        Pen brush;
        public VPoint a, b, startPoint, endPoint;

        public VPole(VPoint p1, VPoint p2, float length)
        {

            startPoint = p1;
            endPoint = p2;
            stiffness = 25f;
            damp = 0.05f;
            length = startPoint.pos.Distance(endPoint.pos);
            brush = new Pen(Color.Green);
            tot = startPoint.mass + endPoint.mass;
            m1 = endPoint.mass / tot;
            m2 = startPoint.mass / tot;

            if (length == 0)
            {

                length = startPoint.pos.Distance(endPoint.pos);

            }
            else
            {

                this.length = length;

            }

        }

        public void Update()
        {

            float tot;
           
            dxy = endPoint.pos - startPoint.pos;
            

          
            dist = dxy.Length();
           
            diff = (length - dist) / dist * stiffness;

            
            offset = (dxy * diff)*(float)0.5;
            


            tot = startPoint.mass + endPoint.mass;
            m2 = startPoint.mass / tot;
            m1 = endPoint.mass / tot;


            startPoint.pos -= offset * m1;
            endPoint.pos += offset * m2;
            

        }


        public void Render(Graphics g, double width, double height)
        {
            Update();
            g.DrawLine(brush, startPoint.pos.X, startPoint.pos.Y, endPoint.pos.X, endPoint.pos.Y);
        }


    }
}
