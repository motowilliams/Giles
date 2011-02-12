﻿using System.Diagnostics;

namespace Giles.Core.Runners
{
    public class RunnerBase
    {
        public Process SetupProcess(string fileName, string arguments)
        {
            return new Process
                       {
                           StartInfo =
                               {
                                   FileName = fileName,
                                   Arguments = arguments,
                                   UseShellExecute = false,
                                   RedirectStandardOutput = true
                               }
                       };
        }
    }
}