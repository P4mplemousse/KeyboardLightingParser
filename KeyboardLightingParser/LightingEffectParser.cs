using System;
using System.IO;

namespace KeyboardLightingParser
{
    class LightingEffectParser : Parser
    {
        public LightingEffect Parse(string line)
        {
            string tempLine = line.ToUpper();
            LightingEffect effect = LightingEffect.UNKNOWN;
            if (Enum.IsDefined(typeof(LightingEffect), tempLine))
                effect = (LightingEffect) Enum.Parse(typeof(LightingEffect), tempLine);
            else
            {
                throw new InvalidDataException("INVALID : Invalid lighting effect input");
            }

            return effect;
        }
    }
}
