﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace MorePlatforms.Content.Tiles
{
    public class PooPlatform : ModTile
    {
        public override void SetStaticDefaults()
        {

            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            Main.tileWaterDeath[Type] = false;
            TileID.Sets.Platforms[Type] = true;
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleMultiplier = 27;
            TileObjectData.newTile.StyleWrapLimit = 27;
            TileObjectData.newTile.UsesCustomCanPlace = false;
            TileObjectData.addTile(Type);
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
            AddMapEntry(new Color(47, 51, 58));
            DustType = 54;

            AdjTiles = new int[] { TileID.Platforms };
        }
        public override void PostSetDefaults()
        {
            Main.tileNoSunLight[Type] = false;
        }
        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = 10;
        }
        public override void FloorVisuals(Player player)
        {
            player.stinky = true;
        }
    }
}