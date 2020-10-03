using FFlow.Core.Enums;

namespace FFlow.Core
{
    public abstract class Fragment
    {
        public string Metadata { get; protected set; }

        public Position Position { get; protected set; }

        public abstract string Assembly();
    }
}
