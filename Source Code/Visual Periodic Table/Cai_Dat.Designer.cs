namespace Visual_Periodic_Table
{
    partial class Cai_Dat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cai_Dat));
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnchuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbXam = new System.Windows.Forms.RadioButton();
            this.rdbXanh = new System.Windows.Forms.RadioButton();
            this.rdbDo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbcochu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(95, 155);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnchuy
            // 
            this.btnchuy.Location = new System.Drawing.Point(14, 156);
            this.btnchuy.Name = "btnchuy";
            this.btnchuy.Size = new System.Drawing.Size(75, 23);
            this.btnchuy.TabIndex = 2;
            this.btnchuy.Text = "Chú Ý";
            this.btnchuy.UseVisualStyleBackColor = true;
            this.btnchuy.Click += new System.EventHandler(this.btnchuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Image = global::Visual_Periodic_Table.Properties.Resources.ok1;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOK.Location = new System.Drawing.Point(176, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 24);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Áp Dụng";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbXam);
            this.groupBox1.Controls.Add(this.rdbXanh);
            this.groupBox1.Controls.Add(this.rdbDo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặt Màu Sắt";
            // 
            // rdbXam
            // 
            this.rdbXam.AutoSize = true;
            this.rdbXam.Location = new System.Drawing.Point(184, 39);
            this.rdbXam.Name = "rdbXam";
            this.rdbXam.Size = new System.Drawing.Size(46, 17);
            this.rdbXam.TabIndex = 3;
            this.rdbXam.TabStop = true;
            this.rdbXam.Text = "Xám";
            this.rdbXam.UseVisualStyleBackColor = true;
            // 
            // rdbXanh
            // 
            this.rdbXanh.AutoSize = true;
            this.rdbXanh.Location = new System.Drawing.Point(118, 39);
            this.rdbXanh.Name = "rdbXanh";
            this.rdbXanh.Size = new System.Drawing.Size(50, 17);
            this.rdbXanh.TabIndex = 2;
            this.rdbXanh.TabStop = true;
            this.rdbXanh.Text = "Xanh";
            this.rdbXanh.UseVisualStyleBackColor = true;
            // 
            // rdbDo
            // 
            this.rdbDo.AutoSize = true;
            this.rdbDo.Location = new System.Drawing.Point(73, 39);
            this.rdbDo.Name = "rdbDo";
            this.rdbDo.Size = new System.Drawing.Size(39, 17);
            this.rdbDo.TabIndex = 1;
            this.rdbDo.TabStop = true;
            this.rdbDo.Text = "Đỏ";
            this.rdbDo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Màu Nền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cỡ Chữ";
            // 
            // txbcochu
            // 
            this.txbcochu.Location = new System.Drawing.Point(85, 110);
            this.txbcochu.Name = "txbcochu";
            this.txbcochu.Size = new System.Drawing.Size(189, 20);
            this.txbcochu.TabIndex = 6;
            this.txbcochu.TextChanged += new System.EventHandler(this.txbcochu_TextChanged);
            // 
            // Cai_Dat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 199);
            this.Controls.Add(this.txbcochu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnchuy);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cai_Dat";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài Đặt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnchuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbXam;
        private System.Windows.Forms.RadioButton rdbXanh;
        private System.Windows.Forms.RadioButton rdbDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbcochu;
    }
}