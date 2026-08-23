using FlailMod.Common;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FlailMod.Content.Accessories
{
    public class ScarabIdol : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 24;
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.rare = ItemRarityID.LightRed;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			FlailPlayer modPlayer = player.GetModPlayer<FlailPlayer>();
			modPlayer.FlailScarab = true;
		}
	}
}
