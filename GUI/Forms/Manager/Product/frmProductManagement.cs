using BLL.Services;
using BLL.Services.Category;
using BLL.Services.ProductDetail;
using BLL.Services.Recipe;
using BLL.Services.Size;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.Forms.Manager
{
    public partial class frmProductManagement : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IProductDetailService _productDetailService;
        private readonly ISizeService _sizeService;
        private readonly IRecipeService _recipeService;

        public frmProductManagement(
            IProductService productService,
            ICategoryService categoryService,
            IProductDetailService productDetailService,
            ISizeService sizeService,
            IRecipeService recipeService
            )
        {
            this._categoryService = categoryService;
            this._productService = productService;
            this._productDetailService = productDetailService;
            this._sizeService = sizeService;
            this._recipeService = recipeService;
            InitializeComponent();
            this.Load += FrmProductManagement_Load;
        }

        private void FrmProductManagement_Load(object sender, EventArgs e)
        {

            listView_ProductList_Config();
            LoadProductsToListView();
            listView_CategoriesList_Config();
            LoadCategoriesToListView();
            listView_ProductDetailList_Config();
            listView_SizeList_Config();
            LoadSizeToListView();
            LoadDataToComboBoxUnit();
            LoadCategoriesToComboBox();
            LoadRecipesToComboBox();
        }



        #region Định nghĩa các hàm sử dụng

        private void listView_ProductList_Config()
        {
            listView_ProductList.View = View.Details;
            listView_ProductList.FullRowSelect = true;
            listView_ProductList.GridLines = true;
            listView_ProductList.MultiSelect = false;
            listView_ProductList.Items.Clear();
            listView_ProductList.Columns.Add("Mã sản phẩm", 100);
            listView_ProductList.Columns.Add("Tên sản phẩm", 200);
            listView_ProductList.Columns.Add("Hình ảnh", 200);
            listView_ProductList.Columns.Add("Đơn vị tính", 100);
            listView_ProductList.Columns.Add("Mô tả", 350);
        }
        private void LoadProductsToListView()
        {
            listView_ProductList.Items.Clear();
            var products = _productService.GetProductList();

            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.maSP);
                item.SubItems.Add(product.tenSP);
                item.SubItems.Add(product.hinhAnh);
                item.SubItems.Add(product.donViTinh);
                item.SubItems.Add(product.moTa);
                item.Tag = product;

                listView_ProductList.Items.Add(item);
            }

        }
        private void listView_CategoriesList_Config()
        {
            listView_CategoryList.View = View.Details;
            listView_CategoryList.FullRowSelect = true;
            listView_CategoryList.GridLines = true;
            listView_CategoryList.MultiSelect = false;
            listView_CategoryList.Items.Clear();

            listView_CategoryList.Columns.Add("Mã danh mục", 100);
            listView_CategoryList.Columns.Add("Tên danh mục", 200);
            listView_CategoryList.Columns.Add("Mô tả", 350);
        }
        private void LoadCategoriesToListView()
        {
            listView_CategoryList.Items.Clear();
            var categories = _categoryService.GetCategoriesList();

            foreach (var category in categories)
            {
                ListViewItem item = new ListViewItem(category.maDM);
                item.SubItems.Add(category.tenDM);
                item.SubItems.Add(category.moTa);
                listView_CategoryList.Items.Add(item);
            }
        }
        private void LoadProductsByCategoryId(string categoryId)
        {
            listView_ProductList.Items.Clear();
            var products = _productService.GetProductByCategoryId(categoryId);

            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.maSP);
                item.SubItems.Add(product.tenSP);
                item.SubItems.Add(product.hinhAnh);
                item.SubItems.Add(product.donViTinh);
                item.SubItems.Add(product.moTa);
                item.Tag = product; 

                listView_ProductList.Items.Add(item);
            }
        }



        #endregion

        private void listView_CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_CategoryList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_CategoryList.SelectedItems[0];
                string categoryName = selectedItem.SubItems[1].Text;

                string categoryId = selectedItem.Text;

                if (categoryId == "")
                {
                    txt_nameCategory.Text = "";

                    LoadProductsToListView();
                }
                else
                {
                    txt_nameCategory.Text = categoryName;
                    LoadProductsByCategoryId(categoryId);
                }
            }

        }
        private void listView_ProductDetailList_Config()
        {
            listView_productDetailList.View = View.Details;
            listView_productDetailList.FullRowSelect = true;
            listView_productDetailList.GridLines = true;
            listView_productDetailList.MultiSelect = false;
            listView_productDetailList.Items.Clear();
            listView_productDetailList.Columns.Add("Size", 100);
            listView_productDetailList.Columns.Add("Đơn giá", 200);
        }
        private void LoadProductDetailToListView()
        {
            listView_productDetailList.Items.Clear();
            var productDetails = _productDetailService.GetProductDetailList();

            foreach (var productDetail in productDetails)
            {
                ListViewItem item = new ListViewItem(productDetail.maSize);
                item.SubItems.Add(productDetail.donGia.ToString());
                listView_productDetailList.Items.Add(item);
            }
        }
        private void LoadProductDetailsByProductId(string ProductId)
        {
            listView_productDetailList.Items.Clear();
            var productDetails = _productDetailService.GetProductDetailsByProductId(ProductId);

            foreach (var productDetail in productDetails)
            {
                ListViewItem item = new ListViewItem(productDetail.maSize);
                item.SubItems.Add(productDetail.donGia.ToString());
                listView_productDetailList.Items.Add(item);
            }
        }

        private void listView_ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_ProductList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_ProductList.SelectedItems[0];
                var product = (SanPham)selectedItem.Tag;
                string productId = selectedItem.Text;

                if (productId == "")
                {
                    LoadProductDetailToListView();
                }
                else
                {
                    string productName = selectedItem.SubItems[1].Text;
                    string productImage = selectedItem.SubItems[2].Text;
                    string productUnit = selectedItem.SubItems[3].Text;
                    string productDescription = selectedItem.SubItems[4].Text;
                    txt_nameProduct.Text = productName;
                    txt_imageProduct.Text = productImage;
                    txt_descriptionProduct.Text = productDescription;
                    checkBox_newProduct.Checked = product.spMoi == true;
                    checkBox_bestSeller.Checked = product.spNoiBat == true;
                    SelectInComboBox(product.maDM, product.maCT);
                    LoadProductDetailsByProductId(productId);
                }
            }
        }
        private void SelectInComboBox(string maDM,string maCT)
        {
            foreach (var item in comboBox_Categories.Items)
            {
                var category = item as DanhMuc;
                if (category != null && category.maDM == maDM)
                {
                    comboBox_Categories.SelectedItem = item;
                    break;
                }
            }
            foreach (var item in comboBox_recipe.Items)
            {
                var recipe = item as CongThuc;
                if (recipe != null && recipe.maCT == maCT)
                {
                    comboBox_recipe.SelectedItem = item;
                    break;
                }
            }
        }
        private void listView_SizeList_Config()
        {
            listView_sizeList.View = View.Details;
            listView_sizeList.FullRowSelect = true;
            listView_sizeList.GridLines = true;
            listView_sizeList.MultiSelect = false;
            listView_sizeList.Items.Clear();
            listView_sizeList.Columns.Add("Mã size", 100);
            listView_sizeList.Columns.Add("Tên Size", 100);
            listView_sizeList.Columns.Add("ghi chú", 200);
        }
        private void LoadSizeToListView()
        {
            listView_sizeList.Items.Clear();
            var sizes = _sizeService.GetSizeList();

            foreach (var size in sizes)
            {
                ListViewItem item = new ListViewItem(size.maSize);
                item.SubItems.Add(size.tenSize);
                item.SubItems.Add(size.ghiChu);
                listView_sizeList.Items.Add(item);
            }
        }

        private void listView_sizeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_sizeList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_sizeList.SelectedItems[0];
                string sizeId = selectedItem.Text;

                if (sizeId == "")
                {
                    LoadSizeToListView();
                }
                else
                {
                    string sizeName = selectedItem.SubItems[1].Text;
                    string sizeNote = selectedItem.SubItems[2].Text;
                    txt_nameSize.Text = sizeName;
                    txt_noteSize.Text = sizeNote;

                }
            }
        }
        private void LoadDataToComboBoxUnit()
        {
            string[] units = { "Túi", "Gói", "Hộp", "Ly" };

            comboBox_unit.Items.Clear();
            comboBox_unit.Items.AddRange(units);
        }
        private void LoadCategoriesToComboBox()
        {
            var categories = _categoryService.GetCategoriesList();

            comboBox_Categories.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_Categories.DataSource = categories;
            comboBox_Categories.DisplayMember = "tenDM";
            comboBox_Categories.ValueMember = "maDM";
        }
        private void LoadRecipesToComboBox()
        {
            var recipes = _recipeService.GetRecipeList();

            comboBox_recipe.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_recipe.DataSource = recipes;
            comboBox_recipe.DisplayMember = "tenCT";
            comboBox_recipe.ValueMember = "maCT";
        }
    }
}
