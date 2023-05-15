using System;
using System.Windows.Forms;

namespace libraryAutomation
{
    public partial class anaEkran : Form
    {

        bool move;
        int mouse_x;
        int mouse_y;

        public anaEkran()
        {
            InitializeComponent();
        }

        public string username;

        private void frmMain_Load(object sender, EventArgs e)
        {
            userToolStripMenuItem.Text = username;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAddMember"] == null)
            {
                uyeEkle form = new uyeEkle();
                form.Show();
            }
            else
                Application.OpenForms["frmAddMember"].Activate();
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEditMember"] == null)
            {
                uyeDuzenle form = new uyeDuzenle();
                form.Show();
            }
            else
                Application.OpenForms["frmEditMember"].Activate();
        }

        private void btnListMember_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListMember"] == null)
            {
                uyeListe form = new uyeListe();
                form.Show();
            }
            else
                Application.OpenForms["frmListMember"].Activate();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmaddBook"] == null)
            {
                kitapEkle form = new kitapEkle();
                form.Show();
            }
            else
                Application.OpenForms["frmaddBook"].Activate();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEditBook"] == null)
            {
                kitapDuzenle form = new kitapDuzenle();
                form.Show();
            }
            else
                Application.OpenForms["frmEditBook"].Activate();
        }

        private void btnListBook_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListBook"] == null)
            {
                kitapListe form = new kitapListe();
                form.Show();
            }
            else
                Application.OpenForms["frmListBook"].Activate();
        }

        private void btnGive_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTakeBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEscrowedBooks_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAccount"] == null)
            {
                ayarlar form = new ayarlar();
                form.username = userToolStripMenuItem.Text; 
                form.Show();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
