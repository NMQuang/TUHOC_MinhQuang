namespace demoXML
{
    partial class TimKiem
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
            this.labelTimKiem = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTimKiem
            // 
            this.labelTimKiem.AutoSize = true;
            this.labelTimKiem.Location = new System.Drawing.Point(38, 42);
            this.labelTimKiem.Name = "labelTimKiem";
            this.labelTimKiem.Size = new System.Drawing.Size(76, 13);
            this.labelTimKiem.TabIndex = 0;
            this.labelTimKiem.Text = "Tên nhân viên";
            this.labelTimKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 123);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(288, 176);
            this.textBox2.TabIndex = 2;
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(458, 31);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 3;
            this.buttonTim.Text = "TÌM";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Location = new System.Drawing.Point(41, 110);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(44, 13);
            this.labelKetQua.TabIndex = 4;
            this.labelKetQua.Text = "Kết quả";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(132, 31);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(288, 31);
            this.textSearch.TabIndex = 5;
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(536, 311);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelTimKiem);
            this.Name = "TimKiem";
            this.Text = "TimKiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimKiem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Label labelKetQua;
        private System.Windows.Forms.TextBox textSearch;
    }
}