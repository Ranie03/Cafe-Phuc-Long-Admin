﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Supplier
{
    public interface ISupplierService
    {
        List<NhaCungCap> GetSupplierList();
    }
}
