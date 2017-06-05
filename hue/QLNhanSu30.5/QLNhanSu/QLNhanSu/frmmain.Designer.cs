namespace QLNhanSu
{
    partial class frmmain
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnphongbant = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnhelp);
            this.groupBox1.Controls.Add(this.btnnhanvien);
            this.groupBox1.Controls.Add(this.btnphongbant);
            this.groupBox1.Location = new System.Drawing.Point(42, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnhelp
            // 
            this.btnhelp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhelp.ForeColor = System.Drawing.Color.Blue;
            this.btnhelp.Image = global::QLNhanSu.Properties.Resources.help;
            this.btnhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhelp.Location = new System.Drawing.Point(411, 19);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(98, 56);
            this.btnhelp.TabIndex = 6;
            this.btnhelp.Text = "Help";
            this.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhelp.UseVisualStyleBackColor = false;
            this.btnhelp.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnhanvien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnhanvien.ForeColor = System.Drawing.Color.Blue;
            this.btnnhanvien.Image = global::QLNhanSu.Properties.Resources.users;
            this.btnnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhanvien.Location = new System.Drawing.Point(47, 19);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(128, 54);
            this.btnnhanvien.TabIndex = 4;
            this.btnnhanvien.Text = "Nhân viên";
            this.btnnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhanvien.UseVisualStyleBackColor = false;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btnphongbant
            // 
            this.btnphongbant.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnphongbant.ForeColor = System.Drawing.Color.Blue;
            this.btnphongbant.Image = global::QLNhanSu.Properties.Resources.database;
            this.btnphongbant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnphongbant.Location = new System.Drawing.Point(238, 19);
            this.btnphongbant.Name = "btnphongbant";
            this.btnphongbant.Size = new System.Drawing.Size(119, 54);
            this.btnphongbant.TabIndex = 5;
            this.btnphongbant.Text = "Phòng Ban";
            this.btnphongbant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnphongbant.UseVisualStyleBackColor = false;
            this.btnphongbant.Click += new System.EventHandler(this.btnphieuxuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = global::QLNhanSu.Properties.Resources.danh_gia_chon_lua_nhan_su_cap_cao;
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 287);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmmain";
            this.Text = "frmmain";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button btnphongbant;
        private System.Windows.Forms.Button btnhelp;
    }
}