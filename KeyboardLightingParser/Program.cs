using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardLightingParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take input file, check file validity

            // Parse input file

            string path = "c:/test.txt";
            try
            {

                FileParser parser = new FileParser();
                parser.Parse(path);

                Console.Write(parser.ToString());
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message + "\n");
            }

            // strict scheme
            // letters
            // color scheme
            // colors

            // a, b, c, d // possible duplication !
            // Static | Wave, Disco // strict values
            // orange, red, blue // whatever we want ? -> possible to limit value later
        }
    }
}
