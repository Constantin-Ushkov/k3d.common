
namespace k3d.Common.Diagnostics
{
    public static partial class Assert
    {
        public static void IsNotNull(object? @object, string message)
        {
            if (@object == null)
            {
                throw new AssertionFailedException(
                    $"Objects is null. Message: {message}.");
            }
        }

        public static void AreEquals<T>(T expected, T actual)
        {
            // todo: ensure there is no boxing
            if (!EqualityComparer<T>.Default.Equals(expected, actual))
            {
                throw new AssertionFailedException(
                    $"Objects are not equal. Expected: {expected}, actual: {actual}.");
            }
        }

        public static void AreEquals<T>(T expected, T actual, string errorMessage)
        {
            // todo: ensure there is no boxing
            if (!EqualityComparer<T>.Default.Equals(expected, actual))
            {
                throw new AssertionFailedException(errorMessage);
            }
        }
    }
}
