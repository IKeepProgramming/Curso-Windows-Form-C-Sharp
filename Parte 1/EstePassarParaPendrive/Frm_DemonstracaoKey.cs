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
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = "";
            Txt_Input.Text = "";
            Lbl_Upper.Text = "";
            Lbl_Lower.Text = "";
        }

        private void Lbl_Minus_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText("\r\n" + "Pressionei a Tecla: " + e.KeyCode + "\r\n"); // -> AppendText cria uma linha de texto em UTF-8
            Txt_Msg.AppendText("\t" + "Código da Tecla: " + ((int)e.KeyCode) + "\r\n"); // -> \t == tab em c#
            Txt_Msg.AppendText("\t" + "Nome da Tecla: " + e.KeyData + "\r\n");
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }
    }
}
