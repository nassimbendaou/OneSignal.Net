using System;

namespace OneSignal {
    public class OneSignalException : Exception {
        /// <summary>
        /// Error message returned from the OneSignal API
        /// </summary>
        public OneSignalError OneSignalError { get; private set; }

        public OneSignalException(string message) : base(message) { }

        public OneSignalException(string message, OneSignalError error) : base(message) {
            OneSignalError = error;
        }
    }
}
