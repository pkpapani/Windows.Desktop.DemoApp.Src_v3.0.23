using Symbol.RFID.SDK.DemoApp.Entities;
using Symbol.RFID.SDK.Domain.Reader;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Symbol.RFID.SDK.DemoApp
{
    public class TagUtility
    {
        #region Public Methods

        public static TagData GetTagData(ushort antennaId, string tagId, ushort tagSeenCount, sbyte peakRSSI)
        {
            TagData data = new TagData();
            data._antennaID = antennaId;
            data._tagId = tagId;
            data._tagSeenCount = tagSeenCount;
            data._peakRSSI = peakRSSI;
            return data;
        }

        /// <summary>
        /// This method fetches a array of Tags that was read by the reader. 
        /// Tags will be read from the Reader using methods: Actions.Inventory.Perform or 
        /// Actions.TagAccess.ReadEvent or Actions.TagAccess.ReadWait.
        /// </summary>
        /// <param name="numberOfTags">Number of Tags that is to be fetched</param>
        /// <returns>An array of TagData if the method succeeds or an empty array if no Tags were available</returns>
        public static TagData[] GetReadTags(int numberOfTags, IRfidReader reader)
        {
            List<ITagData> tagDataReceived = RFIDLibraryUtility.GetReadTags(numberOfTags, reader);

            var temp = new Queue();
            foreach (ITagData dataReceived in tagDataReceived)
            {
                var tagData = new TagData
                {
                    AntennaID = 1,
                    _tagId = dataReceived.EPCId,
                    _tagSeenCount = dataReceived.TagSeenCount,
                    _peakRSSI = dataReceived.RSSI
                };

                temp.Enqueue(tagData);
            }
            return (temp.Count > 0) ? temp.ToArray().OfType<TagData>().ToArray() : null;
        }

        #endregion
    }
}
