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
            this.listView_CategoryList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nameCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_showAllCategories = new System.Windows.Forms.Button();
            this.btn_searchCategory = new System.Windows.Forms.Button();
            this.txt_searchCategory = new System.Windows.Forms.TextBox();
            this.btn_deleteCategory = new System.Windows.Forms.Button();
            this.btn_EditCategory = new System.Windows.Forms.Button();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.listView_ProductList = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_searchProductDetail = new System.Windows.Forms.Button();
            this.txt_searchProductDetail = new System.Windows.Forms.TextBox();
            this.btn_deleteProductDetail = new System.Windows.Forms.Button();
            this.btn_editProductDetail = new System.Windows.Forms.Button();
            this.btn_addProductDetail = new System.Windows.Forms.Button();
            this.listView_productDetailList = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_recipe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_newProduct = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_bestSeller = new System.Windows.Forms.CheckBox();
            this.txt_descriptionProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_unit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_imageProduct = new System.Windows.Forms.Label();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nameProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_nameSize = new System.Windows.Forms.TextBox();
            this.txt_noteSize = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_showAllSize = new System.Windows.Forms.Button();
            this.btn_searchSize = new System.Windows.Forms.Button();
            this.txt_searchSize = new System.Windows.Forms.TextBox();
            this.btn_deleteSize = new System.Windows.Forms.Button();
            this.btn_editSize = new System.Windows.Forms.Button();
            this.btn_addSize = new System.Windows.Forms.Button();
            this.listView_sizeList = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(613, 28);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(288, 45);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Quản lý sản phẩm";
            // 
            // listView_CategoryList
            // 
            this.listView_CategoryList.HideSelection = false;
            this.listView_CategoryList.Location = new System.Drawing.Point(6, 80);
            this.listView_CategoryList.Name = "listView_CategoryList";
            this.listView_CategoryList.Size = new System.Drawing.Size(387, 495);
            this.listView_CategoryList.TabIndex = 3;
            this.listView_CategoryList.UseCompatibleStateImageBehavior = false;
            this.listView_CategoryList.SelectedIndexChanged += new System.EventHandler(this.listView_CategoryList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nameCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_showAllCategories);
            this.groupBox1.Controls.Add(this.btn_searchCategory);
            this.groupBox1.Controls.Add(this.txt_searchCategory);
            this.groupBox1.Controls.Add(this.btn_deleteCategory);
            this.groupBox1.Controls.Add(this.btn_EditCategory);
            this.groupBox1.Controls.Add(this.btn_addCategory);
            this.groupBox1.Controls.Add(this.listView_CategoryList);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 684);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục";
            // 
            // txt_nameCategory
            // 
            this.txt_nameCategory.Location = new System.Drawing.Point(126, 592);
            this.txt_nameCategory.Name = "txt_nameCategory";
            this.txt_nameCategory.Size = new System.Drawing.Size(229, 22);
            this.txt_nameCategory.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên danh mục";
            // 
            // btn_showAllCategories
            // 
            this.btn_showAllCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAllCategories.Location = new System.Drawing.Point(300, 30);
            this.btn_showAllCategories.Name = "btn_showAllCategories";
            this.btn_showAllCategories.Size = new System.Drawing.Size(93, 31);
            this.btn_showAllCategories.TabIndex = 9;
            this.btn_showAllCategories.Text = "Tất cả";
            this.btn_showAllCategories.UseVisualStyleBackColor = true;
            // 
            // btn_searchCategory
            // 
            this.btn_searchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchCategory.Location = new System.Drawing.Point(146, 34);
            this.btn_searchCategory.Name = "btn_searchCategory";
            this.btn_searchCategory.Size = new System.Drawing.Size(93, 31);
            this.btn_searchCategory.TabIndex = 8;
            this.btn_searchCategory.Text = "Tìm kiếm";
            this.btn_searchCategory.UseVisualStyleBackColor = true;
            // 
            // txt_searchCategory
            // 
            this.txt_searchCategory.Location = new System.Drawing.Point(6, 39);
            this.txt_searchCategory.Name = "txt_searchCategory";
            this.txt_searchCategory.Size = new System.Drawing.Size(134, 22);
            this.txt_searchCategory.TabIndex = 7;
            // 
            // btn_deleteCategory
            // 
            this.btn_deleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteCategory.Location = new System.Drawing.Point(284, 635);
            this.btn_deleteCategory.Name = "btn_deleteCategory";
            this.btn_deleteCategory.Size = new System.Drawing.Size(109, 31);
            this.btn_deleteCategory.TabIndex = 6;
            this.btn_deleteCategory.Text = "Xoá";
            this.btn_deleteCategory.UseVisualStyleBackColor = true;
            // 
            // btn_EditCategory
            // 
            this.btn_EditCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditCategory.Location = new System.Drawing.Point(138, 635);
            this.btn_EditCategory.Name = "btn_EditCategory";
            this.btn_EditCategory.Size = new System.Drawing.Size(119, 31);
            this.btn_EditCategory.TabIndex = 5;
            this.btn_EditCategory.Text = "Sửa ";
            this.btn_EditCategory.UseVisualStyleBackColor = true;
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCategory.Location = new System.Drawing.Point(6, 635);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(103, 31);
            this.btn_addCategory.TabIndex = 4;
            this.btn_addCategory.Text = "Thêm";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            // 
            // listView_ProductList
            // 
            this.listView_ProductList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ProductList.HideSelection = false;
            this.listView_ProductList.Location = new System.Drawing.Point(17, 80);
            this.listView_ProductList.Name = "listView_ProductList";
            this.listView_ProductList.Size = new System.Drawing.Size(782, 285);
            this.listView_ProductList.TabIndex = 3;
            this.listView_ProductList.UseCompatibleStateImageBehavior = false;
            this.listView_ProductList.SelectedIndexChanged += new System.EventHandler(this.listView_ProductList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_size);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox_price);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.btn_searchProductDetail);
            this.groupBox2.Controls.Add(this.txt_searchProductDetail);
            this.groupBox2.Controls.Add(this.btn_deleteProductDetail);
            this.groupBox2.Controls.Add(this.btn_editProductDetail);
            this.groupBox2.Controls.Add(this.btn_addProductDetail);
            this.groupBox2.Controls.Add(this.listView_productDetailList);
            this.groupBox2.Location = new System.Drawing.Point(1275, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 365);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // comboBox_size
            // 
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Location = new System.Drawing.Point(63, 209);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(275, 24);
            this.comboBox_size.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Size";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(63, 261);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(275, 22);
            this.textBox_price.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Đơn giá";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(299, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 27);
            this.button6.TabIndex = 15;
            this.button6.Text = "Tất cả";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_searchProductDetail
            // 
            this.btn_searchProductDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchProductDetail.Location = new System.Drawing.Point(121, 28);
            this.btn_searchProductDetail.Name = "btn_searchProductDetail";
            this.btn_searchProductDetail.Size = new System.Drawing.Size(93, 31);
            this.btn_searchProductDetail.TabIndex = 8;
            this.btn_searchProductDetail.Text = "Tìm kiếm";
            this.btn_searchProductDetail.UseVisualStyleBackColor = true;
            // 
            // txt_searchProductDetail
            // 
            this.txt_searchProductDetail.Location = new System.Drawing.Point(6, 33);
            this.txt_searchProductDetail.Name = "txt_searchProductDetail";
            this.txt_searchProductDetail.Size = new System.Drawing.Size(97, 22);
            this.txt_searchProductDetail.TabIndex = 7;
            // 
            // btn_deleteProductDetail
            // 
            this.btn_deleteProductDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProductDetail.Location = new System.Drawing.Point(236, 317);
            this.btn_deleteProductDetail.Name = "btn_deleteProductDetail";
            this.btn_deleteProductDetail.Size = new System.Drawing.Size(102, 31);
            this.btn_deleteProductDetail.TabIndex = 6;
            this.btn_deleteProductDetail.Text = "Xoá";
            this.btn_deleteProductDetail.UseVisualStyleBackColor = true;
            // 
            // btn_editProductDetail
            // 
            this.btn_editProductDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editProductDetail.Location = new System.Drawing.Point(121, 317);
            this.btn_editProductDetail.Name = "btn_editProductDetail";
            this.btn_editProductDetail.Size = new System.Drawing.Size(105, 31);
            this.btn_editProductDetail.TabIndex = 5;
            this.btn_editProductDetail.Text = "Sửa ";
            this.btn_editProductDetail.UseVisualStyleBackColor = true;
            // 
            // btn_addProductDetail
            // 
            this.btn_addProductDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProductDetail.Location = new System.Drawing.Point(12, 317);
            this.btn_addProductDetail.Name = "btn_addProductDetail";
            this.btn_addProductDetail.Size = new System.Drawing.Size(103, 31);
            this.btn_addProductDetail.TabIndex = 4;
            this.btn_addProductDetail.Text = "Thêm";
            this.btn_addProductDetail.UseVisualStyleBackColor = true;
            // 
            // listView_productDetailList
            // 
            this.listView_productDetailList.HideSelection = false;
            this.listView_productDetailList.Location = new System.Drawing.Point(6, 61);
            this.listView_productDetailList.Name = "listView_productDetailList";
            this.listView_productDetailList.Size = new System.Drawing.Size(370, 126);
            this.listView_productDetailList.TabIndex = 3;
            this.listView_productDetailList.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_Categories);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboBox_status);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboBox_recipe);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.txt_descriptionProduct);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox_unit);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_imageProduct);
            this.groupBox3.Controls.Add(this.btn_Upload);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_nameProduct);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.listView_ProductList);
            this.groupBox3.Location = new System.Drawing.Point(453, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(816, 703);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm";
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(557, 381);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(218, 24);
            this.comboBox_Categories.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(473, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Danh mục";
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(557, 480);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(218, 24);
            this.comboBox_status.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(473, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Trạng thái";
            // 
            // comboBox_recipe
            // 
            this.comboBox_recipe.FormattingEnabled = true;
            this.comboBox_recipe.Location = new System.Drawing.Point(557, 429);
            this.comboBox_recipe.Name = "comboBox_recipe";
            this.comboBox_recipe.Size = new System.Drawing.Size(218, 24);
            this.comboBox_recipe.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Công thức";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.checkBox_newProduct);
            this.panel2.Location = new System.Drawing.Point(460, 569);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 35);
            this.panel2.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Sản phẩm mới";
            // 
            // checkBox_newProduct
            // 
            this.checkBox_newProduct.AutoSize = true;
            this.checkBox_newProduct.Location = new System.Drawing.Point(163, 9);
            this.checkBox_newProduct.Name = "checkBox_newProduct";
            this.checkBox_newProduct.Size = new System.Drawing.Size(18, 17);
            this.checkBox_newProduct.TabIndex = 26;
            this.checkBox_newProduct.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.checkBox_bestSeller);
            this.panel1.Location = new System.Drawing.Point(460, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 35);
            this.panel1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sản phẩm nổi bật";
            // 
            // checkBox_bestSeller
            // 
            this.checkBox_bestSeller.AutoSize = true;
            this.checkBox_bestSeller.Location = new System.Drawing.Point(163, 9);
            this.checkBox_bestSeller.Name = "checkBox_bestSeller";
            this.checkBox_bestSeller.Size = new System.Drawing.Size(18, 17);
            this.checkBox_bestSeller.TabIndex = 26;
            this.checkBox_bestSeller.UseVisualStyleBackColor = true;
            // 
            // txt_descriptionProduct
            // 
            this.txt_descriptionProduct.Location = new System.Drawing.Point(149, 520);
            this.txt_descriptionProduct.Multiline = true;
            this.txt_descriptionProduct.Name = "txt_descriptionProduct";
            this.txt_descriptionProduct.Size = new System.Drawing.Size(218, 80);
            this.txt_descriptionProduct.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mô tả";
            // 
            // comboBox_unit
            // 
            this.comboBox_unit.FormattingEnabled = true;
            this.comboBox_unit.Location = new System.Drawing.Point(149, 474);
            this.comboBox_unit.Name = "comboBox_unit";
            this.comboBox_unit.Size = new System.Drawing.Size(218, 24);
            this.comboBox_unit.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Đơn vị tính";
            // 
            // txt_imageProduct
            // 
            this.txt_imageProduct.AutoSize = true;
            this.txt_imageProduct.Location = new System.Drawing.Point(276, 432);
            this.txt_imageProduct.Name = "txt_imageProduct";
            this.txt_imageProduct.Size = new System.Drawing.Size(71, 16);
            this.txt_imageProduct.TabIndex = 20;
            this.txt_imageProduct.Text = "đường dẫn";
            // 
            // btn_Upload
            // 
            this.btn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.Location = new System.Drawing.Point(149, 424);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(109, 31);
            this.btn_Upload.TabIndex = 19;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hình ảnh";
            // 
            // txt_nameProduct
            // 
            this.txt_nameProduct.Location = new System.Drawing.Point(149, 383);
            this.txt_nameProduct.Name = "txt_nameProduct";
            this.txt_nameProduct.Size = new System.Drawing.Size(229, 22);
            this.txt_nameProduct.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên sản phẩm";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(706, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 31);
            this.button5.TabIndex = 14;
            this.button5.Text = "Tất cả";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(315, 653);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(168, 653);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sửa ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(30, 653);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 31);
            this.button4.TabIndex = 11;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(285, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 22);
            this.textBox1.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_nameSize);
            this.groupBox4.Controls.Add(this.txt_noteSize);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.btn_showAllSize);
            this.groupBox4.Controls.Add(this.btn_searchSize);
            this.groupBox4.Controls.Add(this.txt_searchSize);
            this.groupBox4.Controls.Add(this.btn_deleteSize);
            this.groupBox4.Controls.Add(this.btn_editSize);
            this.groupBox4.Controls.Add(this.btn_addSize);
            this.groupBox4.Controls.Add(this.listView_sizeList);
            this.groupBox4.Location = new System.Drawing.Point(1275, 464);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 332);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Size";
            // 
            // txt_nameSize
            // 
            this.txt_nameSize.Location = new System.Drawing.Point(86, 168);
            this.txt_nameSize.Name = "txt_nameSize";
            this.txt_nameSize.Size = new System.Drawing.Size(252, 22);
            this.txt_nameSize.TabIndex = 33;
            // 
            // txt_noteSize
            // 
            this.txt_noteSize.Location = new System.Drawing.Point(86, 207);
            this.txt_noteSize.Multiline = true;
            this.txt_noteSize.Name = "txt_noteSize";
            this.txt_noteSize.Size = new System.Drawing.Size(252, 66);
            this.txt_noteSize.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Tên size";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Ghi chú";
            // 
            // btn_showAllSize
            // 
            this.btn_showAllSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAllSize.Location = new System.Drawing.Point(299, 33);
            this.btn_showAllSize.Name = "btn_showAllSize";
            this.btn_showAllSize.Size = new System.Drawing.Size(77, 27);
            this.btn_showAllSize.TabIndex = 15;
            this.btn_showAllSize.Text = "Tất cả";
            this.btn_showAllSize.UseVisualStyleBackColor = true;
            // 
            // btn_searchSize
            // 
            this.btn_searchSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchSize.Location = new System.Drawing.Point(121, 28);
            this.btn_searchSize.Name = "btn_searchSize";
            this.btn_searchSize.Size = new System.Drawing.Size(93, 31);
            this.btn_searchSize.TabIndex = 8;
            this.btn_searchSize.Text = "Tìm kiếm";
            this.btn_searchSize.UseVisualStyleBackColor = true;
            // 
            // txt_searchSize
            // 
            this.txt_searchSize.Location = new System.Drawing.Point(6, 33);
            this.txt_searchSize.Name = "txt_searchSize";
            this.txt_searchSize.Size = new System.Drawing.Size(109, 22);
            this.txt_searchSize.TabIndex = 7;
            // 
            // btn_deleteSize
            // 
            this.btn_deleteSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteSize.Location = new System.Drawing.Point(232, 284);
            this.btn_deleteSize.Name = "btn_deleteSize";
            this.btn_deleteSize.Size = new System.Drawing.Size(102, 31);
            this.btn_deleteSize.TabIndex = 6;
            this.btn_deleteSize.Text = "Xoá";
            this.btn_deleteSize.UseVisualStyleBackColor = true;
            // 
            // btn_editSize
            // 
            this.btn_editSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editSize.Location = new System.Drawing.Point(121, 284);
            this.btn_editSize.Name = "btn_editSize";
            this.btn_editSize.Size = new System.Drawing.Size(105, 31);
            this.btn_editSize.TabIndex = 5;
            this.btn_editSize.Text = "Sửa ";
            this.btn_editSize.UseVisualStyleBackColor = true;
            // 
            // btn_addSize
            // 
            this.btn_addSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addSize.Location = new System.Drawing.Point(12, 284);
            this.btn_addSize.Name = "btn_addSize";
            this.btn_addSize.Size = new System.Drawing.Size(103, 31);
            this.btn_addSize.TabIndex = 4;
            this.btn_addSize.Text = "Thêm";
            this.btn_addSize.UseVisualStyleBackColor = true;
            // 
            // listView_sizeList
            // 
            this.listView_sizeList.HideSelection = false;
            this.listView_sizeList.Location = new System.Drawing.Point(6, 61);
            this.listView_sizeList.Name = "listView_sizeList";
            this.listView_sizeList.Size = new System.Drawing.Size(370, 91);
            this.listView_sizeList.TabIndex = 3;
            this.listView_sizeList.UseCompatibleStateImageBehavior = false;
            this.listView_sizeList.SelectedIndexChanged += new System.EventHandler(this.listView_sizeList_SelectedIndexChanged);
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1685, 808);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmProductManagement";
            this.Text = "frmProductManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.ListView listView_CategoryList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deleteCategory;
        private System.Windows.Forms.Button btn_EditCategory;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Button btn_searchCategory;
        private System.Windows.Forms.TextBox txt_searchCategory;
        private System.Windows.Forms.ListView listView_ProductList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_searchProductDetail;
        private System.Windows.Forms.TextBox txt_searchProductDetail;
        private System.Windows.Forms.Button btn_deleteProductDetail;
        private System.Windows.Forms.Button btn_editProductDetail;
        private System.Windows.Forms.Button btn_addProductDetail;
        private System.Windows.Forms.ListView listView_productDetailList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_showAllCategories;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_nameCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nameProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_unit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_imageProduct;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_bestSeller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_descriptionProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_newProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_recipe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_Categories;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_noteSize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_showAllSize;
        private System.Windows.Forms.Button btn_searchSize;
        private System.Windows.Forms.TextBox txt_searchSize;
        private System.Windows.Forms.Button btn_deleteSize;
        private System.Windows.Forms.Button btn_editSize;
        private System.Windows.Forms.Button btn_addSize;
        private System.Windows.Forms.ListView listView_sizeList;
        private System.Windows.Forms.TextBox txt_nameSize;
    }
}