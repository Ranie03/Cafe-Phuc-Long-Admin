using BLL.Services.Customer;
<<<<<<< Updated upstream
=======
using DTO;
>>>>>>> Stashed changes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< Updated upstream

namespace GUI.Forms.Manager
=======
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.Forms.Manager.Customer
>>>>>>> Stashed changes
{
    public partial class frmCustomerManagement : Form
    {
        private readonly ICustomerService _customerService;
<<<<<<< Updated upstream
        public frmCustomerManagement(
            ICustomerService customerService
            )
        {
            this._customerService = customerService;
=======


        public frmCustomerManagement(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));

>>>>>>> Stashed changes
            InitializeComponent();
            this.Load += FrmCustomerManagement_Load;
        }

        private void FrmCustomerManagement_Load(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
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
=======
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            LoadCustomerToDataGridView();
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            Reset();
        }


        private void LoadCustomerToDataGridView()
        {
            var customerList = _customerService.GetCustomerList();
            dgvKhachHang.DataSource = customerList;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvKhachHang.Columns["maKH"].HeaderText = "Mã Khách Hàng";
            // Ẩn các cột không cần hiển thị
            if (dgvKhachHang.Columns.Contains("username"))
                dgvKhachHang.Columns["username"].Visible = false;

            if (dgvKhachHang.Columns.Contains("matKhau"))
                dgvKhachHang.Columns["matKhau"].Visible = false;
            dgvKhachHang.Columns["tenKH"].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns["ngaySinh"].HeaderText = "Ngày Sinh";
            dgvKhachHang.Columns["soDT"].HeaderText = "Số Điện Thoại";
            dgvKhachHang.Columns["diaChi"].HeaderText = "Địa Chỉ";
            dgvKhachHang.Columns["email"].HeaderText = "Email";

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txt_maKH.Text = row.Cells["maKH"].Value?.ToString() ?? string.Empty;
               // txt_username.Text = row.Cells["username"].Value?.ToString() ?? string.Empty;
               // txt_password.Text = row.Cells["matKhau"].Value?.ToString() ?? string.Empty;
                txt_tenKH.Text = row.Cells["tenKH"].Value?.ToString() ?? string.Empty;
                dtpNgaySinh.Value = DateTime.TryParse(row.Cells["ngaySinh"].Value?.ToString(), out DateTime ngaySinh) ? ngaySinh : DateTime.Now;
                txt_soDT.Text = row.Cells["soDT"].Value?.ToString() ?? string.Empty;
                txt_diaChi.Text = row.Cells["diaChi"].Value?.ToString() ?? string.Empty;
                txt_email.Text = row.Cells["email"].Value?.ToString() ?? string.Empty;
            }
        }

        //private void btn_Insert_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (string.IsNullOrWhiteSpace(txt_maKH.Text))
        //        {
        //            MessageBox.Show("Mã khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        KhachHang kh = new KhachHang
        //        {
        //            maKH = txt_maKH.Text,
        //            username = txt_username.Text,
        //            matKhau = txt_password.Text,
        //            tenKH = txt_tenKH.Text,
        //            ngaySinh = dtpNgaySinh.Value,
        //            soDT = txt_soDT.Text,
        //            diaChi = txt_diaChi.Text,
        //            email = txt_email.Text,
        //        };

        //        bool result = _customerService.InsertCustomer(kh);

        //        if (result)
        //        {
        //            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            LoadCustomerToDataGridView();
        //            Reset();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Thêm khách hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string maKH = txt_maKH.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool kq = _customerService.DeleteCustomer(maKH);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerToDataGridView();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại, mã khách hàng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_maKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KhachHang kh = new KhachHang
            {
                maKH = txt_maKH.Text,
              //  username = txt_username.Text,
              //  matKhau = txt_password.Text,
                tenKH = txt_tenKH.Text,
                ngaySinh = dtpNgaySinh.Value,
                soDT = txt_soDT.Text,
                diaChi = txt_diaChi.Text,
                email = txt_email.Text,
            };

            bool kq = _customerService.UpdateCustomer(kh);
            if (kq)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomerToDataGridView();
                Reset();
            }
            else
            {
                MessageBox.Show("Sửa thất bại, mã khách hàng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            txt_maKH.Clear();
          //  txt_username.Clear();
          //  txt_password.Clear();
            txt_diaChi.Clear();
            txt_email.Clear();
            txt_soDT.Clear();
            txt_tenKH.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txt_Search.Clear();
            LoadCustomerToDataGridView();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_Search.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
  
                    LoadCustomerToDataGridView();
                    return;
                }

                // Gọi phương thức tìm kiếm trong Service
                var searchResult = _customerService.SearchCustomer(keyword);

                if (searchResult != null && searchResult.Any())
                {
                    dgvKhachHang.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào khớp với từ khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKhachHang.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}


>>>>>>> Stashed changes
