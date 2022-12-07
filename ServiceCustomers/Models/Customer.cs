using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServiceCustomers.Models
{
    [Serializable]
    [Table("Customer")]
    public class Customer
    {
        public Customer(){}

        public Customer(string Name, DateTime dueDate, double amount, long Creditnumber, long phonenbr, string template) {
            this.Name = Name;
            this.phonenr = phonenbr;
            this.amount = amount;
            this.dueDate = dueDate;
            this.Creditnumber = Creditnumber;
            this.template = template;
        }

        [Key, Required]
        public int Id { get; set; }
        [ Required]
        public string Name { get; set; }
        [ Required]
        public DateTime dueDate { get; set; }
        [ Required]
        public double amount { get; set; }
        [ Required]
        public long Creditnumber { get; set; }
        [ Required]
        public long phonenr { get; set; }
        public string template { get; set; }

    }
}