using BLL.Services.Customer;
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
    public partial class frmCustomerManagement : Form
    {
        private readonly ICustomerService _customerService;
        public frmCustomerManagement(
            ICustomerService customerService
            )
        {
            this._customerService = customerService;
            InitializeComponent();
            this.Load += FrmCustomerManagement_Load;
        }

        private void FrmCustomerManagement_Load(object sender, EventArgs e)
        {
            listView_CustomersList_Config();
            LoadCustomersToListView();
        }
        private void listView_CustomersList_Config()
        {
            listView_CustomersList.View = View.Details;
            listView_CustomersList.FullRowSelect = true;
            listView_CustomersList.GridLines = true;
            listView_CustomersList.MultiSelect = false;
            listView_CustomersList.Items.Clear();
            listView_CustomersList.Columns.Add("Mã Khách hàng", 100);
            listView_CustomersList.Columns.Add("Tài khoản", 150);
            listView_CustomersList.Columns.Add("Tên khách hàng", 150);
            listView_CustomersList.Columns.Add("Ngày sinh", 150);
            listView_CustomersList.Columns.Add("Số điện thoại", 150);
            listView_CustomersList.Columns.Add("Địa chỉ", 150);
            listView_CustomersList.Columns.Add("Email", 150);
        }
        private void LoadCustomersToListView()
        {
            listView_CustomersList.Items.Clear();
            var customers = _customerService.GetCustomersList();

            foreach (var customer in customers)
            {
                ListViewItem item = new ListViewItem(customer.maKH);
                item.SubItems.Add(customer.username);
                item.SubItems.Add(customer.tenKH);
                item.SubItems.Add(customer.ngaySinh?.ToString("dd/MM/yyyy") ?? string.Empty);
                item.SubItems.Add(customer.soDT);
                item.SubItems.Add(customer.diaChi);
                item.SubItems.Add(customer.email);

                item.Tag = customer;

                listView_CustomersList.Items.Add(item);
            }

        }
    }
}
