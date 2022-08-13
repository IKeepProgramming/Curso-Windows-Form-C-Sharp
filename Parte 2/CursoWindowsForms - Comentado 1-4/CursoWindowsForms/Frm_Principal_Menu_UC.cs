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
    public partial class Frm_Principal_Menu_UC : Form
    {
        int Controlle = 0;
        int ControlleDemonstracaoKey = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }
        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlleDemonstracaoKey += 1;
            Frm_DemonstracaoKey_UC UC = new Frm_DemonstracaoKey_UC();
            UC.Dock = DockStyle.Fill;
            TabPage C = new TabPage();
            C.Name = "Demonstração Key " + ControlleDemonstracaoKey;
            C.Text = "Demonstração Key " + ControlleDemonstracaoKey;
            C.ImageIndex = 5;
            C.Controls.Add(UC);
            Tbc_Aplicacoes.TabPages.Add(C);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controlle += 1;
            //Adicionando uma tab page na pagina principal de usuario
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            U.Dock = DockStyle.Fill; // Deixa o programa ocupar o espaço todo do formulario.
            TabPage TB = new TabPage();
            TB.Name = "Hello World " + Controlle;
            TB.Text = "Hello World " + Controlle;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara m = new Frm_Mascara();
            m.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF c = new Frm_ValidaCPF();
            c.ShowDialog();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 c2 = new Frm_ValidaCPF2();
            c2.ShowDialog();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha v = new Frm_ValidaSenha();
            v.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Apagar tabs do projeto
            if(!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
            
        }
    }
}
