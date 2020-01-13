using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardLightingParser
{
    public enum LightingScheme
    {
        Static,
        Wave,
        Disco
    }

    class KeyConfiguration
    {
        private string m_key;
        private LightingScheme m_lightingScheme; // Enum ? 
        private string m_colors;

        public KeyConfiguration(string _key, LightingScheme _lightingScheme, string _colors)
        {
            m_key = _key;
            m_lightingScheme = _lightingScheme;
            m_colors = _colors;
        }

        public string Key { get => m_key; set => m_key = value; }

        public string Colors { get => m_colors; set => m_colors = value; }

        public  LightingScheme LightingScheme1 { get => m_lightingScheme; set => m_lightingScheme = value; }

        override public string ToString()
        {
            return Key + ", " + m_lightingScheme.ToString() + ", [" + Colors + "]";
        }
    }
}
