using System;
using System.Threading;

namespace deleg
{


    public delegate void PingD();
    public delegate void PongD();



    class Program
    {
      
        static void Main(string[] args)
        {
            Ping_Pong_Game ping_pong = new Ping_Pong_Game();

            ping_pong.Start_Game(new Ping(),new Pong());
            Console.ReadKey();
        }
      
    }


   

 


}
