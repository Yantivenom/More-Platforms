using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace MorePlatforms.Content.Items
{
	public class AsphaltPlatformItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Asphalt Platform");
			// Tooltip.SetDefault("Increases running speed");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 200;
        }
		public override void SetDefaults()
		{
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 9999;
			Item.useTurn = true;
			Item.useTime = 1;
			Item.useAnimation = 15;
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.AsphaltPlatformTile>();

		}

		public override void AddRecipes()
		{
			CreateRecipe(2)
			.AddIngredient(ItemID.AsphaltBlock)
			.AddTile(TileID.Blendomatic)
			.Register();

			Recipe decraftRecipe = Recipe.Create(ItemID.AsphaltBlock);
			decraftRecipe.AddIngredient<AsphaltPlatformItem>(2);
			decraftRecipe.AddTile(TileID.Blendomatic);
			decraftRecipe.Register();

		}
	}
}
