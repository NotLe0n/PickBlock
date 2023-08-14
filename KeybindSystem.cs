using Terraria.ModLoader;

namespace PickBlock;

public class KeybindSystem : ModSystem
{
	public ModKeybind PickBlockHotkey { get; private set; }

	public override void Load()
	{
		PickBlockHotkey = KeybindLoader.RegisterKeybind(Mod, "PickBlock", "Mouse3");
	}

	public override void Unload()
	{
		PickBlockHotkey = null;
	}
}