using Microsoft.VisualBasic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using bankservice.Common.Enums;

namespace bankservice.Models
{
    public class Bill
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } 

        public Guid BillId { get; set; }
        public Guid UserId { get; set; }
        public Guid AccountId { get; set; }
        public Guid CardId { get; set; }
        public BillType BillType { get; set; } 
        public Biller Biller { get; set; } 
        public double Amount { get; set; }
        public string Currency { get; set; }
        public DateTime DueDate { get; set; }
        public BillPymentStatus PaymentStatus { get; set; } 
        public Notification Notifications { get; set; } 
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
