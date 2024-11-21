using BLL.Services.Category;
using BLL.Services.ProductDetail;
using BLL.Services.Recipe;
using BLL.Services.Size;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services.Recipe_material;
using BLL.Services.Material;

namespace GUI.Forms.Manager

{
    public partial class frmMaterialManagement : Form
    {
        private readonly IRecipeService _recipeService;
        private readonly IRecipe_materialService _recipe_materialService;
        private readonly IMaterialService _materialService;


        public frmMaterialManagement(
            IRecipeService recipeService,
            IRecipe_materialService recipe_materialService,
            IMaterialService materialService
            )
        {
            this._recipeService = recipeService;
            this._recipe_materialService = recipe_materialService;
            this._materialService = materialService;
            InitializeComponent();
            this.Load += FrmMaterialManagement_Load; ;
        }

        private void FrmMaterialManagement_Load(object sender, EventArgs e)
        {
            listView_RecipesList_Config();
            listView_Recipe_materialsList_Config();
            listView_materialsList_Config();
            LoadRecipesToListView();
            LoadmaterialsToListView();
        }
        private void listView_RecipesList_Config()
        {
            listView_recipeList.View = View.Details;
            listView_recipeList.FullRowSelect = true;
            listView_recipeList.GridLines = true;
            listView_recipeList.MultiSelect = false;
            listView_recipeList.Items.Clear();
            listView_recipeList.Columns.Add("Mã công thức", 100);
            listView_recipeList.Columns.Add("Tên công thức", 200);
            listView_recipeList.Columns.Add("Mô tả", 250);
        }
        private void LoadRecipesToListView()
        {
            listView_recipeList.Items.Clear();
            var recipes = _recipeService.GetRecipeList();

            foreach (var recipe in recipes)
            {
                ListViewItem item = new ListViewItem(recipe.maCT);
                item.SubItems.Add(recipe.tenCT);
                item.SubItems.Add(recipe.moTa);
                item.Tag = recipe;

                listView_recipeList.Items.Add(item);
            }

        }

        private void listView_Recipe_materialsList_Config()
        {
            listView_recipe_materialsList.View = View.Details;
            listView_recipe_materialsList.FullRowSelect = true;
            listView_recipe_materialsList.GridLines = true;
            listView_recipe_materialsList.MultiSelect = false;
            listView_recipe_materialsList.Items.Clear();
            listView_recipe_materialsList.Columns.Add("Mã công thức", 100);
            listView_recipe_materialsList.Columns.Add("Mã Nguyên liệu", 100);
            listView_recipe_materialsList.Columns.Add("Số lượng", 100);
        }
        private void LoadRecipe_materialsToListView()
        {
            listView_recipe_materialsList.Items.Clear();
            var recipe_materials = _recipe_materialService.GetRecipe_materialsList();

            foreach (var recipe_material in recipe_materials)
            {
                ListViewItem item = new ListViewItem(recipe_material.maCT);
                item.SubItems.Add(recipe_material.maNL);
                item.SubItems.Add(recipe_material.soLuong.ToString());
                listView_recipe_materialsList.Items.Add(item);
            }

        }
        private void listView_materialsList_Config()
        {
            listView_materialsList.View = View.Details;
            listView_materialsList.FullRowSelect = true;
            listView_materialsList.GridLines = true;
            listView_materialsList.MultiSelect = false;
            listView_materialsList.Items.Clear();
            listView_materialsList.Columns.Add("Mã Nguyên liệu", 100);
            listView_materialsList.Columns.Add("Tên nguyên liệu", 150);
            listView_materialsList.Columns.Add("Số lượng", 100);
            listView_materialsList.Columns.Add("Đơn vị tính", 100);

        }
        private void LoadmaterialsToListView()
        {
            listView_materialsList.Items.Clear();
            var materials = _materialService.GetMaterialsList();

            foreach (var material in materials)
            {
                ListViewItem item = new ListViewItem(material.maNL);
                item.SubItems.Add(material.tenNL);
                item.SubItems.Add(material.soLuong.ToString());
                item.SubItems.Add(material.donViTinh);
                listView_materialsList.Items.Add(item);
            }

        }
    }
}
