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
using GUI.Forms.Manager.Staff;
using GUI.Forms.Manager.Customer;
using GUI.Forms.Manager.GoodsReceipt;



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
            frmProductManagement.ShowDialog();
            this.Show();
        }
        private void ViewMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMaterialManagement frmMaterialManagement = _serviceProvider.GetRequiredService<frmMaterialManagement>();
            frmMaterialManagement.ShowDialog();
            this.Show();
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerManagement frmCustomerManagement = _serviceProvider.GetRequiredService<frmCustomerManagement>();
            frmCustomerManagement.ShowDialog();
            this.Show();
        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmStaffManagement frmStaffManagement = _serviceProvider.GetRequiredService<frmStaffManagement>();
            frmStaffManagement.Show();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmGoodsReceiptManagement frmGoodsReceiptManagement = _serviceProvider.GetRequiredService<frmGoodsReceiptManagement>();
            frmGoodsReceiptManagement.Show();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCustomerManagement frmCustomerManagement = _serviceProvider.GetRequiredService<frmCustomerManagement>();
            frmCustomerManagement.Show();
        }
    }
}
