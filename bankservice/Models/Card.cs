using bankservice.Common.Enums;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Transactions;

namespace bankservice.Models
{
    public class Card
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // MongoDB document ID
        public Guid CardId { get; set; }
        public Guid AccountId { get; set; }
        public Guid UserId { get; set; }
        public CardType CardType { get; set; } // Enum for CardType
        public string CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CVV { get; set; }
        public string PinHash { get; set; }
        public Status CardStatus { get; set; } 
        public DateTime IssuedAt { get; set; }
        public DateTime? BlockedAt { get; set; }
        public string? BlockedReason { get; set; }
        public DateTime? ActivationDate { get; set; }
        public DateTime? LastUsedDate { get; set; }
        public List<string> LinkedServices { get; set; } 
        public double? CreditLimit { get; set; }
        public double? CurrentOutstanding { get; set; }
        public double? RewardPoints { get; set; }
        public List<Transaction> Transactions { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
