using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Net.NetworkInformation;
using bankservice.Common.Enums;

namespace bankservice.Models
{
    public class Upi
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } 

        public Guid UpiId { get; set; }
        public Guid UserId { get; set; }
        public Guid AccountId { get; set; }
        public string UpiAddress { get; set; }
        public Status UpiStatus { get; set; } 
        public string LinkedMobile { get; set; }
        public LinkedBank LinkedBank { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? BlockedAt { get; set; }
        public string BlockReason { get; set; }
        public DateTime? LastUsedAt { get; set; }

    }
    public class LinkedBank
    {
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IfscCode { get; set; }
    }
}
