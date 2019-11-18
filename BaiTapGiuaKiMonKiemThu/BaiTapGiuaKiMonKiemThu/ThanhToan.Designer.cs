namespace BaiTapGiuaKiMonKiemThu
{
    partial class ThanhToan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvGioHang = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.cbSP = new System.Windows.Forms.ComboBox();
            this.hangHoaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet4 = new BaiTapGiuaKiMonKiemThu.PetStoreDataSet4();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet2 = new BaiTapGiuaKiMonKiemThu.PetStoreDataSet2();
            this.hangHoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet3 = new BaiTapGiuaKiMonKiemThu.PetStoreDataSet3();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter1 = new BaiTapGiuaKiMonKiemThu.PetStoreDataSet1TableAdapters.HangHoaTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.khachHangTableAdapter = new BaiTapGiuaKiMonKiemThu.PetStoreDataSet2TableAdapters.KhachHangTableAdapter();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hangHoaTableAdapter2 = new BaiTapGiuaKiMonKiemThu.PetStoreDataSet3TableAdapters.HangHoaTableAdapter();
            this.hangHoaTableAdapter3 = new BaiTapGiuaKiMonKiemThu.PetStoreDataSet4TableAdapters.HangHoaTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvGioHang);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            // 
            // lvGioHang
            // 
            this.lvGioHang.HideSelection = false;
            this.lvGioHang.Location = new System.Drawing.Point(18, 21);
            this.lvGioHang.Name = "lvGioHang";
            this.lvGioHang.Size = new System.Drawing.Size(870, 212);
            this.lvGioHang.TabIndex = 0;
            this.lvGioHang.UseCompatibleStateImageBehavior = false;
            this.lvGioHang.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(-3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thanh toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá bán";
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.AutoSize = true;
            this.lbGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaBan.Location = new System.Drawing.Point(177, 406);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(114, 38);
            this.lbGiaBan.TabIndex = 2;
            this.lbGiaBan.Text = "0 VND";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(817, 390);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(102, 39);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.BtnThanhToan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên khách hàng";
            // 
            // btnTimKH
            // 
            this.btnTimKH.Location = new System.Drawing.Point(293, 54);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(119, 23);
            this.btnTimKH.TabIndex = 6;
            this.btnTimKH.Text = "Tím";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.BtnTimKH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên sản phẩm";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(772, 53);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(134, 26);
            this.btnThemSP.TabIndex = 7;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.BtnThemSP_Click);
            // 
            // cbSP
            // 
            this.cbSP.DataSource = this.hangHoaBindingSource2;
            this.cbSP.DisplayMember = "TenHH";
            this.cbSP.FormattingEnabled = true;
            this.cbSP.Location = new System.Drawing.Point(524, 54);
            this.cbSP.Name = "cbSP";
            this.cbSP.Size = new System.Drawing.Size(242, 24);
            this.cbSP.TabIndex = 8;
            this.cbSP.ValueMember = "TenHH";
            // 
            // hangHoaBindingSource2
            // 
            this.hangHoaBindingSource2.DataMember = "HangHoa";
            this.hangHoaBindingSource2.DataSource = this.petStoreDataSet4;
            // 
            // petStoreDataSet4
            // 
            this.petStoreDataSet4.DataSetName = "PetStoreDataSet4";
            this.petStoreDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.petStoreDataSet2;
            // 
            // petStoreDataSet2
            // 
            this.petStoreDataSet2.DataSetName = "PetStoreDataSet2";
            this.petStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaBindingSource1
            // 
            this.hangHoaBindingSource1.DataMember = "HangHoa";
            this.hangHoaBindingSource1.DataSource = this.petStoreDataSet3;
            // 
            // petStoreDataSet3
            // 
            this.petStoreDataSet3.DataSetName = "PetStoreDataSet3";
            this.petStoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(524, 95);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(70, 22);
            this.txtSoLuong.TabIndex = 5;
            // 
            // hangHoaTableAdapter1
            // 
            this.hangHoaTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(568, 405);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(114, 38);
            this.lbTongTien.TabIndex = 2;
            this.lbTongTien.Text = "0 VND";
            // 
            // cbKH
            // 
            this.cbKH.DataSource = this.khachHangBindingSource;
            this.cbKH.DisplayMember = "HoTen";
            this.cbKH.FormattingEnabled = true;
            this.cbKH.Location = new System.Drawing.Point(134, 52);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(157, 24);
            this.cbKH.TabIndex = 9;
            this.cbKH.ValueMember = "HoTen";
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(134, 92);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(157, 22);
            this.txtMaKH.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mã khách hàng";
            // 
            // hangHoaTableAdapter2
            // 
            this.hangHoaTableAdapter2.ClearBeforeFill = true;
            // 
            // hangHoaTableAdapter3
            // 
            this.hangHoaTableAdapter3.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(638, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mã sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(737, 98);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(100, 22);
            this.txtMaSP.TabIndex = 12;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(817, 436);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 39);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 474);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.cbKH);
            this.Controls.Add(this.cbSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.btnTimKH);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbGiaBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGiaBan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.ComboBox cbSP;
        private System.Windows.Forms.ListView lvGioHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private PetStoreDataSet1TableAdapters.HangHoaTableAdapter hangHoaTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.ComboBox cbKH;
        private PetStoreDataSet2 petStoreDataSet2;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private PetStoreDataSet2TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label7;
        private PetStoreDataSet3 petStoreDataSet3;
        private System.Windows.Forms.BindingSource hangHoaBindingSource1;
        private PetStoreDataSet3TableAdapters.HangHoaTableAdapter hangHoaTableAdapter2;
        private PetStoreDataSet4 petStoreDataSet4;
        private System.Windows.Forms.BindingSource hangHoaBindingSource2;
        private PetStoreDataSet4TableAdapters.HangHoaTableAdapter hangHoaTableAdapter3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Button btnThoat;
    }
}