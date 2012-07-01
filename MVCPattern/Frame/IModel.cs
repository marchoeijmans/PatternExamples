using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPattern
{
    public interface IModel
    {
        string Naam { get; set; }

        int Leeftijd { get; set; }
    }
}