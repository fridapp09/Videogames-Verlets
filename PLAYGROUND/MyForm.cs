using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLAYGROUND
{
    public partial class MyForm : Form
    {
        Scene scene;
        Canvas canvas;
        float delta;
        int countId;

        public MyForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            canvas = new Canvas(PCT_CANVAS);
            scene = new Scene();
            scene.AddElement(new VElement());
            delta = 0;
            countId = 0;
        }

        private void MyForm_SizeChanged(object sender, EventArgs e)
        {
            Init();
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            canvas.Render(scene, delta, PCT_CANVAS); // Pasa el PictureBox como argumento
            delta += 0.001f;
        }

        private void ADD_POINT_BTN_Click(object sender, EventArgs e)
        {
            int numBallsToAdd = 5; // Número de pelotas a agregar
            int spreadRadius = 50; // Radio de dispersión alrededor del punto de clic
            Random random = new Random();

            for (int i = 0; i < numBallsToAdd; i++)
            {
                // Generar una posición aleatoria dentro del radio de dispersión
                int randomX = random.Next(-spreadRadius, spreadRadius + 1);
                int randomY = random.Next(-spreadRadius, spreadRadius + 1);

                // Calcular la posición final sumando la posición del clic y la posición aleatoria
                int finalX = ADD_POINT_BTN.Location.X + randomX;
                int finalY = ADD_POINT_BTN.Location.Y + randomY;

                // Verificar que la nueva posición no esté demasiado cerca de otras pelotas existentes
                bool collision = false;
                foreach (VElement element in scene.Elements)
                {
                    foreach (VPoint point in element.VPoints)
                    {
                        double dx = finalX - point.pos.X;
                        double dy = finalY - point.pos.Y;
                        double distanceSquared = dx * dx + dy * dy;
                        double minDistance = 2 * point.radius; // Se puede ajustar según el tamaño de las pelotas
                        if (distanceSquared < minDistance * minDistance)
                        {
                            // Hay colisión, no agregar la pelota en esta posición
                            collision = true;
                            break;
                        }
                    }
                    if (collision)
                        break;
                }

                // Si no hay colisión, agregar la pelota en la posición final
                if (!collision)
                {
                    scene.Elements[0].addPoint(finalX, finalY, countId, false, 20);
                    countId++;
                }
            }
        }

    }
}
