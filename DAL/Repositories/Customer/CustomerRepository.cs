using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public CustomerRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<KhachHang> GetCustomersList()
        {
            return _context.KhachHangs.ToList();
        }
    }
}
