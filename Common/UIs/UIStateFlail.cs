using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace FlailMod.Common.UIs
{
    public class UIStateFlail : ModUIState
    {
        private const float Segment = 300 / 36f; // Player max flail charge divided by the flail bar texture width
        public static Texture2D TextureBorder;
        public static Texture2D TextureBar;

        public override int InsertionIndex(List<GameInterfaceLayer> layers)
            => layers.FindIndex(layer => layer.Name.Equals("Vanilla: Inventory"));

        public override void OnInitialize()
        {
            TextureBorder ??= ModContent.Request<Texture2D>("FlailMod/Common/UIs/Textures/FlailBar", AssetRequestMode.ImmediateLoad).Value;
            TextureBar ??= ModContent.Request<Texture2D>("FlailMod/Common/UIs/Textures/FlailBarFill", AssetRequestMode.ImmediateLoad).Value;

            Width.Set(0f, 0f);
            Height.Set(0f, 0f);
            Left.Set(Main.screenWidth / 2, 0f);
            Top.Set(Main.screenHeight / 2, 0f);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            Player player = Main.LocalPlayer;
            FlailPlayer modPlayer = player.GetModPlayer<FlailPlayer>();

            if (modPlayer.DisplayFlailBar > 0 && !player.dead)
            {
                spriteBatch.End();
                spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.None, Main.Rasterizer, null, Main.Transform);

                Vector2 position = (player.position + new Vector2(player.width * 0.5f, player.gravDir > 0 ? player.height + player.gfxOffY : 10 + player.gfxOffY)).Floor();
                position = Vector2.Transform(position - Main.screenPosition, Main.GameViewMatrix.EffectMatrix * Main.GameViewMatrix.ZoomMatrix);
                spriteBatch.Draw(TextureBorder, position, null, Color.White, 0f, TextureBorder.Size() * 0.5f, 1f, SpriteEffects.None, 0f);

                Rectangle rectangle = TextureBar.Bounds;
                rectangle.Width = (int)(modPlayer.FLailCharge / Segment);

                spriteBatch.Draw(TextureBar, position, rectangle, Color.White, 0f, TextureBar.Size() * 0.5f, 1f, SpriteEffects.None, 0f);

                spriteBatch.End();
                spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, Main.DefaultSamplerState, DepthStencilState.None, Main.Rasterizer, null, Main.UIScaleMatrix);
            }
        }
    }
}