using System.Runtime.Serialization;

namespace OneSignal {
    public enum OutcomeTimeRange {
        [EnumMember(Value = "1h")]
        OneHour,
        [EnumMember(Value = "1d")]
        OneDay,
        [EnumMember(Value = "1mo")]
        OneMonth
    }
}
