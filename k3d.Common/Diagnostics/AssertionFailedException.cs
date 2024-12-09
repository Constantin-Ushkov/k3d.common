
namespace k3d.Common.Diagnostics
{
    public class AssertionFailedException : k3dException
    {
        public AssertionFailedException(string message) :
            base(message)
        {
        }

        public AssertionFailedException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}
