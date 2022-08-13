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
    public partial class Frm_Menu_Principal_MDI : Form
    {
        public Frm_Menu_Principal_MDI()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey f = new Frm_DemonstracaoKey();
            f.MdiParent = this;
            f.Show();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld h = new Frm_HelloWorld();
            h.MdiParent = this;
            h.Show();
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara m = new Frm_Mascara();
            m.MdiParent = this;
            m.Show();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF c = new Frm_ValidaCPF();
            c.MdiParent = this;
            c.Show();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 c2 = new Frm_ValidaCPF2();
            c2.MdiParent = this;
            c2.Show();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha v = new Frm_ValidaSenha();
            v.MdiParent = this;
            v.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }
    }
}

