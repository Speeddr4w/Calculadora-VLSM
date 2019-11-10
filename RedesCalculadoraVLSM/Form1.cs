using RedesCalculadoraVLSM.Control;
using RedesCalculadoraVLSM.Model;
using RedesCalculadoraVLSM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedesCalculadoraVLSM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProseguirCalculo_Click(object sender, EventArgs e)
        {
            //DAOClassesdeRede.mostrarClasses();
            string[] ipbase = txtboxIPBase.Text.Split('.');
            DAOClassesdeRede.ClassificarRede(ipbase);

            if (ClassesDeRede.ValidAddress)
            {
                txtboxIPBase.Enabled = false;
                btnProseguirCalculo.Enabled = false;
                nudHosts.Enabled = true;
                btnAdicionarHost.Enabled = true;
                btnCalcular.Enabled = true;
                dataGridView1.Enabled = true;
                richTextBox1.AppendText(DAOClassesdeRede.TextoParaInfoDeRede());
            }



        }

        private void BtnAdicionarHost_Click(object sender, EventArgs e)
        {
            int host = Convert.ToInt32(nudHosts.Value);
            if(host >= 0)
            {
                DAOClassesdeRede.AddListaRedes(host);
                Hosts aux = DAOClassesdeRede.ListaHosts[DAOClassesdeRede.ListaHosts.Count - 1];
                dataGridView1.Rows.Add(aux.Host, aux.Mais2, aux.ProximaPotencia);
            }
            else
            {
                Mostrar.ErroNoHosts();
            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            DAOClassesdeRede.OrdernarListaRedes();
            DAOClassesdeRede.TotalListaHosts();
            if (DAOClassesdeRede.ListaValida)
            {   
                richTextBox1.Clear();
                richTextBox1.AppendText(DAOClassesdeRede.TextoParaInfoDeRede());
                DAOClassesdeRede.MakeListSubredes();
                richTextBox1.AppendText(DAOClassesdeRede.MostrarSubredes());
            }
        }

        private void BtnRecomecarCalculo_Click(object sender, EventArgs e)
        {
            txtboxIPBase.Enabled = true;
            txtboxIPBase.Text = string.Empty;
            btnProseguirCalculo.Enabled = true;
            nudHosts.Enabled = false;
            btnAdicionarHost.Enabled = false;
            btnCalcular.Enabled = false;
            dataGridView1.Enabled = false;
            dataGridView1.Rows.Clear();
            richTextBox1.Clear();
            DAOClassesdeRede.resetar();
        }
    }
}
