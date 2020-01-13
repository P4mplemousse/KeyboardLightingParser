using System.Collections.Generic;

namespace KeyboardLightingParser
{
    public enum LightingEffect
    {
        UNKNOWN,
        STATIC,
        WAVE,
        DISCO
    }

    class KeyConfiguration
    {
        private string m_key;
        private LightingEffect m_lightingScheme;
        private List<string> m_colors;

        public KeyConfiguration(string _key, LightingEffect _lightingScheme, List<string> _colors)
        {
            m_key = _key;
            m_lightingScheme = _lightingScheme;
            m_colors = _colors;
        }

        public string Key { get => m_key; set => m_key = value; }

        public List<string> Colors { get => m_colors; set => m_colors = value; }

        public  LightingEffect LightingScheme1 { get => m_lightingScheme; set => m_lightingScheme = value; }

        override public string ToString()
        {
            string output = "";
            output = Key + ", " + m_lightingScheme.ToString() + ", [";
            foreach(var color in Colors)
            {
                output += color + ", ";
            }

            output = output.TrimEnd(',', ' ');

            output += "]";
            return output;
        }
    }
}
