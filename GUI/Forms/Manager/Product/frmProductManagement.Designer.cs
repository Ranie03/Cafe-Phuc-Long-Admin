namespace GUI.Forms.Manager
{
    partial class frmProductManagement
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_Category = new System.Windows.Forms.Label();
            this.panel_ProductList = new System.Windows.Forms.Panel();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.listView_ProductList = new System.Windows.Forms.ListView();
            this.panel_ProductList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(281, 22);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(339, 46);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Thông Tin Sản Phẩm";
            // 
            // lb_Category
            // 
            this.lb_Category.AutoSize = true;
            this.lb_Category.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Category.Location = new System.Drawing.Point(16, 19);
            this.lb_Category.Name = "lb_Category";
            this.lb_Category.Size = new System.Drawing.Size(118, 31);
            this.lb_Category.TabIndex = 1;
            this.lb_Category.Text = "Danh mục";
            // 
            // panel_ProductList
            // 
            this.panel_ProductList.Controls.Add(this.listView_ProductList);
            this.panel_ProductList.Controls.Add(this.comboBox_Categories);
            this.panel_ProductList.Controls.Add(this.lb_Category);
            this.panel_ProductList.Location = new System.Drawing.Point(12, 182);
            this.panel_ProductList.Name = "panel_ProductList";
            this.panel_ProductList.Size = new System.Drawing.Size(918, 339);
            this.panel_ProductList.TabIndex = 2;
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(150, 16);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(291, 34);
            this.comboBox_Categories.TabIndex = 2;
            // 
            // listView_ProductList
            // 
            this.listView_ProductList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ProductList.HideSelection = false;
            this.listView_ProductList.Location = new System.Drawing.Point(12, 70);
            this.listView_ProductList.Name = "listView_ProductList";
            this.listView_ProductList.Size = new System.Drawing.Size(894, 254);
            this.listView_ProductList.TabIndex = 3;
            this.listView_ProductList.UseCompatibleStateImageBehavior = false;
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 533);
            this.Controls.Add(this.panel_ProductList);
            this.Controls.Add(this.lb_Title);
            this.Name = "frmProductManagement";
            this.Text = "frmProductManagement";
            this.panel_ProductList.ResumeLayout(false);
            this.panel_ProductList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_Category;
        private System.Windows.Forms.Panel panel_ProductList;
        private System.Windows.Forms.ComboBox comboBox_Categories;
        private System.Windows.Forms.ListView listView_ProductList;
    }
}