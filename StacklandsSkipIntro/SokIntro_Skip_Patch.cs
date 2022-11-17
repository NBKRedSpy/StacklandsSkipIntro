using HarmonyLib;
using Sokpop;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.SceneManagement;

namespace StacklandsSkipIntro
{
    [HarmonyPatch(typeof(SokIntro), "Awake")]
    public static class SokIntro_Skip_Patch
    {
        public static bool Prefix(SokIntro __instance)
        {
            SceneManager.LoadScene(__instance.NextSceneName);
            return false;
        }
    }
}
