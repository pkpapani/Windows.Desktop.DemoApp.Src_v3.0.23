using Symbol.RFID.SDK.DemoApp.Entities;

namespace Symbol.RFID.SDK.DemoApp.Globals
{
    public class TagInfo
    {
        private int rowIndex = -1;
        private long tagSeenCount = 0;

        public TagInfo(TagData tg, int rowID, long tagSeenCnt)
        {
            Tag = tg;
            RowIndex = rowID;
            TagSeenTotalCount = tagSeenCnt;
        }
        public TagData Tag { get; set; }
        public int RowIndex { get { return rowIndex; } set { rowIndex = value; } }
        public long TagSeenTotalCount { get { return tagSeenCount; } set { tagSeenCount = value; } }
    }
}
