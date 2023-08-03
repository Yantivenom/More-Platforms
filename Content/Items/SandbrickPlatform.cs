using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace MorePlatforms.Content.Items
{
	public class SandbrickPlatform : ModItem
	{
		public override void SetStaticDefaults()
		{
			// Tooltip.SetDefault("Platform made of Sand Bricks.");

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
			Item.createTile = ModContent.TileType<Tiles.SandbrickPlatform>();
		}
		public override void AddRecipes()
		{
			CreateRecipe(2)
				.AddIngredient(ItemID.SandstoneBrick)
				.Register();

			Recipe decraftRecipe = Recipe.Create(ItemID.SandstoneBrick);
			decraftRecipe.AddIngredient<SandbrickPlatform>(2);
			decraftRecipe.Register();
		}
	}
}
