﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.AfterRefactor
{
    public class Jet: Verhicle
    {
        public Jet()
        {
            setAlgorithm(new GloFlyingFastAlgorithm());
        }
    }
}
