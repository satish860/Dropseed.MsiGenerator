using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WixSharp;

namespace Dropseed.MsiGenerator
{
    public class DirectoryBuilder : InstallerConfiguration<Dir>
    {
        public override Dir AddConfiguration(MsiBuilder builder)
        {
            var targetPath = @"%" + builder.SourceDirectory;
            var sourceDirectory = new DirFiles(builder.DestinationDirectory);
            var targetDirectory = new Dir(targetPath, sourceDirectory);
            return targetDirectory;
           
        }

        public override Project BuildComponentWithProject(Dir builder,Project project)
        {
            throw new NotImplementedException();
        }
    }
}
