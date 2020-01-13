using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardLightingParser
{
    class LightingEffectParser
    {
        public LightingEffect Parse(string line)
        {
            string tempLine = line.ToUpper();
            LightingEffect effect = LightingEffect.UNKNOWN;
            if (Enum.IsDefined(typeof(LightingEffect), tempLine))
                effect = (LightingEffect) Enum.Parse(typeof(LightingEffect), tempLine);
            else
            {
                throw new InvalidDataException("Invalid lighting effect input");
            }

            return effect;
        }
    }
}
