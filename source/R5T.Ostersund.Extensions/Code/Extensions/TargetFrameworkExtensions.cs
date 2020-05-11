using System;


namespace R5T.Ostersund.Extensions
{
    public static class TargetFrameworkExtensions
    {
        public static string ToStringStandard(this TargetFramework targetFramework)
        {
            var standardRepresentation = Utilities.ToString(targetFramework);
            return standardRepresentation;
        }
    }
}
