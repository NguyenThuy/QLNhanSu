namespace ThucTapNhom1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maCVLabel;
            System.Windows.Forms.Label tenCVLabel;
            System.Windows.Forms.Label maBacLuongLabel;
            System.Windows.Forms.Label tenBacLuongLabel;
            System.Windows.Forms.Label heSoLabel;
            System.Windows.Forms.Label lblMaPhong;
            System.Windows.Forms.Label lblTenPhong;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maBacLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTrinhDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhanSuDataSet = new ThucTapNhom1.QLNhanSuDataSet();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbThongTinNV = new System.Windows.Forms.GroupBox();
            this.cbbLuong = new System.Windows.Forms.ComboBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.cbbTrinhDo = new System.Windows.Forms.ComboBox();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDNV = new System.Windows.Forms.Label();
            this.cbbGT = new System.Windows.Forms.ComboBox();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTennv = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lblHodem = new System.Windows.Forms.Label();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtHodem = new System.Windows.Forms.TextBox();
            this.tabPhongBan = new System.Windows.Forms.TabPage();
            this.dgvNhanVienThuocPB = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.maPhongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPhongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaPB = new System.Windows.Forms.Button();
            this.btnSuaPB = new System.Windows.Forms.Button();
            this.btnThemPB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbPhongBan = new System.Windows.Forms.GroupBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.tabChucVu = new System.Windows.Forms.TabPage();
            this.dgvNhanVien_ChucVu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNhanVien_CV = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaCV = new System.Windows.Forms.Button();
            this.btnSuaCV = new System.Windows.Forms.Button();
            this.btnThemCV = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.tblChucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.maCVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBacLuong = new System.Windows.Forms.TabPage();
            this.dgvNhanVien_BL = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnXoaBL = new System.Windows.Forms.Button();
            this.btnSuaBL = new System.Windows.Forms.Button();
            this.btnThemBL = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtMaBL = new System.Windows.Forms.TextBox();
            this.tblBacLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTenBL = new System.Windows.Forms.TextBox();
            this.txtHeSoBL = new System.Windows.Forms.TextBox();
            this.dgvBacLuong = new System.Windows.Forms.DataGridView();
            this.maBacLuongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBacLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhanSuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnTrịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fillByDBToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tblNhanVienTableAdapter = new ThucTapNhom1.QLNhanSuDataSetTableAdapters.tblNhanVienTableAdapter();
            this.tblPhongBanTableAdapter = new ThucTapNhom1.QLNhanSuDataSetTableAdapters.tblPhongBanTableAdapter();
            this.tableAdapterManager = new ThucTapNhom1.QLNhanSuDataSetTableAdapters.TableAdapterManager();
            this.tblChucVuTableAdapter = new ThucTapNhom1.QLNhanSuDataSetTableAdapters.tblChucVuTableAdapter();
            this.tblBacLuongTableAdapter = new ThucTapNhom1.QLNhanSuDataSetTableAdapters.tblBacLuongTableAdapter();
            maCVLabel = new System.Windows.Forms.Label();
            tenCVLabel = new System.Windows.Forms.Label();
            maBacLuongLabel = new System.Windows.Forms.Label();
            tenBacLuongLabel = new System.Windows.Forms.Label();
            heSoLabel = new System.Windows.Forms.Label();
            lblMaPhong = new System.Windows.Forms.Label();
            lblTenPhong = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbThongTinNV.SuspendLayout();
            this.tabPhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienThuocPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongBanBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grbPhongBan.SuspendLayout();
            this.tabChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien_ChucVu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblChucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.tabBacLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien_BL)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBacLuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maCVLabel
            // 
            maCVLabel.AutoSize = true;
            maCVLabel.Location = new System.Drawing.Point(25, 25);
            maCVLabel.Name = "maCVLabel";
            maCVLabel.Size = new System.Drawing.Size(64, 13);
            maCVLabel.TabIndex = 0;
            maCVLabel.Text = "Mã chức vụ";
            // 
            // tenCVLabel
            // 
            tenCVLabel.AutoSize = true;
            tenCVLabel.Location = new System.Drawing.Point(25, 57);
            tenCVLabel.Name = "tenCVLabel";
            tenCVLabel.Size = new System.Drawing.Size(68, 13);
            tenCVLabel.TabIndex = 2;
            tenCVLabel.Text = "Tên chức vụ";
            // 
            // maBacLuongLabel
            // 
            maBacLuongLabel.AutoSize = true;
            maBacLuongLabel.Location = new System.Drawing.Point(25, 24);
            maBacLuongLabel.Name = "maBacLuongLabel";
            maBacLuongLabel.Size = new System.Drawing.Size(72, 13);
            maBacLuongLabel.TabIndex = 0;
            maBacLuongLabel.Text = "Mã bậc lương";
            // 
            // tenBacLuongLabel
            // 
            tenBacLuongLabel.AutoSize = true;
            tenBacLuongLabel.Location = new System.Drawing.Point(25, 54);
            tenBacLuongLabel.Name = "tenBacLuongLabel";
            tenBacLuongLabel.Size = new System.Drawing.Size(76, 13);
            tenBacLuongLabel.TabIndex = 2;
            tenBacLuongLabel.Text = "Tên bậc lương";
            // 
            // heSoLabel
            // 
            heSoLabel.AutoSize = true;
            heSoLabel.Location = new System.Drawing.Point(25, 84);
            heSoLabel.Name = "heSoLabel";
            heSoLabel.Size = new System.Drawing.Size(35, 13);
            heSoLabel.TabIndex = 4;
            heSoLabel.Text = "Hệ số";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new System.Drawing.Point(25, 25);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new System.Drawing.Size(55, 13);
            lblMaPhong.TabIndex = 0;
            lblMaPhong.Text = "Mã phòng";
            // 
            // lblTenPhong
            // 
            lblTenPhong.AutoSize = true;
            lblTenPhong.Location = new System.Drawing.Point(25, 58);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new System.Drawing.Size(59, 13);
            lblTenPhong.TabIndex = 2;
            lblTenPhong.Text = "Tên phòng";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabNhanVien);
            this.tabMain.Controls.Add(this.tabPhongBan);
            this.tabMain.Controls.Add(this.tabChucVu);
            this.tabMain.Controls.Add(this.tabBacLuong);
            this.tabMain.Location = new System.Drawing.Point(0, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(787, 522);
            this.tabMain.TabIndex = 0;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.AutoScroll = true;
            this.tabNhanVien.Controls.Add(this.dgvNhanVien);
            this.tabNhanVien.Controls.Add(this.grbChucNang);
            this.tabNhanVien.Controls.Add(this.grbThongTinNV);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(779, 496);
            this.tabNhanVien.TabIndex = 1;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoDemDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.nSDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.gTDataGridViewTextBoxColumn,
            this.maBacLuongDataGridViewTextBoxColumn,
            this.maPhongDataGridViewTextBoxColumn,
            this.maCVDataGridViewTextBoxColumn,
            this.maTrinhDoDataGridViewTextBoxColumn});
            this.dgvNhanVien.DataSource = this.tblNhanVienBindingSource1;
            this.dgvNhanVien.Location = new System.Drawing.Point(11, 252);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.Size = new System.Drawing.Size(751, 228);
            this.dgvNhanVien.TabIndex = 2;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.FillWeight = 60F;
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoDemDataGridViewTextBoxColumn
            // 
            this.hoDemDataGridViewTextBoxColumn.DataPropertyName = "HoDem";
            this.hoDemDataGridViewTextBoxColumn.HeaderText = "Họ đệm";
            this.hoDemDataGridViewTextBoxColumn.Name = "hoDemDataGridViewTextBoxColumn";
            this.hoDemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nSDataGridViewTextBoxColumn
            // 
            this.nSDataGridViewTextBoxColumn.DataPropertyName = "NS";
            this.nSDataGridViewTextBoxColumn.FillWeight = 110F;
            this.nSDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.nSDataGridViewTextBoxColumn.Name = "nSDataGridViewTextBoxColumn";
            this.nSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gTDataGridViewTextBoxColumn
            // 
            this.gTDataGridViewTextBoxColumn.DataPropertyName = "GT";
            this.gTDataGridViewTextBoxColumn.FillWeight = 70F;
            this.gTDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gTDataGridViewTextBoxColumn.Name = "gTDataGridViewTextBoxColumn";
            this.gTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maBacLuongDataGridViewTextBoxColumn
            // 
            this.maBacLuongDataGridViewTextBoxColumn.DataPropertyName = "MaBacLuong";
            this.maBacLuongDataGridViewTextBoxColumn.HeaderText = "Mã bậc lương";
            this.maBacLuongDataGridViewTextBoxColumn.Name = "maBacLuongDataGridViewTextBoxColumn";
            this.maBacLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "Mã phòng";
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            this.maPhongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maCVDataGridViewTextBoxColumn
            // 
            this.maCVDataGridViewTextBoxColumn.DataPropertyName = "MaCV";
            this.maCVDataGridViewTextBoxColumn.HeaderText = "Mã chức vụ";
            this.maCVDataGridViewTextBoxColumn.Name = "maCVDataGridViewTextBoxColumn";
            this.maCVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maTrinhDoDataGridViewTextBoxColumn
            // 
            this.maTrinhDoDataGridViewTextBoxColumn.DataPropertyName = "MaTrinhDo";
            this.maTrinhDoDataGridViewTextBoxColumn.HeaderText = "Mã trình độ";
            this.maTrinhDoDataGridViewTextBoxColumn.Name = "maTrinhDoDataGridViewTextBoxColumn";
            this.maTrinhDoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblNhanVienBindingSource1
            // 
            this.tblNhanVienBindingSource1.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource1.DataSource = this.qLNhanSuDataSet;
            // 
            // qLNhanSuDataSet
            // 
            this.qLNhanSuDataSet.DataSetName = "QLNhanSuDataSet";
            this.qLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Location = new System.Drawing.Point(11, 190);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(751, 53);
            this.grbChucNang.TabIndex = 1;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(552, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(335, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(118, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbThongTinNV
            // 
            this.grbThongTinNV.Controls.Add(this.cbbLuong);
            this.grbThongTinNV.Controls.Add(this.lblLuong);
            this.grbThongTinNV.Controls.Add(this.cbbChucVu);
            this.grbThongTinNV.Controls.Add(this.cbbTrinhDo);
            this.grbThongTinNV.Controls.Add(this.lblTrinhDo);
            this.grbThongTinNV.Controls.Add(this.cbbPhong);
            this.grbThongTinNV.Controls.Add(this.lblPhong);
            this.grbThongTinNV.Controls.Add(this.dtpNgaySinh);
            this.grbThongTinNV.Controls.Add(this.lblNgaySinh);
            this.grbThongTinNV.Controls.Add(this.txtID);
            this.grbThongTinNV.Controls.Add(this.lblIDNV);
            this.grbThongTinNV.Controls.Add(this.cbbGT);
            this.grbThongTinNV.Controls.Add(this.lblChucvu);
            this.grbThongTinNV.Controls.Add(this.lblDiachi);
            this.grbThongTinNV.Controls.Add(this.lblTennv);
            this.grbThongTinNV.Controls.Add(this.lblGioitinh);
            this.grbThongTinNV.Controls.Add(this.txtDiachi);
            this.grbThongTinNV.Controls.Add(this.lblHodem);
            this.grbThongTinNV.Controls.Add(this.txtTennv);
            this.grbThongTinNV.Controls.Add(this.txtHodem);
            this.grbThongTinNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinNV.Location = new System.Drawing.Point(11, 6);
            this.grbThongTinNV.Name = "grbThongTinNV";
            this.grbThongTinNV.Size = new System.Drawing.Size(751, 181);
            this.grbThongTinNV.TabIndex = 0;
            this.grbThongTinNV.TabStop = false;
            this.grbThongTinNV.Text = "Thông tin nhân viên";
            // 
            // cbbLuong
            // 
            this.cbbLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLuong.FormattingEnabled = true;
            this.cbbLuong.Location = new System.Drawing.Point(474, 141);
            this.cbbLuong.Name = "cbbLuong";
            this.cbbLuong.Size = new System.Drawing.Size(133, 21);
            this.cbbLuong.TabIndex = 9;
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.Location = new System.Drawing.Point(382, 144);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(37, 13);
            this.lblLuong.TabIndex = 23;
            this.lblLuong.Text = "Lương";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(118, 112);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(173, 21);
            this.cbbChucVu.TabIndex = 6;
            // 
            // cbbTrinhDo
            // 
            this.cbbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrinhDo.FormattingEnabled = true;
            this.cbbTrinhDo.Location = new System.Drawing.Point(118, 141);
            this.cbbTrinhDo.Name = "cbbTrinhDo";
            this.cbbTrinhDo.Size = new System.Drawing.Size(173, 21);
            this.cbbTrinhDo.TabIndex = 8;
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrinhDo.Location = new System.Drawing.Point(34, 144);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(47, 13);
            this.lblTrinhDo.TabIndex = 23;
            this.lblTrinhDo.Text = "Trình độ";
            // 
            // cbbPhong
            // 
            this.cbbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(474, 27);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(133, 21);
            this.cbbPhong.TabIndex = 1;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(382, 31);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(38, 13);
            this.lblPhong.TabIndex = 23;
            this.lblPhong.Text = "Phòng";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(474, 82);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(197, 20);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(382, 87);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaySinh.TabIndex = 21;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // lblIDNV
            // 
            this.lblIDNV.AutoSize = true;
            this.lblIDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNV.Location = new System.Drawing.Point(34, 28);
            this.lblIDNV.Name = "lblIDNV";
            this.lblIDNV.Size = new System.Drawing.Size(72, 13);
            this.lblIDNV.TabIndex = 19;
            this.lblIDNV.Text = "Mã nhân viên";
            // 
            // cbbGT
            // 
            this.cbbGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGT.FormattingEnabled = true;
            this.cbbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGT.Location = new System.Drawing.Point(118, 84);
            this.cbbGT.Name = "cbbGT";
            this.cbbGT.Size = new System.Drawing.Size(100, 21);
            this.cbbGT.TabIndex = 4;
            // 
            // lblChucvu
            // 
            this.lblChucvu.AutoSize = true;
            this.lblChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvu.Location = new System.Drawing.Point(34, 115);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(47, 13);
            this.lblChucvu.TabIndex = 13;
            this.lblChucvu.Text = "Chức vụ";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(382, 115);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(40, 13);
            this.lblDiachi.TabIndex = 14;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTennv
            // 
            this.lblTennv.AutoSize = true;
            this.lblTennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennv.Location = new System.Drawing.Point(382, 59);
            this.lblTennv.Name = "lblTennv";
            this.lblTennv.Size = new System.Drawing.Size(76, 13);
            this.lblTennv.TabIndex = 15;
            this.lblTennv.Text = "Tên nhân viên";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioitinh.Location = new System.Drawing.Point(34, 86);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioitinh.TabIndex = 16;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(474, 112);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(197, 20);
            this.txtDiachi.TabIndex = 7;
            // 
            // lblHodem
            // 
            this.lblHodem.AutoSize = true;
            this.lblHodem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHodem.Location = new System.Drawing.Point(34, 57);
            this.lblHodem.Name = "lblHodem";
            this.lblHodem.Size = new System.Drawing.Size(45, 13);
            this.lblHodem.TabIndex = 17;
            this.lblHodem.Text = "Họ đệm";
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(474, 56);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(197, 20);
            this.txtTennv.TabIndex = 3;
            // 
            // txtHodem
            // 
            this.txtHodem.Location = new System.Drawing.Point(118, 56);
            this.txtHodem.Name = "txtHodem";
            this.txtHodem.Size = new System.Drawing.Size(176, 20);
            this.txtHodem.TabIndex = 2;
            // 
            // tabPhongBan
            // 
            this.tabPhongBan.AutoScroll = true;
            this.tabPhongBan.Controls.Add(this.dgvNhanVienThuocPB);
            this.tabPhongBan.Controls.Add(this.dgvPhongBan);
            this.tabPhongBan.Controls.Add(this.groupBox2);
            this.tabPhongBan.Controls.Add(this.label1);
            this.tabPhongBan.Controls.Add(this.grbPhongBan);
            this.tabPhongBan.Location = new System.Drawing.Point(4, 22);
            this.tabPhongBan.Name = "tabPhongBan";
            this.tabPhongBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhongBan.Size = new System.Drawing.Size(779, 496);
            this.tabPhongBan.TabIndex = 2;
            this.tabPhongBan.Text = "Phòng ban";
            this.tabPhongBan.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVienThuocPB
            // 
            this.dgvNhanVienThuocPB.AllowUserToAddRows = false;
            this.dgvNhanVienThuocPB.AllowUserToDeleteRows = false;
            this.dgvNhanVienThuocPB.AllowUserToResizeRows = false;
            this.dgvNhanVienThuocPB.AutoGenerateColumns = false;
            this.dgvNhanVienThuocPB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNhanVienThuocPB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVienThuocPB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVienThuocPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVienThuocPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvNhanVienThuocPB.DataSource = this.tblNhanVienBindingSource1;
            this.dgvNhanVienThuocPB.Location = new System.Drawing.Point(361, 60);
            this.dgvNhanVienThuocPB.Name = "dgvNhanVienThuocPB";
            this.dgvNhanVienThuocPB.ReadOnly = true;
            this.dgvNhanVienThuocPB.RowHeadersVisible = false;
            this.dgvNhanVienThuocPB.Size = new System.Drawing.Size(410, 428);
            this.dgvNhanVienThuocPB.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn1.FillWeight = 60F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 47;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoDem";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ đệm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenNV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 51;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NS";
            this.dataGridViewTextBoxColumn4.FillWeight = 110F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 79;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn5.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 65;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GT";
            this.dataGridViewTextBoxColumn6.FillWeight = 70F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 72;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MaBacLuong";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã bậc lương";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 97;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MaPhong";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã phòng";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MaCV";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mã chức vụ";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 89;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MaTrinhDo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Mã trình độ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 86;
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.AllowUserToDeleteRows = false;
            this.dgvPhongBan.AllowUserToResizeRows = false;
            this.dgvPhongBan.AutoGenerateColumns = false;
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhongDataGridViewTextBoxColumn1,
            this.tenPhongDataGridViewTextBoxColumn});
            this.dgvPhongBan.DataSource = this.tblPhongBanBindingSource;
            this.dgvPhongBan.Location = new System.Drawing.Point(9, 178);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.ReadOnly = true;
            this.dgvPhongBan.RowHeadersVisible = false;
            this.dgvPhongBan.Size = new System.Drawing.Size(336, 315);
            this.dgvPhongBan.TabIndex = 8;
            this.dgvPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellClick);
            // 
            // maPhongDataGridViewTextBoxColumn1
            // 
            this.maPhongDataGridViewTextBoxColumn1.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn1.FillWeight = 50F;
            this.maPhongDataGridViewTextBoxColumn1.HeaderText = "Mã phòng";
            this.maPhongDataGridViewTextBoxColumn1.Name = "maPhongDataGridViewTextBoxColumn1";
            this.maPhongDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "Tên phòng";
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            this.tenPhongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblPhongBanBindingSource
            // 
            this.tblPhongBanBindingSource.DataMember = "tblPhongBan";
            this.tblPhongBanBindingSource.DataSource = this.qLNhanSuDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaPB);
            this.groupBox2.Controls.Add(this.btnSuaPB);
            this.groupBox2.Controls.Add(this.btnThemPB);
            this.groupBox2.Location = new System.Drawing.Point(9, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnXoaPB
            // 
            this.btnXoaPB.Location = new System.Drawing.Point(241, 19);
            this.btnXoaPB.Name = "btnXoaPB";
            this.btnXoaPB.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPB.TabIndex = 0;
            this.btnXoaPB.Text = "Xóa";
            this.btnXoaPB.UseVisualStyleBackColor = true;
            this.btnXoaPB.Click += new System.EventHandler(this.btnXoaPB_Click);
            // 
            // btnSuaPB
            // 
            this.btnSuaPB.Location = new System.Drawing.Point(132, 19);
            this.btnSuaPB.Name = "btnSuaPB";
            this.btnSuaPB.Size = new System.Drawing.Size(75, 23);
            this.btnSuaPB.TabIndex = 0;
            this.btnSuaPB.Text = "Sửa";
            this.btnSuaPB.UseVisualStyleBackColor = true;
            this.btnSuaPB.Click += new System.EventHandler(this.btnSuaPB_Click);
            // 
            // btnThemPB
            // 
            this.btnThemPB.Location = new System.Drawing.Point(23, 19);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(75, 23);
            this.btnThemPB.TabIndex = 0;
            this.btnThemPB.Text = "Thêm";
            this.btnThemPB.UseVisualStyleBackColor = true;
            this.btnThemPB.Click += new System.EventHandler(this.btnThemPB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhân viên thuộc phòng ban";
            // 
            // grbPhongBan
            // 
            this.grbPhongBan.Controls.Add(lblMaPhong);
            this.grbPhongBan.Controls.Add(this.txtMaPhong);
            this.grbPhongBan.Controls.Add(lblTenPhong);
            this.grbPhongBan.Controls.Add(this.txtTenPhong);
            this.grbPhongBan.Location = new System.Drawing.Point(9, 6);
            this.grbPhongBan.Name = "grbPhongBan";
            this.grbPhongBan.Size = new System.Drawing.Size(336, 85);
            this.grbPhongBan.TabIndex = 6;
            this.grbPhongBan.TabStop = false;
            this.grbPhongBan.Text = "Thông tin phòng ban";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(100, 21);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(180, 20);
            this.txtMaPhong.TabIndex = 1;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(100, 54);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(180, 20);
            this.txtTenPhong.TabIndex = 3;
            // 
            // tabChucVu
            // 
            this.tabChucVu.AutoScroll = true;
            this.tabChucVu.Controls.Add(this.dgvNhanVien_ChucVu);
            this.tabChucVu.Controls.Add(this.lblNhanVien_CV);
            this.tabChucVu.Controls.Add(this.groupBox3);
            this.tabChucVu.Controls.Add(this.groupBox4);
            this.tabChucVu.Controls.Add(this.dgvChucVu);
            this.tabChucVu.Location = new System.Drawing.Point(4, 22);
            this.tabChucVu.Name = "tabChucVu";
            this.tabChucVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabChucVu.Size = new System.Drawing.Size(779, 496);
            this.tabChucVu.TabIndex = 3;
            this.tabChucVu.Text = "Chức vụ";
            this.tabChucVu.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien_ChucVu
            // 
            this.dgvNhanVien_ChucVu.AllowUserToAddRows = false;
            this.dgvNhanVien_ChucVu.AllowUserToDeleteRows = false;
            this.dgvNhanVien_ChucVu.AllowUserToResizeRows = false;
            this.dgvNhanVien_ChucVu.AutoGenerateColumns = false;
            this.dgvNhanVien_ChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNhanVien_ChucVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien_ChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVien_ChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien_ChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.dgvNhanVien_ChucVu.DataSource = this.tblNhanVienBindingSource1;
            this.dgvNhanVien_ChucVu.Location = new System.Drawing.Point(363, 59);
            this.dgvNhanVien_ChucVu.Name = "dgvNhanVien_ChucVu";
            this.dgvNhanVien_ChucVu.ReadOnly = true;
            this.dgvNhanVien_ChucVu.RowHeadersVisible = false;
            this.dgvNhanVien_ChucVu.Size = new System.Drawing.Size(410, 428);
            this.dgvNhanVien_ChucVu.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn11.FillWeight = 60F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 47;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "HoDem";
            this.dataGridViewTextBoxColumn12.HeaderText = "Họ đệm";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 70;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "TenNV";
            this.dataGridViewTextBoxColumn13.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 51;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "NS";
            this.dataGridViewTextBoxColumn14.FillWeight = 110F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 79;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn15.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 65;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "GT";
            this.dataGridViewTextBoxColumn16.FillWeight = 70F;
            this.dataGridViewTextBoxColumn16.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 72;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "MaBacLuong";
            this.dataGridViewTextBoxColumn17.HeaderText = "Mã bậc lương";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 97;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "MaPhong";
            this.dataGridViewTextBoxColumn18.HeaderText = "Mã phòng";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 80;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "MaCV";
            this.dataGridViewTextBoxColumn19.HeaderText = "Mã chức vụ";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 89;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "MaTrinhDo";
            this.dataGridViewTextBoxColumn20.HeaderText = "Mã trình độ";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 86;
            // 
            // lblNhanVien_CV
            // 
            this.lblNhanVien_CV.AutoSize = true;
            this.lblNhanVien_CV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien_CV.Location = new System.Drawing.Point(468, 19);
            this.lblNhanVien_CV.Name = "lblNhanVien_CV";
            this.lblNhanVien_CV.Size = new System.Drawing.Size(158, 20);
            this.lblNhanVien_CV.TabIndex = 12;
            this.lblNhanVien_CV.Text = "Nhân viên có chức vụ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaCV);
            this.groupBox3.Controls.Add(this.btnSuaCV);
            this.groupBox3.Controls.Add(this.btnThemCV);
            this.groupBox3.Location = new System.Drawing.Point(9, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 61);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnXoaCV
            // 
            this.btnXoaCV.Location = new System.Drawing.Point(241, 19);
            this.btnXoaCV.Name = "btnXoaCV";
            this.btnXoaCV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaCV.TabIndex = 0;
            this.btnXoaCV.Text = "Xóa";
            this.btnXoaCV.UseVisualStyleBackColor = true;
            this.btnXoaCV.Click += new System.EventHandler(this.btnXoaCV_Click);
            // 
            // btnSuaCV
            // 
            this.btnSuaCV.Location = new System.Drawing.Point(132, 19);
            this.btnSuaCV.Name = "btnSuaCV";
            this.btnSuaCV.Size = new System.Drawing.Size(75, 23);
            this.btnSuaCV.TabIndex = 0;
            this.btnSuaCV.Text = "Sửa";
            this.btnSuaCV.UseVisualStyleBackColor = true;
            this.btnSuaCV.Click += new System.EventHandler(this.btnSuaCV_Click);
            // 
            // btnThemCV
            // 
            this.btnThemCV.Location = new System.Drawing.Point(23, 19);
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.Size = new System.Drawing.Size(75, 23);
            this.btnThemCV.TabIndex = 0;
            this.btnThemCV.Text = "Thêm";
            this.btnThemCV.UseVisualStyleBackColor = true;
            this.btnThemCV.Click += new System.EventHandler(this.btnThemCV_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(maCVLabel);
            this.groupBox4.Controls.Add(this.txtMaCV);
            this.groupBox4.Controls.Add(tenCVLabel);
            this.groupBox4.Controls.Add(this.txtTenCV);
            this.groupBox4.Location = new System.Drawing.Point(9, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 85);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chức vụ";
            // 
            // txtMaCV
            // 
            this.txtMaCV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblChucVuBindingSource, "MaCV", true));
            this.txtMaCV.Location = new System.Drawing.Point(100, 21);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(181, 20);
            this.txtMaCV.TabIndex = 1;
            // 
            // tblChucVuBindingSource
            // 
            this.tblChucVuBindingSource.DataMember = "tblChucVu";
            this.tblChucVuBindingSource.DataSource = this.qLNhanSuDataSet;
            // 
            // txtTenCV
            // 
            this.txtTenCV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblChucVuBindingSource, "TenCV", true));
            this.txtTenCV.Location = new System.Drawing.Point(100, 54);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(181, 20);
            this.txtTenCV.TabIndex = 3;
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AllowUserToAddRows = false;
            this.dgvChucVu.AllowUserToDeleteRows = false;
            this.dgvChucVu.AllowUserToResizeRows = false;
            this.dgvChucVu.AutoGenerateColumns = false;
            this.dgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCVDataGridViewTextBoxColumn1,
            this.tenCVDataGridViewTextBoxColumn});
            this.dgvChucVu.DataSource = this.tblChucVuBindingSource;
            this.dgvChucVu.Location = new System.Drawing.Point(9, 171);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.ReadOnly = true;
            this.dgvChucVu.RowHeadersVisible = false;
            this.dgvChucVu.Size = new System.Drawing.Size(336, 316);
            this.dgvChucVu.TabIndex = 0;
            this.dgvChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellClick);
            // 
            // maCVDataGridViewTextBoxColumn1
            // 
            this.maCVDataGridViewTextBoxColumn1.DataPropertyName = "MaCV";
            this.maCVDataGridViewTextBoxColumn1.FillWeight = 50F;
            this.maCVDataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.maCVDataGridViewTextBoxColumn1.Name = "maCVDataGridViewTextBoxColumn1";
            this.maCVDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenCVDataGridViewTextBoxColumn
            // 
            this.tenCVDataGridViewTextBoxColumn.DataPropertyName = "TenCV";
            this.tenCVDataGridViewTextBoxColumn.HeaderText = "Tên chức vụ";
            this.tenCVDataGridViewTextBoxColumn.Name = "tenCVDataGridViewTextBoxColumn";
            this.tenCVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabBacLuong
            // 
            this.tabBacLuong.Controls.Add(this.dgvNhanVien_BL);
            this.tabBacLuong.Controls.Add(this.label2);
            this.tabBacLuong.Controls.Add(this.groupBox5);
            this.tabBacLuong.Controls.Add(this.groupBox6);
            this.tabBacLuong.Controls.Add(this.dgvBacLuong);
            this.tabBacLuong.Location = new System.Drawing.Point(4, 22);
            this.tabBacLuong.Name = "tabBacLuong";
            this.tabBacLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabBacLuong.Size = new System.Drawing.Size(779, 496);
            this.tabBacLuong.TabIndex = 4;
            this.tabBacLuong.Text = "Bậc lương";
            this.tabBacLuong.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien_BL
            // 
            this.dgvNhanVien_BL.AllowUserToAddRows = false;
            this.dgvNhanVien_BL.AllowUserToDeleteRows = false;
            this.dgvNhanVien_BL.AllowUserToResizeRows = false;
            this.dgvNhanVien_BL.AutoGenerateColumns = false;
            this.dgvNhanVien_BL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNhanVien_BL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien_BL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhanVien_BL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien_BL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30});
            this.dgvNhanVien_BL.DataSource = this.tblNhanVienBindingSource1;
            this.dgvNhanVien_BL.Location = new System.Drawing.Point(361, 62);
            this.dgvNhanVien_BL.Name = "dgvNhanVien_BL";
            this.dgvNhanVien_BL.ReadOnly = true;
            this.dgvNhanVien_BL.RowHeadersVisible = false;
            this.dgvNhanVien_BL.Size = new System.Drawing.Size(410, 428);
            this.dgvNhanVien_BL.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn21.FillWeight = 60F;
            this.dataGridViewTextBoxColumn21.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 47;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "HoDem";
            this.dataGridViewTextBoxColumn22.HeaderText = "Họ đệm";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 70;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "TenNV";
            this.dataGridViewTextBoxColumn23.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 51;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "NS";
            this.dataGridViewTextBoxColumn24.FillWeight = 110F;
            this.dataGridViewTextBoxColumn24.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 79;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn25.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 65;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "GT";
            this.dataGridViewTextBoxColumn26.FillWeight = 70F;
            this.dataGridViewTextBoxColumn26.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 72;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "MaBacLuong";
            this.dataGridViewTextBoxColumn27.HeaderText = "Mã bậc lương";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 97;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "MaPhong";
            this.dataGridViewTextBoxColumn28.HeaderText = "Mã phòng";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 80;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "MaCV";
            this.dataGridViewTextBoxColumn29.HeaderText = "Mã chức vụ";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Width = 89;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "MaTrinhDo";
            this.dataGridViewTextBoxColumn30.HeaderText = "Mã trình độ";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nhân viên có bậc lương";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnXoaBL);
            this.groupBox5.Controls.Add(this.btnSuaBL);
            this.groupBox5.Controls.Add(this.btnThemBL);
            this.groupBox5.Location = new System.Drawing.Point(9, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 61);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // btnXoaBL
            // 
            this.btnXoaBL.Location = new System.Drawing.Point(241, 19);
            this.btnXoaBL.Name = "btnXoaBL";
            this.btnXoaBL.Size = new System.Drawing.Size(75, 23);
            this.btnXoaBL.TabIndex = 0;
            this.btnXoaBL.Text = "Xóa";
            this.btnXoaBL.UseVisualStyleBackColor = true;
            this.btnXoaBL.Click += new System.EventHandler(this.btnXoaBL_Click);
            // 
            // btnSuaBL
            // 
            this.btnSuaBL.Location = new System.Drawing.Point(132, 19);
            this.btnSuaBL.Name = "btnSuaBL";
            this.btnSuaBL.Size = new System.Drawing.Size(75, 23);
            this.btnSuaBL.TabIndex = 0;
            this.btnSuaBL.Text = "Sửa";
            this.btnSuaBL.UseVisualStyleBackColor = true;
            this.btnSuaBL.Click += new System.EventHandler(this.btnSuaBL_Click);
            // 
            // btnThemBL
            // 
            this.btnThemBL.Location = new System.Drawing.Point(23, 19);
            this.btnThemBL.Name = "btnThemBL";
            this.btnThemBL.Size = new System.Drawing.Size(75, 23);
            this.btnThemBL.TabIndex = 0;
            this.btnThemBL.Text = "Thêm";
            this.btnThemBL.UseVisualStyleBackColor = true;
            this.btnThemBL.Click += new System.EventHandler(this.btnThemBL_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(maBacLuongLabel);
            this.groupBox6.Controls.Add(this.txtMaBL);
            this.groupBox6.Controls.Add(tenBacLuongLabel);
            this.groupBox6.Controls.Add(this.txtTenBL);
            this.groupBox6.Controls.Add(heSoLabel);
            this.groupBox6.Controls.Add(this.txtHeSoBL);
            this.groupBox6.Location = new System.Drawing.Point(9, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(336, 116);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin bậc lương";
            // 
            // txtMaBL
            // 
            this.txtMaBL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBacLuongBindingSource, "MaBacLuong", true));
            this.txtMaBL.Location = new System.Drawing.Point(112, 20);
            this.txtMaBL.Name = "txtMaBL";
            this.txtMaBL.Size = new System.Drawing.Size(174, 20);
            this.txtMaBL.TabIndex = 1;
            // 
            // tblBacLuongBindingSource
            // 
            this.tblBacLuongBindingSource.DataMember = "tblBacLuong";
            this.tblBacLuongBindingSource.DataSource = this.qLNhanSuDataSet;
            // 
            // txtTenBL
            // 
            this.txtTenBL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBacLuongBindingSource, "TenBacLuong", true));
            this.txtTenBL.Location = new System.Drawing.Point(112, 50);
            this.txtTenBL.Name = "txtTenBL";
            this.txtTenBL.Size = new System.Drawing.Size(174, 20);
            this.txtTenBL.TabIndex = 3;
            // 
            // txtHeSoBL
            // 
            this.txtHeSoBL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBacLuongBindingSource, "HeSo", true));
            this.txtHeSoBL.Location = new System.Drawing.Point(112, 80);
            this.txtHeSoBL.Name = "txtHeSoBL";
            this.txtHeSoBL.Size = new System.Drawing.Size(174, 20);
            this.txtHeSoBL.TabIndex = 5;
            // 
            // dgvBacLuong
            // 
            this.dgvBacLuong.AllowUserToAddRows = false;
            this.dgvBacLuong.AllowUserToDeleteRows = false;
            this.dgvBacLuong.AllowUserToResizeRows = false;
            this.dgvBacLuong.AutoGenerateColumns = false;
            this.dgvBacLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBacLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBacLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBacLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBacLuongDataGridViewTextBoxColumn1,
            this.tenBacLuongDataGridViewTextBoxColumn,
            this.heSoDataGridViewTextBoxColumn});
            this.dgvBacLuong.DataSource = this.tblBacLuongBindingSource;
            this.dgvBacLuong.Location = new System.Drawing.Point(9, 200);
            this.dgvBacLuong.Name = "dgvBacLuong";
            this.dgvBacLuong.ReadOnly = true;
            this.dgvBacLuong.RowHeadersVisible = false;
            this.dgvBacLuong.Size = new System.Drawing.Size(336, 290);
            this.dgvBacLuong.TabIndex = 0;
            this.dgvBacLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBacLuong_CellClick);
            // 
            // maBacLuongDataGridViewTextBoxColumn1
            // 
            this.maBacLuongDataGridViewTextBoxColumn1.DataPropertyName = "MaBacLuong";
            this.maBacLuongDataGridViewTextBoxColumn1.FillWeight = 60F;
            this.maBacLuongDataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.maBacLuongDataGridViewTextBoxColumn1.Name = "maBacLuongDataGridViewTextBoxColumn1";
            this.maBacLuongDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenBacLuongDataGridViewTextBoxColumn
            // 
            this.tenBacLuongDataGridViewTextBoxColumn.DataPropertyName = "TenBacLuong";
            this.tenBacLuongDataGridViewTextBoxColumn.HeaderText = "Tên bậc lương";
            this.tenBacLuongDataGridViewTextBoxColumn.Name = "tenBacLuongDataGridViewTextBoxColumn";
            this.tenBacLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heSoDataGridViewTextBoxColumn
            // 
            this.heSoDataGridViewTextBoxColumn.DataPropertyName = "HeSo";
            this.heSoDataGridViewTextBoxColumn.HeaderText = "Hệ số";
            this.heSoDataGridViewTextBoxColumn.Name = "heSoDataGridViewTextBoxColumn";
            this.heSoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this.qLNhanSuDataSetBindingSource;
            // 
            // qLNhanSuDataSetBindingSource
            // 
            this.qLNhanSuDataSetBindingSource.DataSource = this.qLNhanSuDataSet;
            this.qLNhanSuDataSetBindingSource.Position = 0;
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.quảnTrịToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnTrịToolStripMenuItem
            // 
            this.quảnTrịToolStripMenuItem.Name = "quảnTrịToolStripMenuItem";
            this.quảnTrịToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.quảnTrịToolStripMenuItem.Text = "Quản trị";
            this.quảnTrịToolStripMenuItem.Click += new System.EventHandler(this.quảnTrịToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem1});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem1
            // 
            this.trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            this.trợGiúpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.trợGiúpToolStripMenuItem1.Text = "Thông tin";
            this.trợGiúpToolStripMenuItem1.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fillByDBToolStripButton
            // 
            this.fillByDBToolStripButton.Name = "fillByDBToolStripButton";
            this.fillByDBToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tblPhongBanTableAdapter
            // 
            this.tblPhongBanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBacLuongTableAdapter = null;
            this.tableAdapterManager.tblChucVuTableAdapter = null;
            this.tableAdapterManager.tblDeAnTableAdapter = null;
            this.tableAdapterManager.tblNhanVien_DeAnTableAdapter = null;
            this.tableAdapterManager.tblNhanVienTableAdapter = this.tblNhanVienTableAdapter;
            this.tableAdapterManager.tblNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.tblPhongBanTableAdapter = this.tblPhongBanTableAdapter;
            this.tableAdapterManager.tblTrinhDoTableAdapter = null;
            this.tableAdapterManager.tblUserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThucTapNhom1.QLNhanSuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblChucVuTableAdapter
            // 
            this.tblChucVuTableAdapter.ClearBeforeFill = true;
            // 
            // tblBacLuongTableAdapter
            // 
            this.tblBacLuongTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 549);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ NHÂN SỰ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSet)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.grbThongTinNV.ResumeLayout(false);
            this.grbThongTinNV.PerformLayout();
            this.tabPhongBan.ResumeLayout(false);
            this.tabPhongBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienThuocPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongBanBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grbPhongBan.ResumeLayout(false);
            this.grbPhongBan.PerformLayout();
            this.tabChucVu.ResumeLayout(false);
            this.tabChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien_ChucVu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblChucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.tabBacLuong.ResumeLayout(false);
            this.tabBacLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien_BL)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBacLuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanSuDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabPhongBan;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbThongTinNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblIDNV;
        private System.Windows.Forms.ComboBox cbbGT;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTennv;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lblHodem;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtHodem;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cbbLuong;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.ComboBox cbbTrinhDo;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.BindingSource qLNhanSuDataSetBindingSource;
        private QLNhanSuDataSet qLNhanSuDataSet;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QLNhanSuDataSetTableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource tblPhongBanBindingSource;
        private QLNhanSuDataSetTableAdapters.tblPhongBanTableAdapter tblPhongBanTableAdapter;
        private QLNhanSuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton fillByDBToolStripButton;
        private System.Windows.Forms.GroupBox grbPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaPB;
        private System.Windows.Forms.Button btnSuaPB;
        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.TabPage tabChucVu;
        private System.Windows.Forms.BindingSource tblChucVuBindingSource;
        private QLNhanSuDataSetTableAdapters.tblChucVuTableAdapter tblChucVuTableAdapter;
        private System.Windows.Forms.Label lblNhanVien_CV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoaCV;
        private System.Windows.Forms.Button btnSuaCV;
        private System.Windows.Forms.Button btnThemCV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TabPage tabBacLuong;
        private System.Windows.Forms.BindingSource tblBacLuongBindingSource;
        private QLNhanSuDataSetTableAdapters.tblBacLuongTableAdapter tblBacLuongTableAdapter;
        private System.Windows.Forms.DataGridView dgvBacLuong;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnXoaBL;
        private System.Windows.Forms.Button btnSuaBL;
        private System.Windows.Forms.Button btnThemBL;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtMaBL;
        private System.Windows.Forms.TextBox txtTenBL;
        private System.Windows.Forms.TextBox txtHeSoBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBacLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTrinhDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvNhanVienThuocPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvNhanVien_ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridView dgvNhanVien_BL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBacLuongDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBacLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem quảnTrịToolStripMenuItem;
    }
}