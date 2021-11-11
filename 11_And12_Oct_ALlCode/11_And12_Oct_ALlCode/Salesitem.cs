using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosOOPs
{
    public class SaleItem
    {
        private string _name;
        private decimal _cost;

        public SaleItem(string name, decimal cost)
        {
            _name = name;
            _cost = cost;
        }

        //public string FullName
        //{
        //    get { return this.fullName; } //getter
        //    set { this.fullName = value; } //setter

        //}
        //using expression -lambda
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal Price
        {
            get => _cost;
            set => _cost = value;
        }
    }
}
