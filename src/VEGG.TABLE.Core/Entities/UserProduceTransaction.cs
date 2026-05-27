namespace VEGG.TABLE.Core.Entities;
public class UserProduceTransaction
    {
        public int BuyerId { get; set; }
        public User Buyer { get; set; }

        public int SellerId { get; set; }
        public User Seller { get; set; }


        public int ProduceId { get; set; }
        public Produce Produce { get; set; }

        public DateTime PurchasedAt { get; set; } = DateTime.UtcNow;
    }

