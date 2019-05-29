namespace Visual_Periodic_Table
{
    partial class Tinh_Mol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tinh_Mol));
            this.label1 = new System.Windows.Forms.Label();
            this.txbchattan = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.txbthe = new System.Windows.Forms.TextBox();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số mol chất tan";
            // 
            // txbchattan
            // 
            this.txbchattan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbchattan.Location = new System.Drawing.Point(16, 32);
            this.txbchattan.Name = "txbchattan";
            this.txbchattan.Size = new System.Drawing.Size(236, 26);
            this.txbchattan.TabIndex = 1;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(16, 65);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(189, 20);
            this.l.TabIndex = 2;
            this.l.Text = "Nhập thể tích dung dịch(l)";
            // 
            // txbthe
            // 
            this.txbthe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbthe.Location = new System.Drawing.Point(16, 89);
            this.txbthe.Name = "txbthe";
            this.txbthe.Size = new System.Drawing.Size(236, 26);
            this.txbthe.TabIndex = 3;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Yellow;
            this.btnhome.Image = global::Visual_Periodic_Table.Properties.Resources.home;
            this.btnhome.Location = new System.Drawing.Point(177, 120);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(75, 65);
            this.btnhome.TabIndex = 4;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Red;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(96, 121);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 64);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "CE";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntinh
            // 
            this.btntinh.Image = global::Visual_Periodic_Table.Properties.Resources.ok;
            this.btntinh.Location = new System.Drawing.Point(16, 121);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 63);
            this.btntinh.TabIndex = 6;
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // Tinh_Mol
            // 
            this.AcceptButton = this.btntinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 199);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.txbthe);
            this.Controls.Add(this.l);
            this.Controls.Add(this.txbchattan);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tinh_Mol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính nồng độ mol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbchattan;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox txbthe;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntinh;
    }
}