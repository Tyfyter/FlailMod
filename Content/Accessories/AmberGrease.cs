using FlailMod.Common;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FlailMod.Content.Accessories
{
    public class AmberGrease : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 24;
			Item.value = Item.sellPrice(0, 0, 50, 0);
			Item.rare = ItemRarityID.Orange;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			FlailPlayer modPlayer = player.GetModPlayer<FlailPlayer>();
			modPlayer.FlailChargeDamage += 0.5f;
			modPlayer.FlailChargeSpeed += 0.25f;
		}

		public override void AddRecipes() => CreateRecipe()
			.AddIngredient<GoblinGrease>()
			.AddIngredient<AmberCarving>()
			.AddTile(TileID.TinkerersWorkbench)
			.Register();
	}
}
