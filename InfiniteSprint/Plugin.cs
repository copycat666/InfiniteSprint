using BepInEx;
using BepInEx.Logging;
using GameNetcodeStuff;
using HarmonyLib;
using InfiniteSprint.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace InfiniteSprint
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class InfiniteSprintBase : BaseUnityPlugin
    {
        private const string modGUID = "CopyCat666.InfiniteSprint";

        private const string modName = "Infinite Sprint";

        private const string modVersion = "1.0.1";

        private readonly Harmony harmony = new Harmony("CopyCat666.InfiniteSprint");

        private static InfiniteSprintBase instance;
       
        internal ManualLogSource mls;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            mls = base.Logger;
            mls.LogInfo((object)"NaNSprint active!");
            harmony.PatchAll();
        }
    }
}
