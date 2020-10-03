using System.Diagnostics;

namespace FFlow.Core.External
{
    public static class Debugger
    {
        public static void Run(string filename, params string[] args)
        {
            Process process = new Process();

            process.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                FileName = filename,
                Arguments = string.Join(' ', args)
            };

            process.Start();
        }
    }
}
