using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autofac.Net46.Test.Scenarios.Graph1
{
    // In the below scenario, B1 depends on A1, CD depends on A1 and B1,
    // and E depends on IC1 and B1.
    public class A1 : DisposeTracker
    {
    }
}