using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._11._17_KPYP_Test_Inheritence_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Mashine mashine = new Mashine(new NuclearEngine(new Engine.EngineStateHandler(Show)));
            mashine.Move();

            mashine.Engine = new DarkMatterEngine(Show);
            mashine.Move();

            Console.ReadKey();
        }

        public static void Show(string message)
        {
            Console.WriteLine(message);
        }
    }    
}
