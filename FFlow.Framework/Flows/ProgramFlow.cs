using FFlow.Core;
using FFlow.Core.External;

namespace FFlow.Framework.Flows
{
    public class ProgramFlow : Flow
    {
        public string Name { get; protected set; }

        public string SourceDirectory { get; protected set; }

        public string Filename => SourceDirectory + Name.ToLower() + ".asm";

        public ProgramFlow(string name, string sourceDirectory = "")
        {
            Name = name;
            SourceDirectory = sourceDirectory;
        }

        public string Save()
        {
            Exporter.SaveToFile(this, Filename);

            return Filename;
        }
    }
}
