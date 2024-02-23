using System;

namespace ClockV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Clock clock = new Clock(18, 57);
            Console.WriteLine(clock.ToString());

            clock.Tick();

            Console.WriteLine(clock.ToString());

            clock.Tick();
            clock.Over60Minutes();

            Console.WriteLine(clock.ToString());

            clock.Tick();

            Console.WriteLine(clock.ToString());

            clock.Tick();
            clock.Over60Minutes();
            

            Console.WriteLine(clock.ToString());

            clock.Tick();

            Console.WriteLine(clock.ToString());

            // The LAST line of code should be ABOVE this line
        }
    }
}