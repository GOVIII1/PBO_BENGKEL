using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_BENGKEL.model
{
    internal class Dashboard_cls
    {
        public string id_servis { get; set; }
        public string nama_pelanggan { get; set; }
        public string no_hp { get; set; }
        public string nama_sparepart { get; set; }
        public int stok { get; set; }
        public string username { get; set; }
        public string role { get; set; }
    }
}
