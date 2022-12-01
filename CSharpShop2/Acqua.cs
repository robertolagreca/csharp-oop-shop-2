using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class Acqua : Prodotto
    {
        //ATTRIBUTI
        int litre;
        float ph;
        string source;

        //COSTRUTTORI
        public Acqua(string name, string description, float price, int iva, int litre, float ph, string source) : base(name, description, price, iva)
        {
            this.litre = litre;
            this.ph = ph;
            this.source = source;
        }
        
        //GETTERS
        public int GetLitre
        {
            get { return litre; }
        }

        public float GetPh
        {
            get { return ph; }
        }

        public string GetSource
        {
            get { return source; }
        }
    }
}
