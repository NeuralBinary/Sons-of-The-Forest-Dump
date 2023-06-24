using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public class WeaponMods : MonoBehaviour
	{
		// Token: 0x0600018E RID: 398 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x31A3FB0", Offset = "0x31A25B0", VA = "0x1831A3FB0")]
		public bool HasActiveMods()
		{
			return default(bool);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x31A41A0", Offset = "0x31A27A0", VA = "0x1831A41A0")]
		public bool HasMod(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x31A4310", Offset = "0x31A2910", VA = "0x1831A4310")]
		public WeaponMod GetMod(WeaponMod.Slot slot)
		{
			return null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x31A4470", Offset = "0x31A2A70", VA = "0x1831A4470")]
		public bool ApplyMod(WeaponMod weaponMod)
		{
			return default(bool);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x31A46F0", Offset = "0x31A2CF0", VA = "0x1831A46F0")]
		public bool RemoveMod(WeaponMod mod)
		{
			return default(bool);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x31A4A50", Offset = "0x31A3050", VA = "0x1831A4A50")]
		public void GetActiveSlots(out List<WeaponMod.Slot> activeSlotsOut)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x31A4D70", Offset = "0x31A3370", VA = "0x1831A4D70")]
		public bool HasSlot(WeaponMod.Slot slot)
		{
			return default(bool);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x31A4EE0", Offset = "0x31A34E0", VA = "0x1831A4EE0")]
		public bool IsSlotFree(WeaponMod.Slot slot)
		{
			return default(bool);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x31A5050", Offset = "0x31A3650", VA = "0x1831A5050")]
		public GameObject GetAttachedModObject(WeaponMod mod)
		{
			return null;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x31A52E0", Offset = "0x31A38E0", VA = "0x1831A52E0")]
		public void SwitchMods(IEnumerable<WeaponMod> mods)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WeaponMods()
		{
		}

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<WeaponMods.ModLink> _modLocations;

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		[Serializable]
		public class ModLink
		{
			// Token: 0x06000199 RID: 409 RVA: 0x00002924 File Offset: 0x00000B24
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x31A56F0", Offset = "0x31A3CF0", VA = "0x1831A56F0")]
			public bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x0600019A RID: 410 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ModLink()
			{
			}

			// Token: 0x04000113 RID: 275
			[Token(Token = "0x4000113")]
			[FieldOffset(Offset = "0x10")]
			public WeaponMod.Slot Slot;

			// Token: 0x04000114 RID: 276
			[Token(Token = "0x4000114")]
			[FieldOffset(Offset = "0x18")]
			public Transform Location;

			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			[FieldOffset(Offset = "0x20")]
			public WeaponMod AttachedMod;
		}
	}
}
