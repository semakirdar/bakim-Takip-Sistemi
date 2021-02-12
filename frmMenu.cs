using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakimTakipProgrami
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        public static int yetki;
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void basamaklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void yatayOlarakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void dikeyOlarakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void tumPencereleriKücültToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form frm in this.MdiChildren)
            {
                frm.WindowState = FormWindowState.Minimized;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Text = frmGiris.gonderilecekveri;
            yetki = Convert.ToInt32(frmGiris.gonderilecekyetki);
        }

        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpener<frmHakkinda>.Open(this);
        }

        private void personelEkleDegistirSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpener<frmPersoneller>.Open(this);
        }

        private void arızaKodlarıEkleDeğiştirSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpener<frmArizaKodlari>.Open(this);
        }

        private void makinelerEkleDeğiştirSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpener<frmMakineler>.Open(this);
        }

        private void bölümEkleDeğiştirSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpener<frmBolumler>.Open(this);
        }

        private void ŞifreDeğişikliğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpener<frmSifreDegisikligi>.Open(this);
        }

        private void tarihKilitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpener<frmKilitTarih>.Open(this);
        }

        private void ONERILERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpener<frmOneriler>.Open(this);
        }

        private void dUYURULARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpener<frmDuyurular>.Open(this);
        }
    }

    public static class FormOpener<T>where T : Form
    {
        public static void Open(Form mdiContainer)
        {
            foreach (Form selectedFrm in mdiContainer.MdiChildren)
            {
                if (selectedFrm is T)
                {
                    selectedFrm.Activate();
                    return;
                }
            }
            T frm = (T)Activator.CreateInstance(typeof(T));
            frm.MdiParent = mdiContainer;
            frm.Show();
        }
    }
}
