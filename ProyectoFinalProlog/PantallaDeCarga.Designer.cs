namespace ProyectoFinalProlog
{
    partial class PantallaDeCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDeCarga));
            this.Animacion = new System.Timers.Timer();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panelBarrallena = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Animacion)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Animacion
            // 
            this.Animacion.Enabled = true;
            this.Animacion.SynchronizingObject = this;
            this.Animacion.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Elapsed);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.label4);
            this.panelSuperior.Controls.Add(this.lblCount);
            this.panelSuperior.Controls.Add(this.panelBarra);
            this.panelSuperior.Controls.Add(this.panelBarrallena);
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(600, 400);
            this.panelSuperior.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(135, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "%";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Black;
            this.lblCount.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Snow;
            this.lblCount.Location = new System.Drawing.Point(86, 117);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(30, 35);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "0";
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.White;
            this.panelBarra.Location = new System.Drawing.Point(0, 290);
            this.panelBarra.MaximumSize = new System.Drawing.Size(600, 40);
            this.panelBarra.MinimumSize = new System.Drawing.Size(0, 15);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(0, 15);
            this.panelBarra.TabIndex = 3;
            // 
            // panelBarrallena
            // 
            this.panelBarrallena.BackColor = System.Drawing.Color.SkyBlue;
            this.panelBarrallena.Location = new System.Drawing.Point(0, 290);
            this.panelBarrallena.MaximumSize = new System.Drawing.Size(600, 40);
            this.panelBarrallena.MinimumSize = new System.Drawing.Size(0, 10);
            this.panelBarrallena.Name = "panelBarrallena";
            this.panelBarrallena.Size = new System.Drawing.Size(600, 10);
            this.panelBarrallena.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 105);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(128, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAMACIÓN LÓGICA Y FUNCIONAL\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(272, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "PC Ideal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(166, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "M.C. Rosa Ernestina Pelayo Márquez";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalProlog.Properties.Resources.Intro_HELLO_FUTURE_1920x1080_v2;
            this.pictureBox1.Location = new System.Drawing.Point(-343, -57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1353, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaDeCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaDeCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaDeCarga";
            ((System.ComponentModel.ISupportInitialize)(this.Animacion)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Timers.Timer Animacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel panelBarrallena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCount;
    }
}