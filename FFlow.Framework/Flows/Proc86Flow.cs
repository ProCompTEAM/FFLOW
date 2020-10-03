namespace FFlow.Framework.Flows
{
    public abstract class Proc86Flow : FlatAssemblyFlow
    {
        public void SetName(string name) => InsertBefore($"name '{name}'");

        public void End() => InsertAfter("end");
    }
}