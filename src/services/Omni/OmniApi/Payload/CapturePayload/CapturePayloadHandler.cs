namespace OmniApi.Payload.CapturePayload
{

    public record CapturePayload_Command(DateTime Timestamp, string DataType, double Value, List<object> Properties);
    public record CapturePayload_Result(Guid Id);

    //Link Payload MGG 6/20    
    public class CapturePayloadHandler
    {

    }
}
