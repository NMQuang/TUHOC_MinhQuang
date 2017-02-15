namespace QLSanPham
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
            this.btn_category = new DevComponents.DotNetBar.ButtonX();
            this.btn_product = new DevComponents.DotNetBar.ButtonX();
            this.listBox_category = new DevComponents.DotNetBar.ListBoxAdv();
            this.listBox_product = new DevComponents.DotNetBar.ListBoxAdv();
            this.SuspendLayout();
            // 
            // btn_category
            // 
            this.btn_category.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_category.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_category.Location = new System.Drawing.Point(89, 37);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(130, 23);
            this.btn_category.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_category.TabIndex = 0;
            this.btn_category.Text = "Lấy Category";
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_product
            // 
            this.btn_product.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_product.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_product.Location = new System.Drawing.Point(306, 36);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(141, 23);
            this.btn_product.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_product.TabIndex = 1;
            this.btn_product.Text = "Xóa Product";
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // listBox_category
            // 
            this.listBox_category.AutoScroll = true;
            // 
            // 
            // 
            this.listBox_category.BackgroundStyle.Class = "ListBoxAdv";
            this.listBox_category.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listBox_category.CheckStateMember = null;
            this.listBox_category.ContainerControlProcessDialogKey = true;
            this.listBox_category.DragDropSupport = true;
            this.listBox_category.Location = new System.Drawing.Point(89, 100);
            this.listBox_category.Name = "listBox_category";
            this.listBox_category.Size = new System.Drawing.Size(130, 123);
            this.listBox_category.TabIndex = 2;
            this.listBox_category.Text = "listBoxAdv1";
            this.listBox_category.SelectedIndexChanged += new System.EventHandler(this.listBox_category_SelectedIndexChanged);
            this.listBox_category.ItemClick += new System.EventHandler(this.listBox_category_ItemClick);
            // 
            // listBox_product
            // 
            this.listBox_product.AutoScroll = true;
            // 
            // 
            // 
            this.listBox_product.BackgroundStyle.Class = "ListBoxAdv";
            this.listBox_product.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listBox_product.CheckStateMember = null;
            this.listBox_product.ContainerControlProcessDialogKey = true;
            this.listBox_product.DragDropSupport = true;
            this.listBox_product.Location = new System.Drawing.Point(306, 100);
            this.listBox_product.Name = "listBox_product";
            this.listBox_product.Size = new System.Drawing.Size(141, 123);
            this.listBox_product.TabIndex = 3;
            this.listBox_product.Text = "listBoxAdv2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 261);
            this.Controls.Add(this.listBox_product);
            this.Controls.Add(this.listBox_category);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_category);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_category;
        private DevComponents.DotNetBar.ButtonX btn_product;
        private DevComponents.DotNetBar.ListBoxAdv listBox_category;
        private DevComponents.DotNetBar.ListBoxAdv listBox_product;
    }
}

