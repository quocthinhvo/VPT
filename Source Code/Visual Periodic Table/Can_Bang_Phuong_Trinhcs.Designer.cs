namespace Visual_Periodic_Table
{
    partial class Can_Bang_Phuong_Trinhcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Can_Bang_Phuong_Trinhcs));
            this.btncanbang = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txbchat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbxketqua = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbdieukien = new System.Windows.Forms.RichTextBox();
            this.dBVPTDataSet2 = new Visual_Periodic_Table.DBVPTDataSet2();
            this.pHUONGTRINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHUONGTRINHTableAdapter = new Visual_Periodic_Table.DBVPTDataSet2TableAdapters.PHUONGTRINHTableAdapter();
            this.tHAMGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEUKIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVPTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGTRINHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btncanbang
            // 
            this.btncanbang.AutoSize = true;
            this.btncanbang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncanbang.Location = new System.Drawing.Point(460, 17);
            this.btncanbang.Name = "btncanbang";
            this.btncanbang.Size = new System.Drawing.Size(90, 30);
            this.btncanbang.TabIndex = 0;
            this.btncanbang.Text = "Cân Bằng";
            this.btncanbang.UseVisualStyleBackColor = true;
            this.btncanbang.Click += new System.EventHandler(this.btncanbang_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.AutoSize = true;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(555, 17);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 30);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txbchat
            // 
            this.txbchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbchat.Location = new System.Drawing.Point(233, 19);
            this.txbchat.Name = "txbchat";
            this.txbchat.Size = new System.Drawing.Size(221, 26);
            this.txbchat.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tHAMGIADataGridViewTextBoxColumn,
            this.sANPHAMDataGridViewTextBoxColumn,
            this.dIEUKIENDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pHUONGTRINHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(233, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 39);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbxketqua
            // 
            this.lbxketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxketqua.FormattingEnabled = true;
            this.lbxketqua.ItemHeight = 20;
            this.lbxketqua.Location = new System.Drawing.Point(232, 51);
            this.lbxketqua.Name = "lbxketqua";
            this.lbxketqua.Size = new System.Drawing.Size(398, 24);
            this.lbxketqua.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập chất tham gia phản ứng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Điều kiện để xảy ra phản ứng";
            // 
            // rtbdieukien
            // 
            this.rtbdieukien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbdieukien.Location = new System.Drawing.Point(232, 81);
            this.rtbdieukien.Name = "rtbdieukien";
            this.rtbdieukien.ReadOnly = true;
            this.rtbdieukien.Size = new System.Drawing.Size(399, 96);
            this.rtbdieukien.TabIndex = 8;
            this.rtbdieukien.Text = "";
            // 
            // dBVPTDataSet2
            // 
            this.dBVPTDataSet2.DataSetName = "DBVPTDataSet2";
            this.dBVPTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHUONGTRINHBindingSource
            // 
            this.pHUONGTRINHBindingSource.DataMember = "PHUONGTRINH";
            this.pHUONGTRINHBindingSource.DataSource = this.dBVPTDataSet2;
            // 
            // pHUONGTRINHTableAdapter
            // 
            this.pHUONGTRINHTableAdapter.ClearBeforeFill = true;
            // 
            // tHAMGIADataGridViewTextBoxColumn
            // 
            this.tHAMGIADataGridViewTextBoxColumn.DataPropertyName = "THAMGIA";
            this.tHAMGIADataGridViewTextBoxColumn.HeaderText = "THAMGIA";
            this.tHAMGIADataGridViewTextBoxColumn.Name = "tHAMGIADataGridViewTextBoxColumn";
            // 
            // sANPHAMDataGridViewTextBoxColumn
            // 
            this.sANPHAMDataGridViewTextBoxColumn.DataPropertyName = "SANPHAM";
            this.sANPHAMDataGridViewTextBoxColumn.HeaderText = "SANPHAM";
            this.sANPHAMDataGridViewTextBoxColumn.Name = "sANPHAMDataGridViewTextBoxColumn";
            // 
            // dIEUKIENDataGridViewTextBoxColumn
            // 
            this.dIEUKIENDataGridViewTextBoxColumn.DataPropertyName = "DIEUKIEN";
            this.dIEUKIENDataGridViewTextBoxColumn.HeaderText = "DIEUKIEN";
            this.dIEUKIENDataGridViewTextBoxColumn.Name = "dIEUKIENDataGridViewTextBoxColumn";
            // 
            // Can_Bang_Phuong_Trinhcs
            // 
            this.AcceptButton = this.btncanbang;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 188);
            this.Controls.Add(this.rtbdieukien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxketqua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbchat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btncanbang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Can_Bang_Phuong_Trinhcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cân Bằng Phương Trình";
            this.Load += new System.EventHandler(this.Can_Bang_Phuong_Trinhcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVPTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHUONGTRINHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncanbang;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txbchat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbxketqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbdieukien;
        private DBVPTDataSet2 dBVPTDataSet2;
        private System.Windows.Forms.BindingSource pHUONGTRINHBindingSource;
        private DBVPTDataSet2TableAdapters.PHUONGTRINHTableAdapter pHUONGTRINHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHAMGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIEUKIENDataGridViewTextBoxColumn;
    }
}