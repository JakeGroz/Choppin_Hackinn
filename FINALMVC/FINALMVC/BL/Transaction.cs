using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FINALMVC.BL
{
    public class Transaction
    {
        public string transactionId { get; set; }
        public string amount { get; set; }
        public bool valid { get; set; }
        public string details { get; set; }
    }
}
