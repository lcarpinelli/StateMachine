using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Gate gate = new Gate();
            Console.WriteLine("Benvenuto stai arrivando al casello decidi cosa vuoi fare");
            while (true)
            {
                Console.WriteLine("1 Fermarti/2 Passare/3 Pagare");
                int scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        gate.Arrive();
                        break;
                    case 2:
                        gate.Exit();
                        break;
                    case 3:
                        gate.Pay();
                        break;
                }
                Console.WriteLine("----------------------------------------------------------------------");
            }
        }
    }
}
