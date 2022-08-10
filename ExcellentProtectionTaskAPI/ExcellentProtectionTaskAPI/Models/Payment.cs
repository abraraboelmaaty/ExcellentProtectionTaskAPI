using System.Text.Json.Serialization;

namespace ExcellentProtectionTaskAPI.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public double Ammount { get; set; } 
        //[JsonIgnore]
        //public double Paid { get; set; }
        //[JsonIgnore]
        //public double? Rest { get; set; }
        //[JsonIgnore]
        public DateTime Date { get; set; }
        [JsonIgnore]
        public virtual ICollection<OrderPayment>? orders { get; set; }

    }
}
