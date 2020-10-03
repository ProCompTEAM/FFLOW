using FFlow.Core.External;
using System;
using System.IO;

namespace FFlow.Tests
{
    public abstract class Test
    {
        protected abstract string TestName { get; }

        public static string SourceDirectory => $@"{Environment.CurrentDirectory}\Output\";

        public abstract void Execute();

        protected Test()
        {
            if(!Directory.Exists(SourceDirectory))
            {
                Directory.CreateDirectory(SourceDirectory);
            }
        }

        protected void OpenEditor(string filename)
        {
            Debugger.Run("notepad.exe", filename);
        }
    }
}
