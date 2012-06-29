using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverExample
{
    public class InstanceUpgrader
    {
        public string Upgrade(string tekst)
        {
            return " Hello Observer. upgraded: " +  tekst;
        }
    }
}
