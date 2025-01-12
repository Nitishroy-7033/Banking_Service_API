using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using bankservice.Common.Enums;

namespace bankservice.Models
{
    public class Notification
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // MongoDB document ID

        public Guid NotificationId { get; set; }
        public Guid UserId { get; set; }
        public NotificationType NotificationType { get; set; } // Enum for notification type
        public string Message { get; set; }
        public NotificationStatus Status { get; set; } // Enum for notification status
        public DateTime SentAt { get; set; }
        public DateTime ReceivedAt { get; set; }
        public NotificationChannel Channel { get; set; } // Enum for notification channel
        public DateTime CreatedAt { get; set; }
    }
}
