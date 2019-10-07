using System;
using System.Drawing;
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
            pictureBox1.Width = Width - 15;
            pictureBox1.Height = Height - 45;
            pictureBox1.Location = new Point(Location.X, Location.Y);
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Point centro = p.Centro();
            Point min = p.MinPoint(), max = p.MaxPoint();
            p.Escala(((double) Width - 15) / (max.X - min.X), ((double) Height - 45) / (max.Y - min.Y));
            p.Translacao(-min.X, -min.Y);

            p.Draw(Color.Black, image);
            pictureBox1.Image = image;
        }
        public ViewPort()
        {
            InitializeComponent();
        }
    }
}
