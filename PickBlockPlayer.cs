using Terraria.GameInput;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace PickBlock;

public class PickBlockPlayer : ModPlayer
{
	public override void ProcessTriggers(TriggersSet triggersSet)
	{
		if (!ModContent.GetInstance<KeybindSystem>().PickBlockHotkey.JustPressed)
			return;
		
		GiveTile(Framing.GetTileSafely(Main.MouseWorld));
	}
	
	private void GiveTile(Tile tile)
	{
		ushort ID = tile.HasTile ? tile.TileType : tile.WallType;

		if (tile.HasTile) {
			var tileAssociativeItems = ModContent.GetInstance<PickBlock>().TileAssociativeItems;

			if (!tileAssociativeItems.TryGetValue(ID, out int tileItemID))
				return;

			int tileDrop = TileLoader.GetItemDropFromTypeAndStyle(tile.TileType, TileObjectData.GetTileStyle(tile));
			if (tileDrop != 0 && tileItemID != tileDrop) {
				tileItemID = tileDrop;
			}

			GiveItem(tileItemID);
		}
		else {
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

		if (ModContent.GetInstance<PickBlockConfig>().giveItems && !Player.HasItem(tileItemID)) {
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

		for (int i = 0; i < Main.InventorySlotsTotal; i++) {
			if (Player.inventory[i].type == tileItemID) {
				// swap the current selected slot with the item
				Utils.Swap(ref Player.inventory[i], ref Player.inventory[Player.selectedItem]);
			}
		}
	}
}
