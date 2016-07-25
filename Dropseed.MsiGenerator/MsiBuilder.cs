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

        public static MsiBuilder Build(string filePath)
        {
            Deserializer deserializer = new Deserializer();
            var stringWriter = new StringWriter();
            Serializer seri = new Serializer();
            seri.Serialize(stringWriter, new MsiBuilder { Name="DropSeed"});
            var document =new StringReader(File.ReadAllText(filePath));
            return deserializer.Deserialize<MsiBuilder>(document);
        }
    }
}
