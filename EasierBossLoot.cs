using Terraria.ModLoader;

namespace EasierBossLoot
{
	class EasierBossLoot : Mod
	{
		public EasierBossLoot()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
