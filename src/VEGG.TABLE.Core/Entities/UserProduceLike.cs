namespace VEGG.TABLE.Core.Entities;

public class UserProduceLike
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int ProduceId { get; set; }
        public Produce Produce { get; set; }

        public DateTime LikedAt { get; set; } = DateTime.UtcNow;
    }
