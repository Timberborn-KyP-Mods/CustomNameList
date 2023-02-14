using System.Collections.Generic;
using HarmonyLib;
using Timberborn.Beavers;
using Timberborn.Bots;

namespace CustomNameList
{
    public class CustomNamePatches
    {
        [HarmonyPatch(typeof(BeaverNameService), "InitializeCompleteNamePool")]
        public static class PatchBeaverNameService
        {
            private static bool Prefix(List<string> ____completeNamePool, List<string> ____names)
            {
                ____completeNamePool.AddRange(Mod.Config.BeaverNames);

                return false;
            }
        }

        [HarmonyPatch(typeof(BotNameService), "GetBotName", typeof(string))]
        public static class PatchBotNameService
        {
            private static bool Prefix(ref int ____lastBotName, ref string __result)
            {
                if (! Mod.Config.UseCustomBotName)
                {
                    return true;
                }

                __result = $"{Mod.Config.BotName} {++____lastBotName}";

                return false;
            }
        }
    }
}