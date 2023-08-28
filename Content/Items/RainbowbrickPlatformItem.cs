using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MorePlatforms.Content.Items
{
    public class RainbowbrickPlatformItem : ModItem
    {
        public override void SetStaticDefaults()
        {

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 200;
        }

        public override void SetDefaults()
        {
            Item.width = 8;
            Item.height = 10;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 1;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.RainbowbrickPlatform>();
        }

        public override void PostDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            base.PostDrawInInventory(spriteBatch, position, frame, drawColor, itemColor, origin, scale);
            Item.color = Main.DiscoColor;
        }
        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            base.PostDrawInWorld(spriteBatch, lightColor, alphaColor, rotation, scale, whoAmI);
            Item.color = Main.DiscoColor;
        }


        public override void AddRecipes()
        {
            CreateRecipe(2)
                .AddIngredient(ItemID.RainbowBrick)
                .AddTile(TileID.WorkBenches)
                .Register();

            Recipe decraftRecipe = Recipe.Create(ItemID.RainbowBrick);
            decraftRecipe.AddIngredient<RainbowbrickPlatformItem>(2);
            decraftRecipe.Register();
        }
    }
}
