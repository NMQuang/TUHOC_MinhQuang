namespace demoXML
{
    partial class ReadXml
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
            this.labelChonFile = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.comboBoxChon = new System.Windows.Forms.ComboBox();
            this.listBoxFile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelChonFile
            // 
            this.labelChonFile.AutoSize = true;
            this.labelChonFile.Location = new System.Drawing.Point(52, 41);
            this.labelChonFile.Name = "labelChonFile";
            this.labelChonFile.Size = new System.Drawing.Size(51, 13);
            this.labelChonFile.TabIndex = 0;
            this.labelChonFile.Text = "Chọn File";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(416, 31);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // comboBoxChon
            // 
            this.comboBoxChon.FormattingEnabled = true;
            this.comboBoxChon.Location = new System.Drawing.Point(140, 41);
            this.comboBoxChon.Name = "comboBoxChon";
            this.comboBoxChon.Size = new System.Drawing.Size(225, 21);
            this.comboBoxChon.TabIndex = 4;
            // 
            // listBoxFile
            // 
            this.listBoxFile.FormattingEnabled = true;
            this.listBoxFile.Location = new System.Drawing.Point(55, 89);
            this.listBoxFile.Name = "listBoxFile";
            this.listBoxFile.Size = new System.Drawing.Size(356, 134);
            this.listBoxFile.TabIndex = 5;
            // 
            // ReadXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 261);
            this.Controls.Add(this.listBoxFile);
            this.Controls.Add(this.comboBoxChon);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.labelChonFile);
            this.Name = "ReadXml";
            this.Text = "ReadXml";
            this.Load += new System.EventHandler(this.ReadXml_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChonFile;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ComboBox comboBoxChon;
        private System.Windows.Forms.ListBox listBoxFile;
    }
}