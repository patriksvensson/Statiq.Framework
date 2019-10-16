﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Statiq.Common;

namespace Statiq.Core
{
    internal class Settings : ConfigurationMetadata, ISettings
    {
        public Settings(IConfiguration configuration)
            : base(configuration)
        {
        }
    }
}
