﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WixSharp;

namespace Dropseed.MsiGenerator
{
    public class ProjectBuilder
    {
        public static Project Build(MsiBuilder builder)
        {
            return new Project { Name = builder.Name };
        }
    }
}
