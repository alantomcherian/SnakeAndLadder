using System;

namespace snakeNladder
{
    class Program
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            int pos1 = 0;
            int Start = 0;

            Random r = new Random();
            int dice = r.Next(1, 7);
            int c = r.Next(1, 4); 

            switch (c)
            {
                case 1 :
                    Console.WriteLine("No position change");
                    break;
                case 2 :
                    pos1 += dice;
                    Console.WriteLine("player has moved to "+ pos1 +" block by "+ dice +" steps.");
                    break;
                case 3 :
                    pos1 -= dice;
                    if (pos1 <= Start)
                    {
                        pos1 = 0;
                    }
                    Console.WriteLine("player has moved back to " + pos1 + " block by " + dice + " steps.");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            
        
        }
    }
}
