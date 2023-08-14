using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace PickBlock;

public class PickBlockConfig : ModConfig
{
	public override ConfigScope Mode => ConfigScope.ClientSide;

	[DefaultValue(false)]
	public bool giveItems;
}
