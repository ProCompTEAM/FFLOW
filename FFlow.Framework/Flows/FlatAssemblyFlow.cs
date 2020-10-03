using FFlow.Core.Enums;
using FFlow.Framework.Flows.Fragments;

namespace FFlow.Framework.Flows
{
    public abstract class FlatAssemblyFlow : CombinedFlow
    {
        public void InsertBefore(string fasmCode) => Insert(fasmCode, Position.Top);

        public void InsertInto(string fasmCode) => Insert(fasmCode, Position.Middle);

        public void InsertAfter(string fasmCode) => Insert(fasmCode, Position.Bottom);

        private void Insert(string fasmCode, Position position)
        {
            FasmFragment fragment = new FasmFragment(fasmCode, position);
            Push(fragment);
        }
    }
}
