﻿using OpenSilver.Simulator;
using System;

namespace OpenSilverMauiCalculator.Simulator
{
    internal static class Startup
    {
        [STAThread]
        static int Main(string[] args)
        {
            return SimulatorLauncher.Start(typeof(App));
        }
    }
}
