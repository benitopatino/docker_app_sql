using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docker_app_sql
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        public string Merchant { get; set; }
        public float Price { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
