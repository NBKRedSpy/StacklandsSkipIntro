using HarmonyLib;
using Sokpop;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.SceneManagement;

namespace StacklandsSkipIntro
{
    [HarmonyPatch(typeof(SokIntro), "FakeUpdate")]
    public static class SokIntro_Skip_Patch
    {
        public static void Postfix(SokIntro __instance)
        {
            SceneManager.LoadScene(__instance.NextSceneName);
        }
    }
}
