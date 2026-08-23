using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using FlailMod.Content.Accessories;

namespace FlailMod.Common
{
	public class FlailNPCLoot : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
			if (npc.type == NPCID.DesertBeast || npc.type == NPCID.DesertScorpionWalk || npc.type == NPCID.DesertScorpionWall || npc.type == NPCID.DesertLamiaDark 
				|| npc.type == NPCID.DesertLamiaLight || npc.type == NPCID.DesertGhoul  || npc.type == NPCID.DesertGhoulCorruption  || npc.type == NPCID.DesertGhoulCrimson  
				|| npc.type == NPCID.DesertGhoulHallow || npc.type == NPCID.DuneSplicerHead || npc.type == NPCID.DesertDjinn)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ScarabIdol>(), 33));
			}

			if (npc.type == NPCID.GoblinWarrior)
			{
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GoblinGrease>(), 20));
			}
		}

        public override void ModifyActiveShop(NPC npc, string shopName, Item[] items)
        {
            if (npc.type == NPCID.GoblinTinkerer && Main.hardMode)
            {
				for (int i = 0; i < items.Length; i++)
				{
					if (items[i] is null)
					{
						items[i] = new Item(ModContent.ItemType<GoblinGrease>());
						break;
					}
				}
			}
        }
    }
}
