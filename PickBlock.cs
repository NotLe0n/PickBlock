using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace PickBlock;

public class PickBlock : Mod
{
	public Dictionary<int, int> TileAssociativeItems { get; private set; }
	public Dictionary<int, int> WallAssociativeItems { get; private set; }

	public override void PostSetupContent()
	{
		TileAssociativeItems = new Dictionary<int, int>();
		WallAssociativeItems = new Dictionary<int, int>();

		Item item = new();
		for (int i = 1; i < ItemLoader.ItemCount; i++)
		{
			item.SetDefaults(i);

			if (item.createTile != -1)
			{
				if (TileAssociativeItems.ContainsKey(item.createTile))
					continue;

				TileAssociativeItems.Add(item.createTile, item.type);
			}

			if (item.createWall != -1)
			{
				if (WallAssociativeItems.ContainsKey(item.createWall))
					continue;

				WallAssociativeItems.Add(item.createWall, item.type);
			}
		}
	}
}
