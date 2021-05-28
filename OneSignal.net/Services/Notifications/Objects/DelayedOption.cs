using System.Runtime.Serialization;

namespace OneSignal {
    public enum DelayedOption {
        [EnumMember(Value = "timezone")]
        Timezone,
        [EnumMember(Value = "last-active")]
        LastActive
    }
}
