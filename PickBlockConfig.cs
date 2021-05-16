using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace PickBlock
{
    public class PickBlockConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [DefaultValue(true)]
        [Label("Give Items")]
        [Tooltip("Toggle if the mod should give you Items. \nBasicly: Do you want to cheat?")]
        public bool GiveItems { get; set; }
        public override void OnChanged()
        {
            PickBlockPlayer.GiveItems = GiveItems;
        }
    }
}