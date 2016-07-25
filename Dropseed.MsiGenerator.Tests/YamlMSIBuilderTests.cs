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
    }
}
