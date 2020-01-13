using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardLightingParser
{
    class FileParser
    {
        private List<KeyConfiguration> m_keys;

        FileParser(string fileContent)
        {
            // fill keys
        }

        override public string ToString() 
        {
            string output = ""; // improve with stringChain
            foreach(var key in m_keys)
            {
                output = key.ToString();
            }
            return output;
        }
    }
}
