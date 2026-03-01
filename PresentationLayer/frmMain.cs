using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dmChucVu f = new frm_dmChucVu();
            f.MdiParent = this;
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dmNhanVien f = new frm_dmNhanVien();
            f.MdiParent = this;
            f.Show();
        }
    }
}
