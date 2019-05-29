namespace Visual_Periodic_Table
{
    partial class Nong_Do_Phan_Tram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nong_Do_Phan_Tram));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbmct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbmdd = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính nồng độ phần trăm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khối lượng chất tan";
            // 
            // txbmct
            // 
            this.txbmct.Location = new System.Drawing.Point(181, 43);
            this.txbmct.Name = "txbmct";
            this.txbmct.Size = new System.Drawing.Size(100, 20);
            this.txbmct.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khối lượng dung dịch";
            // 
            // txbmdd
            // 
            this.txbmdd.Location = new System.Drawing.Point(181, 77);
            this.txbmdd.Name = "txbmdd";
            this.txbmdd.Size = new System.Drawing.Size(100, 20);
            this.txbmdd.TabIndex = 4;
            // 
            // btntinh
            // 
            this.btntinh.Image = global::Visual_Periodic_Table.Properties.Resources.ok;
            this.btntinh.Location = new System.Drawing.Point(22, 101);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 57);
            this.btntinh.TabIndex = 5;
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // btnce
            // 
            this.btnce.BackColor = System.Drawing.Color.Red;
            this.btnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnce.Location = new System.Drawing.Point(104, 101);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(75, 57);
            this.btnce.TabIndex = 6;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = false;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Image = global::Visual_Periodic_Table.Properties.Resources.home;
            this.button1.Location = new System.Drawing.Point(181, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nong_Do_Phan_Tram
            // 
            this.AcceptButton = this.btntinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 163);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txbmdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbmct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nong_Do_Phan_Tram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nồng độ phần trăm";
            this.Load += new System.EventHandler(this.Nong_Do_Phan_Tram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbmdd;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button button1;
    }
}