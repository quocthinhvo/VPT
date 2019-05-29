namespace Visual_Periodic_Table
{
    partial class Giai_Phuong_Trinh_Bac_Nhat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giai_Phuong_Trinh_Bac_Nhat));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txba = new System.Windows.Forms.TextBox();
            this.txbb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btngiai = new System.Windows.Forms.Button();
            this.btntrangchinh = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn hãy nhập các hệ số để giải phương trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            // 
            // txba
            // 
            this.txba.Location = new System.Drawing.Point(61, 32);
            this.txba.Name = "txba";
            this.txba.Size = new System.Drawing.Size(33, 20);
            this.txba.TabIndex = 2;
            // 
            // txbb
            // 
            this.txbb.Location = new System.Drawing.Point(146, 34);
            this.txbb.Name = "txbb";
            this.txbb.Size = new System.Drawing.Size(33, 20);
            this.txbb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "+";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "= 0";
            // 
            // btngiai
            // 
            this.btngiai.BackColor = System.Drawing.Color.Lime;
            this.btngiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiai.Image = global::Visual_Periodic_Table.Properties.Resources.ok;
            this.btngiai.Location = new System.Drawing.Point(16, 63);
            this.btngiai.Name = "btngiai";
            this.btngiai.Size = new System.Drawing.Size(75, 59);
            this.btngiai.TabIndex = 7;
            this.btngiai.UseVisualStyleBackColor = false;
            this.btngiai.Click += new System.EventHandler(this.btngiai_Click);
            // 
            // btntrangchinh
            // 
            this.btntrangchinh.BackColor = System.Drawing.Color.Yellow;
            this.btntrangchinh.ForeColor = System.Drawing.SystemColors.Control;
            this.btntrangchinh.Image = global::Visual_Periodic_Table.Properties.Resources.home;
            this.btntrangchinh.Location = new System.Drawing.Point(178, 62);
            this.btntrangchinh.Name = "btntrangchinh";
            this.btntrangchinh.Size = new System.Drawing.Size(75, 60);
            this.btntrangchinh.TabIndex = 8;
            this.btntrangchinh.UseVisualStyleBackColor = false;
            this.btntrangchinh.Click += new System.EventHandler(this.btntrangchinh_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::Visual_Periodic_Table.Properties.Resources.cancel_button;
            this.btnthoat.Location = new System.Drawing.Point(256, 62);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 59);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnce
            // 
            this.btnce.BackColor = System.Drawing.Color.Red;
            this.btnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnce.Location = new System.Drawing.Point(97, 63);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(75, 59);
            this.btnce.TabIndex = 10;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = false;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // Giai_Phuong_Trinh_Bac_Nhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 133);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntrangchinh);
            this.Controls.Add(this.btngiai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbb);
            this.Controls.Add(this.txba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giai_Phuong_Trinh_Bac_Nhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải phương trình bậc nhất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txba;
        private System.Windows.Forms.TextBox txbb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngiai;
        private System.Windows.Forms.Button btntrangchinh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnce;
    }
}