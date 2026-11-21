using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.IntBackedUnit;
using MelonLoader;

namespace LimitlessContainerSpace
{
    public class Implementation : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg($"Version {Info.Version} loaded!");
        }
    }

    [HarmonyPatch(typeof(Container), nameof(Container.Awake))]
    internal static class Container_Awake
    {
        private const float CapacityKG = 10000f;

        private static void Postfix(Container __instance)
        {
            __instance.m_Capacity = ItemWeight.FromKilograms(CapacityKG);
        }
    }
}
