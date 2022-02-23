using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy!");

            Vector2 position;

            position.x = 0;
            position.y = 0;

            MoveTo(position);

            Console.WriteLine();
            Console.WriteLine("Press any input to exit");
            Console.ReadKey(true);
        }

        private static void MoveTo(Vector2 position)
        {
            Console.WriteLine("About to move to (" + position.x + "," + position.y + ")");
            Console.WriteLine("About to move to (" + position + ")");
        }
    }
}
