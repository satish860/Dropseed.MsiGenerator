using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WixSharp;

namespace Dropseed.MsiGenerator
{
    public interface IInstallerConfiguration
    {
        object Configure(MsiBuilder builder);

        Project BuildProject(object ConfigurationBuilder);
    }

}
