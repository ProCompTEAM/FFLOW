using FFlow.Core.Enums;
using FFlow.Core.Utils;

using System.Collections.Generic;
using System.Linq;

namespace FFlow.Core
{
    public class Flow
    {
        public bool CanAssemblyMetadata { get; set; } = true; 

        private readonly List<Fragment> fragments = new List<Fragment>();

        public string Assembly()
        {
            string code = string.Empty;

            code += MakeAssembly(fragments.Where(f => f.Position == Position.Top));
            code += MakeAssembly(fragments.Where(f => f.Position == Position.Middle));
            code += MakeAssembly(fragments.Where(f => f.Position == Position.Bottom));

            return code;
        }

        public virtual void Combine(params Flow[] flows)
        {
            foreach(Flow flow in flows)
            {
                fragments.AddRange(flow.fragments);
            }
        }

        protected virtual void Push(params Fragment[] fragments)
        {
            this.fragments.AddRange(fragments);
        }

        protected virtual void Flush()
        {
            fragments.Clear();
        }

        private string MakeAssembly(IEnumerable<Fragment> fragments)
        {
            string outputCode = string.Empty;

            foreach(Fragment fragment in fragments)
            {
                if(CanAssemblyMetadata)
                {
                    outputCode += CodeFomatter.MakeComment(fragment.Metadata);
                }
                
                outputCode += CodeFomatter.MakeCode(fragment.Assembly());
            }

            return outputCode;
        }
    }
}
