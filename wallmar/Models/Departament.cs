using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wallmar.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<Seller> Sellers { get; set; }
            = new List<Seller>();

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /*Add Seller*/
        public void AddSeler(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            /*vamos utilizar o LINQ para filtrar a lista de vendas com lambda*/
            return Sellers.Sum(seller => seller.TotalSales(initial, final));

        }

        /* Metodo Construtor */
        public Departament() { } 
    }
}
