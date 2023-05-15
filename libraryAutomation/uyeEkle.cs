using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
namespace libraryAutomation
{
    public partial class uyeEkle : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=kutuphane;Integrated Security=True");

        public uyeEkle()
        {
            InitializeComponent();
        }

        public int checkId(string text)
        {
            int result;
            con.Open();
            SqlCommand com = new SqlCommand("Select Count(id_no) from member where id_no='" + text + "'", con);
            result = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIdNo.Text == "")
            {
                MessageBox.Show("TC Kimlik No alanı boş bırakılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (checkId(txtIdNo.Text) != 0)
                    {
                        MessageBox.Show("Bu TC Kimlik Numarası zaten kayıtlı!");
                    }
                    else
                    {
                        con.Open();
                        SqlCommand com = new SqlCommand("insert into member (id_no,name,surname,tel,address) values (@id_no,@name,@surname,@tel,@address)", con);
                        com.Parameters.AddWithValue("@id_no", txtIdNo.Text);
                        com.Parameters.AddWithValue("@name", txtName.Text);
                        com.Parameters.AddWithValue("@surname", txtSurname.Text);
                        com.Parameters.AddWithValue("@tel", txtTel.Text);
                        com.Parameters.AddWithValue("@address", txtAddress.Text);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Üye başarıyla kaydedilmiştir.");
                        con.Close();
                        this.InvokeOnClick(btnClear, EventArgs.Empty);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hay aksi! Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdNo.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtTel.Clear();
            txtAddress.Clear();
        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {

        }
    }
}
