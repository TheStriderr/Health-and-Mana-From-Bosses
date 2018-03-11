using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EasierBossLoot.NPCs
{
	public class ExampleGlobalNPC : GlobalNPC
	{

		public override void NPCLoot(NPC npc)
		{

			if (npc.type == NPCID.EyeofCthulhu && !Main.expertMode)
			{
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(1, 3));
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ManaCrystal, Main.rand.Next(1, 2));
			}

      if (npc.type == NPCID.EaterofWorldsHead && !Main.expertMode)
			{

			}

      if (npc.type == NPCID.EaterofWorldsBody && !Main.expertMode)
			{

			}

      if (npc.type == NPCID.EaterofWorldsTail && !Main.expertMode)
			{

			}

      if (npc.type == NPCID.BrainofCthulhu && !Main.expertMode)
      {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(3, 3));
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ManaCrystal, Main.rand.Next(1, 3));
      }

      if (npc.type == NPCID.SkeletronHead && !Main.expertMode)
      {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(2, 4));
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ManaCrystal, Main.rand.Next(2, 3));
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Bone, Main.rand.Next(24, 46));
      }

      if (npc.type == NPCID.KingSlime && !Main.expertMode)
      {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(1, 1));
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ManaCrystal, Main.rand.Next(1, 2));
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, Main.rand.Next(11, 21));
      }

      if (npc.type == NPCID.QueenBee && !Main.expertMode)
      {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(2, 3));
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ManaCrystal, Main.rand.Next(2, 3));
      }

      if (npc.type == NPCID.WallofFlesh && !Main.expertMode)
      {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(3, 3));
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ManaCrystal, Main.rand.Next(3, 3));
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.FleshBlock, Main.rand.Next(44, 66));
      }

      if (npc.type == NPCID.Retinazer && !Main.expertMode)
      {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(1, 2));
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ManaCrystal, Main.rand.Next(1, 2));
      }

      if (npc.type == NPCID.Spazmatism && !Main.expertMode)
      {
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(1, 2));
        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ManaCrystal, Main.rand.Next(1, 2));
      }

			if (npc.type == NPCID.TheDestroyer && !Main.expertMode)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(3, 4));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ManaCrystal, Main.rand.Next(3, 4));
			}

			if (npc.type == NPCID.SkeletronPrime && !Main.expertMode)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(3, 4));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ManaCrystal, Main.rand.Next(3, 4));
			}

			if (npc.type == NPCID.Plantera && !Main.expertMode)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeFruit, Main.rand.Next(6, 8));
			}

			if (npc.type == NPCID.Golem && !Main.expertMode)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeFruit, Main.rand.Next(7, 9));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LihzahrdBrick, Main.rand.Next(45, 60));
			}

			if (npc.type == NPCID.DukeFishron && !Main.expertMode)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeFruit, Main.rand.Next(6, 10));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FishronFin"), Main.rand.Next(22, 35));
			}

			if (npc.type == NPCID.MoonLordCore && !Main.expertMode)
			{
			}

		}




		}
	}
