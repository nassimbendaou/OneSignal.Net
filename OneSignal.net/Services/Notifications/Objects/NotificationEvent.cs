using System.Runtime.Serialization;

namespace OneSignal {
    public enum NotificationEvent {
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "clicked")]
        Clicked
    }
}
