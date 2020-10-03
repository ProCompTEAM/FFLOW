using FFlow.Framework.Flows;

namespace FFlow.Tests.Test1
{
    public class Test1 : Test
    {
        private readonly Program86 program = new Program86();

        protected override string TestName => "Test1";

        public override void Execute()
        {
            ProgramFlow flow = new ProgramFlow(TestName, SourceDirectory)
            {
                CanAssemblyMetadata = false
            };

            flow.Combine(program);

            string filename = flow.Save();
            OpenEditor(filename);
        }
    }
}
