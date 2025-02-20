namespace AnhCF
{
    partial class frmQuanLyTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            this.dgvQLYK = new Guna.UI2.WinForms.Guna2DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthanhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaitaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kbiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labTenThanhVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labMaNV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbTenThanhVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMatKau = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbLoaiTk = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbTimKiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLYK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLYK
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvQLYK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLYK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLYK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQLYK.ColumnHeadersHeight = 45;
            this.dgvQLYK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvQLYK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tenthanhvien,
            this.taikhoan,
            this.matkhau,
            this.Column6,
            this.loaitaikhoan,
            this.Column8,
            this.kbiet});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLYK.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvQLYK.GridColor = System.Drawing.Color.Silver;
            this.dgvQLYK.Location = new System.Drawing.Point(23, 183);
            this.dgvQLYK.Name = "dgvQLYK";
            this.dgvQLYK.ReadOnly = true;
            this.dgvQLYK.RowHeadersVisible = false;
            this.dgvQLYK.RowHeadersWidth = 51;
            this.dgvQLYK.RowTemplate.Height = 24;
            this.dgvQLYK.Size = new System.Drawing.Size(1745, 690);
            this.dgvQLYK.TabIndex = 0;
            this.dgvQLYK.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLYK.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLYK.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLYK.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLYK.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLYK.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLYK.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvQLYK.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLYK.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQLYK.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLYK.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLYK.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvQLYK.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvQLYK.ThemeStyle.ReadOnly = true;
            this.dgvQLYK.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLYK.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLYK.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLYK.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLYK.ThemeStyle.RowsStyle.Height = 24;
            this.dgvQLYK.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLYK.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLYK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLYK_CellContentClick);
            this.dgvQLYK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLYK_CellContentClick);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "id";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // tenthanhvien
            // 
            this.tenthanhvien.DataPropertyName = "tennv";
            this.tenthanhvien.HeaderText = "Tên thành viên";
            this.tenthanhvien.MinimumWidth = 6;
            this.tenthanhvien.Name = "tenthanhvien";
            this.tenthanhvien.ReadOnly = true;
            // 
            // taikhoan
            // 
            this.taikhoan.DataPropertyName = "tentk";
            this.taikhoan.HeaderText = "Tài khoản";
            this.taikhoan.MinimumWidth = 6;
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.ReadOnly = true;
            this.taikhoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.MinimumWidth = 6;
            this.matkhau.Name = "matkhau";
            this.matkhau.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "trangthai";
            this.Column6.HeaderText = "Trạng thái";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // loaitaikhoan
            // 
            this.loaitaikhoan.DataPropertyName = "maloaitk";
            this.loaitaikhoan.HeaderText = "MaLoaiTK";
            this.loaitaikhoan.MinimumWidth = 6;
            this.loaitaikhoan.Name = "loaitaikhoan";
            this.loaitaikhoan.ReadOnly = true;
            this.loaitaikhoan.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "manv";
            this.Column8.HeaderText = "Mã nhân viên";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // kbiet
            // 
            this.kbiet.DataPropertyName = "tenloaitk";
            this.kbiet.HeaderText = "Loại tài khoản";
            this.kbiet.MinimumWidth = 6;
            this.kbiet.Name = "kbiet";
            this.kbiet.ReadOnly = true;
            this.kbiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(17, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 766);
            this.panel1.TabIndex = 1;
            // 
            // labTenThanhVien
            // 
            this.labTenThanhVien.AutoSize = false;
            this.labTenThanhVien.BackColor = System.Drawing.Color.Transparent;
            this.labTenThanhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTenThanhVien.Location = new System.Drawing.Point(750, 717);
            this.labTenThanhVien.Name = "labTenThanhVien";
            this.labTenThanhVien.Size = new System.Drawing.Size(10, 10);
            this.labTenThanhVien.TabIndex = 28;
            this.labTenThanhVien.Text = "***";
            this.labTenThanhVien.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labMaNV
            // 
            this.labMaNV.AutoSize = false;
            this.labMaNV.BackColor = System.Drawing.Color.Transparent;
            this.labMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaNV.Location = new System.Drawing.Point(33, 891);
            this.labMaNV.Name = "labMaNV";
            this.labMaNV.Size = new System.Drawing.Size(56, 31);
            this.labMaNV.TabIndex = 27;
            this.labMaNV.Text = "*";
            this.labMaNV.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbTenThanhVien
            // 
            this.cbbTenThanhVien.BackColor = System.Drawing.Color.Transparent;
            this.cbbTenThanhVien.BorderColor = System.Drawing.Color.Black;
            this.cbbTenThanhVien.BorderRadius = 6;
            this.cbbTenThanhVien.DisplayMember = "tennhanvien";
            this.cbbTenThanhVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenThanhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenThanhVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTenThanhVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTenThanhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenThanhVien.ForeColor = System.Drawing.Color.Black;
            this.cbbTenThanhVien.ItemHeight = 30;
            this.cbbTenThanhVien.Location = new System.Drawing.Point(903, 892);
            this.cbbTenThanhVien.Name = "cbbTenThanhVien";
            this.cbbTenThanhVien.Size = new System.Drawing.Size(188, 36);
            this.cbbTenThanhVien.TabIndex = 1;
            this.cbbTenThanhVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbbTenThanhVien.ValueMember = "manv";
            this.cbbTenThanhVien.SelectedIndexChanged += new System.EventHandler(this.cbbTenThanhVien_SelectedIndexChanged);
            // 
            // txtMatKau
            // 
            this.txtMatKau.Animated = true;
            this.txtMatKau.BorderColor = System.Drawing.Color.Black;
            this.txtMatKau.BorderRadius = 6;
            this.txtMatKau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKau.DefaultText = "";
            this.txtMatKau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKau.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMatKau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKau.Location = new System.Drawing.Point(330, 891);
            this.txtMatKau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKau.Name = "txtMatKau";
            this.txtMatKau.PasswordChar = '\0';
            this.txtMatKau.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMatKau.PlaceholderText = "Mật khẩu( Bao gồm chữ hoa, chữ thường và số)";
            this.txtMatKau.SelectedText = "";
            this.txtMatKau.Size = new System.Drawing.Size(310, 34);
            this.txtMatKau.TabIndex = 4;
            // 
            // cbbLoaiTk
            // 
            this.cbbLoaiTk.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiTk.BorderColor = System.Drawing.Color.Black;
            this.cbbLoaiTk.BorderRadius = 6;
            this.cbbLoaiTk.DisplayMember = "tenloaitk";
            this.cbbLoaiTk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiTk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiTk.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiTk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiTk.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbbLoaiTk.ForeColor = System.Drawing.Color.Black;
            this.cbbLoaiTk.ItemHeight = 30;
            this.cbbLoaiTk.Location = new System.Drawing.Point(675, 891);
            this.cbbLoaiTk.Name = "cbbLoaiTk";
            this.cbbLoaiTk.Size = new System.Drawing.Size(197, 36);
            this.cbbLoaiTk.TabIndex = 2;
            this.cbbLoaiTk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbbLoaiTk.ValueMember = "idloaitk";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Animated = true;
            this.txtTaiKhoan.BorderColor = System.Drawing.Color.Black;
            this.txtTaiKhoan.BorderRadius = 6;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.DefaultText = "";
            this.txtTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.Location = new System.Drawing.Point(113, 892);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PasswordChar = '\0';
            this.txtTaiKhoan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTaiKhoan.PlaceholderText = "Tài khoản";
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.Size = new System.Drawing.Size(200, 30);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Navy;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(17, 26);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(209, 32);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Quản lý tài khỏan";
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.cbbTimKiem.BorderColor = System.Drawing.Color.Black;
            this.cbbTimKiem.BorderRadius = 6;
            this.cbbTimKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.cbbTimKiem.ItemHeight = 30;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên thành viên",
            "Loại tài khoản"});
            this.cbbTimKiem.Location = new System.Drawing.Point(1301, 134);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(193, 36);
            this.cbbTimKiem.TabIndex = 20;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Animated = true;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiem.BorderRadius = 6;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(1501, 134);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(267, 36);
            this.txtTimKiem.TabIndex = 19;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(1296, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tìm kiếm theo";
            // 
            // btnThoat
            // 
            this.btnThoat.BorderRadius = 6;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(1651, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 41);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(66, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Thông tin tài khỏan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(616, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Danh sách tài khoản ";
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button1.BackgroundImage")));
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 50);
            this.guna2Button1.Location = new System.Drawing.Point(1376, 882);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(76, 67);
            this.guna2Button1.TabIndex = 40;
            this.guna2HtmlToolTip1.SetToolTip(this.guna2Button1, "Nhấn để thêm sản phẩm");
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button2.BackgroundImage")));
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button2.BorderRadius = 6;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 50);
            this.guna2Button2.Location = new System.Drawing.Point(1512, 882);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(69, 67);
            this.guna2Button2.TabIndex = 41;
            this.guna2HtmlToolTip1.SetToolTip(this.guna2Button2, "Nhấn để sửa sản phẩm");
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button3.BackgroundImage")));
            this.guna2Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button3.BorderRadius = 6;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 50);
            this.guna2Button3.Location = new System.Drawing.Point(1655, 880);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(76, 65);
            this.guna2Button3.TabIndex = 42;
            this.guna2HtmlToolTip1.SetToolTip(this.guna2Button3, "Nhấn để xóa sản phẩm");
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1780, 947);
            this.Controls.Add(this.labTenThanhVien);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.labMaNV);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.cbbTenThanhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtMatKau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbLoaiTk);
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvQLYK);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLYK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvQLYK;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiTk;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKau;
        private Guna.UI2.WinForms.Guna2TextBox txtTaiKhoan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTenThanhVien;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labMaNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel labTenThanhVien;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthanhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaitaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn kbiet;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}