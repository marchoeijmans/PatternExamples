using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.AfterRefactor
{
    // Door een Is-A relatie en het gebruik van algoritme kun je makkelijk dynamisch dit uitbereiden.
    public class RealJet: Verhicle
    {
        private Jet _jet;

        public RealJet()
        {
            _jet = new Jet();
        }

        public override void go()
        {
            _jet.setAlgorithm(new GoDrivingAlgorithm());
            _jet.go();

            _jet.setAlgorithm(new GloFlyingFastAlgorithm());
            _jet.go();

            _jet.setAlgorithm(new GoDrivingAlgorithm());
            _jet.go();
        }
    }
}
