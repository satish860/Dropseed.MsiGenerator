using WixSharp;

namespace Dropseed.MsiGenerator
{
    public class MsiBuilderOrchestration
    {
        public Project Orchestrate(string filePath)
        {
            var msibuilder = MsiBuilder.Build(filePath);
            Project project = ProjectBuilder.Build(msibuilder);
            DirectoryBuilder directoryBuilder = new DirectoryBuilder();
            var dir=directoryBuilder.AddConfiguration(msibuilder);
            directoryBuilder.BuildComponentWithProject(dir, project);
            BeforeActionBuilder actionBuilder = new BeforeActionBuilder();
            var beforeAction=actionBuilder.AddConfiguration(msibuilder);
            AfterActionBuilder AfteractionBuilder = new AfterActionBuilder();
            var afterAction = AfteractionBuilder.AddConfiguration(msibuilder);
            project.Actions = new[] { beforeAction, afterAction };
            return project;
        }
    }
}
