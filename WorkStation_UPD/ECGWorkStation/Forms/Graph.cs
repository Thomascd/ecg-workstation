using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ECGWorkStation
{
    partial class Graph : UserControl
    {
        #region field
        ECGData Data;
        double Cycle
        {
            get 
            {
                if (Data.Count > 0) return Data.Time[1] - Data.Time[0];
                else return 0;
            }
        }

        private double RoomRateValue = 0.3;
        public double RoomRate  // default = 0.3;      // 1 ms = RoomRate px  | 1mv = 400 Roomrate px
        {
            get
            {
                return this.RoomRateValue;
            }
            set
            {
                this.RoomRateValue = value * 0.3;
                switch (Mode)
                {
                    case state.History:
                        // reset panel
                        Panel.Width = this.Width - 4;
                        ResetPanel();

                        //Draw();

                        break;

                    case state.Realtime:
                        ResizePanel();
                        x = 0;
                        y = this.Height / 2;
                        x_buffer = 0;
                        break;

                    case state.Record:
                        break;
                }
            }
        }
        public int AccuracyRate = 75;

        private Pen greenPen = new Pen(Color.GraphLine, 2);            // graph line
        private Graphics graph;

        double x_buffer;
        int x, y;
        int LastCount;

        private Thread RealTimeThread;

        #endregion

        #region properties

        private state _state;
        public state Mode
        {
            get
            {
                return _state;
            }
            set
            {
                if (this._state != value)
                {
                    switch (value)
                    {
                        case state.Realtime:
                            if (_state == state.Record)
                            {
                                greenPen = new Pen(Color.GraphLine, 2);            // graph line
                            }
                            else
                            {
                                ResetPanel();
                                RealTimeThread = new Thread(new ThreadStart(this.RealtimeDraw));
                                RealTimeThread.Start();
                            }
                            break;

                        case state.History:
                            if (RealTimeThread != null) RealTimeThread.Abort();
                            ResizePanel();
                            Draw();
                            break;

                        case state.Record:
                            greenPen = new Pen(Color.GraphRecordLine, 2);            // graph line
                            break;

                        case state.ViewNotice:
                            if (RealTimeThread != null) RealTimeThread.Abort();
                            ResizePanel();
                            Draw();
                            break;

                        default:
                            if (RealTimeThread != null) RealTimeThread.Abort();
                            break;
                    }

                    this._state = value;
                }
            }
        }

        #endregion

        #region Init form

        public Graph()
        {
            InitializeComponent();
            graph = this.Panel.CreateGraphics();            
        }

        public Graph(ECGData Data)
        {
            InitializeComponent();
            this.Data = Data;
            graph = this.Panel.CreateGraphics();
        }

        public Graph(Size Size, ECGData Data)
        {
            InitializeComponent();
            this.Size = Size;
            this.Panel.Width = this.Width - 4;
            this.Data = Data;
            graph = this.Panel.CreateGraphics();
        }

        public Graph(Size Size, ECGData Data, string Name)
        {
            InitializeComponent();
            this.Label.Text = Name;

            this.Size = Size;
            this.Panel.Width = this.Width - 4;
            this.Data = Data;
            graph = this.Panel.CreateGraphics();
        }

        public void Close()
        {
            if (RealTimeThread != null && RealTimeThread.IsAlive) RealTimeThread.Abort();
        }

        #endregion

        #region Draw method

        public void RealtimeDraw()
        {
            x = 0;
            y = this.Height / 2;
            x_buffer = 0;
            LastCount = 0;

            while (Mode == state.Realtime || Mode == state.Record)
            {
                if (LastCount < Data.Count)
                {
                    Draw(Data.Count - LastCount);
                    LastCount = Data.Count;
                }
                else Thread.Sleep(101 - AccuracyRate);
            }
        }

        public void Draw()
        // draw all single in data
        {
            // draw graphics
            if (Data.Count > 1) // begin with second sign
            {
                double x_buffer = 0;
                int x = 0;
                int y = (int)(this.Height / 2 - RoomRate * Data.Sign[0]);
                double cycle = (Data.Time[1] - Data.Time[0]);

                for (int i = 1; i < Data.Count; i++)
                {
                    x_buffer += cycle * RoomRate;
                    if ((int)(x_buffer) > x && i % (int)(21 - AccuracyRate / 5) == 0)
                    //if ((int)(x_buffer) > x )
                    {
                        graph.DrawLine(greenPen,
                            x,
                            y,
                            x = (int)x_buffer,
                            y = (int)(this.Height / 2 - Data.Sign[i] * 400 * RoomRate));
                    }
                }
            }
        }

        private void Draw(int sub)
        // draw last "sub" sign
        {
            if (x >= this.Width)
            {
                x_buffer = 0;
                x = 0;
                y = (int)(this.Height / 2 - RoomRate * Data.LastSign);
            }
            else if (Data.Count > 1)
            {
                double Cycle = (Data.Time[1] - Data.Time[0]);
                x_buffer += sub * RoomRate * Cycle;

                if ((int)(x_buffer) - x > 1)
                {
                    DrawBackground((int)x, sub);
                    graph.DrawLine(
                        greenPen,
                        x,
                        y,
                        x = (int)x_buffer,
                        y = (int)(this.Height / 2 - 400 * RoomRate * Data.LastSign));
                }

            }
        }

        private void DrawBackground(int x, int sub)
        // draw background in line with x + offset 
        {
            // offset = 10 pixel 
            x = (x + 10) % this.Width;

            //**************************** clear background
            sub = Math.Max(sub, 5);
            Pen blackPen = new Pen(Color.GraphBackground, sub);    // black
            graph.DrawLine(blackPen, x, 0, x, this.Height);

            /***************************** draw grid line
                * 10px / line
                * 5 normal line / bold line  
                * 10px / RoomRate.Value           */
            /*
            // first half row
            for (int i = hafl_height; i > 0; i -= RoomRateValue) graph.DrawLine(readPen, x - 1, i, x + 1, i);  // normal line
            for (int i = hafl_height - 1; i > 0; i -= RoomRate5) graph.DrawLine(readPen, x - 1, i, x + 1, i);  // bold line

            // second half row 
            for (int i = hafl_height; i < height; i += RoomRateValue) graph.DrawLine(readPen, x - 1, i, x + 1, i);  // normal line
            for (int i = hafl_height + 1; i < height; i += RoomRate5) graph.DrawLine(readPen, x - 1, i, x + 1, i);  // bold line

            // column
            for (int i = x - 1; i < x + 2; i++)
            {
                if (i % (RoomRateValue) == 0) graph.DrawLine(readPen, i, 0, i, height);     // normal line
                if (i % (RoomRate5) == 1) graph.DrawLine(readPen, i, 0, i, height);     // bold line
            }
             * */
        }

        public void ResetPanel()
        {
            this.Panel.Width = this.Width - 4;
            this.Panel.Invalidate();
            graph = this.Panel.CreateGraphics();
            graph.Clear(Color.GraphBackground);

        }

        public void ResizePanel()
        {

            if (Data.LastTime * RoomRate > this.Panel.Width)
            {
                this.Panel.Width = (int)(Data.LastTime * RoomRate);
                this.Panel.Invalidate();
                graph = this.Panel.CreateGraphics();
                graph.Clear(Color.GraphBackground);
            }
        }

        private void ReDraw(object sender, PaintEventArgs e)
        {
            if (Mode == state.History || Mode == state.ViewNotice)
            {
                Draw();
            }
        }

        #endregion
    }
}
