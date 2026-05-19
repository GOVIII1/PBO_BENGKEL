using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_BENGKEL.model
{
    public class Sparepart_cls
    {
        public string id_sparepart { get; set; }
        public string nama_sparepart { get; set; }
        public int stok { get; set; }
        public int harga_part { get; set; }
    }
}