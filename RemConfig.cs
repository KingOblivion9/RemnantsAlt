using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Remnants.Tiles;
using Terraria.Graphics.Shaders;
using Terraria.Graphics.Effects;
using Remnants.World;
//using SubworldLibrary;
using Terraria.ModLoader.Config;
using System.ComponentModel;

namespace Remnants
{
    public class Worldgen : ModConfig
    {
        public static Worldgen Instance;

        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("General")]

        [DefaultValue(true)]
        [BackgroundColor(90, 160, 140)]
        public bool Safeguard;

        [DefaultValue(false)]
        [BackgroundColor(150, 100, 125)]
        public bool ExperimentalWorldgen;

        [Header("Terrain")]

        [Range(0f, 1f)]
        [Increment(.25f)]
        [DrawTicks]
        [DefaultValue(1f)]
        public float OreFrequency;

        [Range(0f, 1.5f)]
        [Increment(.25f)]
        [DrawTicks]
        [DefaultValue(1f)]
        public float CloudDensity;

        [Range(0.5f, 1.5f)]
        [Increment(.25f)]
        [DrawTicks]
        [DefaultValue(1f)]
        public float TerrainAmplitude;

        [DefaultValue(true)]
        public bool IceMountain;

        [DefaultValue(true)]
        public bool JungleValley;

        [Header("Structure")]

        [Range(0f, 2f)]
        [Increment(.25f)]
        [DrawTicks]
        [DefaultValue(1f)]
        public float TrapFrequency;

        [Range(0f, 1f)]
        [Increment(.25f)]
        [DrawTicks]
        [DefaultValue(1f)]
        public float CabinFrequency;

        [Range(0f, 1f)]
        [Increment(.25f)]
        [DrawTicks]
        [DefaultValue(1f)]
        public float CacheFrequency;

        [Range(0f, 1f)]
        [Increment(.25f)]
        [DrawTicks]
        [DefaultValue(1f)]
        public float RailroadFrequency;

        //[DefaultValue(true)]
        //[BackgroundColor(90, 160, 140)]
        //[ReloadRequired]
        //public float MeteorRework;

        [Header("StructureChanges")]

        [DefaultValue(true)]
        public bool DoNewTemple;

        [DefaultValue(true)]
        public bool DoNewDungeon;

        [DefaultValue(false)]
        public bool DoLivingTrees;

        [Header("CalamityCompatability")]

        [DefaultValue(true)]
        [BackgroundColor(150, 150, 125)]
        public bool SunkenSeaRework;

        [DefaultValue(true)]
        public bool AltPlanetoids;

        [DefaultValue(true)]
        public bool DoLava;

        [Header("LargerSky")]

        [DefaultValue(true)]
        [BackgroundColor(192, 54, 64, 192)]
        public bool SkySafeguard;

        [Range(0, 10000)]
        [DefaultValue(150)]
        [BackgroundColor(192, 54, 64, 192)]
        public int FlatSurfaceRatioIncrease;

        [Range(0, 10000)]
        [DefaultValue(150)]
        [BackgroundColor(192, 54, 64, 192)]
        public int FlatUndergroundRatioIncrease;

        [Range(0, 10000)]
        [DefaultValue(150)]
        [BackgroundColor(192, 54, 64, 192)]
        public int FlatLavaRatioIncrease;
    }
    public class Gameplay : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("Functional")]

        [DefaultValue(true)]
        [BackgroundColor(90, 160, 140)]
        public bool FreedomOfMovement;

        [DefaultValue(true)]
        [BackgroundColor(150, 150, 125)]
        public bool EnemyAI;

        [DefaultValue(false)]
        [BackgroundColor(150, 100, 125)]
        public bool ProjectileAI;

        [DefaultValue(true)]
        [BackgroundColor(150, 150, 125)]
        public bool HangingBats;

        [Header("Audio")]

        [DefaultValue(true)]
        public bool CustomMusic;
    }
}
