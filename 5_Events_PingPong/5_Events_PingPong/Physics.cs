using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Events_PingPong
{
    class Physics
    {
        public delegate void PhysicsTickEventHandler(PhysicsTickEventArgs e);
        public static event PhysicsTickEventHandler PhysicsTick;
        public class PhysicsTickEventArgs: EventArgs
        {
            public Bitmap bmp;
            public PhysicsTickEventArgs(Bitmap bmp)
            {
                this.bmp = bmp;
            }
        }
        public static void Start(PictureBox pictureBox)
        {
            Task.Factory.StartNew(() =>
            {
                while(true)
                {
                    OnPhysicsTick(pictureBox);
                    Thread.Sleep(5);
                }
            });
        }
        public static void OnPhysicsTick(PictureBox pictureBox)
        {
            using (var g = Graphics.FromImage(Form1.im))
            {
                g.Clear(Color.Black);
            }
            PhysicsTick?.Invoke(new PhysicsTickEventArgs(Form1.im));
            pictureBox.Image = Form1.im;
        }
    }
}
