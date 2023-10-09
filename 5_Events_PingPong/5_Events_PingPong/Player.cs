using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Events_PingPong
{
    class Player
    {
        public static Player PLAYER1;
        public static Player PLAYER2;
        public int score = 0;
        public Racket racket;
        private Player(Racket racket)
        {
            this.racket = racket;
        }
        public static void createPlayers()
        {
            PLAYER1 = new Player(new Racket(50, Form1.h / 2 - 50, 50, Form1.h / 2 + 50));
            PLAYER2 = new Player(new Racket(Form1.w - 50, Form1.h / 2 - 50, Form1.w - 50, Form1.h / 2 + 50));
        }
        public static void test(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W: PLAYER1.racket.Move(-10); break;
                case Keys.S: PLAYER1.racket.Move(10); break;
                case Keys.Up: PLAYER2.racket.Move(-10); break;
                case Keys.Down: PLAYER2.racket.Move(10); break;
            }
        }
    }
}
