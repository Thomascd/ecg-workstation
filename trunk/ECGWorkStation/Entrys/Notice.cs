using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECGWorkStation
{
    public class Notice
    {
        long Start;
        long End;
        string Message;

        bool isNotice(long point)
        {
            return point <= End && point >= Start;
        }
    }
}
