using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace MorePlatforms.Content.Items
{
    public class MudPlatform : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Platform made of mud.");

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
			Item.createTile = ModContent.TileType<Tiles.MudPlatform>();
		}
		public override void AddRecipes()
		{
			CreateRecipe(2)
				.AddIngredient(ItemID.MudBlock)
				.Register();
		}
	}
}
