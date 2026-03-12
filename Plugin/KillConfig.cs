using Rocket.API;
using System;

namespace walterhcain.KillLibrary
{
    public class KillConfig : IRocketPluginConfiguration
    {
        public bool recordKills;

        public void LoadDefaults()
        {
            recordKills = true;
        }
    }
}
