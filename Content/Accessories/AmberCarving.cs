using FlailMod.Common;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FlailMod.Content.Accessories
{
    public class AmberCarving : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 24;
			Item.value = Item.sellPrice(0, 0, 40, 0);
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			FlailPlayer modPlayer = player.GetModPlayer<FlailPlayer>();
			modPlayer.FlailChargeDamage += 0.5f;
		}

		public override void AddRecipes() => CreateRecipe()
			.AddIngredient(ItemID.Amber, 5)
			.AddIngredient(ItemID.FossilOre, 20)
			.AddTile(TileID.Anvils)
			.Register();
	}
}
