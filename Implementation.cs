using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;
using Harmony;
namespace LimitlessContainerSpace
{
    public class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
        }
    }

    [HarmonyPatch(typeof(Container), "Awake")]
    internal class Container_Awake
    {
        private static void Postfix(Container __instance)
        {
            __instance.m_CapacityKG = 10000;
        }
    }
}
