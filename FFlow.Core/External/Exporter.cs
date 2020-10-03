using System.IO;

namespace FFlow.Core.External
{
    public static class Exporter
    {
        public static void SaveToFile(Flow flow, string filename)
        {
            File.WriteAllText(filename, flow.Assembly());
        }
    }
}
