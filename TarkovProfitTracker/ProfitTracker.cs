using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace TarkovProfitTracker
{

    public class ProfitTracker
    {
        public struct TrackingData
        {
            public DateTime Date;
            public Int64 Roubles;
            public Int64 Euros;
            public Int64 Dollars;

            private Int64 RGain;
            private Int64 EGain;
            private Int64 DGain;

            public TrackingData( DateTime InDate, Int64 InRoubles, Int64 InEuros, Int64 InDollars )
            {
                Date = InDate;
                Roubles = InRoubles;
                Euros = InEuros;
                Dollars = InDollars;

                RGain = 0;
                EGain = 0;
                DGain = 0;
            }

            public void UpdateGain(Int64 InRGain, Int64 InEGain, Int64 InDGain )
            {
                RGain = InRGain;
                EGain = InEGain;
                DGain = InDGain;
            }

            public Int64 GetRGain()
            {
                return RGain;
            }

            public Int64 GetEGain()
            {
                return EGain;
            }

            public Int64 GetDGain()
            {
                return DGain;
            }
        }

        static string DataFilePath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Data\";
        static string DataFileName = @"test.csv";
        static string DataFileLocation = DataFilePath + DataFileName;
        

        void CalculateGain( string Previous, ref TrackingData CurrentData )
        {
            var PreviousData = Previous.Split(',');
            Int64 PreviousRoubles = Int64.Parse(PreviousData[1]);
            Int64 PreviousEuros = Int64.Parse(PreviousData[2]);
            Int64 PreviousDollars = Int64.Parse(PreviousData[3]);

            Int64 RGain = CurrentData.Roubles - PreviousRoubles;
            Int64 EGain = CurrentData.Euros - PreviousEuros;
            Int64 DGain = CurrentData.Dollars - PreviousDollars;

            CurrentData.UpdateGain( RGain, EGain, DGain );
        }

        public void UpdateTracker( TrackingData Data )
        {
            if (!File.Exists(DataFileLocation))
            {
                Directory.CreateDirectory(DataFilePath);
                var NewFile = File.Create(DataFileLocation);
                NewFile.Close();
            }

            IEnumerable<string> FileData = File.ReadLines(DataFileLocation);
            string delimiter = ",";

            if (FileData.Count() > 1)
            {
                string lastLine = FileData.Last();
                CalculateGain(lastLine, ref Data);
            }
            else
            {
                RebuildDataFile();
            }

            string[][] output = new string[][]
            {
                new string[]
                {
                    Data.Date.ToShortDateString(),
                    Data.Roubles.ToString(),
                    Data.Euros.ToString(),
                    Data.Dollars.ToString(),
                    Data.GetRGain().ToString(),
                    Data.GetEGain().ToString(),
                    Data.GetDGain().ToString()
                }   
            };

            int length = output.GetLength(0);
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < length; index++)
            {
                sb.AppendLine(string.Join(delimiter, output[index]));
            }

            File.AppendAllText(DataFileLocation, sb.ToString());
        }

        public void RebuildDataFile()
        {
            string filePath = DataFileLocation;
            string delimiter = ",";

            string[][] output = new string[][]{
                new string[]{ "Date,Roubles (RUB), Euros (€) , Dollars ($) , Gain(RUB) , Gain(€) , Gain($)" },
            };
            int length = output.GetLength(0);
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < length; index++)
            {
                sb.AppendLine(string.Join(delimiter, output[index]));
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        public IEnumerable<string> GetTableData()
        {
            string filePath = DataFileLocation;

            return File.ReadLines(filePath);
        }
    }
}
