using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMCServices;

namespace IMC_WinForms
{
    public partial class FrmDiagnostico : Form
    {
        IMCService imcService = new IMCService();
        FrmMain main;
        public FrmDiagnostico(FrmMain frmMain)
        {
            InitializeComponent();
            main = frmMain;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void BtnCalcularIMC_Click(object sender, EventArgs e)
        {
            double Peso;
            double Altura;

            Peso = double.Parse(TxtPeso.Text);
            Altura = double.Parse(TxtAltura.Text);

            LblIMC.Text = imcService.CalcularIMC(Peso, Altura).ToString();

        }
    }
}
