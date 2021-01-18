using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProlog
{
    public partial class PantallaDeCarga : Form
    {
        public PantallaDeCarga()
        {
            InitializeComponent();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            double var;

            if (panelBarra.Width < 600)
            {
                panelBarra.Width += 6;
                var = (panelBarra.Width * 100) / 600;
                lblCount.Text = var.ToString();
            }
            else
            {
                Animacion.Stop();

                Principal dashboard = new Principal();
                dashboard.Show();
                this.Hide();
            }
        }
    }
}
