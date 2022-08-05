using Symbol.RFID.SDK.Domain.Reader;

namespace Symbol.RFID.SDK.DemoApp.Entities
{
    public class ActiveReaderStatus
    {
        /// <summary>
        /// Is inventory running in batch mode or not.
        /// </summary>
        public static bool IsBatchModeInventoryRunning { get; set; }

        /// <summary>
        /// Is inventory running or not.
        /// </summary>
        public static bool IsInventoryRunning { get; set; }

        /// <summary>
        /// Check whether reader status are initialized or not. 
        /// </summary>
        public static bool Initialized { get; set; }

        /// <summary>
        /// This is to check batch mode while inventory in progress (remote reader is busy, so can't get value via reader at that time)
        /// </summary>
        public static BATCH_MODE BatchMode { get; set; }

        /// <summary>
        /// Is restore default clicked.
        /// </summary>
        public static bool IsRestoreDefaultClicked { get; set; }

        /// <summary>
        /// Gets or Sets flag of isTriggerRepeat.
        /// </summary>
        public static bool IsTriggerRepeat { get; set; }

        /// <summary>
        /// Is Locate Tag running or not.
        /// </summary>
        public static bool IsTagLocateRunning { get; set; }

        /// <summary>
        /// Reset status flag values.
        /// </summary>
        public static void Reset()
        {
            IsTriggerRepeat = false;
            IsRestoreDefaultClicked = false;
            BatchMode = BATCH_MODE.AUTO;
            Initialized = false;
            IsInventoryRunning = false;
            IsBatchModeInventoryRunning = false;
            IsTagLocateRunning = false;
        }
    }
}
