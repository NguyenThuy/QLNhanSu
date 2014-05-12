using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom1
{
    public partial class frmPermission : Form
    {
        QLNhanSuDataContext DB = new QLNhanSuDataContext();
        public frmPermission()
        {
            InitializeComponent();
        }

        private void frmPermission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhanSuDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.qLNhanSuDataSet.tblUser);
            loadDatabase();
            clearInput();
        }
        void loadDatabase()
        {
            dgvUser.DataSource = DB.tblUsers.ToList();
            cbbGroup.DataSource = DB.tblNhomNguoiDungs.ToList();
            cbbGroup.DisplayMember = "TenNhom";
            cbbGroup.ValueMember = "MaNhom";
        }
        void clearInput()
        {
            txtUser.Clear();
            txtPass.Clear();
            cbbGroup.SelectedIndex = -1;
        }
        private void tblUserDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvUser.CurrentRow.Selected = true;
                txtUser.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
                txtPass.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
                cbbGroup.SelectedValue = dgvUser.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                tblUser us = new tblUser();
                us.UserName = txtUser.Text;
                us.Pass = txtPass.Text;
                us.MaNhom = cbbGroup.SelectedValue.ToString();
                DB.tblUsers.InsertOnSubmit(us);
                DB.SubmitChanges();
                loadDatabase();
                clearInput();
            }
            catch
            {
                MessageBox.Show("Thêm người dùng lỗi. Kiểm tra lại thông tin");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                tblUser us = new tblUser();
                us = DB.tblUsers.Where(user1 => user1.UserName == txtUser.Text).FirstOrDefault();
                if (us != null)
                {
                    us.Pass = txtPass.Text;
                    us.MaNhom = cbbGroup.SelectedValue.ToString();
                    DB.SubmitChanges();
                    loadDatabase();
                    clearInput();
                }
                else MessageBox.Show("Không tìm thấy người dùng cần tìm");
            }
            catch
            {
                MessageBox.Show("Xóa người dùng lỗi. Kiểm tra lại thông tin");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                tblUser us = new tblUser();
                us = DB.tblUsers.Where(user1 => user1.UserName == txtUser.Text).FirstOrDefault();
                if (us != null)
                {
                    DB.tblUsers.DeleteOnSubmit(us);
                    DB.SubmitChanges();
                    loadDatabase();
                    clearInput();
                }
                else MessageBox.Show("Không tìm thấy người dùng cần tìm");
            }
            catch
            {
                MessageBox.Show("Xóa người dùng lỗi. Kiểm tra lại thông tin");
            }
        }
    }
}
