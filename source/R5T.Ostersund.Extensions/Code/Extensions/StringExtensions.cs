using System;


namespace R5T.Ostersund.Extensions
{
    public static class StringExtensions
    {
        public static TargetFramework ToTargetFramework(this string @string)
        {
            var targetFramework = Utilities.ToTargetFramework(@string);
            return targetFramework;
        }

        public static OutputType ToOutputType(this string @string)
        {
            var outputType = Utilities.ToOutputType(@string);
            return outputType;
        }
    }
}
