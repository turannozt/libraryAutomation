using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
namespace libraryAutomation
{
    public partial class kitapListe : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=kutuphane;Integrated Security=True");
        DataTable table = new DataTable();
        DataView dataView = new DataView();
        public kitapListe()
        {
            InitializeComponent();
        }

        private void frmListBook_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from book order by book_title", con);
            adapter.Fill(table);
            dgwBook.DataSource = table;
            dgwBook.Columns["barcode_no"].HeaderText = "Barkod No";
            dgwBook.Columns["book_title"].HeaderText = "Kitap Adı";
            dgwBook.Columns["author"].HeaderText = "Yazarı";
            dgwBook.Columns["page_count"].HeaderText = "Sayfa Sayısı";
            dgwBook.Columns["shelf_no"].HeaderText = "Raf No";
            con.Close();
        }

        //This line of code filters the table based on entered barcode number.
        private void txtSearchBarcodeNo_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "barcode_no LIKE '%" + txtSearchBarcodeNo.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        //This line of code filters the table based on entered book title.
        private void txtSearchBookTitle_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "book_title LIKE '%" + txtSearchBookTitle.Text + "%'";
            dgwBook.DataSource = dataView;
        }

        private void txtSearchBarcodeNo_Enter(object sender, EventArgs e)
        {
            txtSearchBookTitle.Clear();
        }

        private void txtSearchBookTitle_Enter(object sender, EventArgs e)
        {
            txtSearchBarcodeNo.Clear();
        }

        private void dgwBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmaddBook"] == null)
            {
                kitapEkle form = new kitapEkle();
                form.Show();
            }
            else
                Application.OpenForms["frmaddBook"].Activate();
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapDuzenle form = new kitapDuzenle();
            form.barcodeNo = dgwBook.CurrentRow.Cells[0].Value.ToString();
            form.bookTitle = dgwBook.CurrentRow.Cells[1].Value.ToString();
            form.author = dgwBook.CurrentRow.Cells[2].Value.ToString();
            form.pageCount = dgwBook.CurrentRow.Cells[3].Value.ToString();
            form.shelfNo = dgwBook.CurrentRow.Cells[4].Value.ToString();
            form.Show();
            this.Close();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = new DialogResult();
                answer = MessageBox.Show("Kitap kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("delete from book where barcode_no=@barcode_no", con);
                    com.Parameters.AddWithValue("@barcode_no", dgwBook.CurrentRow.Cells["barcode_no"].Value.ToString());
                    com.ExecuteNonQuery();
                    table.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from book order by book_title", con);
                    adapter.Fill(table);
                    dgwBook.DataSource = table;
                    MessageBox.Show("Kitap kaydı silinmiştir.");
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hay aksi! Bir hata oluştu. Tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
