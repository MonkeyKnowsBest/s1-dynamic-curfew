using MelonLoader;
using System.Collections.Generic;

namespace ScheduleI.DynamicCurfew
{
    public class ZoneController
    {
        // Manage district-specific curfew rules
        private Dictionary<string, ZoneConfig> _zoneConfigurations = new Dictionary<string, ZoneConfig>()
        {
            { "HighEnd", new ZoneConfig { CurfewStrictness = 0.9f, PolicePresence = 0.8f } },
            { "Industrial", new ZoneConfig { CurfewStrictness = 0.3f, PolicePresence = 0.4f } },
            { "LowIncome", new ZoneConfig { CurfewStrictness = 0.5f, PolicePresence = 0.6f } }
        };

        public ZoneConfig GetZoneConfiguration(string zoneName)
        {
            return _zoneConfigurations.TryGetValue(zoneName, out var config) 
                ? config 
                : new ZoneConfig { CurfewStrictness = 0.5f, PolicePresence = 0.5f };
        }

        public void UpdateZoneConfiguration(string zoneName, ZoneConfig newConfig)
        {
            _zoneConfigurations[zoneName] = newConfig;
            MelonLogger.Msg($"Updated zone configuration for {zoneName}");
        }
    }

    public class ZoneConfig
    {
        public float CurfewStrictness { get; set; }
        public float PolicePresence { get; set; }
    }
}