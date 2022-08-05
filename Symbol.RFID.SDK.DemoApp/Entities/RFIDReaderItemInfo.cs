using Symbol.RFID.SDK.Domain.Reader;
using System;

namespace Symbol.RFID.SDK.DemoApp.Entities
{
    /// <summary>
    /// Hold the RFID reader information
    /// </summary>
    public class RFIDReaderItemInfo
    {
        /// <summary>
        /// Friendly name of the reader
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Host address of the reader
        /// </summary>
        public string HostAddress { get; set; }

        /// <summary>
        /// Bluetooth address of the reader
        /// </summary>
        [Obsolete("This property is deprecated, use instead of \"HostAddress\".")]
        public string BluetoothAddress { get; set; }

        /// <summary>
        /// Port number of the reader
        /// </summary>
        public string PortNumber { get; set; }

        /// <summary>
        /// ComPort number of the reader
        /// </summary>
        [Obsolete("This property is deprecated, use instead of \"PortNumber\".")]
        public string ComPortNumber { get; set; }


        /// <summary>
        /// Gets the communication method of reader.
        /// </summary>
        /// <value>The Communication.</value>
        public ReaderCommunicationMode CommunicationMode { get; set; }

        /// <summary>
        /// Gets the status of reader.
        /// </summary>
        /// <value>The status.</value>
        public ReaderStatus Status { get; set; }

        /// <summary>
        /// RFID reader
        /// </summary>
        public IRfidReader Reader { get; set; }
    }
}
