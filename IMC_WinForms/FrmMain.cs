using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_WinForms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            ShowTime();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void ShowTime()
        {
            LblFecha.Text = "FECHA: " + DateTime.Now.Date.ToString("dd/MM/yyyy");
            LblHora.Text = "HORA: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void BtnNuevoDiagnostico_Click(object sender, EventArgs e)
        {
            FrmDiagnostico frmDiagnostico = new FrmDiagnostico(this);
            frmDiagnostico.ShowDialog();
            //this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            FrmComprar frmComprar = new FrmComprar(this);
            frmComprar.Show();
            this.Hide();
        }
    }
}
