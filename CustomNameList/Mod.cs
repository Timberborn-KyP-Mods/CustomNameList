using HarmonyLib;
using TimberApi.ConsoleSystem;
using TimberApi.ModSystem;

namespace CustomNameList
{
    public class Mod : IModEntrypoint
    {
        public static CustomNameListConfig Config { get; private set; } = null!;
        
        public void Entry(IMod mod, IConsoleWriter consoleWriter)
        {
            new Harmony("kyp.customNameList").PatchAll();

            Config = mod.Configs.Get<CustomNameListConfig>();
        }
    }
}