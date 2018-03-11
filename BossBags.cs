using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EasierBossLoot
{
	public class BossBags : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg)
		{

			// Prehardmode

			if (context == "bossBag" && arg == ItemID.EyeOfCthulhuBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeCrystal, Main.rand.Next(1, 3));
				player.QuickSpawnItem(ItemID.ManaCrystal, Main.rand.Next(1, 2));
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(29, 39));
			}

			if (context == "bossBag" && arg == ItemID.EaterOfWorldsBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeCrystal, Main.rand.Next(2, 3));
				player.QuickSpawnItem(ItemID.ManaCrystal, Main.rand.Next(1, 3));
		  	player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(52, 62));
			}

			if (context == "bossBag" && arg == ItemID.BrainOfCthulhuBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeCrystal, Main.rand.Next(2, 3));
				player.QuickSpawnItem(ItemID.ManaCrystal, Main.rand.Next(1, 3));
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(52, 62));
			}

			if (context == "bossBag" && arg == ItemID.SkeletronBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeCrystal, Main.rand.Next(2, 4));
				player.QuickSpawnItem(ItemID.ManaCrystal, Main.rand.Next(2, 3));
				player.QuickSpawnItem(ItemID.Bone, Main.rand.Next(24, 46));
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(132, 142));
			}

			if (context == "bossBag" && arg == ItemID.KingSlimeBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeCrystal, Main.rand.Next(1, 1));
				player.QuickSpawnItem(ItemID.ManaCrystal, Main.rand.Next(1, 2));
				player.QuickSpawnItem(ItemID.Gel, Main.rand.Next(34, 43));
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(11, 21));
			}

			if (context == "bossBag" && arg == ItemID.QueenBeeBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeCrystal, Main.rand.Next(2, 3));
				player.QuickSpawnItem(ItemID.ManaCrystal, Main.rand.Next(2, 3));
		  	player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(79, 89));
			}

			if (context == "bossBag" && arg == ItemID.WallOfFleshBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeCrystal, Main.rand.Next(3, 3));
				player.QuickSpawnItem(ItemID.ManaCrystal, Main.rand.Next(3, 3));
				player.QuickSpawnItem(ItemID.FleshBlock, Main.rand.Next(44, 66));
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(161, 171));
			}

			//Hardmode

			if (context == "bossBag" && arg == ItemID.TwinsBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeCrystal, Main.rand.Next(3, 4));
				player.QuickSpawnItem(ItemID.ManaCrystal, Main.rand.Next(3, 4));
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(241, 251));
			}

			if (context == "bossBag" && arg == ItemID.DestroyerBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeCrystal, Main.rand.Next(3, 4));
				player.QuickSpawnItem(ItemID.ManaCrystal, Main.rand.Next(3, 4));
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(241, 251));
			}

			if (context == "bossBag" && arg == ItemID.SkeletronPrimeBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeCrystal, Main.rand.Next(3, 4));
				player.QuickSpawnItem(ItemID.ManaCrystal, Main.rand.Next(3, 4));
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(241, 251));
			}

			if (context == "bossBag" && arg == ItemID.PlanteraBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeFruit, Main.rand.Next(6, 8));
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(304, 314));
			}

			if (context == "bossBag" && arg == ItemID.GolemBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeFruit, Main.rand.Next(7, 9));
				player.QuickSpawnItem(ItemID.LihzahrdBrick, Main.rand.Next(45, 60));
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(374, 384));
			}

			if (context == "bossBag" && arg == ItemID.FishronBossBag)
			{
				player.QuickSpawnItem(ItemID.LifeFruit, Main.rand.Next(6, 10));
				player.QuickSpawnItem(mod.ItemType("FishronFin"), Main.rand.Next(22, 35));
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(447, 457));
			}

			if (context == "bossBag" && arg == ItemID.MoonLordBossBag)
			{
				player.QuickSpawnItem(mod.ItemType("SoulOfPlight"), Main.rand.Next(534, 544));
			}

		}
	}
}
