﻿using System;
using System.Linq;
using System.Runtime.Serialization;

namespace OneSignal {
    internal static class EnumExtensions {
        public static string ToEnumMemberAttrValue(this Enum @enum) {
            var attr =
                @enum.GetType().GetMember(@enum.ToString()).FirstOrDefault()?.
                    GetCustomAttributes(false).OfType<EnumMemberAttribute>().
                    FirstOrDefault();
            if (attr == null)
                return @enum.ToString();
            return attr.Value;
        }
    }
}
