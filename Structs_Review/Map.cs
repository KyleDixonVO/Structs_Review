using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Review
{
    class Map
    {
        struct Tile
        {
            public char character;
            public ConsoleColor Fore;
            public ConsoleColor Back;
        }

        Tile[,] map;

        public Map()
        {
            map = new Tile[100, 100];
        }

        public void Draw()
        {
            int x = 0;
            int y = 0;

            Console.ForegroundColor = map[x, y].Fore;
            Console.ForegroundColor = map[x, y].Back;

        }
    }
}
