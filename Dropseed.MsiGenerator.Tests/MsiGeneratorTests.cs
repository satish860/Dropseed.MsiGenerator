using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Should;

namespace Dropseed.MsiGenerator.Tests
{
    public class MsiGeneratorTests
    {
        public void ShouldBeAbleToCreateMSIWithJustProvidingName()
        {
            MsiGenerator generator = new MsiGenerator();
            string path=generator.Build("Dropseed.minions");
            path.ShouldNotBeNull();
        }
    }
}
