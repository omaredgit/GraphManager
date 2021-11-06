using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Diagnostics;
using System.IO;

namespace GraphScriptBroker.ExternalExecutions
{
    public class ScriptExecution
    {
        public static void Main()
        {

            Process proc = new Process();
            proc.StartInfo.FileName = @"GraphCreator.exe";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.StartInfo.WorkingDirectory = @"C:\Users\carva\source\repos\GraphManager\GraphScriptBroker\PythonScripts\dist";
            proc.Start();

        }
    }
}
