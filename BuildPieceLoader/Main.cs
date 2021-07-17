using BepInEx;
using Jotunn.Utils;
using UnityEngine;

namespace BuildPieceLoader
{
    [BepInPlugin("github.imcanida.buildpieceloader", "BuildPieceLoader", "1.0.0")]
    [BepInDependency(Jotunn.Main.ModGuid)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    public class ModMain : BaseUnityPlugin
    {
        private void Awake()
        {
            Debug.Log("We are in..");

            AssetManager.LoadConfigs();
            AssetManager.RegisterPrefabs();
            AssetManager.RegisterLocalization();
        }
    }
}