// This Class define format of ecg

using System;
using System.Collections.Generic;
using System.Text;

namespace ECGWorkStation
{
    public class ECGData
    {
        public List<long>  Time;      // Time values
        public List<float> Sign;      // Volt values      

        public List<Notice> Notices;

        public ECGData()
        {
            Time = new List<long>();
            Sign = new List<float>();
        }

        public ECGData(List<long> xArg, List<float> yArg)
        {
            this.Time = xArg;
            this.Sign = yArg;
        }

        public ECGData(ECGData Copy)
        {
            this.Sign = new List<float>(Copy.Sign);
            this.Time = new List<long>(Copy.Time);
        }

        //public List<Double> Time { get; set; }

        //public List<Double> Sign { get; set; }

        public long LastTime
        {
            get
            {
                if (Time.Count > 0) return Time[Time.Count - 1];
                else                return 0;
            }
            set
            {
                Time.Add(value);
            }
        }

        public float LastSign
        {
            get
            {
                if(Sign.Count > 0) return Sign[Sign.Count - 1];
                return 0;
            }
            set
            {
                Sign.Add(value);
            }
        }

        public int Count
        {
            get
            {
                //return Math.Min(Time.Count, Sign.Count);
                return Time.Count < Sign.Count ? Time.Count : Sign.Count;
            }
        }

        public ECGData SubData(int StartIndex, int Length)
        {
            ECGData subdata = new ECGData();
            for (int i = StartIndex; (i < StartIndex + Length) && (i < Count); i++)
            {
                subdata.LastSign = Sign[i];
                subdata.LastTime = Time[i];
            }

            return subdata;
        }

        public ECGData LastSubData(int Length)
        {
            //return SubData(0 > count - Length ? 0 : count - Length, Length > count ? Length : count);
            return SubData(0 > (Count - Length) ? 0 : Count - Length, Length);
        }

        public void Add(ECGData ECGData)
        {
            for (int i = 0; i < ECGData.Count; i++)
            {
                LastSign = ECGData.Sign[i];
                LastTime = ECGData.Time[i];
            }
        }

        public void Reset()
        {
            Time.Clear();
            Sign.Clear();
        }
    }
}
