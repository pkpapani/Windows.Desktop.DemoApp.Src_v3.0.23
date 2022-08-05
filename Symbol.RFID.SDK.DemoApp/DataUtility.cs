using System;
using System.Windows.Forms;

namespace Symbol.RFID.SDK.DemoApp
{
    internal class DataUtility
    {
        public static byte[] HexStringToByteArray(String s)
        {
            if (string.IsNullOrEmpty(s))
                return new byte[] { };

            int len = s.Length;
            byte[] data = new byte[len / 2];
            for (int i = 0; i < len; i += 2)
            {
                data[i / 2] = Convert.ToByte(s.Substring(i, 2), 16);
            }
            return data;
        }

        public static String ByteArrayToHexString(byte[] data)
        {
            if (data == null)
                return string.Empty;

            string hexString = BitConverter.ToString(data);
            hexString = hexString.Replace("-", "");
            return hexString.ToUpper();
        }


        public static void IsHex(KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == 8 || (e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 70) || (e.KeyChar >= 97 && e.KeyChar <= 102));
        }

        public static void IsNumeric(KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == 8 || (e.KeyChar >= 48 && e.KeyChar <= 57));
        }
    }
}