using FlailMod.Common;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FlailMod.Content.Accessories
{
    public class MechanicalGrease : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 24;
			Item.value = Item.sellPrice(0, 5, 0, 0);
			Item.rare = ItemRarityID.LightPurple;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			FlailPlayer modPlayer = player.GetModPlayer<FlailPlayer>();
			modPlayer.FlailChargeDamage += 0.8f;
			modPlayer.FlailChargeSpeed += 0.3f;
		}

		public override void AddRecipes() => CreateRecipe()
			.AddIngredient<AmberGrease>()
			.AddIngredient(ItemID.AvengerEmblem)
			.AddTile(TileID.TinkerersWorkbench)
			.Register();
	}
}
