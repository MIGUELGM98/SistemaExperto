namespace ProyectoFinalProlog
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.uso = new System.Windows.Forms.ComboBox();
            this.gama = new System.Windows.Forms.ComboBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCer = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelComponentes = new System.Windows.Forms.Panel();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblPSU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMOBO = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uso
            // 
            this.uso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uso.FormattingEnabled = true;
            this.uso.Items.AddRange(new object[] {
            "USO",
            "ofimatica",
            "gaming",
            "productividad"});
            this.uso.Location = new System.Drawing.Point(63, 90);
            this.uso.Name = "uso";
            this.uso.Size = new System.Drawing.Size(273, 21);
            this.uso.TabIndex = 7;
            // 
            // gama
            // 
            this.gama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gama.FormattingEnabled = true;
            this.gama.Items.AddRange(new object[] {
            "GAMA",
            "alta",
            "media",
            "baja"});
            this.gama.Location = new System.Drawing.Point(63, 170);
            this.gama.Name = "gama";
            this.gama.Size = new System.Drawing.Size(273, 21);
            this.gama.TabIndex = 6;
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(270, 232);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(281, 277);
            this.lbInfo.TabIndex = 5;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.pnlSuperior.Controls.Add(this.label2);
            this.pnlSuperior.Controls.Add(this.btnCer);
            this.pnlSuperior.Controls.Add(this.btnMax);
            this.pnlSuperior.Controls.Add(this.btnMin);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(420, 25);
            this.pnlSuperior.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "PC ideal";
            // 
            // btnCer
            // 
            this.btnCer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCer.BackgroundImage")));
            this.btnCer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCer.FlatAppearance.BorderSize = 0;
            this.btnCer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.btnCer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnCer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCer.Location = new System.Drawing.Point(395, 0);
            this.btnCer.Margin = new System.Windows.Forms.Padding(0);
            this.btnCer.Name = "btnCer";
            this.btnCer.Size = new System.Drawing.Size(25, 25);
            this.btnCer.TabIndex = 33;
            this.btnCer.UseVisualStyleBackColor = true;
            this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMax.BackgroundImage")));
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(295, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.TabIndex = 32;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Visible = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(370, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.TabIndex = 31;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(59, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "¿Qué uso le dara a la computadora?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "¿Qué gama desea?";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelComponentes);
            this.panelContenedor.Controls.Add(this.pictureBox7);
            this.panelContenedor.Controls.Add(this.pictureBox4);
            this.panelContenedor.Controls.Add(this.label3);
            this.panelContenedor.Controls.Add(this.btnBuscar);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.gama);
            this.panelContenedor.Controls.Add(this.uso);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(0, 25);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(420, 695);
            this.panelContenedor.TabIndex = 13;
            // 
            // panelComponentes
            // 
            this.panelComponentes.Controls.Add(this.lblCPU);
            this.panelComponentes.Controls.Add(this.lblGPU);
            this.panelComponentes.Controls.Add(this.pictureBox6);
            this.panelComponentes.Controls.Add(this.lblPSU);
            this.panelComponentes.Controls.Add(this.lblRAM);
            this.panelComponentes.Controls.Add(this.pictureBox5);
            this.panelComponentes.Controls.Add(this.pictureBox2);
            this.panelComponentes.Controls.Add(this.pictureBox3);
            this.panelComponentes.Controls.Add(this.pictureBox1);
            this.panelComponentes.Controls.Add(this.lblMOBO);
            this.panelComponentes.Location = new System.Drawing.Point(85, 282);
            this.panelComponentes.Name = "panelComponentes";
            this.panelComponentes.Size = new System.Drawing.Size(251, 370);
            this.panelComponentes.TabIndex = 6;
            this.panelComponentes.Visible = false;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.Transparent;
            this.lblCPU.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblCPU.ForeColor = System.Drawing.Color.Black;
            this.lblCPU.Location = new System.Drawing.Point(58, 43);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(81, 18);
            this.lblCPU.TabIndex = 13;
            this.lblCPU.Text = "Procesador";
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.BackColor = System.Drawing.Color.Transparent;
            this.lblGPU.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblGPU.ForeColor = System.Drawing.Color.Black;
            this.lblGPU.Location = new System.Drawing.Point(60, 110);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(103, 18);
            this.lblGPU.TabIndex = 15;
            this.lblGPU.Text = "Tarjeta gráfica";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProyectoFinalProlog.Properties.Resources.RAM;
            this.pictureBox6.Location = new System.Drawing.Point(6, 290);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 48);
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // lblPSU
            // 
            this.lblPSU.AutoSize = true;
            this.lblPSU.BackColor = System.Drawing.Color.Transparent;
            this.lblPSU.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblPSU.ForeColor = System.Drawing.Color.Black;
            this.lblPSU.Location = new System.Drawing.Point(58, 238);
            this.lblPSU.Name = "lblPSU";
            this.lblPSU.Size = new System.Drawing.Size(114, 18);
            this.lblPSU.TabIndex = 16;
            this.lblPSU.Text = "Fuente de poder";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.Color.Transparent;
            this.lblRAM.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblRAM.ForeColor = System.Drawing.Color.Black;
            this.lblRAM.Location = new System.Drawing.Point(61, 303);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(101, 18);
            this.lblRAM.TabIndex = 14;
            this.lblRAM.Text = "Memoria RAM";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyectoFinalProlog.Properties.Resources.PSU;
            this.pictureBox5.Location = new System.Drawing.Point(3, 225);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 48);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinalProlog.Properties.Resources.CPU;
            this.pictureBox2.Location = new System.Drawing.Point(3, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 48);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinalProlog.Properties.Resources.GPU;
            this.pictureBox3.Location = new System.Drawing.Point(5, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 48);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalProlog.Properties.Resources.MOBO;
            this.pictureBox1.Location = new System.Drawing.Point(3, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 48);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblMOBO
            // 
            this.lblMOBO.AutoSize = true;
            this.lblMOBO.BackColor = System.Drawing.Color.Transparent;
            this.lblMOBO.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.lblMOBO.ForeColor = System.Drawing.Color.Black;
            this.lblMOBO.Location = new System.Drawing.Point(58, 173);
            this.lblMOBO.Name = "lblMOBO";
            this.lblMOBO.Size = new System.Drawing.Size(99, 18);
            this.lblMOBO.TabIndex = 21;
            this.lblMOBO.Text = "Tarjeta madre";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::ProyectoFinalProlog.Properties.Resources.INFO;
            this.pictureBox7.Location = new System.Drawing.Point(3, 662);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::ProyectoFinalProlog.Properties.Resources.COMOUSAR;
            this.pictureBox4.Location = new System.Drawing.Point(387, 662);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.BorderRadius = 0;
            this.btnBuscar.ButtonText = "¡Buscar piezas!";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscar.Iconimage = global::ProyectoFinalProlog.Properties.Resources.Buscar;
            this.btnBuscar.Iconimage_right = null;
            this.btnBuscar.Iconimage_right_Selected = null;
            this.btnBuscar.Iconimage_Selected = null;
            this.btnBuscar.IconMarginLeft = 0;
            this.btnBuscar.IconMarginRight = 0;
            this.btnBuscar.IconRightVisible = true;
            this.btnBuscar.IconRightZoom = 0D;
            this.btnBuscar.IconVisible = true;
            this.btnBuscar.IconZoom = 60D;
            this.btnBuscar.IsTab = false;
            this.btnBuscar.Location = new System.Drawing.Point(110, 223);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btnBuscar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            this.btnBuscar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscar.selected = false;
            this.btnBuscar.Size = new System.Drawing.Size(179, 53);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "¡Buscar piezas!";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Textcolor = System.Drawing.Color.White;
            this.btnBuscar.TextFont = new System.Drawing.Font("Yu Gothic", 12F);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lbInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(420, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 695);
            this.panel1.TabIndex = 14;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pnlSuperior);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(420, 720);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelComponentes.ResumeLayout(false);
            this.panelComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox uso;
        private System.Windows.Forms.ComboBox gama;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscar;
        private System.Windows.Forms.Button btnCer;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPSU;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblMOBO;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panelComponentes;
        private System.Windows.Forms.Label label2;
    }
}

