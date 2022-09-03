using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace MorePlatforms.Content.Items
{
    public class StonePlatform : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Platform made of stone.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 200;
		}

		public override void SetDefaults()
		{
			Item.width = 8;
			Item.height = 10;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 1;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.StonePlatform>();
		}
		public override void AddRecipes()
		{
			CreateRecipe(2)
				.AddIngredient(ItemID.StoneBlock)
				.Register();

			Recipe decraftRecipe = Recipe.Create(ItemID.StoneBlock);
			decraftRecipe.AddIngredient<StonePlatform>(2);
			decraftRecipe.Register();
		}
	}
}
