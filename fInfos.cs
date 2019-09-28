using System;
using System.Windows.Forms;

namespace Poligonos
{
    public partial class fInfos : Form
    {
        Poligono p = null;

        public fInfos()
        {
            InitializeComponent();
        }       
        
        public void SetPoligono(Object p)
        {
            this.p = (Poligono) p;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int w = int.Parse(tbW.Text), h = int.Parse(tbH.Text);

            ViewPort vp = new ViewPort();
            vp.Width = w;
            vp.Height = h;
            vp.SetPoligono(p);
            vp.Show();
            Close();
        }
    }
}
