using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace MorePlatforms.Content.Items
{
    public class PooPlatform : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Poo Platform");
            // Tooltip.SetDefault("Why? You stink now.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 200;
        }
        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.maxStack = 999;
            Item.useTurn = true;
            Item.useTime = 1;
            Item.useAnimation = 15;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.PooPlatform>();

        }

        public override void AddRecipes()
        {
            CreateRecipe(2)
            .AddIngredient(ItemID.PoopBlock)
            .Register();

            Recipe decraftRecipe = Recipe.Create(ItemID.PoopBlock);
            decraftRecipe.AddIngredient<PooPlatform>(2);
            decraftRecipe.Register();

        }
    }
}
