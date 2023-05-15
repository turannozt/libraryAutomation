using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
namespace libraryAutomation
{
    public partial class kitapEkle : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=kutuphane;Integrated Security=True");

        public kitapEkle()
        {
            InitializeComponent();
        }

        //This button gets information from TextBoxes and loads data into "book" table
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBarcodeNo.Text == "")
            {
                MessageBox.Show("Barkod No alanı boş bırakılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("insert into book (barcode_no,book_title,author,page_count,shelf_no) values (@barcode_no,@book_title,@author,@page_count,@shelf_no)", con);
                    com.Parameters.AddWithValue("@barcode_no", txtBarcodeNo.Text);
                    com.Parameters.AddWithValue("@book_title", txtBookTitle.Text);
                    com.Parameters.AddWithValue("@author", txtAuthor.Text);
                    com.Parameters.AddWithValue("@page_count", txtPageCount.Text);
                    com.Parameters.AddWithValue("@shelf_no", txtShelfNo.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Kitap kaydı gerçekleştirildi.");
                    con.Close();
                    this.InvokeOnClick(btnClear, EventArgs.Empty);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hay aksi! Kitap kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBarcodeNo.Clear();
            txtBookTitle.Clear();
            txtAuthor.Clear();
            txtPageCount.Clear();
            txtShelfNo.Clear();
        }

        private void frmaddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
