using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace MorePlatforms.Content.Items
{
	public class InfusedHoneyPlatform : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Infused Honey Platform");
			// Tooltip.SetDefault("Just like swimming in honey!");

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
			Item.createTile = ModContent.TileType<Tiles.InfusedHoneyPlatform>();

		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddIngredient(ItemID.HoneyPlatform)
			.AddTile(TileID.HoneyDispenser)
			.Register();

			Recipe decraftRecipe = Recipe.Create(ItemID.HoneyPlatform);
			decraftRecipe.AddIngredient<InfusedHoneyPlatform>(1);
			decraftRecipe.AddTile(TileID.HoneyDispenser);
			decraftRecipe.Register();

		}
	}
}