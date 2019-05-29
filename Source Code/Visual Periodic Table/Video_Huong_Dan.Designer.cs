namespace Visual_Periodic_Table
{
    partial class Video_Huong_Dan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video_Huong_Dan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.play = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.play);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 542);
            this.panel1.TabIndex = 0;
            // 
            // play
            // 
            this.play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play.Enabled = true;
            this.play.Location = new System.Drawing.Point(0, 0);
            this.play.Name = "play";
            this.play.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("play.OcxState")));
            this.play.Size = new System.Drawing.Size(1104, 542);
            this.play.TabIndex = 0;
            // 
            // Video_Huong_Dan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 542);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Video_Huong_Dan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng dẫn sử dụng phần mềm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Video_Huong_Dan_FormClosed);
            this.Load += new System.EventHandler(this.Video_Huong_Dan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer play;
    }
}