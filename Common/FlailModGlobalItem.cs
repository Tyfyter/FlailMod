using FlailMod.Content;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace FlailMod.Common
{
	public class FlailModGlobalItem : GlobalItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.ToolTipDamageMultiplier[ItemID.Anchor] = 2f;
			ItemID.Sets.ToolTipDamageMultiplier[ItemID.Flairon] = 2f;
		}

		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Anchor)
			{
				item.channel = true;
				item.shoot = ModContent.ProjectileType<AnchorProjectile>();
				item.damage = 110;
			}

			if (item.type == ItemID.Flairon)
			{
				item.channel = true;
				item.shoot = ModContent.ProjectileType<FlaironProjectile>();
			}

			if (item.type == ItemID.BallOHurt)
			{
				item.shoot = ModContent.ProjectileType<BallOhurtProjectile>();
			}

			if (item.type == ItemID.TheMeatball)
			{
				item.shoot = ModContent.ProjectileType<TheMeatballProjectile>();
			}

			if (item.type == ItemID.BlueMoon)
			{
				item.shoot = ModContent.ProjectileType<BlueMoonProjectile>();
			}

			if (item.type == ItemID.Sunfury)
			{
				item.shoot = ModContent.ProjectileType<SunfuryProjectile>();
			}

			if (item.type == ItemID.DaoofPow)
			{
				item.shoot = ModContent.ProjectileType<DaoOfPowProjectile>();
			}

			if (item.type == ItemID.DripplerFlail)
			{
				item.shoot = ModContent.ProjectileType<DripplerCripplerProjectile>();
			}

			if (item.type == ItemID.FlowerPow)
			{
				item.shoot = ModContent.ProjectileType<FlowerPowProjectile>();
			}
		}
	}
}