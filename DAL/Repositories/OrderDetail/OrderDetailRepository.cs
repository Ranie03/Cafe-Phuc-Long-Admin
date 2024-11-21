using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.OrderDetail
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public OrderDetailRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<ChiTietDonHang> GetOrderDetailsList()
        {
            return _context.ChiTietDonHangs.ToList();
        }
    }
}
