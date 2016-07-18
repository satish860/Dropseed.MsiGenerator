using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Should;

namespace Dropseed.MsiGenerator.Tests
{
    public class MsiGeneratorConfigurationTests
    {
        public void ShouldBeAbleToAddTheSourceAndDestinationDirectory()
        {
            MsiGeneratorConfiguration configuration = new MsiGeneratorConfiguration();
            configuration.AddDirectoryPath(@"Release\Debug\*.* ", @"%ProgramFiles%\DropSeed\DropSeed.Minions");
            var project=configuration.GetConfiguredProject();
            project.Dirs.ShouldNotBeNull();
        }
    }
}
