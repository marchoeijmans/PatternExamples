using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPattern
{
    public interface IPresentationModel
    {
        string Naam { get; }

        string LeeftijdInJaren { get; }
    }
}