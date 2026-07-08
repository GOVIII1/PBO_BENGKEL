using System;
using System.Collections.Generic;

namespace PBO_BENGKEL.model
{
    public class StrukItemModel
    {
        public string NamaItem { get; set; }
        public int Qty { get; set; }
        public decimal HargaSatuan { get; set; }
        public decimal Subtotal => Qty * HargaSatuan;
    }

    public class Struk_clz
    {
        public string IdServis { get; set; }
        public string NamaPelanggan { get; set; }
        public string PlatNomor { get; set; }
        public string NamaKasir { get; set; }
        public string Status { get; set; }
        public DateTime TanggalServis { get; set; }
        public List<StrukItemModel> DaftarItem { get; set; }
        public decimal TotalTagihan { get; set; }

        public Struk_clz()
        {
            DaftarItem = new List<StrukItemModel>();
            TanggalServis = DateTime.Now;
        }
    }
}
