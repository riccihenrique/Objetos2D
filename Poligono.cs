﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Poligonos
{
    class Poligono
    {
        List<Point> pontosOriginais = new List<Point>();
        List<Point> pontosAtuais = new List<Point>();
        double[,] matrizTranformacao = new double[3, 3];
        char type;
        string Pol;

        public Poligono()
        {
            pontosAtuais = new List<Point>();
            Identidade();
        }
        public Poligono(List<Point> pontosOriginais, char type)
        {
            this.PontosOriginais = pontosOriginais;
            this.pontosAtuais = new List<Point>(pontosOriginais);
            this.Type = type;
            Identidade();
        }

        public Poligono(Poligono p)
        {
            foreach (Point po in p.PontosAtuais)
            {
                pontosAtuais.Add(new Point(po.X, po.Y));
                pontosOriginais.Add(new Point(po.X, po.Y));
            }
            Identidade();
        }

        public List<Point> PontosOriginais { get => pontosOriginais; set => pontosOriginais = value; }
        public List<Point> PontosAtuais { get => pontosAtuais; }
        public char Type { get => type; set => type = value; }
        public string Pol1 { get => Pol; set => Pol = value; }
        public double[,] GetMat { get => matrizTranformacao; set => matrizTranformacao = value; }

        private void Identidade()
        {
            for (int i = 0; i < 3; i++)
                matrizTranformacao[i, i] = 1;
        }
        public void Translacao(double x, double y)
        {
            double[,] tra = new double[3, 3];
            tra[0, 0] = 1;
            tra[1, 1] = 1;
            tra[2, 2] = 1;
            tra[0, 2] = x;
            tra[1, 2] = y;
            MultMatriz(tra);
            MultPontos();
        }
        public void Rotacao(double degree)
        {
            double[,] rot = new double[3, 3];
            rot[0, 0] = Math.Cos(degree);
            rot[0, 1] = -Math.Sin(degree);
            rot[1, 0] = Math.Sin(degree);
            rot[1, 1] = Math.Cos(degree);
            rot[2, 2] = 1;
            MultMatriz(rot);
            MultPontos();
        } 
        public void Cisalhamento(double x, double y)
        {
            double[,] cis = new double[3, 3];
            cis[0, 0] = 1;
            cis[1, 1] = 1;
            cis[2, 2] = 1;
            cis[0, 1] = y == 0 ? 1 : y;
            cis[1, 0] = x == 0 ? 1 : x;

            MultMatriz(cis);
            MultPontos();
        }
        public void Espelhamento(double x, double y)
        {
            double[,] esp = new double[3, 3];
            esp[0, 0] = y != 0 ? -1 : 1;
            esp[1, 1] = x != 0 ? -1 : 1;
            esp[2, 2] = 1;

            MultMatriz(esp);
            MultPontos();
        }
        public void Escala(double dx, double dy)
        {
            double[,] sca = new double[3, 3];
            sca[0, 0] = dx == 0 ? 1 : dx;
            sca[1, 1] = dy == 0 ? 1 : dy;
            sca[2, 2] = 1;
            MultMatriz(sca);
            MultPontos();
        }
        private void MultMatriz(double[,] matT)
        {
            double soma;
            double[,] aux = new double[3, 3];
            for(int i = 0; i < 3; i++)
                for(int j = 0; j < 3; j++)
                {
                    soma = 0;
                    for (int k = 0; k < 3; k++)
                        soma += matrizTranformacao[i, k] * matT[k, j];

                    aux[i, j] = soma;
                }
            matrizTranformacao = aux;
        }
        private void MultPontos()
        {
            pontosAtuais.Clear();

            foreach(Point p in pontosOriginais)
            {
                double[,] mat = new double[3, 1];

                Point pn;
                mat[0, 0] = p.X;
                mat[1, 0] = p.Y;
                mat[2, 0] = 1;

                pn = new Point((int) (matrizTranformacao[0, 0] * mat[0, 0] + matrizTranformacao[0, 1] * mat[1, 0] + matrizTranformacao[0, 2]), 
                    (int) (matrizTranformacao[1, 0] * mat[0, 0] + matrizTranformacao[1, 1] * mat[1, 0] + matrizTranformacao[1, 2]));
                pontosAtuais.Add(pn);
            }
        }
        public void Draw(Color c, Bitmap image)
        {
            if(pontosAtuais.Count > 0)
            {
                Primitivas.bresenham(pontosAtuais[0].X, pontosAtuais[0].Y,
                pontosAtuais[pontosAtuais.Count - 1].X, pontosAtuais[pontosAtuais.Count - 1].Y, c, image);

                for (int i = 0; i < pontosAtuais.Count - 1; i++)
                    Primitivas.bresenham(pontosAtuais[i].X, pontosAtuais[i].Y,
                        pontosAtuais[i + 1].X, pontosAtuais[i + 1].Y, c, image);
            }
        }
        public void AddPonto(Point p)
        {
            pontosAtuais.Add(p);
            pontosOriginais.Add(p);
        }
        public void ScanLine(Bitmap image, Color cor)
        {
            Point max = MaxPoint();
            int dy = max.Y + 1;
            List<No>[] lista = new List<No>[dy];
            int i, idxm = 10000; // Corrigir aqui

            for(i = 0; i < pontosAtuais.Count; i++)
            {
                Point ma, mi;
                if(i == pontosAtuais.Count - 1)
                    if (pontosAtuais[i].Y > pontosAtuais[0].Y)
                    {
                        ma = pontosAtuais[i];
                        mi = pontosAtuais[0];
                    }
                    else
                    {
                        ma = pontosAtuais[0];
                        mi = pontosAtuais[i];
                    }
                else
                    if (pontosAtuais[i].Y > pontosAtuais[i + 1].Y)
                    {
                        ma = pontosAtuais[i];
                        mi = pontosAtuais[i + 1];
                    }
                    else
                    {
                        ma = pontosAtuais[i + 1];
                        mi = pontosAtuais[i];
                    }

                int idx = mi.Y;

                if (idx < idxm)
                    idxm = idx;

                if (lista[idx] == null)
                    lista[idx] = new List<No>();
                double x = (ma.Y - mi.Y);
                x = x == 0 ? 0 : (ma.X - mi.X) / x;

                lista[idx].Add(new No(ma.Y, mi.X, x));
                lista[idx].Sort(new XCompare());
            }

            List<No> AET = new List<No>();
            i = idxm;
            foreach (No n in lista[i])
                AET.Add(n);
            do
            {
                for (int j = AET.Count - 1; j >= 0; j--)
                    if (AET[j].Ymax1 == i)
                        AET.RemoveAt(j);

                if(AET.Count > 0)
                {
                    AET.Sort(new XCompare());
                    for (int j = 0; j < AET.Count; j += 2)
                        Primitivas.bresenham((int) AET[j].Xmin1, i,(int) AET[j + 1].Xmin1 - 1, i, cor, image);

                    foreach (No e in AET)
                        e.Xmin1 += e.IncX1;

                    i++;

                    if (lista[i] != null)
                        foreach (No n in lista[i])
                            AET.Add(n);
                } 
            } while (AET.Count > 0);
        }
        public Point MinPoint()
        {
            Point min = new Point(3000, 3000);
            foreach(Point p in pontosAtuais)
            {
                if (p.X < min.X)
                    min.X = p.X;

                if (p.Y < min.Y)
                    min.Y = p.Y;
            }
            return min;
        }
        public Point Centro()
        {
            int x = 0, y = 0;
            foreach (Point p in pontosOriginais)
            {
                x += p.X;
                y += p.Y;
            }
            return new Point(x /= pontosAtuais.Count, y /= pontosAtuais.Count);
        }
        public Point CentroAtual()
        {
            int x = 0, y = 0;
            foreach (Point p in PontosAtuais)
            {
                x += p.X;
                y += p.Y;
            }
            return new Point(x /= PontosAtuais.Count, y /= PontosAtuais.Count);
        }

        public Point MaxPoint()
        {
            Point max = new Point(0, 0);
            foreach (Point p in pontosAtuais)
            {
                if (p.X > max.X)
                    max.X = p.X;

                if (p.Y > max.Y)
                    max.Y = p.Y;
            }
            return max;
        }
        public override string ToString()
        {
            return Pol;
        }
        public class XCompare : IComparer<No>
        {
            public int Compare(No x, No y)
            {
                return x.Xmin1.CompareTo(y.Xmin1);
            }
        }
    }
    class No
    {
        private double IncX, Ymax, Xmin;
        
        public No(double ymax, double xmin, double incX)
        {
            Ymax = ymax;
            Xmin = xmin;
            IncX = incX;
        }

        public double Ymax1 { get => Ymax; set => Ymax = value; }
        public double Xmin1 { get => Xmin; set => Xmin = value; }
        public double IncX1 { get => IncX; set => IncX = value; }
    }
}
