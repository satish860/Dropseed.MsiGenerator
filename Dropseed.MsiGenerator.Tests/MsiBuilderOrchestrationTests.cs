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
            MsiBuilderOrchestration orchestration = new MsiBuilderOrchestration();
            var project=orchestration.Orchestrate("Infra.yml");
            project.Dirs.ShouldNotBeNull();
        }

        public void ShouldBeAbleAddBuildAction()
        {
            MsiBuilderOrchestration orchestration = new MsiBuilderOrchestration();
            var project = orchestration.Orchestrate("Infra.yml");
            project.Actions.ShouldNotBeNull();
            project.Actions.Count().ShouldBeGreaterThanOrEqualTo(2);
        }
    }
}
