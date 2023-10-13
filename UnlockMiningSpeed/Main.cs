using HarmonyLib;

namespace UnlockMiningSpeed
{
    [HarmonyPatch(typeof(ResearchSystem), nameof(ResearchSystem.getMiningDrillSpeedMultiplier))]
    internal class ResearchSystem_getMiningDrillSpeedMultiplier
    {
        static float Postfix(float value)
        {
            return 0;
        }
    }
}
