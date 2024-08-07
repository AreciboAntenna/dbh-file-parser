﻿using System;
using System.IO;
using System.Reflection;

namespace FileParser.Core
{
    public sealed class CommandLineArgumentsProvider : ICommandLineArgumentsProvider
    {
        public string[] Arguments => Environment.GetCommandLineArgs();
        public string ExecutableFolderPath => AppContext.BaseDirectory;
    }
}
