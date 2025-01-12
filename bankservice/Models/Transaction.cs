using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Transactions;

namespace bankservice.Models
{
    public class Transaction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // MongoDB document ID

        public Guid TransactionId { get; set; }
        public Guid AccountId { get; set; }
        public Guid UserId { get; set; }
        public Guid CardId { get; set; }
        public TransactionType TransactionType { get; set; } // Enum for transaction type
        public TransactionMode TransactionMode { get; set; } // Enum for transaction mode
        public double Amount { get; set; }
        public string Currency { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionStatus Status { get; set; } // Enum for transaction status
        public Merchant Merchant { get; set; } // Embedded merchant details
        public Guid? ReceiverAccountId { get; set; }
        public double? TransactionFee { get; set; }
        public string Description { get; set; }
        public double? RewardPointsEarned { get; set; }
        public List<LinkedService> LinkedServices { get; set; } // List of linked services
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
