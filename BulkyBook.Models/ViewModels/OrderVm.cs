﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models.ViewModels
{
    public class OrderVm
    {
        OrderHeader Header { get; set; }

        List<OrderDetail> Details { get; set; }
    }
}