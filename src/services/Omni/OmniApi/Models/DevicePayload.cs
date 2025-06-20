using Microsoft.VisualBasic;

namespace OmniApi.Models
{
    public class DevicePayload
    {   
        //Reference of Document Identifier in the document database.MGG 6/20
        public Guid Id { get; set; }          
        //Link Payload MGG 6/20
        public DateTime Timestamp { get; set; }
        public string DataType { get; set; }
        public double Value { get; set; }
        public List<object> Properties { get; set; } = new List<object>();

    }
}
