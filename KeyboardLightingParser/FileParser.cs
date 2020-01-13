using System.Collections.Generic;
using System.IO;

namespace KeyboardLightingParser
{
    class FileParser
    {
        private Dictionary<string, KeyConfiguration> m_keys = new Dictionary<string, KeyConfiguration>();

        public FileParser()
        {
        }

        public string Parse(string filePath)
        {
            string output = "";
            StreamReader file = new StreamReader(filePath);
            if (file != null)
            {
                while(!file.EndOfStream)
                {
                    // First should be keys
                    List<string> keys = new List<string>();
                    keys = getKeys(file);

                    LightingEffect effect = GetLightingEffect(file);                   

                    List<string> colors = new List<string>();
                    colors = GetColors(file);

                    var colorCount = colors.Count;
                    if (effect == LightingEffect.STATIC && colorCount != 1)
                    {
                        throw new InvalidDataException("INVALID : Static effects are single color only");
                    }
                    else if (effect == LightingEffect.DISCO && colorCount != 3)
                    {
                        throw new InvalidDataException("INVALID : Disco effects need 3 colors");
                    }

                    addConfigurationEntries(keys, effect, colors);
                }
            }

            return output;
        }

        override public string ToString()
        {
            string output = ""; // improve with stringChain
            foreach (var config in m_keys)
            {
                output += config.Value.ToString() + "\n";
            }
            return output;
        }

        private List<string> getKeys(StreamReader file)
        {
            if (file != null)
            {
                KeysParser keysParser = new KeysParser();
                string line = file.ReadLine();
                if (line != null)
                {
                    var keys = keysParser.Parse(line);
                    if (keys.Count > 0)
                    {
                        return keys;
                    }
                    else
                    {
                        throw new InvalidDataException("INVALID : No data for keys");
                    }
                }
                else
                {
                    throw new InvalidDataException("INVALID : No line for keys");
                }
            }
            else
            {
                throw new InvalidDataException("INVALID : No input file for keys");
            }
        }

        private LightingEffect GetLightingEffect(StreamReader file)
        {
            if (file != null)
            {
                LightingEffectParser lightingEffectParser = new LightingEffectParser();
                string line = file.ReadLine();
                if (line != null)
                {
                    var effect = lightingEffectParser.Parse(line);
                    if (effect == LightingEffect.UNKNOWN)
                    {
                        throw new InvalidDataException("Effect is missing from the input file");
                    }
                    return effect;
                }
                else
                {
                    throw new InvalidDataException("INVALID : No data for lighting effect");
                }
            }
            else
            {
                throw new InvalidDataException("INVALID : No input file for lighting effect");
            }
        }

        private List<string> GetColors(StreamReader file)
        {
            if (file != null)
            {
                ColorParser parser = new ColorParser();
                string line = file.ReadLine();
                if (line != null)
                {
                    var colors = parser.Parse(line);
                    if (colors.Count > 0)
                    {
                        return colors;
                    }
                    else
                    {
                        throw new InvalidDataException("INVALID : No data for colors");
                    }
                }
                else
                {
                    throw new InvalidDataException("INVALID : No line for colors");
                }
            }
            else
            {
                throw new InvalidDataException("INVALID : No input file for colors");
            }
        }

        private void addConfigurationEntries(List<string> keys, LightingEffect effect, List<string> colors)
        {
            keys.Sort();
            foreach(var key in keys)
            {
                m_keys[key] = new KeyConfiguration(key, effect, colors);
            }
        }
    }
}
