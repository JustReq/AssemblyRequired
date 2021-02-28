using Terraria;
using Terraria.ModLoader;

namespace AssemblyRequired
{
    public class AssemblyRequiredPlayer : ModPlayer
    {
		public bool IronManMk2AccessoryPrevious;
		public bool IronManMk2Accessory;
		public bool IronManMk2HideVanity;
		public bool IronManMk2ForceVanity;
		public bool IronManMk2Power;

		public bool nullified;

		public override void ResetEffects()
        {
            IronManMk2AccessoryPrevious = IronManMk2Accessory;
            IronManMk2Accessory = IronManMk2HideVanity = IronManMk2ForceVanity = IronManMk2Power = false;

			nullified = false;
		}

		public override void PostUpdateBuffs()
		{
			if (nullified)
			{
				Nullify();
			}
		}

		public override void PostUpdateEquips()
		{
			if (nullified)
			{
				Nullify();
			}
		}

		public override void UpdateVanityAccessories()
		{
			for (int n = 13; n < 18 + player.extraAccessorySlots; n++)
			{
				Item item = player.armor[n];
				if (item.type == ModContent.ItemType<IronManSuits.Mark2.IronManMk2>())
				{
					IronManMk2HideVanity = false;
					IronManMk2ForceVanity = true;
				}
			}
		}

		/* public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
		{
			// Make sure this condition is the same as the condition in the Buff to remove itself. We do this here instead of in ModItem.UpdateAccessory in case we want future upgraded items to set blockyAccessory
			if (player.townNPCs >= 1 && blockyAccessory)
			{
				player.AddBuff(ModContent.BuffType<Buffs.Blocky>(), 60, true);
			}
		} */

		public override void FrameEffects()
		{
			if ((IronManMk2Power || IronManMk2ForceVanity) && !IronManMk2HideVanity)
			{
				player.legs = mod.GetEquipSlot("IronManMk2Legs", EquipType.Legs);
				player.body = mod.GetEquipSlot("IronManMk2Body", EquipType.Body);
				player.head = mod.GetEquipSlot("IronManMk2Head", EquipType.Head);
			}
			if (nullified)
			{
				Nullify();
			}
		}

		private void Nullify()
		{
			player.ResetEffects();
			player.head = -1;
			player.body = -1;
			player.legs = -1;
			player.handon = -1;
			player.handoff = -1;
			player.back = -1;
			player.front = -1;
			player.shoe = -1;
			player.waist = -1;
			player.shield = -1;
			player.neck = -1;
			player.face = -1;
			player.balloon = -1;
			nullified = true;
		}

		public override void ModifyDrawInfo(ref PlayerDrawInfo drawInfo)
		{
			if ((IronManMk2Power || IronManMk2ForceVanity) && !IronManMk2HideVanity)
			{
				player.headRotation = player.velocity.Y * (float)player.direction * 0.1f;
				player.headRotation = Utils.Clamp(player.headRotation, -0.3f, 0.3f);
			}
		}
	}
}
