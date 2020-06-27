using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using System.Linq;

namespace NoNurseCheese
{
    public class NoNurseCheese : Mod
    {
        
    }

    public class Killer : GlobalNPC
	{
        public override void OnChatButtonClicked(NPC npc, bool firstButton)
        {
            if(npc.TypeName == "Nurse" && Main.npc.Where(n => n.active && n.boss).ToList().Count > 0)
            {
                Main.LocalPlayer.KillMe(PlayerDeathReason.ByCustomReason(Main.LocalPlayer.name + " was punished for dishonorable tactics."), 1.0, 0);
            }
        }
    }
}