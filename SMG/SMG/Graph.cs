using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SMG
{
    class Graph
    {
        private double max, min;

        public Graph()
        {
        }

        private void refreshValues(List<double> displayPoints)
        {
            max = displayPoints[0];
            min = displayPoints[0];
            for (int i = 0; i < displayPoints.Count; i++)
            {
                if (displayPoints[i] > max) max = displayPoints[i];
                if (displayPoints[i] < min) min = displayPoints[i];
            }
        }

        public void Render(List<double> displayPoints, int width, int height, PaintEventArgs e)
        {
            refreshValues(displayPoints);
            int segmentWidth = (width - (width / 8)) / displayPoints.Count;
            double pixelValue = 1000 / height;

            e.Graphics.DrawLine(Pens.Black, width / 6, 0.0f, width / 6, height);

            Font font = new Font("Arial", 11);
            SolidBrush brush = new SolidBrush(Color.Black);

            e.Graphics.DrawString("$1000.00", font, brush, 0, 2);
            e.Graphics.DrawString("$500.00", font, brush, 0, (height / 2) - 10);
            e.Graphics.DrawString("$0.00", font, brush, 0, height - 17);

            for (int i = 1; i < displayPoints.Count; i++)
            {
                int x0 = (width / 8) + ((i - 1) * segmentWidth);
                int y0 = (int) (height - (displayPoints[i - 1] * pixelValue));
                int x1 = (width / 8) + (i * segmentWidth);
                int y1 = (int) (height - (displayPoints[i] * pixelValue));
                e.Graphics.DrawLine(Pens.Black, x0, y0, x1, y1);
            }
        }

    }
}