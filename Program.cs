using System;

namespace clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();
            while (true) {
                myClock.tick(10);
                Console.WriteLine(myClock);
            }
        }
    }
}
