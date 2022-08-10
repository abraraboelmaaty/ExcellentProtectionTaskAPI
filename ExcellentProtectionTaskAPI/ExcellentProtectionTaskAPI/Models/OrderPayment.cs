using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ExcellentProtectionTaskAPI.Models
{
    public class OrderPayment
    {
        [ForeignKey("order")]
        public int OrderId { get; set; }
        [ForeignKey("payment")]
        public int PaymentId { get; set; }
        [JsonIgnore]
        public Payment? payment { get; set; }
        [JsonIgnore]
        public Order? order { get; set; }
        public DateTime? Date { get; set; }

    }
}
