using WixSharp;

namespace Dropseed.MsiGenerator
{
    public class AfterActionBuilder : InstallerConfiguration<WixSharp.Action>
    {
        public override WixSharp.Action AddConfiguration(MsiBuilder builder)
        {
            var actions = new InstalledFileAction(builder.AfterBuild, builder.AfterBuildArgument, Return.check, When.Before,
                                     Step.InstallFinalize,
                                     Condition.Installed);
            return actions;
        }

        public override Project BuildComponentWithProject(WixSharp.Action builder, Project project)
        {
            if (project.Actions == null)
                project.Actions = new WixSharp.Action[10];
            project.Actions.Add(builder);
            return project;
        }
    }
}
