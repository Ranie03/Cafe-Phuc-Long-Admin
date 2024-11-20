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

namespace GUI.Forms.Manager

{
    public partial class frmMaterialManagement : Form
    {
        private readonly IRecipeService _recipeService;

        public frmMaterialManagement(
            IRecipeService recipeService
            )
        {
            this._recipeService = recipeService;
            InitializeComponent();
            this.Load += FrmMaterialManagement_Load; ;
        }

        private void FrmMaterialManagement_Load(object sender, EventArgs e)
        {
            listView_RecipesList_Config();
            LoadRecipesToListView();
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
    }
}
