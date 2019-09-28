using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poligonos
{
    public partial class ViewPort : Form
    {
        Poligono p;
        Bitmap image;
        public void SetPoligono(Object o)
        {
            this.p = (Poligono) o;
            pictureBox1.Width = Width - 5;
            pictureBox1.Height = Height - 5;

            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Point centro = p.centro();
            Point min = p.minPoint(), max = p.maxPoint();

            p.escala(Width / (max.X - min.X), Height / (max.Y - min.Y));
            p.translacao(-p.minPoint().X, -p.minPoint().Y);

            p.draw(Color.Black, image);
            pictureBox1.Image = image;
        }
        public ViewPort()
        {
            InitializeComponent();
        }
    }
}
