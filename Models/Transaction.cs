using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int SenderAccountId { get; set; }
        public int ReceiverAccountId { get; set; }
        public int TransactionTypeId { get; set; }
        public decimal Amount { get; set; }
        public string Purpose { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
