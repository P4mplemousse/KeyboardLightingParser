using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KeyboardLightingParser
{
    class ColorParser
    {
        public List<string> Parse(string line)
        {
            List<string> output = new List<string>();
            string tempLine = line.ToLower();
            tempLine = tempLine.Replace(" ", string.Empty);

            // only 'a' or 'a,b,c,d' likes inputs
            Regex test = new Regex(@"(^[a-z]*$)|(^((([a-z]*,)*)[a-z])*$)");
            if (test.IsMatch(tempLine))
            {
                var keys = tempLine.Split(',');
                foreach (var color in keys)
                {
                    if (!output.Contains(color))
                    {
                        output.Add(color);
                    }
                }
            }
            else
            {
                throw new InvalidDataException("Invalid colors input");
            }

            return output;
        }
    }
}
