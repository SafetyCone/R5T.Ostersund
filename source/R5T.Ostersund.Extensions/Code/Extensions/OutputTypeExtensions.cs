using System;


namespace R5T.Ostersund.Extensions
{
    public static class OutputTypeExtensions
    {
        public static string ToStringStandard(this OutputType outputType)
        {
            var stringRepresentation = Utilities.ToString(outputType);
            return stringRepresentation;
        }
    }
}
