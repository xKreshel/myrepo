using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPWebService.Entities
{
    class RateData
    {
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public Decimal Value { get; set; }
       
    }
}

