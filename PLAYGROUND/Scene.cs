using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace PLAYGROUND
{
    public class Scene
    {   
        public List<VElement> Elements { get; set; }

        public Scene()
        {
            Elements = new List<VElement>();
        }

        public void AddElement(VElement element)
        {
            Elements.Add(element);
        }

        public void DrawInclinedLines(Graphics g, int pictureBoxWidth, int pictureBoxHeight)
        {
            // Calcular las coordenadas del centro del PictureBox
            int centerX = pictureBoxWidth / 2;
            int centerY = pictureBoxHeight / 2;

            // Calcular la longitud de las líneas (la mitad del ancho del PictureBox)
            int lineLength = pictureBoxWidth / 4;

            // Calcular la inclinación de las líneas (ángulo en radianes)
            double angle = Math.PI / 20; // 30 grados en radianes

            // Calcular las coordenadas para la línea que va hacia la derecha
            int startXRight = centerX + (int)(lineLength * Math.Cos(angle));
            int startY = centerY + (int)(lineLength * Math.Sin(angle));
            int endXRight = centerX;
            int endY = centerY;

            // Calcular las coordenadas para la línea que va hacia la izquierda
            int startXLeft = centerX - (int)(lineLength * Math.Cos(angle));
            int endXLeft = centerX;

            // Ajustar el grosor de la línea
            int lineWidth = 7;

            // Configurar el grosor del trazo
            Pen pen = new Pen(Color.LightPink, lineWidth);

            // Dibujar las líneas con el grosor especificado
            g.DrawLine(pen, startXLeft, startY, endXLeft, endY); // Línea hacia la izquierda
            g.DrawLine(pen, startXRight, startY, endXRight, endY); // Línea hacia la derecha
        }



        public void DrawGlass(Graphics g, Size size)
        {
            int glassX = 400; 
            int glassY = size.Height - 200;

            int glassWidth = 200; 
            int glassHeight = 190;

            int baseThickness = 30;
            int sideThickness = baseThickness; // Igualar el grosor de los lados al grosor de la base

            int baseX = glassX - glassWidth / 14; 
            int baseY = glassY + glassHeight - baseThickness / 2; 
            int baseWidth = glassWidth + 8; 
            int baseHeight = baseThickness + 2; 
            g.FillRectangle(Brushes.CadetBlue, baseX, baseY, baseWidth, baseHeight); 

            int sideX = glassX - sideThickness / 2; 
            int sideY = glassY - sideThickness / 2; 
            int sideHeight = glassHeight + 2 * sideThickness; 
            g.FillRectangle(Brushes.CadetBlue, sideX , sideY, sideThickness, sideHeight); 
            g.FillRectangle(Brushes.CadetBlue, glassX + glassWidth - sideThickness / 2, sideY, sideThickness, sideHeight); 
        }
        public List<VPole> GetInclinedLines()
        {
            List<VPole> inclinedLines = new List<VPole>();

            // Agregar las líneas inclinadas a la lista
            // (Aquí debes agregar las líneas inclinadas que tengas en tu escena)

            return inclinedLines;
        }

    }
}