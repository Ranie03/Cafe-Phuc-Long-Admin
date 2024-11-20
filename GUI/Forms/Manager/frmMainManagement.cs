using BLL.Services;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class frmMainManagement : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public frmMainManagement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Load += FrmMainManagement_Load;
        }

        private void FrmMainManagement_Load(object sender, EventArgs e)
        {
            // Các sự kiện sau khi load thông tin form
            this.viewProductToolStripMenuItem.Click += ViewProductToolStripMenuItem_Click;
            this.ViewMaterialToolStripMenuItem.Click += ViewMaterialToolStripMenuItem_Click;
        }

        private void ViewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmProductManagement frmProductManagement = _serviceProvider.GetRequiredService<frmProductManagement>();
            frmProductManagement.Show();
        }
        private void ViewMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMaterialManagement frmMaterialManagement = _serviceProvider.GetRequiredService<frmMaterialManagement>();
            frmMaterialManagement.Show();
        }
    }
}
