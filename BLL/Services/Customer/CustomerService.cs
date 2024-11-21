using DAL.Repositories.Customer;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        { 
            _repository = repository; 
        }
        public List<KhachHang> GetCustomersList()
        {
            return _repository.GetCustomersList();
        }
    }
}
