using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPattern
{
    public class PresentationModelAdapter
    {
        private string naam;
        private string leeftijdInJaren;

        public PresentationModelAdapter(Model model)
        {
            this.naam = model.Naam;
            this.leeftijdInJaren = model.Leeftijd.ToString();
        }

        public PresentationModel PresentationModel
        {
            get
            {
                return new PresentationModel(this.naam, this.leeftijdInJaren);
            }
        }
    }
}