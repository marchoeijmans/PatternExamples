using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPattern
{
    public class PresentationModel
    {
        public PresentationModel()
        {
        }

        public PresentationModel(string naam, string leeftijdInJaren)
        {
            this.Naam = naam;
            this.LeeftijdInJaren = leeftijdInJaren;
        }

        public string Naam { get; set; }

        public string LeeftijdInJaren { get; set; }
    }
}