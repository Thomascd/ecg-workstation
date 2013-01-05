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
        double lastR = 0;
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

            List<double> Sign_value = new List<double>();
            Sign_value = SessionData.Sign;
			//List<double> Sign_value   = SessionData.Sign;
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
        private List<double> cancelDC(List<double> input)
        {
            List<double> temp   = new List<double>();
            List<double> output = new List<double>();

            // average value of signature 
            double averageValue = input.Average();

            // Cancel DC components
            for (int i = 0; i < input.Count; i++)
            {
                temp.Add(input[i] - averageValue);
            }

            output = normalizeSignal(temp);

            return output;
        }

        private List<double> normalizeSignal(List<double> input)
        {            
            List<double> output = new List<double>();
            double maxValue = getMax(input);
            int n = input.Count;

            for (int i = 0; i < n; i++)
            {
                output.Add(input[i] / maxValue);
            }
            return output;
        }

        // Get Max value in list
        private double getMax(List<double> myList)
        {
            double maxValue = 0;
            int n = myList.Count;
            for (int i = 0; i < n; i++)
            {
                maxValue = Math.Max(maxValue, Math.Abs(myList[i]));
            }
            return maxValue;
        }
 

        // **************************************************** Low Pass Filtering
        private List<double> LowPassFilter(List<double> input)
        {
            List<double> output = new List<double>();
            double[] h_FP = new double[] { 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1, 0, 0 };
            List<double> temp = new List<double>();
            temp = convolutionFunction(input, h_FP);
            output = normalizeSignal(temp);
            return output;
        }

        // Convolution and polynomial multiplication
        private List<double> convolutionFunction(List<double> list_1, double[] list_2)
        {
            List<double> output = new List<double>();
            int m = list_1.Count;
            int n = list_2.Length;
            for (int k = 0; k < m + n - 1; k++)
            {
                double tempValue = 0.0;
                for (int j = Math.Max(0, k - n + 1); j <= Math.Min(k, m - 1); j++)
                {
                    tempValue += list_1[j] * list_2[k - j];
                }
                output.Add(tempValue);
            }
            return output;
        }

        
        // ************************************************** Hight Pass Filtering

        private List<double> HightPassFilter(List<double> input)
        {
            List<double> output = new List<double>();
            double[] h_FP = new double[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 31,
                                           -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0 };

            List<double> temp = new List<double>();
            temp = convolutionFunction(input, h_FP);

            output = normalizeSignal(temp);

            return output;
        }

        private List<double> derivativeFilter(List<double> input, int lengthOfSignal)
        {
            List<double> output = new List<double>();
            List<double> temp = new List<double>();
            double[] h = new double[] { -0.125, -0.25, 0, 0.25, 0.125 };
            temp = convolutionFunction(input, h);
            for (int i = 0; i < lengthOfSignal; i++)
            {
                output.Add(temp[i + 2]);
            }
            output = normalizeSignal(output);
            return output;
        }

        
        // ***************************************************** Squaring function
        private List<double> squaringFunction(List<double> input)
        {
            List<double> output = new List<double>();
            int n = input.Count;
            for (int i = 0; i < n; i++)
            {
                output.Add(input[i] * input[i]);
            }
            output = normalizeSignal(output);
            return output;
        }


        // ********************************************************** Apply filter
        private List<double> applyFilter(List<double> input, int lengthOfSignal)
        {
            List<double> output = new List<double>();
            List<double> temp = new List<double>();
            double[] h = new double[31];
            for (int i = 0; i < h.Length; i++)
            {
                h[i] = (double)1 / 31;
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

        private bool findQRSPoints(List<double> yarg, List<double> input, List<int> Q_location, List<int> R_location, List<int> S_location)
        {
            double       max_h    = getMax(input);
            double       thresh   = input.Average();
            List<double> poss_reg = new List<double>();
            int          n        = input.Count;

            for (int i = 0; i < n; i++)
            {
                if (input[i] > max_h * thresh) 
                     poss_reg.Add(1);
                else poss_reg.Add(0);
            }

            List<double> diff  = new List<double>(); diff  = diffrence(poss_reg);
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

        private List<double> diffrence(List<double> input)
        {
            List<double> output = new List<double>();
            int n = input.Count;
            for (int i = 0; i < n - 1; i++)
            {
                output.Add(input[i] - input[i + 1]);
            }
            return output;
        }

        private List<int> findValues(List<double> input, double value)
        {
            List<int> output = new List<int>();
            int n = input.Count;
            for (int i = 0; i < n; i++)
            {
                if (input[i] == value) output.Add(i - 21);
            }
            return output;
        }

        private int findMaxOfSection(List<double> input, int i, int j)
        {
            double max = -100;
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

        private int findMinOfSection(List<double> input, int i, int j)
        {
            double min = 100;
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
