using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WixSharp;

namespace Dropseed.MsiGenerator
{
    public class MsiGenerator
    {
        public string Build(string name)
        {
            Project project = new Project(name);
            return Compiler.BuildMsi(project);
        }
    }
}
