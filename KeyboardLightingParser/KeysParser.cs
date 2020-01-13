using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace KeyboardLightingParser
{
    class KeysParser
    {
        public List<string> Parse(string line)
        {
            List<string> output = new List<string>();
            string tempLine = line.ToLower();
            tempLine = tempLine.Replace(" ", string.Empty);

            // only 'a' or 'a,b,c,d' likes inputs
            Regex test = new Regex(@"(^[a-z]$)|(^(([a-z],)*)[a-z]$)");
            if (test.IsMatch(tempLine))
            {
                var keys = tempLine.Split(',');
                foreach(var key in keys)
                {
                    if (!output.Contains(key))
                    {
                        output.Add(key);
                    }
                }
            }
            else
            {
                throw new InvalidDataException("INVALID : Invalid keys input");
            }

            return output;
        }
    }
}
