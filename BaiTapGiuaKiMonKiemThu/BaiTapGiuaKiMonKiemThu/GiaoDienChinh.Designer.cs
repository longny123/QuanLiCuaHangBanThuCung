namespace BaiTapGiuaKiMonKiemThu
{
    partial class GiaoDienChinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnQLSP = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLNH = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao diện chính";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQLSP
            // 
            this.btnQLSP.Location = new System.Drawing.Point(70, 118);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(155, 38);
            this.btnQLSP.TabIndex = 1;
            this.btnQLSP.Text = "Quản lý sản phẩm";
            this.btnQLSP.UseVisualStyleBackColor = true;
            this.btnQLSP.Click += new System.EventHandler(this.BtnQLSP_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Location = new System.Drawing.Point(70, 162);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(155, 38);
            this.btnQLKH.TabIndex = 1;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.BtnQLKH_Click);
            // 
            // btnQLNH
            // 
            this.btnQLNH.Location = new System.Drawing.Point(70, 206);
            this.btnQLNH.Name = "btnQLNH";
            this.btnQLNH.Size = new System.Drawing.Size(155, 38);
            this.btnQLNH.TabIndex = 1;
            this.btnQLNH.Text = "Quản lý nhập hàng";
            this.btnQLNH.UseVisualStyleBackColor = true;
            this.btnQLNH.Click += new System.EventHandler(this.BtnQLNH_Click);
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(231, 118);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(155, 38);
            this.btnTT.TabIndex = 1;
            this.btnTT.Text = "Thanh toán";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.BtnTT_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(231, 162);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(155, 38);
            this.btnTK.TabIndex = 1;
            this.btnTK.Text = "Thông kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.BtnTK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(231, 206);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 38);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // GiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 343);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQLNH);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.btnQLSP);
            this.Controls.Add(this.label1);
            this.Name = "GiaoDienChinh";
            this.Text = "GiaoDienChinh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLNH;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnThoat;
    }
}