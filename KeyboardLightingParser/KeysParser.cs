using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace KeyboardLightingParser
{
    class KeysParser : Parser
    {
        public List<string> Parse(string line)
        {
            List<string> output = new List<string>();
            output = ParseRegex(line, @"(^[a-z]$)|(^(([a-z],)*)[a-z]$)");
            if (output.Count == 0)
            {
                throw new InvalidDataException("INVALID : Invalid keys input");
            }

            return output;
        }
    }
}
