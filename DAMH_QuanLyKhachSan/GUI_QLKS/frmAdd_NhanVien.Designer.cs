﻿
namespace DAMH_QuanLyKhachSan.GUI_QLKS
{
    partial class frmAdd_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_NhanVien));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUser = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.datePickerStartDay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.datepickerDateOfBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStaffType = new MetroFramework.Controls.MetroComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddStaff = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.DatepickerDateOfReceive = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txbAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxSex = new MetroFramework.Controls.MetroComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbIDcard = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbFullName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(14, 53);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(453, 10);
            this.bunifuSeparator1.TabIndex = 60;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 37);
            this.label2.TabIndex = 59;
            this.label2.Text = "Thêm Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txbUser
            // 
            this.txbUser.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbUser.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbUser.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbUser.BorderThickness = 1;
            this.txbUser.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbUser.isPassword = false;
            this.txbUser.Location = new System.Drawing.Point(7, 48);
            this.txbUser.Margin = new System.Windows.Forms.Padding(0);
            this.txbUser.MaxLength = 32767;
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(199, 29);
            this.txbUser.TabIndex = 0;
            this.txbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // datePickerStartDay
            // 
            this.datePickerStartDay.BackColor = System.Drawing.Color.SteelBlue;
            this.datePickerStartDay.BorderRadius = 0;
            this.datePickerStartDay.ForeColor = System.Drawing.Color.White;
            this.datePickerStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerStartDay.FormatCustom = null;
            this.datePickerStartDay.Location = new System.Drawing.Point(233, 207);
            this.datePickerStartDay.Margin = new System.Windows.Forms.Padding(226, 719, 226, 651);
            this.datePickerStartDay.Name = "datePickerStartDay";
            this.datePickerStartDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePickerStartDay.Size = new System.Drawing.Size(203, 29);
            this.datePickerStartDay.TabIndex = 61;
            this.datePickerStartDay.Value = new System.DateTime(2018, 5, 16, 0, 0, 0, 0);
            // 
            // datepickerDateOfBirth
            // 
            this.datepickerDateOfBirth.BackColor = System.Drawing.Color.SteelBlue;
            this.datepickerDateOfBirth.BorderRadius = 0;
            this.datepickerDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.datepickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepickerDateOfBirth.FormatCustom = null;
            this.datepickerDateOfBirth.Location = new System.Drawing.Point(233, 46);
            this.datepickerDateOfBirth.Margin = new System.Windows.Forms.Padding(14, 21, 14, 21);
            this.datepickerDateOfBirth.Name = "datepickerDateOfBirth";
            this.datepickerDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datepickerDateOfBirth.Size = new System.Drawing.Size(203, 29);
            this.datepickerDateOfBirth.TabIndex = 47;
            this.datepickerDateOfBirth.Value = new System.DateTime(1998, 4, 6, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(231, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "Ngày vào làm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(231, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ngày sinh:";
            // 
            // comboBoxStaffType
            // 
            this.comboBoxStaffType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxStaffType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStaffType.FormattingEnabled = true;
            this.comboBoxStaffType.ItemHeight = 23;
            this.comboBoxStaffType.Location = new System.Drawing.Point(5, 210);
            this.comboBoxStaffType.Name = "comboBoxStaffType";
            this.comboBoxStaffType.Size = new System.Drawing.Size(203, 29);
            this.comboBoxStaffType.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.SteelBlue;
            this.label20.Location = new System.Drawing.Point(3, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 20);
            this.label20.TabIndex = 41;
            this.label20.Text = "Loại nhân viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose_);
            this.groupBox1.Controls.Add(this.btnAddStaff);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 74);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnClose_
            // 
            this.btnClose_.ActiveBorderThickness = 1;
            this.btnClose_.ActiveCornerRadius = 20;
            this.btnClose_.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnClose_.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose_.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnClose_.BackColor = System.Drawing.Color.White;
            this.btnClose_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose_.BackgroundImage")));
            this.btnClose_.ButtonText = "Đóng";
            this.btnClose_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose_.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose_.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnClose_.IdleBorderThickness = 1;
            this.btnClose_.IdleCornerRadius = 20;
            this.btnClose_.IdleFillColor = System.Drawing.Color.White;
            this.btnClose_.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnClose_.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnClose_.Location = new System.Drawing.Point(233, 24);
            this.btnClose_.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(203, 40);
            this.btnClose_.TabIndex = 51;
            this.btnClose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose_.Click += new System.EventHandler(this.btnClose__Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.ActiveBorderThickness = 1;
            this.btnAddStaff.ActiveCornerRadius = 20;
            this.btnAddStaff.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.btnAddStaff.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddStaff.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddStaff.BackColor = System.Drawing.Color.White;
            this.btnAddStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddStaff.BackgroundImage")));
            this.btnAddStaff.ButtonText = "Thêm Nhân Viên";
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAddStaff.IdleBorderThickness = 1;
            this.btnAddStaff.IdleCornerRadius = 20;
            this.btnAddStaff.IdleFillColor = System.Drawing.Color.White;
            this.btnAddStaff.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.btnAddStaff.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnAddStaff.Location = new System.Drawing.Point(5, 24);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(203, 40);
            this.btnAddStaff.TabIndex = 48;
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(453, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 63;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DatepickerDateOfReceive
            // 
            this.DatepickerDateOfReceive.BackColor = System.Drawing.Color.SteelBlue;
            this.DatepickerDateOfReceive.BorderRadius = 0;
            this.DatepickerDateOfReceive.ForeColor = System.Drawing.Color.White;
            this.DatepickerDateOfReceive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatepickerDateOfReceive.FormatCustom = "";
            this.DatepickerDateOfReceive.Location = new System.Drawing.Point(35, 766);
            this.DatepickerDateOfReceive.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DatepickerDateOfReceive.Name = "DatepickerDateOfReceive";
            this.DatepickerDateOfReceive.Size = new System.Drawing.Size(304, 47);
            this.DatepickerDateOfReceive.TabIndex = 30;
            this.DatepickerDateOfReceive.Value = new System.DateTime(2018, 2, 23, 23, 29, 57, 962);
            // 
            // txbAddress
            // 
            this.txbAddress.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbAddress.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbAddress.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbAddress.BorderThickness = 1;
            this.txbAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbAddress.isPassword = false;
            this.txbAddress.Location = new System.Drawing.Point(233, 101);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txbAddress.MaxLength = 32767;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(203, 29);
            this.txbAddress.TabIndex = 4;
            this.txbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(231, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Địa chỉ:";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.ItemHeight = 23;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBoxSex.Location = new System.Drawing.Point(233, 152);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(203, 29);
            this.comboBoxSex.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboBoxSex.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(231, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Giới tính:";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbPhoneNumber.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbPhoneNumber.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbPhoneNumber.BorderThickness = 1;
            this.txbPhoneNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPhoneNumber.isPassword = false;
            this.txbPhoneNumber.Location = new System.Drawing.Point(5, 262);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbPhoneNumber.MaxLength = 32767;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(203, 29);
            this.txbPhoneNumber.TabIndex = 3;
            this.txbPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.label14.Location = new System.Drawing.Point(3, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Số điện thoại:";
            // 
            // txbIDcard
            // 
            this.txbIDcard.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbIDcard.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbIDcard.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbIDcard.BorderThickness = 1;
            this.txbIDcard.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIDcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDcard.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbIDcard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbIDcard.isPassword = false;
            this.txbIDcard.Location = new System.Drawing.Point(5, 154);
            this.txbIDcard.Margin = new System.Windows.Forms.Padding(4);
            this.txbIDcard.MaxLength = 32767;
            this.txbIDcard.Name = "txbIDcard";
            this.txbIDcard.Size = new System.Drawing.Size(203, 29);
            this.txbIDcard.TabIndex = 2;
            this.txbIDcard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SteelBlue;
            this.label15.Location = new System.Drawing.Point(3, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Thẻ căn cước/ CMND:";
            // 
            // txbFullName
            // 
            this.txbFullName.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.txbFullName.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.txbFullName.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.txbFullName.BorderThickness = 1;
            this.txbFullName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbFullName.isPassword = false;
            this.txbFullName.Location = new System.Drawing.Point(5, 101);
            this.txbFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txbFullName.MaxLength = 32767;
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(203, 29);
            this.txbFullName.TabIndex = 1;
            this.txbFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SteelBlue;
            this.label16.Location = new System.Drawing.Point(3, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Họ và tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txbUser);
            this.groupBox2.Controls.Add(this.datePickerStartDay);
            this.groupBox2.Controls.Add(this.datepickerDateOfBirth);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxStaffType);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.DatepickerDateOfReceive);
            this.groupBox2.Controls.Add(this.txbAddress);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBoxSex);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txbPhoneNumber);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txbIDcard);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txbFullName);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 313);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // frmAdd_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 487);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd_NhanVien";
            this.Text = "frmAdd_NhanVien";
            this.Load += new System.EventHandler(this.frmAdd_NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose_;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddStaff;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbUser;
        private Bunifu.Framework.UI.BunifuDatepicker datePickerStartDay;
        private Bunifu.Framework.UI.BunifuDatepicker datepickerDateOfBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox comboBoxStaffType;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerDateOfReceive;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbAddress;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroComboBox comboBoxSex;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPhoneNumber;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbIDcard;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbFullName;
        private System.Windows.Forms.Label label16;
    }
}