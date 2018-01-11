namespace QuanLiVatLieuXayDung.View.UC
{
    partial class ucThayDoiQuyDinh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThayDoiQuyDinh));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtGia);
            this.groupBox4.Controls.Add(this.btnCapnhat);
            this.groupBox4.Controls.Add(this.btnXacnhan);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // txtGia
            // 
            resources.ApplyResources(this.txtGia, "txtGia");
            this.txtGia.Name = "txtGia";
            // 
            // btnCapnhat
            // 
            resources.ApplyResources(this.btnCapnhat, "btnCapnhat");
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXacnhan
            // 
            resources.ApplyResources(this.btnXacnhan, "btnXacnhan");
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // ucThayDoiQuyDinh
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Name = "ucThayDoiQuyDinh";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnCapnhat;
    }
}
