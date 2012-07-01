using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPattern
{
    public class ModelAdapter
    {
        private string naam;
        private int leeftijd;
        private Model model;

        public ModelAdapter(PresentationModel model)
        {
            this.naam = model.Naam;
            this.leeftijd = Convert.ToInt16(model.LeeftijdInJaren);
            this.model = new Model(this.naam, this.leeftijd);
        }

        public Model Model
        {
            get
            {
                return this.model;
            }
        }
    }
}