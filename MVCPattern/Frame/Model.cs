using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPattern
{
    public class Model
    {
        public Model()
        {
        }

        public Model(string naam, int leeftijd)
        {
            this.Naam = naam;
            this.Leeftijd = leeftijd;
        }

        public string Naam { get; set; }

        public int Leeftijd { get; set; }
    }
}