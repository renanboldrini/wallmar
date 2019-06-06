using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wallmar.Models
{
    public class SalesRecord
    {
        private DateTime dateTime;
        private double v;
        private SaleStatus bILLED;
        private Seller s1;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller  { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

        public SalesRecord(DateTime dateTime, double v, SaleStatus bILLED, Seller s1)
        {
            this.dateTime = dateTime;
            this.v = v;
            this.bILLED = bILLED;
            this.s1 = s1;
        }
    }
}
