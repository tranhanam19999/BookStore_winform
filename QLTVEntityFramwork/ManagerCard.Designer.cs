namespace QLTVEntityFramwork
{
    partial class ManagerCard
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaCart = new System.Windows.Forms.TextBox();
            this.txtMaUser = new System.Windows.Forms.TextBox();
            this.txtNgayHetHan = new System.Windows.Forms.TextBox();
            this.ds = new System.Windows.Forms.Label();
            this.kk = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.searchMuonSach = new System.Windows.Forms.Button();
            this.txtNgayMo = new System.Windows.Forms.TextBox();
            this.txtNumberCard = new System.Windows.Forms.TextBox();
            this.txtMaCardSearch = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.Label();
            this.dfa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCard = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCard)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 30);
            this.button1.TabIndex = 180;
            this.button1.Text = "Hủy Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtMaCart
            // 
            this.txtMaCart.Location = new System.Drawing.Point(209, 25);
            this.txtMaCart.Name = "txtMaCart";
            this.txtMaCart.Size = new System.Drawing.Size(100, 26);
            this.txtMaCart.TabIndex = 179;
            // 
            // txtMaUser
            // 
            this.txtMaUser.Location = new System.Drawing.Point(209, 92);
            this.txtMaUser.Name = "txtMaUser";
            this.txtMaUser.Size = new System.Drawing.Size(100, 26);
            this.txtMaUser.TabIndex = 178;
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.Location = new System.Drawing.Point(583, 95);
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.Size = new System.Drawing.Size(192, 26);
            this.txtNgayHetHan.TabIndex = 177;
            // 
            // ds
            // 
            this.ds.AutoSize = true;
            this.ds.BackColor = System.Drawing.Color.Transparent;
            this.ds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds.Location = new System.Drawing.Point(60, 88);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(117, 29);
            this.ds.TabIndex = 176;
            this.ds.Text = "Mã User:";
            // 
            // kk
            // 
            this.kk.AutoSize = true;
            this.kk.BackColor = System.Drawing.Color.Transparent;
            this.kk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kk.Location = new System.Drawing.Point(386, 95);
            this.kk.Name = "kk";
            this.kk.Size = new System.Drawing.Size(180, 29);
            this.kk.TabIndex = 175;
            this.kk.Text = "Ngày Hết Hạn:";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.BackColor = System.Drawing.Color.Transparent;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(60, 29);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(118, 29);
            this.d.TabIndex = 174;
            this.d.Text = "Mã Card:";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.Location = new System.Drawing.Point(955, 524);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(171, 72);
            this.btnHuy.TabIndex = 173;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLuu.Location = new System.Drawing.Point(955, 442);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(174, 72);
            this.btnLuu.TabIndex = 172;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(955, 278);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(174, 72);
            this.btnXoa.TabIndex = 171;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Blue;
            this.btnCapNhat.Location = new System.Drawing.Point(955, 360);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(174, 72);
            this.btnCapNhat.TabIndex = 170;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Green;
            this.btnThem.Location = new System.Drawing.Point(955, 196);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(174, 72);
            this.btnThem.TabIndex = 169;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // searchMuonSach
            // 
            this.searchMuonSach.Location = new System.Drawing.Point(784, 147);
            this.searchMuonSach.Name = "searchMuonSach";
            this.searchMuonSach.Size = new System.Drawing.Size(75, 30);
            this.searchMuonSach.TabIndex = 168;
            this.searchMuonSach.Text = "Search";
            this.searchMuonSach.UseVisualStyleBackColor = true;
            this.searchMuonSach.Click += new System.EventHandler(this.searchMuonSach_Click_1);
            // 
            // txtNgayMo
            // 
            this.txtNgayMo.Location = new System.Drawing.Point(583, 33);
            this.txtNgayMo.Name = "txtNgayMo";
            this.txtNgayMo.Size = new System.Drawing.Size(192, 26);
            this.txtNgayMo.TabIndex = 167;
            // 
            // txtNumberCard
            // 
            this.txtNumberCard.Location = new System.Drawing.Point(209, 151);
            this.txtNumberCard.Name = "txtNumberCard";
            this.txtNumberCard.Size = new System.Drawing.Size(100, 26);
            this.txtNumberCard.TabIndex = 166;
            // 
            // txtMaCardSearch
            // 
            this.txtMaCardSearch.Location = new System.Drawing.Point(583, 149);
            this.txtMaCardSearch.Name = "txtMaCardSearch";
            this.txtMaCardSearch.Size = new System.Drawing.Size(192, 26);
            this.txtMaCardSearch.TabIndex = 165;
            // 
            // txtNgay
            // 
            this.txtNgay.AutoSize = true;
            this.txtNgay.BackColor = System.Drawing.Color.Transparent;
            this.txtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(386, 33);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(180, 29);
            this.txtNgay.TabIndex = 164;
            this.txtNgay.Text = "Ngày Đăng ký:";
            // 
            // dfa
            // 
            this.dfa.AutoSize = true;
            this.dfa.BackColor = System.Drawing.Color.Transparent;
            this.dfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfa.Location = new System.Drawing.Point(60, 145);
            this.dfa.Name = "dfa";
            this.dfa.Size = new System.Drawing.Size(115, 29);
            this.dfa.TabIndex = 163;
            this.dfa.Text = "Số Card:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 162;
            this.label6.Text = "Tìm kiếm:";
            // 
            // dgvCard
            // 
            this.dgvCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCard.Location = new System.Drawing.Point(49, 196);
            this.dgvCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCard.Name = "dgvCard";
            this.dgvCard.ReadOnly = true;
            this.dgvCard.RowHeadersWidth = 51;
            this.dgvCard.RowTemplate.Height = 24;
            this.dgvCard.Size = new System.Drawing.Size(899, 391);
            this.dgvCard.TabIndex = 161;
            this.dgvCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCard_CellClick_1);
            this.dgvCard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCard_CellContentClick);
            // 
            // ManagerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTVEntityFramwork.Properties.Resources._121;
            this.ClientSize = new System.Drawing.Size(1178, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMaCart);
            this.Controls.Add(this.txtMaUser);
            this.Controls.Add(this.txtNgayHetHan);
            this.Controls.Add(this.ds);
            this.Controls.Add(this.kk);
            this.Controls.Add(this.d);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.searchMuonSach);
            this.Controls.Add(this.txtNgayMo);
            this.Controls.Add(this.txtNumberCard);
            this.Controls.Add(this.txtMaCardSearch);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.dfa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvCard);
            this.Name = "ManagerCard";
            this.Text = "ManagerCard";
            this.Load += new System.EventHandler(this.ManagerCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaCart;
        private System.Windows.Forms.TextBox txtMaUser;
        private System.Windows.Forms.TextBox txtNgayHetHan;
        private System.Windows.Forms.Label ds;
        private System.Windows.Forms.Label kk;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button searchMuonSach;
        private System.Windows.Forms.TextBox txtNgayMo;
        private System.Windows.Forms.TextBox txtNumberCard;
        private System.Windows.Forms.TextBox txtMaCardSearch;
        private System.Windows.Forms.Label txtNgay;
        private System.Windows.Forms.Label dfa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCard;
    }
}