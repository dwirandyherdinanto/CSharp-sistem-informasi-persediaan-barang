﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jotun.Models
{
    public class detailpo
    {
        public int kd_detail_po { get; set; }
        public string no_po { get; set; }
        public string kd_barang { get; set; }
        public int qty { get; set; }
        public double liter { get; set; }
        public int harga { get; set; }
        public int total { get; set; }

        public virtual po po { get; set; }
        public virtual barang barang { get; set; }
    }
}
