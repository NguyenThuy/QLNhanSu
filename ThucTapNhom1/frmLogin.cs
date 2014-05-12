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
    public partial class frmLogin : Form
    {
        QLNhanSuDataContext DB = new QLNhanSuDataContext();
        public frmLogin()
        {
            InitializeComponent() ;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tblUser_BLL ktuser = new tblUser_BLL();
            tblUser user = ktuser.FindUser(txtUsername.Text, txtPassword.Text);
            if(user!=null)
            {
                frmMain fmain = new frmMain(user);
                fmain.FormClosed += fmain_FormClosed;
                this.Hide();
                fmain.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Ko thành công");
            }
        }

        void fmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
