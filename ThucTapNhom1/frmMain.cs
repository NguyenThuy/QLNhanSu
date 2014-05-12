using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ThucTapNhom1
{
    public partial class frmMain : Form
    {
        #region "formMain"
        tblUser user;
        QLNhanSuDataContext DB = new QLNhanSuDataContext();
        public frmMain(tblUser user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhanSuDataSet.tblBacLuong' table. You can move, or remove it, as needed.
            this.tblBacLuongTableAdapter.Fill(this.qLNhanSuDataSet.tblBacLuong);
            // TODO: This line of code loads data into the 'qLNhanSuDataSet.tblChucVu' table. You can move, or remove it, as needed.
            this.tblChucVuTableAdapter.Fill(this.qLNhanSuDataSet.tblChucVu);
            // TODO: This line of code loads data into the 'qLNhanSuDataSet.tblPhongBan' table. You can move, or remove it, as needed.
            this.tblPhongBanTableAdapter.Fill(this.qLNhanSuDataSet.tblPhongBan);
            // TODO: This line of code loads data into the 'qLNhanSuDataSet.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.qLNhanSuDataSet.tblNhanVien);
            ReloadDatabase();
            ClearTabNhanVien();
            ClearTabPhongBan();
            ClearTabChucVu();
            ClearTabBacLuong();
            setPermission();
        }
        void setPermission()
        {
            if(user.MaNhom=="N2")
            {
                btnThem.Enabled = false;
                btnThemBL.Enabled = false;
                btnThemCV.Enabled = false;
                btnThemPB.Enabled = false;
                btnXoa.Enabled = false;
                btnXoaBL.Enabled = false;
                btnXoaCV.Enabled = false;
                btnXoaPB.Enabled = false;
                btnSua.Enabled = false;
                btnSuaBL.Enabled = false;
                btnSuaCV.Enabled = false;
                btnSuaPB.Enabled = false;
                quảnTrịToolStripMenuItem.Visible = false;
            }
        }
        void ReloadDatabase()
        {
            tblNhanVien_BLL DBNV = new tblNhanVien_BLL();
            tblPhongBan_BLL DBPB = new tblPhongBan_BLL();
            tblChucVu_BLL DBCV = new tblChucVu_BLL();
            tblBacLuong_BLL DBBL = new tblBacLuong_BLL();
            tblTrinhDo_BLL DBTD = new tblTrinhDo_BLL();
            cbbPhong.DataSource = DBPB.SelectAll();
            cbbPhong.DisplayMember = "TenPhong";
            cbbPhong.ValueMember = "MaPhong";
            cbbChucVu.DataSource = DBCV.SelectAll();
            cbbChucVu.DisplayMember = "TenCV";
            cbbChucVu.ValueMember = "MaCV";
            cbbLuong.DataSource = DBBL.SelectAll();
            cbbLuong.DisplayMember = "TenBacLuong";
            cbbLuong.ValueMember = "MaBacLuong";
            cbbTrinhDo.DataSource = DBTD.SelectAll();
            cbbTrinhDo.DisplayMember = "TenTrinhDo";
            cbbTrinhDo.ValueMember = "MaTrinhDo";
            dgvNhanVien.DataSource = DBNV.SelectAll();
            dgvBacLuong.DataSource = DBBL.SelectAll();
            dgvChucVu.DataSource = DBCV.SelectAll();
            dgvPhongBan.DataSource = DBPB.SelectAll();
        }

        #endregion

        #region "Menu"
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin flogin = new frmLogin();
            flogin.FormClosed += flogin_FormClosed;
            this.Hide();
            flogin.ShowDialog();
        }
        void flogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbout fabout = new frmAbout();
            fabout.ShowDialog();
        }
        private void quảnTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermission fp = new frmPermission();
            fp.ShowDialog();
        }

        #endregion

        #region "tabNhanVien"
        void ClearTabNhanVien()
        {
            txtID.Clear();
            txtTennv.Clear();
            txtHodem.Clear();
            txtDiachi.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            cbbGT.SelectedIndex = -1;
            cbbChucVu.SelectedIndex = -1;
            cbbLuong.SelectedIndex = -1;
            cbbPhong.SelectedIndex = -1;
            cbbTrinhDo.SelectedIndex = -1;
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvNhanVien.CurrentRow.Selected = true;
                txtID.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtHodem.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtTennv.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.CurrentRow.Cells[3].Value.ToString());
                txtDiachi.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
                if (dgvNhanVien.CurrentRow.Cells[5].Value.ToString() == "Nam")
                {
                    cbbGT.SelectedIndex = 0;
                }
                else
                {
                    cbbGT.SelectedIndex = 1;
                }
                cbbLuong.SelectedValue = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                cbbPhong.SelectedValue = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
                cbbChucVu.SelectedValue = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
                cbbTrinhDo.SelectedValue = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                tblNhanVien_BLL DBNV = new tblNhanVien_BLL();
                tblNhanVien nvnew = new tblNhanVien();
                nvnew.MaNV = txtID.Text;
                nvnew.HoDem = txtHodem.Text;
                nvnew.TenNV = txtTennv.Text;
                nvnew.NS = dtpNgaySinh.Value;
                nvnew.DiaChi = txtDiachi.Text;
                if (cbbGT.SelectedIndex == 0) nvnew.GT = "Nam";
                else nvnew.GT = "Nu";
                nvnew.MaBacLuong = cbbLuong.SelectedValue.ToString();
                nvnew.MaPhong = cbbPhong.SelectedValue.ToString();
                nvnew.MaCV = cbbChucVu.SelectedValue.ToString();
                nvnew.MaTrinhDo = cbbTrinhDo.SelectedValue.ToString();
                DBNV.AddNV(nvnew);
                ReloadDatabase();
                ClearTabNhanVien();
            }
            catch
            {
                MessageBox.Show("Thêm nhân viên lỗi. Kiểm tra lại thông tin");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                tblNhanVien nvnew = DB.tblNhanViens.Where(nv => nv.MaNV == txtID.Text).FirstOrDefault();
                nvnew.HoDem = txtHodem.Text;
                nvnew.TenNV = txtTennv.Text;
                nvnew.NS = dtpNgaySinh.Value;
                nvnew.DiaChi = txtDiachi.Text;
                if (cbbGT.SelectedIndex == 0) nvnew.GT = "Nam";
                else nvnew.GT = "Nu";
                nvnew.MaBacLuong = cbbLuong.SelectedValue.ToString();
                nvnew.MaPhong = cbbPhong.SelectedValue.ToString();
                nvnew.MaCV = cbbChucVu.SelectedValue.ToString();
                nvnew.MaTrinhDo = cbbTrinhDo.SelectedValue.ToString();
                DB.SubmitChanges();
                ReloadDatabase();
                ClearTabNhanVien();
            }
            catch
            {
                MessageBox.Show("Sửa thông tin nhân viên lỗi. Kiểm tra lại thông tin");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            tblNhanVien_BLL DBNV = new tblNhanVien_BLL();
            DBNV.DeleteID(txtID.Text);
            ReloadDatabase();
            ClearTabNhanVien();
        }
        #endregion

        #region "tabPhongBan"
        void ClearTabPhongBan()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
        }
        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tblNhanVien_BLL DBNV = new tblNhanVien_BLL();
                dgvPhongBan.CurrentRow.Selected = true;
                txtMaPhong.Text = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
                txtTenPhong.Text = dgvPhongBan.CurrentRow.Cells[1].Value.ToString();
                dgvNhanVienThuocPB.DataSource = DBNV.SelectIDPhong(dgvPhongBan.CurrentRow.Cells[0].Value.ToString());
            }
        }
        private void btnThemPB_Click(object sender, EventArgs e)
        {
            try
            {
                tblPhongBan_BLL DBPB = new tblPhongBan_BLL();
                tblPhongBan pb = new tblPhongBan();
                pb.MaPhong = txtMaPhong.Text;
                pb.TenPhong = txtTenPhong.Text;
                DBPB.Add(pb);
                ReloadDatabase();
                ClearTabPhongBan();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        private void btnSuaPB_Click(object sender, EventArgs e)
        {
            try
            {
                tblPhongBan pb = DB.tblPhongBans.Where(pb1 => pb1.MaPhong == txtMaPhong.Text).FirstOrDefault();
                pb.TenPhong = txtTenPhong.Text;
                DB.SubmitChanges();
                ReloadDatabase();
                ClearTabPhongBan();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {
            try
            {
                tblPhongBan_BLL DBPB = new tblPhongBan_BLL();
                DBPB.DeleteID(txtMaPhong.Text);
                ReloadDatabase();
                ClearTabPhongBan();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }
        #endregion

        #region "tabChucVu"
        void ClearTabChucVu()
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
        }
        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tblNhanVien_BLL DBNV = new tblNhanVien_BLL();
                dgvChucVu.CurrentRow.Selected = true;
                txtMaCV.Text = dgvChucVu.CurrentRow.Cells[0].Value.ToString();
                txtTenCV.Text = dgvChucVu.CurrentRow.Cells[1].Value.ToString();
                dgvNhanVien_ChucVu.DataSource = DBNV.SelectIDChucVu(dgvChucVu.CurrentRow.Cells[0].Value.ToString());
                lblNhanVien_CV.Text = "Nhân viên có chức vụ " + dgvChucVu.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            try
            {
                tblChucVu_BLL DBCV = new tblChucVu_BLL();
                tblChucVu cv = new tblChucVu();
                cv.MaCV = txtMaCV.Text;
                cv.TenCV = txtTenCV.Text;
                DBCV.Add(cv);
                ReloadDatabase();
                ClearTabChucVu();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        private void btnSuaCV_Click(object sender, EventArgs e)
        {
            try
            {
                tblChucVu cv = DB.tblChucVus.Where(cv1 => cv1.MaCV == txtMaCV.Text).FirstOrDefault();
                cv.TenCV = txtTenCV.Text;
                DB.SubmitChanges();
                ReloadDatabase();
                ClearTabChucVu();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        private void btnXoaCV_Click(object sender, EventArgs e)
        {
            try
            {
                tblChucVu_BLL DBCV = new tblChucVu_BLL();
                DBCV.DeleteID(txtMaCV.Text);
                ReloadDatabase();
                ClearTabChucVu();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }
        #endregion

        #region "tabBacLuong"
        void ClearTabBacLuong()
        {
            txtMaBL.Clear();
            txtTenBL.Clear();
            txtHeSoBL.Clear();
        }
        private void dgvBacLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tblNhanVien_BLL DBNV = new tblNhanVien_BLL();
                dgvBacLuong.CurrentRow.Selected = true;
                txtMaBL.Text = dgvBacLuong.CurrentRow.Cells[0].Value.ToString();
                txtTenBL.Text = dgvBacLuong.CurrentRow.Cells[1].Value.ToString();
                txtHeSoBL.Text = dgvBacLuong.CurrentRow.Cells[2].Value.ToString();
                dgvNhanVien_BL.DataSource = DBNV.SelectIDBacLuong(dgvBacLuong.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnThemBL_Click(object sender, EventArgs e)
        {
            try
            {
                tblBacLuong_BLL DBBL = new tblBacLuong_BLL();
                tblBacLuong bl = new tblBacLuong();
                bl.MaBacLuong = txtMaBL.Text;
                bl.TenBacLuong = txtTenBL.Text;
                bl.HeSo = float.Parse(txtHeSoBL.Text);
                DBBL.Add(bl);
                ReloadDatabase();
                ClearTabBacLuong();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }
        private void btnSuaBL_Click(object sender, EventArgs e)
        {
            try
            {
                tblBacLuong bl = DB.tblBacLuongs.Where(bl1 => bl1.MaBacLuong == txtMaBL.Text).FirstOrDefault();
                bl.TenBacLuong = txtTenBL.Text;
                bl.HeSo = float.Parse(txtHeSoBL.Text);
                DB.SubmitChanges();
                ReloadDatabase();
                ClearTabBacLuong();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }
        private void btnXoaBL_Click(object sender, EventArgs e)
        {
            try
            {
                tblBacLuong_BLL DBBL = new tblBacLuong_BLL();
                DBBL.DeleteID(txtMaBL.Text);
                ReloadDatabase();
                ClearTabBacLuong();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }
        #endregion

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("help.chm");
        }

    }
}
