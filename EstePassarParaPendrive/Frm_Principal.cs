using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstePassarParaPendrive
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_DemonstracaoKey_Click(object sender, EventArgs e)
        {
            //Esta em outro arquivo, mas segue a mesma coisa :D
        }

        private void Btn_Mascara_Click(object sender, EventArgs e)
        {
            Frm_Mascara m = new Frm_Mascara(); //-> Instancia a classe Frm_Mascara e apresenta o form com a herança do : Form
            m.ShowDialog();
        }

        private void Btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF vc = new Frm_ValidaCPF();
            vc.ShowDialog();
        }

        private void Btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 vc2 = new Frm_ValidaCPF2();
            vc2.ShowDialog();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha vs = new Frm_ValidaSenha();
            vs.ShowDialog();
        }

        private void Btn_HelloWorld_Click(object sender, EventArgs e)
        {
            //Esta em outro arquivo, mas segue a mesma coisa :D

            // Lembra de trocar no HelloWorld.cs - ao inves de Application.exit() que fecha o programa todo
            // vamos colocar this.close(), assim ele vai fechar a janela
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
