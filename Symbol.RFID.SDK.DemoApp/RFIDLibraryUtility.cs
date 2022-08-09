using System;
using System.Collections.Generic;
using Symbol.RFID.SDK.DemoApp.Entities;
using Symbol.RFID.SDK.Domain.Reader;

namespace Symbol.RFID.SDK.DemoApp
{
    /// <summary>
    /// Represents all supported features from the RFID SDK which can be used with RFID SDK based any application developement.  
    /// </summary>
    /// <remarks>This library class can be directly copied from here and reuse with your RFID SDK based sample application.</remarks>
    public class RFIDLibraryUtility
    {
        #region Home Operations

        /// <summary>
        /// Initializes the readers.
        /// </summary>
        public static List<IRfidReaderInfo> InitReaderList(ReaderCommunicationMode mode)
        {
            var readerManager = RfidSdk.ReaderManagementServicesFactory.Create(mode);
            //get available readers list
            var readerInfoList = readerManager.GetReaders(ReaderSearchOptions.AllReaders);

            return readerInfoList;
        }

        /// <summary>
        ///Creates reader instance based on reader information.
        /// </summary>
        /// <param name="readerInfo"></param>
        /// <returns></returns>
        public static IRfidReader CreateReader(IRfidReaderInfo readerInfo)
        {
            return RfidSdk.RfidReaderFactory.Create(readerInfo);
        }

        /// <summary>
        /// Connects the device.
        /// </summary>
        public static void Connect(IRfidReader reader)
        {
            reader.Connect();
        }

        /// <summary>
        /// Disconnects the device.
        /// </summary>
        public static void Disconnect(IRfidReader reader)
        {
            //call when reader manually disconnect
            reader.Disconnect();
        }

        #endregion

        #region Inventory Operations

        /// <summary>
        /// Perform inventory process.
        /// </summary>
        /// <param name="reader"></param>
        public static void InventoryPerfom(IRfidReader reader)
        {
            reader.Inventory.Perform();
        }

        /// <summary>
        /// Stops an ongoing inventory.
        /// </summary>
        /// <param name="reader"></param>
        public static void StopInventory(IRfidReader reader)
        {
            reader.Inventory.Stop();
        }

        /// <summary>
        /// Get batch tags once the inventory in batch mode.
        /// </summary>
        public static void GetBatchedTags(IRfidReader reader)
        {
            try
            {
                if (reader != null)
                {
                    reader.Inventory.GetBatchedTags();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Purge tags.
        /// </summary>
        public static void PurgeTags(IRfidReader reader)
        {
            try
            {
                if (reader != null)
                {
                    reader.Inventory.PurgeTags();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetches an array of tags that was read by the reader.
        /// </summary>
        /// <param name="numberOfTags">Number of Tags that is to be fetched.</param>
        /// <param name="reader"></param>
        /// <returns>A list of TagDataInfo if the method succeeds or an empty array if no Tags were available.</returns>
        public static List<ITagData> GetReadTags(int numberOfTags, IRfidReader reader)
        {
            return reader.Inventory.GetReadTags(numberOfTags);
        }

        /// <summary>
        /// Get Tag data via queue
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static ITagData GetNextTagDataReceived(IRfidReader reader)
        {
            return reader.Inventory.GetNextTagDataReceived();
        }

        #endregion

        #region Locate Tag Operations

        /// <summary>
        /// Perform  tag locate process.
        /// </summary>
        /// <param name="reader"></param>
        public static void PerfomTagLocate(IRfidReader reader, string epc)
        {
            reader.TagLocate.Perform(epc);
        }

        /// <summary>
        /// Stops an ongoing tag locate.
        /// </summary>
        /// <param name="reader"></param>
        public static void StopTagLocate(IRfidReader reader)
        {
            reader.TagLocate.Stop();
        }

        #endregion

        #region Access Operations

        public static void ReadTag(IRfidReader reader)
        {
            reader.AccessOperations.TagRead.Read();
        }

        public static void WriteTag(IRfidReader reader)
        {
            reader.AccessOperations.TagWrite.Write();
        }

        public static void LockTag(IRfidReader reader)
        {
            reader.AccessOperations.TagLock.Lock();
        }

        public static void KillTag(IRfidReader reader)
        {
            reader.AccessOperations.TagKill.Kill();
        }
        #endregion

        #region Antenna

        /// <summary>
        /// Gets the antenna configuration.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>AntennaConfiguration</returns>
        public static AntennaConfiguration GetAntennaConfigurations(IRfidReader reader)
        {
            ushort[] antID = new ushort[1];
            return reader.Configurations.Antennas[antID[0]].Configuration;
        }

        /// <summary>
        /// Sets the antenna configuration.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="antennaConfig"></param>
        public static void SetAntennaConfigurations(IRfidReader reader, AntennaConfiguration antennaConfig)
        {
            ushort[] antID = new ushort[1];
            reader.Configurations.Antennas[antID[0]].Configuration = antennaConfig;
        }

        #endregion

        #region Capabilities

        /// <summary>
        /// Gets the capabilities of the reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static Capabilities GetCapabilities(IRfidReader reader)
        {
            return reader.Capabilities;
        }

        #endregion

        #region Configuration

        /// <summary>
        /// Gets the beeper volume.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static BEEPER_VOLUME GetBeeperVolume(IRfidReader reader)
        {
            return reader.Configurations.BeeperVolume;
        }

        /// <summary>
        /// Sets the beeper volume.
        /// </summary>
        /// <param name="reader">RFID Reader</param>
        /// <param name="bEEPER_VOLUME">Beeper Volume</param>
        public static void SetBeeperVolume(IRfidReader reader, BEEPER_VOLUME bEEPER_VOLUME)
        {
            reader.Configurations.BeeperVolume = bEEPER_VOLUME;
        }

        /// <summary>
        /// Gets the Trigger Mode 
        /// </summary>
        /// <param name="reader">RFID Reader</param>
        /// <returns>Trigger Mode</returns>
        public static TRIGGER_MODE GetTriggerMode(IRfidReader reader)
        {
            return reader.Configurations.TriggerModeConfig;
        }

        /// <summary>
        /// Sets the Trigger Mode
        /// </summary>
        /// <param name="reader">RFID Reader</param>
        /// <param name="trigger_mode">Trigger Mode</param>
        public static void SetTriggerMode(IRfidReader reader, TRIGGER_MODE trigger_mode)
        {
            reader.Configurations.TriggerModeConfig = trigger_mode;
        }

        /// <summary>
        /// Gets device status in terms of battery, power and temperature.
        /// </summary>
        /// <param name="battery">battery events required.</param>
        /// <param name="power">power events required.</param>
        /// <param name="temperature">temperature events required.</param>
        public static void GetDeviceStatus(IRfidReader reader, bool batteryStatus, bool powerStatus, bool temperatureStatus)
        {
            reader.Configurations.GetDeviceStatus(batteryStatus, powerStatus, temperatureStatus);
        }

        /*
        /// <summary>
        /// Get RSM attribute value from the device.
        /// </summary>
        /// <param name="reader">RFID Reader</param>
        /// <param name="attribute">RSM attribute</param>
        /// <returns></returns>
        public static RsmAttribute GetAttribute(IRfidReader reader, int attribute)
        {
            return reader.RemoteScannerManagement.GetAttribute(attribute);
        }
        */

        /*
        /// <summary>
        /// Set RSM attribute value to the device.
        /// </summary>
        /// <param name="reader">RFID Reader</param>
        /// <param name="attribute">RSM attribute</param>
        /// <param name="attribute">RSM attribute</param>
        /// <param name="attribute">RSM attribute</param>
        /// <returns></returns>
        public static string SetAttribute(IRfidReader reader, int attribute, string type, string value)
        {
            return reader.RemoteScannerManagement.SetAttribute(attribute, type, value).ToString();
        }
        */

        #endregion

        #region Regulatory

        /// <summary>
        /// Gets regulatory configuration.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>The regulatory configuration.</returns>
        public static RegulatoryConfig GetRegion(IRfidReader reader)
        {
            return reader.Configurations.RegulatoryConfig;
        }

        /// <summary>
        /// Set regulatory configuration
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="regulatoryConfig"></param>
        public static void SetRegion(IRfidReader reader, RegulatoryConfig regulatoryConfig)
        {
            reader.Configurations.RegulatoryConfig = regulatoryConfig;
        }

        #endregion

        #region Pre-Filters

        #endregion

        #region Singulation


        /// <summary>
        /// Gets the singulation control.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="curAntennaID">Antenna ID</param>
        /// <returns></returns>
        public static SingulationControl GetSingulation(IRfidReader reader, int curAntennaID)
        {
            return reader.Configurations.Antennas[curAntennaID].SingulationControl;
        }

        /// <summary>
        /// Sets the singulation control.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="curAntennaID"></param>
        /// <param name="singulationControl"></param>
        public static void SetSingulation(IRfidReader reader, int curAntennaID, SingulationControl singulationControl)
        {
            reader.Configurations.Antennas[curAntennaID].SingulationControl = singulationControl;
        }

        #endregion

        #region Tag Reporting

        /// <summary>
        /// Gets the batch mode configuration.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static BATCH_MODE GetBatchMode(IRfidReader reader)
        {
            return reader.Configurations.BatchModeConfig;
        }

        /// <summary>
        /// Sets the batch mode configuration.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="batchMode"></param>
        public static void SetBatchMode(IRfidReader reader, BATCH_MODE batchMode)
        {
            reader.Configurations.BatchModeConfig = batchMode;
            ActiveReaderStatus.BatchMode = batchMode;
        }

        /// <summary>
        /// Gets the tag data report configuration.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static ReportConfig GetTagReportConfig(IRfidReader reader)
        {
            return reader.Configurations.ReportConfig;
        }

        /// <summary>
        /// Sets the tag data report configuration.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="tagdataInfo"></param>
        public static void SetTagReportConfig(IRfidReader reader, ReportConfig reportConfig)
        {
            reader.Configurations.ReportConfig = reportConfig;
        }

        #endregion

        #region Triggers

        /// <summary>
        /// Sets IsTirggerRepeat bool value.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="isTriggerRepeat"></param>
        public static bool IsTriggerRepeat(IRfidReader reader)
        {
            var isTriggerRepeat = false;

            if (reader != null)
            {
                var startTriggerType = reader.Configurations.TriggerInfo.StartTrigger.Type;

                if (startTriggerType == START_TRIGGER_TYPE.START_TRIGGER_TYPE_PERIODIC || startTriggerType == START_TRIGGER_TYPE.START_TRIGGER_TYPE_HANDHELD)
                {
                    isTriggerRepeat = true;
                }
            }
            return isTriggerRepeat;

        }

        /// <summary>
        /// Gets the trigger information.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static TriggerInfo GetTriggerInformation(IRfidReader reader)
        {
            return reader.Configurations.TriggerInfo;
        }

        /// <summary>
        /// Sets the trigger information.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="triggerInfo"></param>
        public static void SetTriggerInformation(IRfidReader reader, TriggerInfo triggerInfo)
        {
            reader.Configurations.TriggerInfo = triggerInfo;
            ActiveReaderStatus.IsTriggerRepeat = RFIDLibraryUtility.IsTriggerRepeat(reader);
        }

        #endregion

        #region Version

        /// <summary>
        /// Gets the version info of the reader.
        /// </summary>
        /// <returns></returns>
        public static Domain.Reader.Version GetVersionInfo(IRfidReader reader)
        {
            return reader.Version;
        }

        #endregion

        #region Restore Default

        /// <summary>
        /// Restores default the device.
        /// </summary>
        /// <param name="reader"></param>
        public static void RestoreDefault(IRfidReader reader)
        {
            if (reader != null)
            {
                reader.ResetFactoryDefaults();
            }
        }

        #endregion

        #region Save Configuration

        /// <summary>
        /// This method is used to make the current configuration persist over power down and power up cycles.
        /// </summary>
        /// <param name="reader"></param>
        public static void SaveConfiguration(IRfidReader reader)
        {
            reader.Configurations.SaveConfig();
        }

        #endregion
    }
}
