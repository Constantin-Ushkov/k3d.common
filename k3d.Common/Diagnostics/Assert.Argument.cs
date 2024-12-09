using System.Diagnostics;

namespace k3d.Common.Diagnostics
{
    public static partial class Assert
    {
        public static class Argument
        {
            [DebuggerStepThrough]
            public static void IsNotNull(object? @object, string name)
            {
                if (@object == null)
                {
                    throw new ArgumentNullException(name);
                }
            }

            [DebuggerStepThrough]
            public static void IsNotNullOrEmpty(string? @string, string name)
            {
                if (string.IsNullOrEmpty(@string))
                {
                    throw new ArgumentException($"{name} parameter should not be null or empty string.", name);
                }
            }
        }
    }
}
