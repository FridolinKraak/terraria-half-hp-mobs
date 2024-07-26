using Terraria;
using Terraria.ModLoader;

namespace HalfHpMobs
{
    public class MobHpChanger : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {			
            if (!npc.boss && !npc.townNPC)
            {
                npc.lifeMax = (int)(npc.lifeMax * 0.5);
            }
        }
    }
}