using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace libraryAutomation
{
    public partial class ayarlar : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=kutuphane;Integrated Security=True");

        public ayarlar()
        {
            InitializeComponent();
        }

        public string username;

        static string ComputeSHA256Hash(string text)
        {
            SHA256 sha256Encrypting = new SHA256CryptoServiceProvider();
            byte[] bytes = sha256Encrypting.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }
            return builder.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "" || txtOldPassword.Text == "")
            {
                MessageBox.Show("Lütfen bütün alanları doldurun!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("SELECT * FROM user_information WHERE Username = @username AND Password = @password", con);
                    com.Parameters.AddWithValue("@username", username);
                    com.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtOldPassword.Text));
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        SqlCommand com2 = new SqlCommand("UPDATE user_information SET Password = @password WHERE Username = @username", con);
                        com2.Parameters.AddWithValue("@password", ComputeSHA256Hash(txtNewPassword.Text));
                        com2.Parameters.AddWithValue("@username", username);
                        com2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Şifreniz başarıyla değiştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Eski şifrenizi yanlış girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hay aksi! Beklenmeyen bir sorun oluştu. Lütfen tekrar deneyin.");
                    con.Close();
                }
            }
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            lblUsername.Text = username;

        }

        private void btnDelAccount_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = new DialogResult();
                answer = MessageBox.Show("Hesabınızı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("delete from user_information where Username=@Username", con);
                    com.Parameters.AddWithValue("@Username", lblUsername.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Hesabınız silinmiştir.");
                    con.Close();
                    Application.Restart();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hay aksi! Beklenmeyen bir sorun oluştu. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
