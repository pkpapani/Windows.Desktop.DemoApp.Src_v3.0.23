namespace Symbol.RFID.SDK.DemoApp.Entities
{
    public class TagData
    {
        #region Private Fields

        internal string _tagId;
        internal sbyte _peakRSSI;
        internal ushort _tagSeenCount;
        internal ushort _antennaID;

        #endregion

        #region Public Propeties

        /// <summary>
        /// Gets the Tag ID 
        /// </summary>
        public string TagID { get { return _tagId; } }

        /// <summary>
        /// Gets the Peak RSSI 
        /// </summary>
        public sbyte PeakRSSI { get { return _peakRSSI; } }

        /// <summary>
        /// Gets the Tag seen count
        /// </summary>
        public ushort TagSeenCount { get { return _tagSeenCount; } }

        /// <summary>
        /// Gets the antenna ID on which this tag is seen
        /// </summary>
        public ushort AntennaID { get { return _antennaID; } internal set { _antennaID = value; } }

        #endregion
    }
}
