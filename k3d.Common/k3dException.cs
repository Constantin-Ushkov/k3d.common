namespace k3d.Common
{
    public class k3dException: Exception
    {
        public k3dException(string message) :
            base(message)
        {
        }

        public k3dException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}
