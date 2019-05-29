namespace Visual_Periodic_Table
{
    partial class Tu_Dien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tu_Dien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntim = new System.Windows.Forms.Button();
            this.txbnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbkihieu = new System.Windows.Forms.RichTextBox();
            this.rtbdoc = new System.Windows.Forms.RichTextBox();
            this.rtbsoi = new System.Windows.Forms.RichTextBox();
            this.rtbchay = new System.Windows.Forms.RichTextBox();
            this.rtbhoa = new System.Windows.Forms.RichTextBox();
            this.rtbungdung = new System.Windows.Forms.RichTextBox();
            this.dBVPTDataSet3 = new Visual_Periodic_Table.DBVPTDataSet3();
            this.tUDIENHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tU_DIEN_HOATableAdapter = new Visual_Periodic_Table.DBVPTDataSet3TableAdapters.TU_DIEN_HOATableAdapter();
            this.tENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nONGCHAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNGDUNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVPTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUDIENHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tENDataGridViewTextBoxColumn,
            this.dOCDataGridViewTextBoxColumn,
            this.sOIDataGridViewTextBoxColumn,
            this.nONGCHAYDataGridViewTextBoxColumn,
            this.tCHHDataGridViewTextBoxColumn,
            this.uNGDUNGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tUDIENHOABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-13, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 104);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btntim
            // 
            this.btntim.AutoSize = true;
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(331, 9);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(79, 30);
            this.btntim.TabIndex = 1;
            this.btntim.Text = "Tìm chất";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txbnhap
            // 
            this.txbnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnhap.Location = new System.Drawing.Point(12, 12);
            this.txbnhap.Name = "txbnhap";
            this.txbnhap.Size = new System.Drawing.Size(313, 24);
            this.txbnhap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kí hiệu hóa học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đọc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhiệt độ sôi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhiệt độ nóng chảy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tính chất hóa học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ứng dụng";
            // 
            // rtbkihieu
            // 
            this.rtbkihieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbkihieu.Location = new System.Drawing.Point(158, 47);
            this.rtbkihieu.Name = "rtbkihieu";
            this.rtbkihieu.ReadOnly = true;
            this.rtbkihieu.Size = new System.Drawing.Size(252, 31);
            this.rtbkihieu.TabIndex = 9;
            this.rtbkihieu.Text = "";
            // 
            // rtbdoc
            // 
            this.rtbdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbdoc.Location = new System.Drawing.Point(158, 84);
            this.rtbdoc.Name = "rtbdoc";
            this.rtbdoc.ReadOnly = true;
            this.rtbdoc.Size = new System.Drawing.Size(252, 31);
            this.rtbdoc.TabIndex = 10;
            this.rtbdoc.Text = "";
            // 
            // rtbsoi
            // 
            this.rtbsoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbsoi.Location = new System.Drawing.Point(158, 121);
            this.rtbsoi.Name = "rtbsoi";
            this.rtbsoi.ReadOnly = true;
            this.rtbsoi.Size = new System.Drawing.Size(252, 31);
            this.rtbsoi.TabIndex = 11;
            this.rtbsoi.Text = "";
            // 
            // rtbchay
            // 
            this.rtbchay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbchay.Location = new System.Drawing.Point(158, 158);
            this.rtbchay.Name = "rtbchay";
            this.rtbchay.ReadOnly = true;
            this.rtbchay.Size = new System.Drawing.Size(252, 31);
            this.rtbchay.TabIndex = 12;
            this.rtbchay.Text = "";
            // 
            // rtbhoa
            // 
            this.rtbhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbhoa.Location = new System.Drawing.Point(158, 195);
            this.rtbhoa.Name = "rtbhoa";
            this.rtbhoa.ReadOnly = true;
            this.rtbhoa.Size = new System.Drawing.Size(252, 31);
            this.rtbhoa.TabIndex = 13;
            this.rtbhoa.Text = "";
            // 
            // rtbungdung
            // 
            this.rtbungdung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbungdung.Location = new System.Drawing.Point(158, 232);
            this.rtbungdung.Name = "rtbungdung";
            this.rtbungdung.ReadOnly = true;
            this.rtbungdung.Size = new System.Drawing.Size(252, 103);
            this.rtbungdung.TabIndex = 14;
            this.rtbungdung.Text = "";
            // 
            // dBVPTDataSet3
            // 
            this.dBVPTDataSet3.DataSetName = "DBVPTDataSet3";
            this.dBVPTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tUDIENHOABindingSource
            // 
            this.tUDIENHOABindingSource.DataMember = "TU_DIEN_HOA";
            this.tUDIENHOABindingSource.DataSource = this.dBVPTDataSet3;
            // 
            // tU_DIEN_HOATableAdapter
            // 
            this.tU_DIEN_HOATableAdapter.ClearBeforeFill = true;
            // 
            // tENDataGridViewTextBoxColumn
            // 
            this.tENDataGridViewTextBoxColumn.DataPropertyName = "TEN";
            this.tENDataGridViewTextBoxColumn.HeaderText = "TEN";
            this.tENDataGridViewTextBoxColumn.Name = "tENDataGridViewTextBoxColumn";
            // 
            // dOCDataGridViewTextBoxColumn
            // 
            this.dOCDataGridViewTextBoxColumn.DataPropertyName = "DOC";
            this.dOCDataGridViewTextBoxColumn.HeaderText = "DOC";
            this.dOCDataGridViewTextBoxColumn.Name = "dOCDataGridViewTextBoxColumn";
            // 
            // sOIDataGridViewTextBoxColumn
            // 
            this.sOIDataGridViewTextBoxColumn.DataPropertyName = "SOI";
            this.sOIDataGridViewTextBoxColumn.HeaderText = "SOI";
            this.sOIDataGridViewTextBoxColumn.Name = "sOIDataGridViewTextBoxColumn";
            // 
            // nONGCHAYDataGridViewTextBoxColumn
            // 
            this.nONGCHAYDataGridViewTextBoxColumn.DataPropertyName = "NONGCHAY";
            this.nONGCHAYDataGridViewTextBoxColumn.HeaderText = "NONGCHAY";
            this.nONGCHAYDataGridViewTextBoxColumn.Name = "nONGCHAYDataGridViewTextBoxColumn";
            // 
            // tCHHDataGridViewTextBoxColumn
            // 
            this.tCHHDataGridViewTextBoxColumn.DataPropertyName = "TCHH";
            this.tCHHDataGridViewTextBoxColumn.HeaderText = "TCHH";
            this.tCHHDataGridViewTextBoxColumn.Name = "tCHHDataGridViewTextBoxColumn";
            // 
            // uNGDUNGDataGridViewTextBoxColumn
            // 
            this.uNGDUNGDataGridViewTextBoxColumn.DataPropertyName = "UNGDUNG";
            this.uNGDUNGDataGridViewTextBoxColumn.HeaderText = "UNGDUNG";
            this.uNGDUNGDataGridViewTextBoxColumn.Name = "uNGDUNGDataGridViewTextBoxColumn";
            // 
            // Tu_Dien
            // 
            this.AcceptButton = this.btntim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 354);
            this.Controls.Add(this.rtbungdung);
            this.Controls.Add(this.rtbhoa);
            this.Controls.Add(this.rtbchay);
            this.Controls.Add(this.rtbsoi);
            this.Controls.Add(this.rtbdoc);
            this.Controls.Add(this.rtbkihieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbnhap);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tu_Dien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Từ điển hóa học";
            this.Load += new System.EventHandler(this.Tu_Dien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVPTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUDIENHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txbnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbkihieu;
        private System.Windows.Forms.RichTextBox rtbdoc;
        private System.Windows.Forms.RichTextBox rtbsoi;
        private System.Windows.Forms.RichTextBox rtbchay;
        private System.Windows.Forms.RichTextBox rtbhoa;
        private System.Windows.Forms.RichTextBox rtbungdung;
        private DBVPTDataSet3 dBVPTDataSet3;
        private System.Windows.Forms.BindingSource tUDIENHOABindingSource;
        private DBVPTDataSet3TableAdapters.TU_DIEN_HOATableAdapter tU_DIEN_HOATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nONGCHAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNGDUNGDataGridViewTextBoxColumn;
    }
}