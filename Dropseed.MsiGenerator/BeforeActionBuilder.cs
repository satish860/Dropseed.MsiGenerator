using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WixSharp;

namespace Dropseed.MsiGenerator
{
    public class BeforeActionBuilder : InstallerConfiguration<WixSharp.Action>
    {
        public override WixSharp.Action AddConfiguration(MsiBuilder builder)
        {
            var actions = new InstalledFileAction(builder.BeforeBuild,builder.BeforeBuildArgument, Return.check, When.After,
                                     Step.InstallFinalize,
                                     Condition.NOT_Installed);
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
