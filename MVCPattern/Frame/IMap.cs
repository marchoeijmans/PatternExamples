using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPattern
{
    internal interface IMap
    {
        PresentationModel Map(Model modelToMap);

        Model Map(PresentationModel modelToMap);
    }
}