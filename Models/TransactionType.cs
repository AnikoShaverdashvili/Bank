using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class TransactionType
    {
        [Key]
        public string Name { get; set; }
        public int Id { get; }
        public int AccountId { get; set; }
    }
}
