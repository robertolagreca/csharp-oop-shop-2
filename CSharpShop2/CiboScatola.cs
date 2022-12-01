using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class CiboScatola: Prodotto
    {
        private string foodType;
        private float weight;


        public CiboScatola(string name, string description, float price, int iva, string foodType,float weight): base(name, description, price, iva)
        {
            this.foodType = foodType;
            this.weight = weight;
        }
    }
}
