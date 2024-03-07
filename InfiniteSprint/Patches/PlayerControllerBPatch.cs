using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace InfiniteSprint.Patches
{
    [HarmonyPatch(typeof(GameNetcodeStuff.PlayerControllerB))]
    internal class PlayerControllerPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        private static void Postfix(GameNetcodeStuff.PlayerControllerB __instance)
        {
            if (__instance.isSprinting)
            {
                if (!__instance.isInsideFactory)
                    __instance.sprintMeter = 1f;
                } 
            }
        }
    }

