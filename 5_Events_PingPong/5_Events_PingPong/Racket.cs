using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Events_PingPong
{
    class Racket : Wall
    {
        
        public Racket(float x1, float y1, float x2, float y2) : base(x1, y1, x2, y2)
        {
            
        }
        public void Move(float d = 0)
        {
            if (y1 + d-10 < 0 || y2 + d+10 > Form1.h) return;
            y1 += d;
            y2 += d;
        }
        }
}
