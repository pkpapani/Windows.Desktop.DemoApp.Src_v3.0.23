namespace Symbol.RFID.SDK.DemoApp.Entities
{
    public class FilterData
    {
        #region Public Propeties       

        public int Action { get; set; }

        public bool IsEnable { get; set; }

        public int MemoryBank { get; set; }

        public short OffSet { get; set; }       

        public string TagPattern { get; set; }

        public int Target { get; set; }

        #endregion
    }
}
