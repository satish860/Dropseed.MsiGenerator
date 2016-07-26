using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet;
using YamlDotNet.Serialization;

namespace Dropseed.MsiGenerator
{
    public class MsiBuilder
    {
        public string Name { get; set; }

        public string SourceDirectory { get; set; }

        public string DestinationDirectory { get; set; }

        public string BeforeBuild { get; set; }

        public string BeforeBuildArgument { get; set; }

        public string AfterBuild { get; set; }

        public string AfterBuildArgument { get; set; }

        public static MsiBuilder Build(string filePath)
        {
            Deserializer deserializer = new Deserializer();
            var document =new StringReader(File.ReadAllText(filePath));
            return deserializer.Deserialize<MsiBuilder>(document);
        }
    }
}
