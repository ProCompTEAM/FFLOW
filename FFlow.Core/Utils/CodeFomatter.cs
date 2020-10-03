using System;

namespace FFlow.Core.Utils
{
    public static class CodeFomatter
    {
        private static readonly string line = Environment.NewLine;

        public static string MakeComment(string commentText)
        {
            return $";{commentText}{line}";
        }

        public static string MakeComment(string prefix, string commentText)
        {
            return $"; #{prefix}# {commentText}{line}";
        }

        public static string MakeCode(string fasm, int linesAfter = 2)
        {
            for(int index = 0; index < linesAfter; index++)
            {
                fasm += line;
            }

            return fasm;
        }
    }
}
