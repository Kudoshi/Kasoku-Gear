using UnityEngine;
using Voxell.Util.Interface;

namespace GameWorld.Storage
{
    [System.Serializable]
    public struct WaveConfig : IDefault<WaveConfig>
    {
        public PowerPlotConfig DamagePlot;
        public WaveConfig Default()
        {
            return new WaveConfig
            {
                
            };
        }
    }
}
