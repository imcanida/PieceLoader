using Jotunn.Configs;
using System.Collections.Generic;

namespace BuildPieceLoader.Config
{
    public static class AssetConfig
    {
        public static AssetBundleToLoad Assets = new AssetBundleToLoad()
        {
            AssetBundleName = "piece_logwall",
            Pieces = new List<PrefabToLoad<PieceConfig>>()
            {
                new PrefabToLoad<PieceConfig>()
                {
                    AssetPath = "Assets/CustomItems/LogWall90/logwall.prefab",
                    Config = new PieceConfig
                    {
                        PieceTable = "Hammer",
                        Requirements = new[]
                        {
                            new RequirementConfig { Item = "Stone", Amount = 1 }
                        }
                    },
                }
            }
        };
    }
}
