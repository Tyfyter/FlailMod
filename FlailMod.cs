using FlailMod.Common;
using FlailMod.Content;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace FlailMod
{
	public class FlailMod : Mod
    {
        public static Mod ThoriumMod;

        public override void Load()
        {
            ThoriumMod = ModLoader.TryGetMod("ThoriumMod", out Mod mod) ? mod : null;
        }

        public override void PostSetupContent()
        {
            List<int> list = FlailModGlobalProjectile.FailProjectileTypes;

            list = new List<int>()
            {
                ProjectileID.Mace,
                ProjectileID.FlamingMace,
                ProjectileID.BallOHurt,
                ProjectileID.TheMeatball,
                ProjectileID.BlueMoon,
                ProjectileID.Sunfury,
                ProjectileID.DripplerFlail,
                ProjectileID.TheDaoofPow,
                ProjectileID.FlowerPow
            };

            list.Add(ModContent.ProjectileType<BallOhurtProjectile>());
            list.Add(ModContent.ProjectileType<TheMeatballProjectile>());
            list.Add(ModContent.ProjectileType<AnchorProjectile>());
            list.Add(ModContent.ProjectileType<FlaironProjectile>());
            list.Add(ModContent.ProjectileType<BlueMoonProjectile>());
            list.Add(ModContent.ProjectileType<SunfuryProjectile>());
            list.Add(ModContent.ProjectileType<DaoOfPowProjectile>());
            list.Add(ModContent.ProjectileType<DripplerCripplerProjectile>());
            list.Add(ModContent.ProjectileType<FlowerPowProjectile>());

            if (ThoriumMod != null)
            {
                List<string> TypesToTry = new List<string>()
                {
                    "TheSnowballPro",
                    "SparkingJellyBallPro",
                    "StarTrailPro",
                    "BoneFlayerTailPro",
                    "FleshMacePro",
                    "EbonyTailPro",
                    "TheSeaMinePro",
                    "TheJuggernautPro",
                    "LodeStoneBreakerPro",
                    "SteamFlailPro",
                    "LivewireCrasherPro"
                };

                ModProjectile thoriumProjectile;
                foreach (string str in TypesToTry)
                {
                    if (ThoriumMod.TryFind(str, out thoriumProjectile))
                    {
                        list.Add(thoriumProjectile.Type);
                    }
                }

                ThoriumMod.Call("AddFlailProjectileID", ModContent.ProjectileType<BallOhurtProjectile>());
                ThoriumMod.Call("AddFlailProjectileID", ModContent.ProjectileType<TheMeatballProjectile>());
                ThoriumMod.Call("AddFlailProjectileID", ModContent.ProjectileType<AnchorProjectile>());
                ThoriumMod.Call("AddFlailProjectileID", ModContent.ProjectileType<FlaironProjectile>());
                ThoriumMod.Call("AddFlailProjectileID", ModContent.ProjectileType<BlueMoonProjectile>());
                ThoriumMod.Call("AddFlailProjectileID", ModContent.ProjectileType<SunfuryProjectile>());
                ThoriumMod.Call("AddFlailProjectileID", ModContent.ProjectileType<DaoOfPowProjectile>());
                ThoriumMod.Call("AddFlailProjectileID", ModContent.ProjectileType<DripplerCripplerProjectile>());
                ThoriumMod.Call("AddFlailProjectileID", ModContent.ProjectileType<FlowerPowProjectile>());
            }

            FlailModGlobalProjectile.FailProjectileTypes = list;
        }

        public override void Unload()
        {
            FlailModGlobalProjectile.FailProjectileTypes = null;
        }
    }
}