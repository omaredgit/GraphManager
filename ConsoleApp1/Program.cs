using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strCmdText = @"GraphCreator.exe";

            Process proc = new Process();
            proc.StartInfo.FileName = strCmdText;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.StartInfo.WorkingDirectory = @"C:\Users\carva\source\repos\GraphManager\GraphScriptBroker\PythonScripts\dist";
            proc.Start();
            proc.WaitForExit();


        }
    }
}
