using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Symbol.RFID.SDK.DemoApp.Entities
{
    public class TagDataListViewItem
    {
        private long tagSeenTotalCount = 0;
        private int rowIndex = -1;
        private TagData tagData;

        public TagDataListViewItem(TagData tg, int rowID, long tagSeenTotalCount)
        {
            this.tagData = tg;
            this.rowIndex = rowID;
            this.tagSeenTotalCount = tagSeenTotalCount;
        }
        
        public TagData Tag
        {
            get { return this.tagData; }
            set { this.tagData = value; }
        }
       
        public int RowIndex
        {
            get { return this.rowIndex; }
            set { this.rowIndex = value; }
        }

        public long TagSeenTotalCount
        {
            get { return this.tagSeenTotalCount; }
            set { this.tagSeenTotalCount = value; }
        }
    }
}
