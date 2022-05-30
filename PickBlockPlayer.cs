using System.Collections.Generic;
using Terraria.GameInput;
using Terraria;
using Terraria.ModLoader;

namespace PickBlock;

class PickBlockPlayer : ModPlayer
{
	public static bool giveItems;
	public override void ProcessTriggers(TriggersSet triggersSet)
	{
		if (!Main.mouseMiddle || !Main.mouseMiddleRelease)
			return;

		Tile tile = Main.tile[(int)(Main.MouseWorld.X / 16f), (int)(Main.MouseWorld.Y / 16f)];

		GiveTile(tile);
	}

	private void GiveTile(Tile tile)
	{
		var ID = tile.HasTile ? tile.TileType : tile.WallType;

		if (tile.HasTile)
		{
			var tileAssociativeItems = ModContent.GetInstance<PickBlock>().TileAssociativeItems;

			if (!tileAssociativeItems.TryGetValue(ID, out int tileItemID))
				return;

			TileDrops.KillTile_GetItemDrops(x: 0, y: 0, tileCache: tile, out int tileDrop, dropItemStack: out _, secondaryItem: out _, secondaryItemStack: out _, includeLargeObjectDrops: true);
			if (tileDrop != 0 && tileItemID != tileDrop)
				tileItemID = tileDrop;

			GiveItem(tileItemID);
		}
		else
		{
			var wallAssociativeItems = ModContent.GetInstance<PickBlock>().WallAssociativeItems;

			if (!wallAssociativeItems.TryGetValue(ID, out int wallItemID))
				return;

			GiveItem(wallItemID);
		}
	}

	private void GiveItem(int tileItemID)
	{
		if (tileItemID == 0)
			return;

		if (giveItems && !Player.HasItem(tileItemID))
		{
			var item = new Item(tileItemID);
			item.stack = item.maxStack;

			// loop though the inventory
			for (int i = 0; i < Main.InventoryItemSlotsCount; i++) {
				if (Player.inventory[i].IsAir) { // is the slot a free space
					Player.inventory[i] = item; // set item
					break;
				}
			}
		}

		for (int i = 0; i < Main.InventorySlotsTotal; i++)
		{
			if (Player.inventory[i].type == tileItemID)
			{
				// swap the current selected slot with the item
				Utils.Swap(ref Player.inventory[i], ref Player.inventory[Player.selectedItem]);
			}
		}
	}
}
