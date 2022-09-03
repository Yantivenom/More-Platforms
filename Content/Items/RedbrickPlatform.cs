using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace MorePlatforms.Content.Items
{
    public class RedbrickPlatform : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Platform made of Red Bricks.");

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
			Item.createTile = ModContent.TileType<Tiles.RedbrickPlatform>();
		}
		public override void AddRecipes()
		{
			CreateRecipe(2)
				.AddIngredient(ItemID.RedBrick)
				.Register();

			Recipe decraftRecipe = Recipe.Create(ItemID.RedBrick);
			decraftRecipe.AddIngredient<RedbrickPlatform>(2);
			decraftRecipe.Register();
		}
	}
}
