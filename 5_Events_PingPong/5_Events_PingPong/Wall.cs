using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Events_PingPong
{
    class Wall
    {
        public static List<Wall> walls = new List<Wall>();
        public float x1, y1, x2, y2;
        readonly public System.Drawing.Color color = System.Drawing.Color.White;
        public Wall(float x1, float y1, float x2, float y2)
        {
            walls.Add(this);
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            Physics.PhysicsTick += OnPhysicsTick;
        }
        public virtual void OnPhysicsTick(Physics.PhysicsTickEventArgs e) {
            using (var g = Graphics.FromImage(e.bmp))
            using (Pen pen = new Pen(color,5))
            {
                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }
            
        }
    
}
