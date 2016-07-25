using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WixSharp;

namespace Dropseed.MsiGenerator
{
    public class MsiBuilderOrchestration
    {
        public Project Orchestrate(string filePath)
        {
            var msibuilder = MsiBuilder.Build(filePath);
            return ProjectBuilder.Build(msibuilder);
        }
    }
}
