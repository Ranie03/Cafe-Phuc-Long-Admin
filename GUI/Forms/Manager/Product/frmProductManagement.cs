using BLL.Services;
using BLL.Services.Category;
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
        public frmProductManagement(
            IProductService productService,
            ICategoryService categoryService
            )
        {
            this._categoryService = categoryService;
            this._productService = productService;
            InitializeComponent();
            this.Load += FrmProductManagement_Load;
        }

        private void FrmProductManagement_Load(object sender, EventArgs e)
        {
            // Sự kiện
            this.comboBox_Categories.SelectedIndexChanged += ComboBox_Categories_SelectedIndexChanged;

            // Cấu hình
            panel_ProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_ProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            
            LoadCategoriesToComboBox();
            listView_ProductList_Config();
            LoadProductsToListView();
        }

        private void ComboBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            DanhMuc category = comboBox_Categories.SelectedItem as DanhMuc;
            string categoryId = category.maDM;

            if ( categoryId == "0")
            {
                LoadProductsToListView();
            }
            else
            {
                LoadProductsByCategoryId(categoryId);
            }
        }

        #region Định nghĩa các hàm sử dụng

        private void listView_ProductList_Config()
        {
            listView_ProductList.View = View.Details;
            listView_ProductList.FullRowSelect = true;
            listView_ProductList.GridLines = true;
            listView_ProductList.MultiSelect = false;
            listView_ProductList.Items.Clear();

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
                ListViewItem item = new ListViewItem(product.tenSP);
                item.SubItems.Add(product.hinhAnh);
                item.SubItems.Add(product.donViTinh);
                item.SubItems.Add(product.moTa);
                listView_ProductList.Items.Add(item);
            }
        }
        private void LoadProductsByCategoryId(string categoryId)
        {
            listView_ProductList.Items.Clear();
            var products = _productService.GetProductByCategoryId(categoryId);

            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(product.tenSP);
                item.SubItems.Add(product.hinhAnh);
                item.SubItems.Add(product.donViTinh);
                item.SubItems.Add(product.moTa);
                listView_ProductList.Items.Add(item);
            }
        }

        private void LoadCategoriesToComboBox()
        {
            var categories = _categoryService.GetCategoriesList();
            
            comboBox_Categories.DropDownStyle = ComboBoxStyle.DropDownList;

            var defaultCategory = new DanhMuc { maDM = "0", tenDM = "Tất cả sản phẩm" };
            categories.Insert(0, defaultCategory);

            comboBox_Categories.DataSource = categories;
            comboBox_Categories.DisplayMember = "tenDM";
            comboBox_Categories.ValueMember = "maDM";
        }

        #endregion
    }
}
