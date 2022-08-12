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
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            // O replace faz a alteração de certos caracteres por outros.
            string vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim(); // Trim remove o espaçamento em branco na string

            if (vConteudo == "")
            {
                MessageBox.Show("Você deve digitar um CPF", "Mensagem de Válidação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF precisa conter 11 digítos", "Mensagem de Válidação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // O DialogResult vai receber o resultado da caixa de dialogo.
                    if (MessageBox.Show("Você tem certeza que quer validar o CPF?", "Mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                    }

                    bool validaCPF = false;
                    validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);

                    if (validaCPF == true)
                    {
                        // Comando para fazer uma caixa de texto ao clickar de um botão
                        MessageBox.Show("CPF VÁLIDO", "Mensagem de Válidação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF INVÁLIDO", "Mensagem de Válidação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
