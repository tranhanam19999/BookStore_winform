namespace QLTVEntityFramwork
{
    partial class More
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
            this.lblMore = new System.Windows.Forms.Label();
            this.dgvMore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMore
            // 
            this.lblMore.AutoSize = true;
            this.lblMore.BackColor = System.Drawing.Color.Transparent;
            this.lblMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMore.ForeColor = System.Drawing.Color.Transparent;
            this.lblMore.ImageKey = "(none)";
            this.lblMore.Location = new System.Drawing.Point(292, 33);
            this.lblMore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMore.Name = "lblMore";
            this.lblMore.Size = new System.Drawing.Size(471, 39);
            this.lblMore.TabIndex = 11;
            this.lblMore.Text = "Thông Tin Thêm Về Tác Giả";
            // 
            // dgvMore
            // 
            this.dgvMore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMore.Location = new System.Drawing.Point(16, 106);
            this.dgvMore.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMore.Name = "dgvMore";
            this.dgvMore.ReadOnly = true;
            this.dgvMore.RowHeadersWidth = 51;
            this.dgvMore.Size = new System.Drawing.Size(1035, 415);
            this.dgvMore.TabIndex = 10;
            this.dgvMore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMore_CellContentClick);
            // 
            // More
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTVEntityFramwork.Properties.Resources._121;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblMore);
            this.Controls.Add(this.dgvMore);
            this.Name = "More";
            this.Text = "More";
            this.Load += new System.EventHandler(this.More_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMore;
        private System.Windows.Forms.DataGridView dgvMore;
    }
}