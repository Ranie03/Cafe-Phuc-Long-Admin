using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Customer
{
    public interface ICustomerRepository
    {
<<<<<<< Updated upstream
        List<KhachHang> GetCustomersList();
=======
        List<KhachHang> GetCustomerList();

        bool InsertCustomer(KhachHang Customer);

        bool DeleteCustomer(string maKH);

        bool UpdateCustomer(KhachHang updated);

        List<KhachHang> SearchCustomer(string keyword);
>>>>>>> Stashed changes
    }
}
