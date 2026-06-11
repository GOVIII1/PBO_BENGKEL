using System;
using System.Collections.Generic;


namespace PBO_BENGKEL.model
{
    public class DetailTagihan
    {
        public string NamaItem { get; set; }
        public int Qty { get; set; }
        public decimal HargaSatuan { get; set; }
        public decimal Subtotal => Qty * HargaSatuan;
    }

    public class BayarModel
    {
        public string IdServis { get; set; }
        public string PlatNomor { get; set; }
        public string NamaPelanggan { get; set; }
        public List<DetailTagihan> RincianNota { get; set; }
        public decimal TotalTagihan { get; set; }

        public BayarModel()
        {
            RincianNota = new List<DetailTagihan>();
        }
    }
}