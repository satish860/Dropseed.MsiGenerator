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
            throw new NotImplementedException();
        }

        public override Project BuildProject(Dir builder)
        {
            throw new NotImplementedException();
        }
    }
}
