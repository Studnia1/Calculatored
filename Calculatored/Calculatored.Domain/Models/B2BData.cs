using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatored.Domain.Models
{
    public class B2BData
    {
        public int Id { get; set; }
        public int Cash { get; set; }
        public float HourlyRate { get; set; }
        public float DailyRate { get; set; }
        public int Vat { get; set; }
        public TaxType TaxType { get; set; }
        public bool FreeCash { get; set; }
        public bool  Leave { get; set; }
    }

    public enum TaxType
    {
        ryczalt,
        skala,
        liniowa,
        drugiprog
    }
}
