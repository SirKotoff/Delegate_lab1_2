using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace deleg
{
    public class Ping_Pong_Game
    {
        public event PingD Ping_event = null;
        public event PongD Pong_event = null;

        public void Start_Game(Ping ping, Pong pong)
        {

            Ping_event += ping.Ping_info;
            Pong_event += pong.Pong_info;

            for (int i = 0; i < 3; i++)
            {
                Console.Beep();
                Ping_event?.Invoke();
                Thread.Sleep(500);
                Pong_event?.Invoke();
                Thread.Sleep(500);
            }


     }
    }
}
