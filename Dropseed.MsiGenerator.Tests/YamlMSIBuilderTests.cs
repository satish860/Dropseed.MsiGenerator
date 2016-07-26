using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Should;

namespace Dropseed.MsiGenerator.Tests
{
    public class YamlMSIBuilderTests
    {
        public void ShouldBeAbleConvertYamlForProject()
        {
            var filePath = "Infra.yml";
            MsiBuilder builder=MsiBuilder.Build(filePath);
            builder.Name.ShouldEqual("DropSeed");
        }

        public void ShouldBeAbleConvertYamlForProjectWithDirectory()
        {
            var filePath = "Infra.yml";
            MsiBuilder builder = MsiBuilder.Build(filePath);
            builder.Name.ShouldEqual("DropSeed");
            builder.SourceDirectory.ShouldEqual(@"ProgramFiles%\DropSeed\DropSeed.Minions");
            builder.DestinationDirectory.ShouldEqual(@"Release\Debug\*.*");
        }

        public void ShouldBeAbleToGetBeforeBuild()
        {
            var filePath = "Infra.yml";
            MsiBuilder builder = MsiBuilder.Build(filePath);
            builder.Name.ShouldEqual("DropSeed");
            builder.BeforeBuild.ShouldEqual("WixGenerator.exe");
            builder.BeforeBuildArgument.ShouldEqual("install");
        }

        public void ShouldBeAbleToGetAfterBuild()
        {
            var filePath = "Infra.yml";
            MsiBuilder builder = MsiBuilder.Build(filePath);
            builder.Name.ShouldEqual("DropSeed");
            builder.AfterBuild.ShouldEqual("WixGenerator.exe");
            builder.AfterBuildArgument.ShouldEqual("uninstall");
        }
    }
}
