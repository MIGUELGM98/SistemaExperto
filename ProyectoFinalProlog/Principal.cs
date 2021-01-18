using SbsSW.SwiPlCs;
using System;
using System.Collections;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            gama.SelectedIndex = 0;
            uso.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Environment.SetEnvironmentVariable("Path", @"E:\\SISTEMA EXPERTO\\ProyectoFinalProlog\\ProyectoFinalProlog\\bin\\Debug\\swipl\\bin");
                String[] p = { "-q", "-f", @"proyecto_final.pl" };
                PlEngine.Initialize(p);
                //firstElementComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                throw;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArrayList datos = new ArrayList();
            Boolean repetido = false;

            lbInfo.DataSource = null;
            lbInfo.Items.Clear();

            //String query = "es_uso(X," + uso.Text.ToString() + "),es_gama(X," + gama.Text.ToString() + ").";


            String query = "gama_uso(" +
              "X,"
                + uso.Text.ToString() + ","
                + gama.Text.ToString() + ")";
            MessageBox.Show(query);
            PlQuery consulta = new PlQuery(query);
            foreach (PlQueryVariables z in consulta.SolutionVariables)
            {
                foreach (var element in datos)
                {
                    if (element.Equals(z["X"].ToString()))
                    {
                        repetido = true;
                        break;
                    }
                }

                if (repetido == false)
                {
                    datos.Add(z["X"].ToString());
                }
                repetido = false;
            }

            lbInfo.DataSource = datos;




            lblCPU.Text = datos[0].ToString().Replace('_',' ');
            lblGPU.Text = datos[1].ToString().Replace('_', ' ');
            lblMOBO.Text = datos[4].ToString().Replace('_', ' ');
            lblPSU.Text = datos[3].ToString().Replace('_', ' ').Replace('a',' ');
            lblRAM.Text = datos[2].ToString().Replace('_', ' ').Replace('a',' ');

            panelComponentes.Visible = true;
        }

        private void btnCer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Uso uso = new Uso();
            uso.ShowDialog();
        }
    }
}
