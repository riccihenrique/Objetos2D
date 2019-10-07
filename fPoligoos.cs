using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Poligonos
{
    public partial class fPoligoos : Form
    {
        private string flag = "";
        private Point old, down, liv;
        private Color color = Color.Black, white = Color.FromArgb(255, 240, 240, 240);
        private Bitmap image;
        private Poligono p = new Poligono();

        public fPoligoos()
        {
            InitializeComponent();
            image = new Bitmap(pbMain.Width, pbMain.Height);            
            down.X = -1;
            LimpaImagem();
        }

        private void LimpaImagem()
        {
            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                    image.SetPixel(i, j, white);
        }

        private void BtQuad_Click(object sender, EventArgs e)
        {
            lbDescricao.Visible = false;
            p = new Poligono();
            flag = ((Button)sender).Name.Replace("bt", "");
            if (flag.Equals("Bal"))
                cdCor.ShowDialog();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvPolig.SelectedIndex > -1)
            {
                p = (Poligono)lvPolig.Items[lvPolig.SelectedIndex];
                p.Draw(Color.Red, image);

                DataTable dt = new DataTable();
                dt.Columns.Add("X");
                dt.Columns.Add("Y");

                foreach (Point pts in p.PontosAtuais)
                {
                    DataRow dr = dt.NewRow();
                    dr["X"] = pts.X;
                    dr["Y"] = pts.Y;

                    dt.Rows.Add(dr);
                }
                gbTrans.Enabled = true;
                dataGridView1.DataSource = dt;
                pbMain.Image = image;
            }
        }

        private void BtTransformar_Click(object sender, EventArgs e)
        {
            p.Draw(white, image);
            string select = cbTransf.Text;
            double x = tbX.Text.Equals("") ? 0 : double.Parse(tbX.Text), y = tbY.Text.Equals("") ? 0 : double.Parse(tbY.Text);
            Point ponto_aux = new Point();
            if(select.Equals("ScanLine"))
            {
                cdCor.ShowDialog();
                p.ScanLine(image, cdCor.Color);
            }
            else
                if (select.Equals("Translação"))
                    p.Translacao(x, y);
                else if (select.Equals("Rotação"))
                {
                    if (rbEixo.Checked)
                        ponto_aux = p.Centro();
                    else if (rbPonto.Checked)
                        ponto_aux = new Point(int.Parse(tbPFx.Text), int.Parse(tbPFy.Text));
                    if (rbEixo.Checked || rbPonto.Checked)
                        p.Translacao(ponto_aux.X, ponto_aux.Y);
                    p.Rotacao(x * Math.PI / 180.0);
                    if (rbEixo.Checked || rbPonto.Checked)
                        p.Translacao(-ponto_aux.X, -ponto_aux.Y);
                }
                else
                {
                    if (rbEixo.Checked)
                        ponto_aux = p.CentroAtual();
                    else if(rbPonto.Checked)
                        ponto_aux = new Point(int.Parse(tbPFx.Text), int.Parse(tbPFy.Text));

                    if (rbEixo.Checked || rbPonto.Checked)
                        p.Translacao(p.Centro().X, p.Centro().Y);

                    if (select.Equals("Escala"))
                        p.Escala(x, y);
                    else if (select.Equals("Cisalhamento"))
                        p.Cisalhamento(x, y);
                    else if (select.Equals("Espelhamento"))
                        p.Espelhamento(x, y);

                    if (rbEixo.Checked || rbPonto.Checked)
                        p.Translacao(-ponto_aux.X, -ponto_aux.Y);
                }

            p.Draw(Color.Black, image);
            pbMain.Image = image;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if(!flag.Equals(""))
                if (flag.Equals("Bal"))
                {
                    FloodFill(e.Location, cdCor.Color);
                    pbMain.Image = image;
                }
                else
                {
                    if (down.X == -1)
                        p = new Poligono();

                    down = liv = e.Location;
                    if (flag.Equals("Pol") && down.X != -1)
                        p.AddPonto(down);
                }
        }

        private void RbPonto_CheckedChanged(object sender, EventArgs e)
        {
            tbPFx.Clear();
            tbPFy.Clear();
            tbPFx.Visible = tbPFy.Visible = rbPonto.Checked;
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            lvPolig.Items.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            LimpaImagem();
            gbTrans.Enabled = tbX.Visible = tbY.Visible = false;
            cbTransf.SelectedIndex = down.X = -1;
            pbMain.Image = image;
            rbEixo.Checked = true;
            tbPFx.Clear(); tbPFy.Clear();
        }

        private void BtBal_MouseHover(object sender, EventArgs e)
        {
            string s, flag;
            lbDescricao.Visible = true;
            lbDescricao.Location = ((Button)sender).Location;

            flag = ((Button)sender).Name.Replace("bt", "");
            if (flag.Equals("Ret"))
                s = "Retangulo";
            else if (flag.Equals("Circ"))
                s = "Circulo";
            else if (flag.Equals("Elip"))
                s = "Elipse";
            else if (flag.Equals("Reta"))
                s = "Reta";
            else if (flag.Equals("Livre"))
                s = "Desenho Livre";
            else if (flag.Equals("Pol"))
                s = "Poligono";
            else
                s = "Flood Fill";

            lbDescricao.Text = s;
        }

        private void CbTransf_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cbTransf.Text;
            if(cbTransf.SelectedIndex != -1)
            {
                tbX.Clear();
                tbY.Clear();
                if (select.Equals("Rotação"))
                {
                    lbTX.Text = "Grau";
                    tbX.Visible = true;
                    tbY.Visible = lbTY.Visible = false; ;
                }
                else
                {
                    lbTX.Text = "X:";
                    tbX.Visible = tbY.Visible = lbTY.Visible = true;
                }
            }
        }

        private void BtViewPort_Click(object sender, EventArgs e)
        {
            fInfos fi = new fInfos();
            fi.SetPoligono(lvPolig.Items[lvPolig.SelectedIndex]);
            fi.Show();            
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            List<Point> l = new List<Point>();
            
            if(down.X != -1)
            {
                if (flag.Equals("Ret"))
                {
                    p.Draw(white, image);
                    l.Add(new Point(Math.Min(e.X, down.X), Math.Min(e.Y, down.Y)));                    
                    l.Add(new Point(Math.Abs(down.X - e.X) + Math.Min(e.X, down.X), Math.Min(e.Y, down.Y)));
                    l.Add(new Point(Math.Max(e.X, down.X), Math.Max(e.Y, down.Y)));
                    l.Add(new Point(Math.Min(e.X, down.X), Math.Abs(down.Y - e.Y) + Math.Min(e.Y, down.Y)));
                    p = new Poligono(l, 'R');
                    p.Draw(color, image);
                }
                else if (flag.Equals("Circ"))
                {
                    Primitivas.ponto_medio_circunf(down.X, down.Y, old.X, old.Y, white, image);
                    Primitivas.ponto_medio_circunf(down.X, down.Y, e.X, e.Y, color, image);
                }
                else if (flag.Equals("Elip"))
                {
                    Primitivas.ponto_medio_elipse(down.X, down.Y, old.X, old.Y, white, image);
                    Primitivas.ponto_medio_elipse(down.X, down.Y, e.X, e.Y, color, image);
                }
                else if (flag.Equals("Reta"))
                {
                    Primitivas.bresenham(down.X, down.Y, old.X, old.Y, white, image);
                    Primitivas.bresenham(down.X, down.Y, e.X, e.Y, color, image);
                }
                else if (flag.Equals("Livre"))
                {
                    Primitivas.bresenham(liv.X, liv.Y, e.X, e.Y, color, image);
                    liv = e.Location;
                }
                else if (flag.Equals("Pol"))
                {
                    Primitivas.bresenham(down.X, down.Y, old.X, old.Y, white, image);
                    Primitivas.bresenham(down.X, down.Y, e.X, e.Y, color, image);
                }

                old = e.Location;
                pbMain.Image = image;
            }

            lbX.Text = e.X + "";
            lbY.Text = e.Y + "";
        }

        private void FloodFill(Point p, Color c)
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Push(p);
            while(stack.Count > 0)
            {
                p = stack.Pop();
                image.SetPixel(p.X, p.Y, c);
                if(p.X - 1 > 0 && image.GetPixel(p.X - 1, p.Y).Equals(white))
                    stack.Push(new Point(p.X - 1, p.Y));

                if (p.Y - 1 > 0 && image.GetPixel(p.X, p.Y - 1).Equals(white))
                    stack.Push(new Point(p.X, p.Y - 1));

                if (p.X + 1 < image.Width && image.GetPixel(p.X + 1, p.Y).Equals(white))
                    stack.Push(new Point(p.X + 1, p.Y));

                if (p.Y + 1 < image.Height && image.GetPixel(p.X, p.Y + 1).Equals(white))
                    stack.Push(new Point(p.X, p.Y + 1));
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (down.X != -1 && !flag.Equals(""))
                if (flag.Equals("Livre") || flag.Equals("Reta") || flag.Equals("Circ") || flag.Equals("Elip"))
                {
                    old.X = 0;
                    down.X = -1;
                }
                else
                    if (!flag.Equals("Pol"))
                    {
                        p.Pol1 = "Poligono " + (lvPolig.Items.Count + 1);
                        lvPolig.Items.Add(p);
                        p = new Poligono();

                        old.X = 0;
                        down.X = -1;
                    }
                else
                    if (p.PontosAtuais.Count > 2 &&  e.Button == MouseButtons.Right)
                    {
                        Primitivas.bresenham(down.X, down.Y, p.PontosOriginais[0].X, p.PontosOriginais[0].Y, Color.Black, image);
                        p.Pol1 = "Poligono " + (lvPolig.Items.Count + 1);
                        lvPolig.Items.Add(p);
                        p = new Poligono();
                        
                        old.X = 0;
                        down.X = -1;
                    }
                    else
                        down = e.Location;
            pbMain.Image = image;
        }
    }
}
