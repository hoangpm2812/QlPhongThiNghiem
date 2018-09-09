namespace HQT_GGND_QuanLyPhongThiNghiem
{
    partial class frmDangKyMuonPhong
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
            this.ThongSoKyThuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDanhSachThietBi = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachThietBi = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMucDich = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTietKetThuc = new System.Windows.Forms.ComboBox();
            this.txtSoPhieuMuon = new System.Windows.Forms.TextBox();
            this.brnTroVe = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTietBatDau = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNguoiMuon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrangThaiPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgayThang = new System.Windows.Forms.TextBox();
            this.grbThongTinMuon = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThietBi)).BeginInit();
            this.grbThongTinMuon.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThongSoKyThuat
            // 
            this.ThongSoKyThuat.HeaderText = "Thông số kỹ thuật";
            this.ThongSoKyThuat.Name = "ThongSoKyThuat";
            // 
            // grbDanhSachThietBi
            // 
            this.grbDanhSachThietBi.Controls.Add(this.dgvDanhSachThietBi);
            this.grbDanhSachThietBi.Location = new System.Drawing.Point(12, 183);
            this.grbDanhSachThietBi.Name = "grbDanhSachThietBi";
            this.grbDanhSachThietBi.Size = new System.Drawing.Size(737, 280);
            this.grbDanhSachThietBi.TabIndex = 44;
            this.grbDanhSachThietBi.TabStop = false;
            this.grbDanhSachThietBi.Text = "Danh sách thiết bị trong phòng";
            // 
            // dgvDanhSachThietBi
            // 
            this.dgvDanhSachThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachThietBi.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgvDanhSachThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Name,
            this.ma,
            this.SL,
            this.ThongSoKyThuat,
            this.GhiChu});
            this.dgvDanhSachThietBi.Location = new System.Drawing.Point(6, 19);
            this.dgvDanhSachThietBi.Name = "dgvDanhSachThietBi";
            this.dgvDanhSachThietBi.Size = new System.Drawing.Size(725, 255);
            this.dgvDanhSachThietBi.TabIndex = 3;
            // 
            // STT
            // 
            this.STT.FillWeight = 25F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên thiết bị";
            this.Name.Name = "Name";
            // 
            // ma
            // 
            this.ma.HeaderText = "Mã thiết bị";
            this.ma.Name = "ma";
            // 
            // SL
            // 
            this.SL.FillWeight = 50F;
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // txtMucDich
            // 
            this.txtMucDich.Location = new System.Drawing.Point(74, 95);
            this.txtMucDich.Multiline = true;
            this.txtMucDich.Name = "txtMucDich";
            this.txtMucDich.Size = new System.Drawing.Size(636, 38);
            this.txtMucDich.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mục đích";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.ForeColor = System.Drawing.Color.Red;
            this.lblDienThoai.Location = new System.Drawing.Point(521, 22);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(88, 16);
            this.lblDienThoai.TabIndex = 14;
            this.lblDienThoai.Text = "0123456789";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(430, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Điện thoại :";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGV.ForeColor = System.Drawing.Color.Red;
            this.lblMaGV.Location = new System.Drawing.Point(341, 22);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(40, 16);
            this.lblMaGV.TabIndex = 12;
            this.lblMaGV.Text = "1234";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(273, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mã GV :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trạng thái phòng";
            // 
            // cbbTietKetThuc
            // 
            this.cbbTietKetThuc.DisplayMember = "1";
            this.cbbTietKetThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTietKetThuc.FormattingEnabled = true;
            this.cbbTietKetThuc.Location = new System.Drawing.Point(478, 60);
            this.cbbTietKetThuc.Name = "cbbTietKetThuc";
            this.cbbTietKetThuc.Size = new System.Drawing.Size(73, 21);
            this.cbbTietKetThuc.TabIndex = 9;
            // 
            // txtSoPhieuMuon
            // 
            this.txtSoPhieuMuon.Location = new System.Drawing.Point(646, 7);
            this.txtSoPhieuMuon.Name = "txtSoPhieuMuon";
            this.txtSoPhieuMuon.Size = new System.Drawing.Size(103, 20);
            this.txtSoPhieuMuon.TabIndex = 51;
            // 
            // brnTroVe
            // 
            this.brnTroVe.Location = new System.Drawing.Point(512, 469);
            this.brnTroVe.Name = "brnTroVe";
            this.brnTroVe.Size = new System.Drawing.Size(75, 41);
            this.brnTroVe.TabIndex = 47;
            this.brnTroVe.Text = "Trở về";
            this.brnTroVe.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(593, 470);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 41);
            this.btnLamMoi.TabIndex = 46;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(674, 469);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 41);
            this.btnDangKy.TabIndex = 45;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiết kết thúc";
            // 
            // cbbTietBatDau
            // 
            this.cbbTietBatDau.DisplayMember = "1";
            this.cbbTietBatDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTietBatDau.FormattingEnabled = true;
            this.cbbTietBatDau.Location = new System.Drawing.Point(287, 60);
            this.cbbTietBatDau.Name = "cbbTietBatDau";
            this.cbbTietBatDau.Size = new System.Drawing.Size(73, 21);
            this.cbbTietBatDau.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tiết bắt đầu";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(74, 61);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(109, 20);
            this.dtpNgayMuon.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(562, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Số phiếu mượn";
            // 
            // lblNguoiMuon
            // 
            this.lblNguoiMuon.AutoSize = true;
            this.lblNguoiMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiMuon.ForeColor = System.Drawing.Color.Red;
            this.lblNguoiMuon.Location = new System.Drawing.Point(111, 22);
            this.lblNguoiMuon.Name = "lblNguoiMuon";
            this.lblNguoiMuon.Size = new System.Drawing.Size(130, 16);
            this.lblNguoiMuon.TabIndex = 4;
            this.lblNguoiMuon.Text = "Phạm Bùi Nguyễn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày tháng";
            // 
            // txtTrangThaiPhong
            // 
            this.txtTrangThaiPhong.BackColor = System.Drawing.Color.Lime;
            this.txtTrangThaiPhong.Enabled = false;
            this.txtTrangThaiPhong.Location = new System.Drawing.Point(684, 58);
            this.txtTrangThaiPhong.Name = "txtTrangThaiPhong";
            this.txtTrangThaiPhong.Size = new System.Drawing.Size(26, 20);
            this.txtTrangThaiPhong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày mượn";
            // 
            // txtNgayThang
            // 
            this.txtNgayThang.Location = new System.Drawing.Point(454, 7);
            this.txtNgayThang.Name = "txtNgayThang";
            this.txtNgayThang.Size = new System.Drawing.Size(97, 20);
            this.txtNgayThang.TabIndex = 49;
            // 
            // grbThongTinMuon
            // 
            this.grbThongTinMuon.Controls.Add(this.txtMucDich);
            this.grbThongTinMuon.Controls.Add(this.label11);
            this.grbThongTinMuon.Controls.Add(this.lblDienThoai);
            this.grbThongTinMuon.Controls.Add(this.label10);
            this.grbThongTinMuon.Controls.Add(this.lblMaGV);
            this.grbThongTinMuon.Controls.Add(this.label8);
            this.grbThongTinMuon.Controls.Add(this.label6);
            this.grbThongTinMuon.Controls.Add(this.cbbTietKetThuc);
            this.grbThongTinMuon.Controls.Add(this.label5);
            this.grbThongTinMuon.Controls.Add(this.cbbTietBatDau);
            this.grbThongTinMuon.Controls.Add(this.label4);
            this.grbThongTinMuon.Controls.Add(this.dtpNgayMuon);
            this.grbThongTinMuon.Controls.Add(this.lblNguoiMuon);
            this.grbThongTinMuon.Controls.Add(this.txtTrangThaiPhong);
            this.grbThongTinMuon.Controls.Add(this.label2);
            this.grbThongTinMuon.Controls.Add(this.label1);
            this.grbThongTinMuon.Location = new System.Drawing.Point(12, 33);
            this.grbThongTinMuon.Name = "grbThongTinMuon";
            this.grbThongTinMuon.Size = new System.Drawing.Size(737, 144);
            this.grbThongTinMuon.TabIndex = 43;
            this.grbThongTinMuon.TabStop = false;
            this.grbThongTinMuon.Text = "Thông tin mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người mượn :";
            // 
            // frmDangKyMuonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 517);
            this.Controls.Add(this.grbDanhSachThietBi);
            this.Controls.Add(this.txtSoPhieuMuon);
            this.Controls.Add(this.brnTroVe);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNgayThang);
            this.Controls.Add(this.grbThongTinMuon);
            this.Name = "frmDangKyMuonPhong";
            this.Text = "Đăng ký mượn phòng";
            this.grbDanhSachThietBi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThietBi)).EndInit();
            this.grbThongTinMuon.ResumeLayout(false);
            this.grbThongTinMuon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ThongSoKyThuat;
        private System.Windows.Forms.GroupBox grbDanhSachThietBi;
        private System.Windows.Forms.DataGridView dgvDanhSachThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.TextBox txtMucDich;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTietKetThuc;
        private System.Windows.Forms.TextBox txtSoPhieuMuon;
        private System.Windows.Forms.Button brnTroVe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTietBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNguoiMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrangThaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNgayThang;
        private System.Windows.Forms.GroupBox grbThongTinMuon;
        private System.Windows.Forms.Label label1;
    }
}