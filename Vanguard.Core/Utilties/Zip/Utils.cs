﻿using System.Diagnostics;

namespace Vanguard.Core.Utilties.Zip
{
    public static class Utils
    {
        public static UInt16 LEU16(byte[] value, int startIndex)
        {
            return BitConverter.ToUInt16(value, startIndex);
        }

        public static byte[] LEU16(UInt16 value)
        {
            return BitConverter.GetBytes(value);
        }

        public static byte[] BEU32(UInt32 value)
        {
            byte[] Result = BitConverter.GetBytes(value);

            Array.Reverse(Result);

            return Result;
        }

        public static void Crc16(byte data, ref UInt16 crc)
        {
            for (byte i = 0; i < 8; i++)
            {
                if (((data & 0x01) ^ (crc & 0x0001)) != 0)
                {
                    crc = (ushort)(crc >> 1);
                    crc = (ushort)(crc ^ 0xA001);
                }
                else
                    crc = (ushort)(crc >> 1);

                data = (byte)(data >> 1);
            }
        }

        public static void OutDbgStr(string DbgType, string DbgCode, string DebugLine)
        {
            var logLine = DateTime.Now.ToString("HH:mm:ss.fff") + " " +
                          DbgType.PadRight(3, ' ') + " " +
                          DbgCode.PadRight(20, ' ') + " " +
                          DebugLine;

#if DEBUG
            if (Environment.UserInteractive)
            {
                Console.WriteLine(logLine);
            }
            else
                Debug.WriteLine(logLine);
#endif
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

    }
}
