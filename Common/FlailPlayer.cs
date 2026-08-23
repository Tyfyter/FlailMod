using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FlailMod.Common
{
    public class FlailPlayer : ModPlayer
    {
        // Can be tweaked with Gear;
        public float FlailChargeSpeed = 1f; // Increases the speed at which Flails are Charged
        public float FlailChargeDamage = 1f; // Further increases the damage of flails based on Charge
        public bool FlailScarab = false;

        // Do not change with gear
        public float FLailCharge = 0f;
        public int DisplayFlailBar = 0;

        public override void ResetEffects()
        {
            DisplayFlailBar--;
            FlailChargeSpeed = 1f;
            FlailChargeDamage = 1f;
            FlailScarab = false;
        }

        public override void ModifyHitByNPC(NPC npc, ref Player.HurtModifiers modifiers)
        {
            if (FlailScarab && FLailCharge > 0)
            {
                modifiers.FinalDamage = modifiers.FinalDamage * 0.8f;
            }
        }

        public override void ModifyHitByProjectile(Projectile proj, ref Player.HurtModifiers modifiers)
        {
            if (FlailScarab && FLailCharge > 0)
            {
                modifiers.FinalDamage = modifiers.FinalDamage * 0.8f;
            }
        }

        public void TryHeal(int amount)
        {
            if (!Player.moonLeech && Player.whoAmI == Main.myPlayer)
            {
                int damage = Player.statLifeMax2 - Player.statLife;
                if (amount > damage)
                {
                    amount = damage;
                }
                if (amount > 0)
                {
                    Player.HealEffect(amount, true);
                    Player.statLife += amount;
                }
            }
        }
    }
}