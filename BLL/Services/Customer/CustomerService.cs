using DAL.Repositories.Customer;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Customer
{
<<<<<<< Updated upstream
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
=======
    public class CustomerService: ICustomerService
    {
        public readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        {
            this._repository = repository;
        }
        public List<KhachHang> GetCustomerList()
        {
            return _repository.GetCustomerList();
        }

        public bool InsertCustomer(KhachHang Customer)
        {
            return _repository.InsertCustomer(Customer);
        }

        public bool DeleteCustomer(string maKH)
        {
            return _repository.DeleteCustomer(maKH);
        }

        public bool UpdateCustomer(KhachHang update)
        {
            return _repository.UpdateCustomer(update);
        }

        public List<KhachHang> SearchCustomer(string keyword)
        { return _repository.SearchCustomer(keyword);}    
>>>>>>> Stashed changes
    }
}
