using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WixSharp;

namespace Dropseed.MsiGenerator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() != 1)
            {
                System.Console.WriteLine("We are expecting a file path as the input with the settings");
                Environment.Exit(42);
            }
            else
            {
                MsiBuilderOrchestration orchestration = new MsiBuilderOrchestration();
                Project project = orchestration.Orchestrate(args[0]);
                project.BuildMsi();
            }
           
        }
    }
}
