using FlailMod.Common;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FlailMod.Content.Accessories
{
    public class ScarabGrease : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 24;
			Item.value = Item.sellPrice(0, 6, 0, 0);
			Item.rare = ItemRarityID.Lime;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			FlailPlayer modPlayer = player.GetModPlayer<FlailPlayer>();
			modPlayer.FlailChargeDamage += 1f;
			modPlayer.FlailChargeSpeed += 0.5f;
			modPlayer.FlailScarab = true;
		}

		public override void AddRecipes() => CreateRecipe()
			.AddIngredient<MechanicalGrease>()
			.AddIngredient<ScarabIdol>()
			.AddTile(TileID.TinkerersWorkbench)
			.Register();
	}
}
