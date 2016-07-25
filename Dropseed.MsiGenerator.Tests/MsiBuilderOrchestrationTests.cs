using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Should;

namespace Dropseed.MsiGenerator.Tests
{
    public class MsiBuilderOrchestrationTests
    {
        public void ShouldBeAbleTakeTheFilePathAndBuildProjectOutProject()
        {
            MsiBuilderOrchestration orchestration = new MsiBuilderOrchestration();
            var project=orchestration.Orchestrate("Infra.yml");
            project.Name.ShouldEqual("DropSeed");
        }

        public void ShouldBeAbleAddADirectoryToTheProject()
        {

        }
    }
}
