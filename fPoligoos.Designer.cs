namespace Poligonos
{
    partial class fPoligoos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPol = new System.Windows.Forms.Button();
            this.btBal = new System.Windows.Forms.Button();
            this.btLivre = new System.Windows.Forms.Button();
            this.btReta = new System.Windows.Forms.Button();
            this.btElip = new System.Windows.Forms.Button();
            this.btCirc = new System.Windows.Forms.Button();
            this.btRet = new System.Windows.Forms.Button();
            this.gbTrans = new System.Windows.Forms.GroupBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lbTY = new System.Windows.Forms.Label();
            this.lbTX = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTransf = new System.Windows.Forms.ComboBox();
            this.tbPFy = new System.Windows.Forms.TextBox();
            this.tbPFx = new System.Windows.Forms.TextBox();
            this.rbPonto = new System.Windows.Forms.RadioButton();
            this.btTransformar = new System.Windows.Forms.Button();
            this.rbEixo = new System.Windows.Forms.RadioButton();
            this.rbOrigem = new System.Windows.Forms.RadioButton();
            this.lvPolig = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.cdCor = new System.Windows.Forms.ColorDialog();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.btViewPort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Location = new System.Drawing.Point(12, 96);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(943, 431);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btPol);
            this.groupBox1.Controls.Add(this.btBal);
            this.groupBox1.Controls.Add(this.btLivre);
            this.groupBox1.Controls.Add(this.btReta);
            this.groupBox1.Controls.Add(this.btElip);
            this.groupBox1.Controls.Add(this.btCirc);
            this.groupBox1.Controls.Add(this.btRet);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poligonos";
            // 
            // btPol
            // 
            this.btPol.Location = new System.Drawing.Point(171, 34);
            this.btPol.Name = "btPol";
            this.btPol.Size = new System.Drawing.Size(27, 23);
            this.btPol.TabIndex = 6;
            this.btPol.Text = "P";
            this.btPol.UseVisualStyleBackColor = true;
            this.btPol.Click += new System.EventHandler(this.BtQuad_Click);
            this.btPol.MouseHover += new System.EventHandler(this.BtBal_MouseHover);
            // 
            // btBal
            // 
            this.btBal.Location = new System.Drawing.Point(204, 34);
            this.btBal.Name = "btBal";
            this.btBal.Size = new System.Drawing.Size(28, 23);
            this.btBal.TabIndex = 6;
            this.btBal.Text = "B";
            this.btBal.UseVisualStyleBackColor = true;
            this.btBal.Click += new System.EventHandler(this.BtQuad_Click);
            this.btBal.MouseHover += new System.EventHandler(this.BtBal_MouseHover);
            // 
            // btLivre
            // 
            this.btLivre.Location = new System.Drawing.Point(138, 34);
            this.btLivre.Name = "btLivre";
            this.btLivre.Size = new System.Drawing.Size(27, 23);
            this.btLivre.TabIndex = 5;
            this.btLivre.Text = "L";
            this.btLivre.UseVisualStyleBackColor = true;
            this.btLivre.Click += new System.EventHandler(this.BtQuad_Click);
            this.btLivre.MouseHover += new System.EventHandler(this.BtBal_MouseHover);
            // 
            // btReta
            // 
            this.btReta.Location = new System.Drawing.Point(105, 34);
            this.btReta.Name = "btReta";
            this.btReta.Size = new System.Drawing.Size(27, 23);
            this.btReta.TabIndex = 4;
            this.btReta.Text = "Re";
            this.btReta.UseVisualStyleBackColor = true;
            this.btReta.Click += new System.EventHandler(this.BtQuad_Click);
            this.btReta.MouseHover += new System.EventHandler(this.BtBal_MouseHover);
            // 
            // btElip
            // 
            this.btElip.Location = new System.Drawing.Point(72, 34);
            this.btElip.Name = "btElip";
            this.btElip.Size = new System.Drawing.Size(27, 23);
            this.btElip.TabIndex = 3;
            this.btElip.Text = "E";
            this.btElip.UseVisualStyleBackColor = true;
            this.btElip.Click += new System.EventHandler(this.BtQuad_Click);
            this.btElip.MouseHover += new System.EventHandler(this.BtBal_MouseHover);
            // 
            // btCirc
            // 
            this.btCirc.Location = new System.Drawing.Point(39, 34);
            this.btCirc.Name = "btCirc";
            this.btCirc.Size = new System.Drawing.Size(27, 23);
            this.btCirc.TabIndex = 2;
            this.btCirc.Text = "C";
            this.btCirc.UseVisualStyleBackColor = true;
            this.btCirc.Click += new System.EventHandler(this.BtQuad_Click);
            this.btCirc.MouseHover += new System.EventHandler(this.BtBal_MouseHover);
            // 
            // btRet
            // 
            this.btRet.Location = new System.Drawing.Point(6, 34);
            this.btRet.Name = "btRet";
            this.btRet.Size = new System.Drawing.Size(27, 23);
            this.btRet.TabIndex = 1;
            this.btRet.Text = "R";
            this.btRet.UseVisualStyleBackColor = true;
            this.btRet.Click += new System.EventHandler(this.BtQuad_Click);
            this.btRet.MouseHover += new System.EventHandler(this.BtBal_MouseHover);
            // 
            // gbTrans
            // 
            this.gbTrans.Controls.Add(this.btViewPort);
            this.gbTrans.Controls.Add(this.tbX);
            this.gbTrans.Controls.Add(this.lbTY);
            this.gbTrans.Controls.Add(this.lbTX);
            this.gbTrans.Controls.Add(this.tbY);
            this.gbTrans.Controls.Add(this.label2);
            this.gbTrans.Controls.Add(this.cbTransf);
            this.gbTrans.Controls.Add(this.tbPFy);
            this.gbTrans.Controls.Add(this.tbPFx);
            this.gbTrans.Controls.Add(this.rbPonto);
            this.gbTrans.Controls.Add(this.btTransformar);
            this.gbTrans.Controls.Add(this.rbEixo);
            this.gbTrans.Controls.Add(this.rbOrigem);
            this.gbTrans.Enabled = false;
            this.gbTrans.Location = new System.Drawing.Point(266, 12);
            this.gbTrans.Name = "gbTrans";
            this.gbTrans.Size = new System.Drawing.Size(548, 78);
            this.gbTrans.TabIndex = 2;
            this.gbTrans.TabStop = false;
            this.gbTrans.Text = "Tranformadas";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(109, 51);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(33, 20);
            this.tbX.TabIndex = 27;
            this.tbX.Visible = false;
            // 
            // lbTY
            // 
            this.lbTY.AutoSize = true;
            this.lbTY.Location = new System.Drawing.Point(148, 55);
            this.lbTY.Name = "lbTY";
            this.lbTY.Size = new System.Drawing.Size(17, 13);
            this.lbTY.TabIndex = 26;
            this.lbTY.Text = "Y:";
            // 
            // lbTX
            // 
            this.lbTX.AutoSize = true;
            this.lbTX.Location = new System.Drawing.Point(80, 55);
            this.lbTX.Name = "lbTX";
            this.lbTX.Size = new System.Drawing.Size(17, 13);
            this.lbTX.TabIndex = 25;
            this.lbTX.Text = "X:";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(171, 52);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(33, 20);
            this.tbY.TabIndex = 24;
            this.tbY.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tranformação:";
            // 
            // cbTransf
            // 
            this.cbTransf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransf.FormattingEnabled = true;
            this.cbTransf.Items.AddRange(new object[] {
            "Cisalhamento",
            "Escala",
            "Espelhamento",
            "Rotação",
            "ScanLine",
            "Translação"});
            this.cbTransf.Location = new System.Drawing.Point(83, 24);
            this.cbTransf.Name = "cbTransf";
            this.cbTransf.Size = new System.Drawing.Size(121, 21);
            this.cbTransf.Sorted = true;
            this.cbTransf.TabIndex = 18;
            this.cbTransf.SelectedIndexChanged += new System.EventHandler(this.CbTransf_SelectedIndexChanged);
            // 
            // tbPFy
            // 
            this.tbPFy.Location = new System.Drawing.Point(382, 44);
            this.tbPFy.Name = "tbPFy";
            this.tbPFy.Size = new System.Drawing.Size(31, 20);
            this.tbPFy.TabIndex = 16;
            this.tbPFy.Visible = false;
            // 
            // tbPFx
            // 
            this.tbPFx.Location = new System.Drawing.Point(345, 44);
            this.tbPFx.Name = "tbPFx";
            this.tbPFx.Size = new System.Drawing.Size(31, 20);
            this.tbPFx.TabIndex = 15;
            this.tbPFx.Visible = false;
            // 
            // rbPonto
            // 
            this.rbPonto.AutoSize = true;
            this.rbPonto.Location = new System.Drawing.Point(330, 21);
            this.rbPonto.Name = "rbPonto";
            this.rbPonto.Size = new System.Drawing.Size(107, 17);
            this.rbPonto.TabIndex = 14;
            this.rbPonto.Text = "Ponto Específico";
            this.rbPonto.UseVisualStyleBackColor = true;
            this.rbPonto.CheckedChanged += new System.EventHandler(this.RbPonto_CheckedChanged);
            // 
            // btTransformar
            // 
            this.btTransformar.Location = new System.Drawing.Point(467, 48);
            this.btTransformar.Name = "btTransformar";
            this.btTransformar.Size = new System.Drawing.Size(75, 23);
            this.btTransformar.TabIndex = 13;
            this.btTransformar.Text = "Transformar";
            this.btTransformar.UseVisualStyleBackColor = true;
            this.btTransformar.Click += new System.EventHandler(this.BtTransformar_Click);
            // 
            // rbEixo
            // 
            this.rbEixo.AutoSize = true;
            this.rbEixo.Checked = true;
            this.rbEixo.Location = new System.Drawing.Point(240, 48);
            this.rbEixo.Name = "rbEixo";
            this.rbEixo.Size = new System.Drawing.Size(81, 17);
            this.rbEixo.TabIndex = 11;
            this.rbEixo.TabStop = true;
            this.rbEixo.Text = "Próprio Eixo";
            this.rbEixo.UseVisualStyleBackColor = true;
            // 
            // rbOrigem
            // 
            this.rbOrigem.AutoSize = true;
            this.rbOrigem.Location = new System.Drawing.Point(240, 23);
            this.rbOrigem.Name = "rbOrigem";
            this.rbOrigem.Size = new System.Drawing.Size(58, 17);
            this.rbOrigem.TabIndex = 10;
            this.rbOrigem.Text = "Origem";
            this.rbOrigem.UseVisualStyleBackColor = true;
            // 
            // lvPolig
            // 
            this.lvPolig.FormattingEnabled = true;
            this.lvPolig.Location = new System.Drawing.Point(961, 120);
            this.lvPolig.Name = "lvPolig";
            this.lvPolig.Size = new System.Drawing.Size(240, 199);
            this.lvPolig.TabIndex = 3;
            this.lvPolig.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(958, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Polígonos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView1.Location = new System.Drawing.Point(961, 334);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(240, 193);
            this.dataGridView1.TabIndex = 5;
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.X.DataPropertyName = "X";
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Y.DataPropertyName = "Y";
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(961, 13);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(20, 13);
            this.lbX.TabIndex = 6;
            this.lbX.Text = "X: ";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(961, 35);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(20, 13);
            this.lbY.TabIndex = 7;
            this.lbY.Text = "Y: ";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(964, 61);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar Tudo";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(916, 306);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(0, 13);
            this.lbDescricao.TabIndex = 7;
            // 
            // btViewPort
            // 
            this.btViewPort.Location = new System.Drawing.Point(467, 17);
            this.btViewPort.Name = "btViewPort";
            this.btViewPort.Size = new System.Drawing.Size(75, 23);
            this.btViewPort.TabIndex = 28;
            this.btViewPort.Text = "ViewPort";
            this.btViewPort.UseVisualStyleBackColor = true;
            this.btViewPort.Click += new System.EventHandler(this.BtViewPort_Click);
            // 
            // fPoligoos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 534);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPolig);
            this.Controls.Add(this.gbTrans);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbMain);
            this.Name = "fPoligoos";
            this.Text = "Polígonos";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbTrans.ResumeLayout(false);
            this.gbTrans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btPol;
        private System.Windows.Forms.Button btLivre;
        private System.Windows.Forms.Button btReta;
        private System.Windows.Forms.Button btElip;
        private System.Windows.Forms.Button btCirc;
        private System.Windows.Forms.Button btRet;
        private System.Windows.Forms.GroupBox gbTrans;
        private System.Windows.Forms.ListBox lvPolig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button btTransformar;
        private System.Windows.Forms.RadioButton rbEixo;
        private System.Windows.Forms.RadioButton rbOrigem;
        private System.Windows.Forms.Button btBal;
        private System.Windows.Forms.RadioButton rbPonto;
        private System.Windows.Forms.TextBox tbPFy;
        private System.Windows.Forms.TextBox tbPFx;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ColorDialog cdCor;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lbTY;
        private System.Windows.Forms.Label lbTX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTransf;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button btViewPort;
    }
}

