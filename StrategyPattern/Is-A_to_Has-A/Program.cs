using System;

using AR = StrategyPattern.AfterRefactor;
using BR = StrategyPattern.BeforeRefactor;

namespace StrategyPattern
{
    /// <summary>
    /// Voorbeeld van strategy pattern, creeer een groep van uitwisselbare algoritme objecten.
    /// Code die kan wijzigen wordt encapsulated in een algoritme object.
    /// Doel wijzig de Is-a relatie (generalisatie) in een Has-a relatie (compositie) door het gebruik van het strategy pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BR.StreetRacer streetRacer = new BR.StreetRacer();
            BR.FormulaOne formulaOne = new BR.FormulaOne();
            BR.Helicopter helicopter = new BR.Helicopter();
            BR.Jet jet = new BR.Jet();
            BR.RealJet realJet = new BR.RealJet();

            streetRacer.go();
            formulaOne.go();
            helicopter.go();
            jet.go();
            Console.WriteLine("Hier komt de real jet (BR)");
            realJet.go();

            AR.StreetRacer steetRacer2 = new AR.StreetRacer();
            AR.FormulaOne formulaOne2 = new AR.FormulaOne();
            AR.Helicopter helicopter2 = new AR.Helicopter();
            AR.Jet jet2 = new AR.Jet();
            AR.RealJet realJet2 = new AR.RealJet();

            steetRacer2.go();
            formulaOne2.go();
            helicopter2.go();
            jet2.go();

            Console.WriteLine("Hier komt de real jet (AR)");
            realJet2.go();
            Console.ReadLine();
        }
    }
}
