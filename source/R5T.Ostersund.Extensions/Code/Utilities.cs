using System;

using R5T.Angleterria;
using R5T.Magyar;


namespace R5T.Ostersund.Extensions
{
    public static class Utilities
    {
        public static string ToString(TargetFramework targetFramework)
        {
            switch(targetFramework)
            {
                case TargetFramework.NetCoreApp22:
                    return TargetFrameworkName.NetCoreApp2_2;

                case TargetFramework.NetStandard20:
                    return TargetFrameworkName.NetStandard2_0;

                default:
                    throw EnumerationHelper.UnexpectedEnumerationValueException(targetFramework);
            }
        }

        public static TargetFramework ToTargetFramework(string targetFrameworkString)
        {
            switch(targetFrameworkString)
            {
                case TargetFrameworkName.NetCoreApp2_2:
                    return TargetFramework.NetCoreApp22;

                case TargetFrameworkName.NetStandard2_0:
                    return TargetFramework.NetStandard20;

                default:
                    throw EnumerationHelper.UnrecognizedEnumerationValueException<TargetFramework>(targetFrameworkString);
            }
        }

        public static string ToString(OutputType outputType)
        {
            switch(outputType)
            {
                case OutputType.Executable:
                    return OutputTypeName.Executable;

                default:
                    throw EnumerationHelper.UnexpectedEnumerationValueException(outputType);
            }
        }

        public static OutputType ToOutputType(string outputTypeString)
        {
            switch(outputTypeString)
            {
                case OutputTypeName.Executable:
                    return OutputType.Executable;

                default:
                    throw EnumerationHelper.UnrecognizedEnumerationValueException<OutputType>(outputTypeString);
            }
        }
    }
}
