namespace demoXML
{
    partial class Form1
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
            this.labelChiNhanh = new System.Windows.Forms.Label();
            this.labelDonVi = new System.Windows.Forms.Label();
            this.labelNhanVien = new System.Windows.Forms.Label();
            this.textChiNhanh = new System.Windows.Forms.TextBox();
            this.textDonVi = new System.Windows.Forms.TextBox();
            this.textNhanVien = new System.Windows.Forms.TextBox();
            this.buttonTiep = new System.Windows.Forms.Button();
            this.buttonGhi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChiNhanh
            // 
            this.labelChiNhanh.AutoSize = true;
            this.labelChiNhanh.Location = new System.Drawing.Point(33, 32);
            this.labelChiNhanh.Name = "labelChiNhanh";
            this.labelChiNhanh.Size = new System.Drawing.Size(55, 13);
            this.labelChiNhanh.TabIndex = 0;
            this.labelChiNhanh.Text = "Chi nhánh";
            // 
            // labelDonVi
            // 
            this.labelDonVi.AutoSize = true;
            this.labelDonVi.Location = new System.Drawing.Point(33, 96);
            this.labelDonVi.Name = "labelDonVi";
            this.labelDonVi.Size = new System.Drawing.Size(38, 13);
            this.labelDonVi.TabIndex = 1;
            this.labelDonVi.Text = "Đơn vị";
            // 
            // labelNhanVien
            // 
            this.labelNhanVien.AutoSize = true;
            this.labelNhanVien.Location = new System.Drawing.Point(33, 168);
            this.labelNhanVien.Name = "labelNhanVien";
            this.labelNhanVien.Size = new System.Drawing.Size(56, 13);
            this.labelNhanVien.TabIndex = 2;
            this.labelNhanVien.Text = "Nhân viên";
            // 
            // textChiNhanh
            // 
            this.textChiNhanh.Location = new System.Drawing.Point(129, 12);
            this.textChiNhanh.Multiline = true;
            this.textChiNhanh.Name = "textChiNhanh";
            this.textChiNhanh.Size = new System.Drawing.Size(224, 33);
            this.textChiNhanh.TabIndex = 3;
            // 
            // textDonVi
            // 
            this.textDonVi.Location = new System.Drawing.Point(129, 73);
            this.textDonVi.Multiline = true;
            this.textDonVi.Name = "textDonVi";
            this.textDonVi.Size = new System.Drawing.Size(224, 36);
            this.textDonVi.TabIndex = 4;
            // 
            // textNhanVien
            // 
            this.textNhanVien.Location = new System.Drawing.Point(129, 143);
            this.textNhanVien.Multiline = true;
            this.textNhanVien.Name = "textNhanVien";
            this.textNhanVien.Size = new System.Drawing.Size(224, 38);
            this.textNhanVien.TabIndex = 5;
            // 
            // buttonTiep
            // 
            this.buttonTiep.Location = new System.Drawing.Point(129, 214);
            this.buttonTiep.Name = "buttonTiep";
            this.buttonTiep.Size = new System.Drawing.Size(75, 23);
            this.buttonTiep.TabIndex = 6;
            this.buttonTiep.Text = "Tiếp";
            this.buttonTiep.UseVisualStyleBackColor = true;
            this.buttonTiep.Click += new System.EventHandler(this.buttonTiep_Click);
            // 
            // buttonGhi
            // 
            this.buttonGhi.Location = new System.Drawing.Point(308, 213);
            this.buttonGhi.Name = "buttonGhi";
            this.buttonGhi.Size = new System.Drawing.Size(75, 23);
            this.buttonGhi.TabIndex = 7;
            this.buttonGhi.Text = "Ghi ra";
            this.buttonGhi.UseVisualStyleBackColor = true;
            this.buttonGhi.Click += new System.EventHandler(this.buttonGhi_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 261);
            this.Controls.Add(this.buttonGhi);
            this.Controls.Add(this.buttonTiep);
            this.Controls.Add(this.textNhanVien);
            this.Controls.Add(this.textDonVi);
            this.Controls.Add(this.textChiNhanh);
            this.Controls.Add(this.labelNhanVien);
            this.Controls.Add(this.labelDonVi);
            this.Controls.Add(this.labelChiNhanh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChiNhanh;
        private System.Windows.Forms.Label labelDonVi;
        private System.Windows.Forms.Label labelNhanVien;
        private System.Windows.Forms.TextBox textChiNhanh;
        private System.Windows.Forms.TextBox textDonVi;
        private System.Windows.Forms.TextBox textNhanVien;
        private System.Windows.Forms.Button buttonTiep;
        private System.Windows.Forms.Button buttonGhi;
    }
}

