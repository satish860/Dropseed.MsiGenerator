using System;
using WixSharp;

namespace Dropseed.MsiGenerator
{
    public abstract class InstallerConfiguration<T> : IInstallerConfiguration
    {
        public object Configure(MsiBuilder builder)
        {
            return AddConfiguration(builder);
        }

        public Project BuildProject(object ConfigurationBuilder)
        {
            throw new NotImplementedException();
        }

        public abstract T AddConfiguration(MsiBuilder builder);

        public abstract Project BuildProject(T builder);
        
    }
}
