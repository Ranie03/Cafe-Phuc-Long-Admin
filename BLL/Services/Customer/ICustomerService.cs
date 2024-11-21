using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Customer
{
    public interface ICustomerService
    {
<<<<<<< Updated upstream
        List<KhachHang> GetCustomersList();
=======
        List<KhachHang> GetCustomerList();

        bool InsertCustomer(KhachHang nv);
        bool DeleteCustomer(string maKH);
        bool UpdateCustomer(KhachHang update);
        List<KhachHang> SearchCustomer(string keyword);
>>>>>>> Stashed changes
    }
}
