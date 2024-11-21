using BLL.Services.Order;
using BLL.Services.OrderDetail;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class frmOrderManagement : Form
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;


        public frmOrderManagement(
            IOrderService orderService,
            IOrderDetailService orderDetailService
            )
        {
            this._orderService = orderService;
            this._orderDetailService = orderDetailService;
            InitializeComponent();
            this.Load += FrmOrderManagement_Load;
        }

        private void FrmOrderManagement_Load(object sender, EventArgs e)
        {
            // Call the method to display the list of orders in the ListBox
            DisplayOrderList();
            listView_OrderDetailList_Config();
            LoadOrderDetailsToListView();
        }

        private void DisplayOrderList()
        {
            var orders = _orderService.GetOrdersList();

            listBox_order.Items.Clear();

            foreach (DonHang order in orders)
            {
                listBox_order.Items.Add(order.maDH + " - " + (order.ngayLapDH.HasValue ? order.ngayLapDH.Value.ToString("dd/MM/yyyy H:mm") : "N/A"));
            }
        }
        private void listView_OrderDetailList_Config()
        {
            listView_orderDetailsList.View = View.Details;
            listView_orderDetailsList.FullRowSelect = true;
            listView_orderDetailsList.GridLines = true;
            listView_orderDetailsList.MultiSelect = false;
            listView_orderDetailsList.Items.Clear();
            listView_orderDetailsList.Columns.Add("Mã chi tiết đơn hàng", 100);
            listView_orderDetailsList.Columns.Add("Số lượng", 100);
            listView_orderDetailsList.Columns.Add("Đơn giá",100);
            listView_orderDetailsList.Columns.Add("Thành tiền", 200);
        }
        private void LoadOrderDetailsToListView()
        {
            listView_orderDetailsList.Items.Clear();
            var orderDetails = _orderDetailService.GetOrderDetailsList();

            foreach (ChiTietDonHang orderDetail in orderDetails)
            {
                ListViewItem item = new ListViewItem(orderDetail.maCTSP);
                item.SubItems.Add(orderDetail.soLuongDatHang.ToString());
                item.SubItems.Add(orderDetail.donGia.ToString());
                item.SubItems.Add(orderDetail.thanhTien.ToString());
                item.Tag = orderDetail;

                listView_orderDetailsList.Items.Add(item);
            }

        }
    }
}
