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
    public partial class Frm_Principal_Menu : Form
    {
        public Frm_Principal_Menu()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey f = new Frm_DemonstracaoKey();
            f.ShowDialog();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld h = new Frm_HelloWorld();
            h.ShowDialog();
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
    }
}
