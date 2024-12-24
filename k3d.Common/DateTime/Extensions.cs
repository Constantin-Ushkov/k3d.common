
namespace k3d.Common.DateTime
{
    public static class Extensions
    {
        public static System.DateTime TrimMilliseconds(this System.DateTime dt)
        {
            return dt.AddMilliseconds(-dt.Millisecond);
        }
    }
}
