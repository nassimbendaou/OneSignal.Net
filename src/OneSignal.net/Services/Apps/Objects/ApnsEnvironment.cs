using System.Runtime.Serialization;

namespace OneSignal {
    public enum ApnsEnvironment {
        [EnumMember(Value = "sandbox")]
        Sandbox,
        [EnumMember(Value = "production")]
        Production
    }
}
