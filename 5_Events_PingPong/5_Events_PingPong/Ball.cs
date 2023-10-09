using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Events_PingPong
{
    class Ball
    {
        public float x, y;
        public static Ball BALL;
        readonly public System.Drawing.Color color = System.Drawing.Color.White;
        public Ball(float x, float y)
        {
            this.x = x;
            this.y = y;
            Physics.PhysicsTick += OnPhysicsTick;
        }
        public static void createBall()
        {
            BALL = new Ball(Form1.w / 2, Form1.h / 2);
        }
        public virtual void OnPhysicsTick(Physics.PhysicsTickEventArgs e)
        {
            using (var g = Graphics.FromImage(e.bmp))
            using (Pen pen = new Pen(color, 5))
            {
                g.DrawEllipse(pen, x, y, 20, 20);
            }
        }

    }
}
