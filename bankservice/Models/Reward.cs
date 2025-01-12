using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace bankservice.Models
{
    public class Reward
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // MongoDB document ID

        public Guid RewardId { get; set; }
        public Guid UserId { get; set; }
        public double PointsEarned { get; set; }
        public Guid TransactionId { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double RedeemedPoints { get; set; }
        public double BalancePoints { get; set; }
        public string RewardCategory { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
