﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
namespace libraryAutomation
{
    public partial class uyeDuzenle : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=kutuphane;Integrated Security=True");
        DataTable table = new DataTable();
        DataView dataView = new DataView();

        public uyeDuzenle()
        {
            InitializeComponent();
        }

        public string idNo, name, surname, tel, address;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIdNo.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtTel.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayın!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("update member set id_no=@id_no,name=@name,surname=@surname,tel=@tel,address=@address where id_no=@id_no", con);
                    com.Parameters.AddWithValue("@id_no", txtIdNo.Text);
                    com.Parameters.AddWithValue("@name", txtName.Text);
                    com.Parameters.AddWithValue("@surname", txtSurname.Text);
                    com.Parameters.AddWithValue("@tel", txtTel.Text);
                    com.Parameters.AddWithValue("@address", txtAddress.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Üye bilgileri güncellenmiştir.");
                    con.Close();
                    this.InvokeOnClick(btnClear, EventArgs.Empty);

                    table.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from member order by name", con);
                    adapter.Fill(table);
                    dgwMember.DataSource = table;
                }
                catch (Exception)
                {
                    MessageBox.Show("Bilgileri kontrol edin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmEditMember_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from member order by name", con);
            adapter.Fill(table);
            dgwMember.DataSource = table;
            dgwMember.Columns["id_no"].HeaderText = "TC Kimlik No";
            dgwMember.Columns["name"].HeaderText = "İsim";
            dgwMember.Columns["surname"].HeaderText = "Soyisim";
            dgwMember.Columns["tel"].HeaderText = "Telefon";
            dgwMember.Columns["address"].HeaderText = "Adres";
            con.Close();

            //To get the data from frmListMember.
            txtIdNo.Text = idNo;
            txtName.Text = name;
            txtSurname.Text = surname;
            txtTel.Text = tel;
            txtAddress.Text = address;
        }

        private void txtSearchIdNo_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "id_no LIKE '%" + txtSearchIdNo.Text + "%'";
            dgwMember.DataSource = dataView;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "name LIKE '%" + txtSearchName.Text + "%'";
            dgwMember.DataSource = dataView;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAddMember"] == null)
            {
                uyeEkle form = new uyeEkle();
                form.Show();
            }
            else
                Application.OpenForms["frmAddMember"].Activate();
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = new DialogResult();
                answer = MessageBox.Show("Üye kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("delete from member where id_no=@id_no", con);
                    com.Parameters.AddWithValue("@id_no", dgwMember.CurrentRow.Cells["id_no"].Value.ToString());
                    com.ExecuteNonQuery();
                    table.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from Member order by name", con);
                    adapter.Fill(table);
                    dgwMember.DataSource = table;
                    MessageBox.Show("Üye kaydı silinmiştir.");
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hay aksi! Bir hata oluştu. Tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIdNo.Text = dgwMember.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgwMember.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dgwMember.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dgwMember.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dgwMember.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgwMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdNo.Text = dgwMember.CurrentRow.Cells["id_no"].Value.ToString();
            txtName.Text = dgwMember.CurrentRow.Cells["name"].Value.ToString();
            txtSurname.Text = dgwMember.CurrentRow.Cells["surname"].Value.ToString();
            txtTel.Text = dgwMember.CurrentRow.Cells["tel"].Value.ToString();
            txtAddress.Text = dgwMember.CurrentRow.Cells["address"].Value.ToString();
        }

        private void txtSearchIdNo_Enter(object sender, EventArgs e)
        {
            txtSearchName.Clear();
        }

        private void txtSearchName_Enter(object sender, EventArgs e)
        {
            txtSearchIdNo.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdNo.Text == "")
            {
                MessageBox.Show("TC Kimlik No alanı boş bırakılamaz! Lütfen silmek istediğiniz üyeyi seçin.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult answer = new DialogResult();
                    answer = MessageBox.Show("Üye kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (answer == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand com = new SqlCommand("delete from member where id_no=@id_no", con);
                        com.Parameters.AddWithValue("@id_no", txtIdNo.Text);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Üye kaydı silinmiştir.");
                        con.Close();
                        this.InvokeOnClick(btnClear, EventArgs.Empty);
                        table.Clear();
                        SqlDataAdapter adapter = new SqlDataAdapter("select * from member order by name", con);
                        adapter.Fill(table);
                        dgwMember.DataSource = table;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hay aksi! Bir hata oluştu. Tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
