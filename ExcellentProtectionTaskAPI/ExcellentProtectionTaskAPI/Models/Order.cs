using ExcellentProtectionTaskAPI.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ExcellentProtectionTaskAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        //[JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string? status
        {
            get;
            //{
            //    if (Rest <= 0)
            //        return "Paid";
            //    else if (Rest < TotalPrice || Rest>0)
            //        return "partialPaid";
            //    return "NotPaid";
            //}
            private set;
        }
        //[JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? TotalPrice { get;/*{ return Quantity * Price; }*/ private set; }
        //[JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? Paid
        {
            get;
            //{
            //    double? result = 0;
            //    List<OrderPayment> paymentList = new List<OrderPayment>();
            //    foreach (var item in payments)
            //    {
            //        if (item.OrderId == Id)
            //            paymentList.Add(item);
            //    }
            //    foreach (var payment in paymentList)
            //    {
            //        result += payment.payment.Ammount;
            //    }
            //    return result;
            //}
            private set;
        }
        //[JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? Rest { get; /*{ return TotalPrice - Paid; }*/ private set; }
        [JsonIgnore]
        public virtual ICollection<OrderPayment>? payments { get; set; }

    }
}
