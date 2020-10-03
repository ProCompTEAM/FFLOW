using FFlow.Core;
using FFlow.Core.Enums;

namespace FFlow.Framework.Flows.Fragments
{
    public class FasmFragment : Fragment
    {
        private readonly string fasmCode;

        private string ObjectType => GetType().ToString();

        public FasmFragment(string fasmCode, Position position)
        {
            Metadata = $"[FASM code fragment of {ObjectType}]";
            Position = position;

            this.fasmCode = fasmCode;
        }

        public override string Assembly()
        {
            return fasmCode;
        }
    }
}
