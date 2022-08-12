using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_HelloWord : Form
    {
        public Frm_HelloWord()
        {
            InitializeComponent(); // -> Faz a construção/desenho do formulário
        }

        private void lbl_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit(); // -> Encerra a Aplicação
        }

        private void Btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            //lbl_Titulo.Text = "Label Modificado"; -> Modifica a Label
            lbl_Titulo.Text = Txt_ConteudoLabel.Text; // -> Modifica a Label através da escrita do TextBox
        }
    }
}
