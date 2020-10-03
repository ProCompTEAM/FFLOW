using FFlow.Core;

namespace FFlow.Framework.Flows
{
    public abstract class CombinedFlow : Flow
    {
        public abstract void Run();

        protected CombinedFlow()
        {
            Run();
        }
    }
}
