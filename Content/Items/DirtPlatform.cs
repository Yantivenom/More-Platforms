﻿using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace MorePlatforms.Content.Items
{
    public class DirtPlatform : ModItem
    {
        public override void SetStaticDefaults()
        {
            // Tooltip.SetDefault("Platform made of dirt.");

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
			Item.createTile = ModContent.TileType<Tiles.DirtPlatform>();
		}

        public override void AddRecipes()
		{
			CreateRecipe(2)
				.AddIngredient(ItemID.DirtBlock)
				.Register();

			Recipe decraftRecipe = Recipe.Create(ItemID.DirtBlock);
			decraftRecipe.AddIngredient<DirtPlatform>(2);
			decraftRecipe.Register();
		}
	}
}
