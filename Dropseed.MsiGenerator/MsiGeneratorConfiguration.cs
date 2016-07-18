using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WixSharp;

namespace Dropseed.MsiGenerator
{
    public class MsiGeneratorConfiguration
    {
        private Project configuredProject;

        public MsiGeneratorConfiguration AddDirectoryPath(string sourcePath,string targetPath= "%ProgramFiles%")
        {
            if (configuredProject == null)
                configuredProject = new Project();
            var sourceDirectory = new DirFiles(sourcePath);
            var targetDirectory = new Dir(targetPath, sourceDirectory);
            configuredProject.Dirs = new[] { targetDirectory };
            return this;
        }

        public MsiGenerator BuildConfiguration()
        {
            return new MsiGenerator();
        }

        public Project GetConfiguredProject()
        {
            return configuredProject;
        }
    }
}
