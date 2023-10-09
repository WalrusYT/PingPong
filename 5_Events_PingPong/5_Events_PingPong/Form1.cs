using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Events_PingPong
{
    public partial class Form1 : Form
    {
        public static Bitmap im;
        public static float w, h;
        public Form1()
        {
            InitializeComponent();
            w = PlayArena.Width;
            h = PlayArena.Height;
            im = new Bitmap((int)w, (int)h);
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateElements();
            Physics.Start(PlayArena);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void CreateElements()
        {
            // стены
            Wall leftWall = new Wall(0, 0, 0, h);
            Wall bottomWall = new Wall(0, h, w, h);
            Wall rigthWall = new Wall(w, h, w, 0);
            Wall topWall = new Wall(w, 0, 0, 0);
            // игроки
            Player.createPlayers();
            Ball.createBall();
        }

    }
}
