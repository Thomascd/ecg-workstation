using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECGWorkStation
{
    class QRSDetect
    {
        ECGData Data = null;
        int LastCount = 0;
        float lastR = 0;
        public int HR, QR, RS, QRS, R;

        List<int> R_location;
        List<int> Q_location;
        List<int> S_location;

        Boolean Detected = false;

        /************************************************************************/
        /* Constructor.                                                         */
        /************************************************************************/

        public QRSDetect() {}

        public QRSDetect(ECGData Data) 
        {
            this.Data = Data;
        }

        /************************************************************************/
        /* find QRS function                                                    */
        /************************************************************************/

        public void FindQRS()
        {
            FindQRS(Data);
        }

        public bool FindQRS(ECGData SessionData)
        {
            if (SessionData.Count == 0) return false;

            List<float> Sign_value = new List<float>();
            Sign_value = SessionData.Sign;
			//List<float> Sign_value   = SessionData.Sign;
			int          lenghtOfSign = Sign_value.Count;

            R_location = new List<int>();
            Q_location = new List<int>();
            S_location = new List<int>();

            Sign_value = cancelDC(Sign_value);
            Sign_value = LowPassFilter(Sign_value);
            Sign_value = HightPassFilter(Sign_value);
            Sign_value = derivativeFilter(Sign_value, lenghtOfSign);
            Sign_value = squaringFunction(Sign_value);
            Sign_value = applyFilter(Sign_value, lenghtOfSign);

            bool Detected = findQRSPoints(SessionData.Sign, Sign_value, Q_location, R_location, S_location);
            if  (Detected)
            {
                int cycle = (int)(SessionData.Time[1] - SessionData.Time[0]);

                if (R_location.Count == 1)
                {
                    HR  = (int)(60000 / (SessionData.Time[R_location[0]] - lastR));
                    QR  = (int)(R_location[0] - Q_location[0]) * cycle;
                    RS  = (int)(S_location[0] - R_location[0]) * cycle;
                    QRS = (int)(S_location[0] - Q_location[0]) * cycle;
                    R   = (int)(SessionData.Sign[R_location[0]] * 1000);

                    lastR = SessionData.Time[R_location[0]];

                    //SessionData = new ECGData();
                }
                else
                {
                    HR  = (int)(60000 / ((SessionData.Time[R_location[R_location.Count - 1]] - SessionData.Time[R_location[0]]) / (R_location.Count - 1)));
                    QR  = (int)(R_location[0] - Q_location[0]) * cycle;
                    RS  = (int)(S_location[0] - R_location[0]) * cycle;
                    QRS = (int)(S_location[0] - Q_location[0]) * cycle;
                    R   = (int)(SessionData.Sign[R_location[0]] * 1000);

                    lastR = SessionData.Time[R_location.Count - 1];
                }
            }

            return Detected;
        }


        /************************************************************************/
        /* functions of QRS Detect algorithm                                    */
        /************************************************************************/

        // ******************************* Cancellation DC drift and normalization
        private List<float> cancelDC(List<float> input)
        {
            List<float> temp   = new List<float>();
            List<float> output = new List<float>();

            // average value of signature 
            float averageValue = input.Average();

            // Cancel DC components
            for (int i = 0; i < input.Count; i++)
            {
                temp.Add(input[i] - averageValue);
            }

            output = normalizeSignal(temp);

            return output;
        }

        private List<float> normalizeSignal(List<float> input)
        {            
            List<float> output = new List<float>();
            float maxValue = getMax(input);
            int n = input.Count;

            for (int i = 0; i < n; i++)
            {
                output.Add(input[i] / maxValue);
            }
            return output;
        }

        // Get Max value in list
        private float getMax(List<float> myList)
        {
            float maxValue = 0;
            int n = myList.Count;
            for (int i = 0; i < n; i++)
            {
                maxValue = Math.Max(maxValue, Math.Abs(myList[i]));
            }
            return maxValue;
        }
 

        // **************************************************** Low Pass Filtering
        private List<float> LowPassFilter(List<float> input)
        {
            List<float> output = new List<float>();
            float[] h_FP = new float[] { 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1, 0, 0 };
            List<float> temp = new List<float>();
            temp = convolutionFunction(input, h_FP);
            output = normalizeSignal(temp);
            return output;
        }

        // Convolution and polynomial multiplication
        private List<float> convolutionFunction(List<float> list_1, float[] list_2)
        {
            List<float> output = new List<float>();
            int m = list_1.Count;
            int n = list_2.Length;
            for (int k = 0; k < m + n - 1; k++)
            {
                float tempValue = 0.0f;
                for (int j = Math.Max(0, k - n + 1); j <= Math.Min(k, m - 1); j++)
                {
                    tempValue += list_1[j] * list_2[k - j];
                }
                output.Add(tempValue);
            }
            return output;
        }

        
        // ************************************************** Hight Pass Filtering

        private List<float> HightPassFilter(List<float> input)
        {
            List<float> output = new List<float>();
            float[] h_FP = new float[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 31,
                                           -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0 };

            List<float> temp = new List<float>();
            temp = convolutionFunction(input, h_FP);

            output = normalizeSignal(temp);

            return output;
        }

        private List<float> derivativeFilter(List<float> input, int lengthOfSignal)
        {
            List<float> output = new List<float>();
            List<float> temp = new List<float>();
            float[] h = new float[] { -0.125f, -0.25f, 0f, 0.25f, 0.125f };
            temp = convolutionFunction(input, h);
            for (int i = 0; i < lengthOfSignal; i++)
            {
                output.Add(temp[i + 2]);
            }
            output = normalizeSignal(output);
            return output;
        }

        
        // ***************************************************** Squaring function
        private List<float> squaringFunction(List<float> input)
        {
            List<float> output = new List<float>();
            int n = input.Count;
            for (int i = 0; i < n; i++)
            {
                output.Add(input[i] * input[i]);
            }
            output = normalizeSignal(output);
            return output;
        }


        // ********************************************************** Apply filter
        private List<float> applyFilter(List<float> input, int lengthOfSignal)
        {
            List<float> output = new List<float>();
            List<float> temp = new List<float>();
            float[] h = new float[31];
            for (int i = 0; i < h.Length; i++)
            {
                h[i] = (float)1 / 31;
            }
            temp = convolutionFunction(input, h);
            for (int i = 0; i < lengthOfSignal; i++)
            {
                output.Add(temp[i + 15]);
            }
            output = normalizeSignal(output);
            return output;
        }


        // ******************************************************* find QRS Points

        private bool findQRSPoints(List<float> yarg, List<float> input, List<int> Q_location, List<int> R_location, List<int> S_location)
        {
            float       max_h    = getMax(input);
            float       thresh   = input.Average();
            List<float> poss_reg = new List<float>();
            int          n        = input.Count;

            for (int i = 0; i < n; i++)
            {
                if (input[i] > max_h * thresh) 
                     poss_reg.Add(1);
                else poss_reg.Add(0);
            }

            List<float> diff  = new List<float>(); diff  = diffrence(poss_reg);
            List<int>    right = new List<int>();    right = findValues(diff, 1);
            List<int>    left  = new List<int>();    left  = findValues(diff, -1);            
            n = right.Count;

            if (n == 0) return false;
            // Find R
            for (int i = 0; i < n; i++)
            {
                try
                {
                    R_location.Add(findMaxOfSection(yarg, left[i], right[i]));                    
                }
                catch
                {
                    return false;
                }
            }
            // Find Q
            for (int i = 0; i < n; i++)
            {                
                try
                {
                    Q_location.Add(findMinOfSection(yarg, left[i], R_location[i]));                    
                }
                catch
                {
                    return false;
                }
            }
            // Find S
            for (int i = 0; i < n; i++)
            {
                try
                {                    
                    S_location.Add(findMinOfSection(yarg, R_location[i], right[i]));
                }
                catch
                {
                    return false;
                }                
            }
            return true;
        }

        private List<float> diffrence(List<float> input)
        {
            List<float> output = new List<float>();
            int n = input.Count;
            for (int i = 0; i < n - 1; i++)
            {
                output.Add(input[i] - input[i + 1]);
            }
            return output;
        }

        private List<int> findValues(List<float> input, float value)
        {
            List<int> output = new List<int>();
            int n = input.Count;
            for (int i = 0; i < n; i++)
            {
                if (input[i] == value) output.Add(i - 21);
            }
            return output;
        }

        private int findMaxOfSection(List<float> input, int i, int j)
        {
            float max = -100;
            int output = 0;
            for (int k = i; k < j; k++)
            {
                if (max < input[k])
                {
                    max = input[k];
                    output = k;
                }
            }
            return output;
        }

        private int findMinOfSection(List<float> input, int i, int j)
        {
            float min = 100;
            int output = 0;
            for (int k = i; k < j; k++)
            {
                if (min > input[k])
                {
                    min = input[k];
                    output = k;
                }
            }
            return output;
        }

    }
}
