using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using bankservice.Common.Enums;

namespace bankservice.Models
{
    public class Account
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // MongoDB document ID

        public string AccountId { get; set; }
        public string UserId { get; set; }
        public AccountType AccountType { get; set; } // Example: "SAVING"
        public string AccountName { get; set; }
        public double Balance { get; set; }
        public string Currency { get; set; }
        public double? InterestRate { get; set; }
        public double? OverdraftLimit { get; set; }
        public Status AccountStatus { get; set; } 
        public string? BlockedReason { get; set; }
        public DateTime? BlockedAt { get; set; }
        public DateTime? LastTransactionDate { get; set; }
        public double MinimumBalance { get; set; }
        public int RewardPoints { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? ClosedAt { get; set; }
    }
}
