namespace OmniApi.Exceptions
{
    public class DeviceNotFoundException :Exception
    {
        public DeviceNotFoundException()
            : base("Device payload not found.")
        {
        }
        public DeviceNotFoundException(string message)
            : base(message)
        {
        }
        public DeviceNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
