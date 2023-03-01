using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Weapon;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x0200061A RID: 1562
	[Token(Token = "0x200061A")]
	[Serializable]
	public class RangedWeaponItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000549")]
		public RangedWeapon RangedWeapon
		{
			[Token(Token = "0x60027F3")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054A")]
		public List<WeaponMod> ActiveMods
		{
			[Token(Token = "0x60027F4")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x24AE630", Offset = "0x24AD630", VA = "0x1824AE630")]
		public void SetAmmoCount(int count)
		{
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F6")]
		[Address(RVA = "0x7E13C0", Offset = "0x7E03C0", VA = "0x1807E13C0")]
		public void SetAmmoType(int itemId)
		{
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F7")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F8")]
		[Address(RVA = "0x2DC2CF0", Offset = "0x2DC1CF0", VA = "0x182DC2CF0", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x111BAA0", Offset = "0x111AAA0", VA = "0x18111BAA0", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FA")]
		[Address(RVA = "0x2DC2210", Offset = "0x2DC1210", VA = "0x182DC2210")]
		public void AddWeaponMod(WeaponMod weaponMod)
		{
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FB")]
		[Address(RVA = "0x2DC30D0", Offset = "0x2DC20D0", VA = "0x182DC30D0")]
		public void RemoveAllMods()
		{
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		[Token(Token = "0x60027FC")]
		[Address(RVA = "0x2DC3420", Offset = "0x2DC2420", VA = "0x182DC3420")]
		public bool TryGetActiveModItemIds(out List<int> modItemIds)
		{
			return default(bool);
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FD")]
		[Address(RVA = "0x2DC33A0", Offset = "0x2DC23A0", VA = "0x182DC33A0")]
		private void SwitchMods()
		{
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[Token(Token = "0x60027FE")]
		[Address(RVA = "0x2DC2670", Offset = "0x2DC1670", VA = "0x182DC2670")]
		public bool IsWeaponModCompatible(WeaponMod potentialMod)
		{
			return default(bool);
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[Token(Token = "0x60027FF")]
		[Address(RVA = "0x2DC25A0", Offset = "0x2DC15A0", VA = "0x182DC25A0")]
		public bool IsSlotAvailable(WeaponMod.Slot slot)
		{
			return default(bool);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x2DC24C0", Offset = "0x2DC14C0", VA = "0x182DC24C0")]
		public bool HasRequiredSlot(WeaponMod.Slot requiredSlot)
		{
			return default(bool);
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002801")]
		[Address(RVA = "0x2DC3130", Offset = "0x2DC2130", VA = "0x182DC3130", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002802")]
		[Address(RVA = "0x2DC2B40", Offset = "0x2DC1B40", VA = "0x182DC2B40", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x2DC22F0", Offset = "0x2DC12F0", VA = "0x182DC22F0", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x2DC2830", Offset = "0x2DC1830", VA = "0x182DC2830", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x2DC3620", Offset = "0x2DC2620", VA = "0x182DC3620")]
		public RangedWeaponItemInstanceModule()
		{
		}

		// Token: 0x040023DA RID: 9178
		[Token(Token = "0x40023DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RangedWeapon _rangedWeapon;

		// Token: 0x040023DB RID: 9179
		[Token(Token = "0x40023DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<WeaponMod> _weaponMods;

		// Token: 0x040023DC RID: 9180
		[Token(Token = "0x40023DC")]
		[FieldOffset(Offset = "0x30")]
		private WeaponMods _weaponModsComponent;

		// Token: 0x040023DD RID: 9181
		[Token(Token = "0x40023DD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RangedWeapon.Ammo _ammo;

		// Token: 0x040023DE RID: 9182
		[Token(Token = "0x40023DE")]
		[FieldOffset(Offset = "0x40")]
		private int _ammoType;

		// Token: 0x040023DF RID: 9183
		[Token(Token = "0x40023DF")]
		[FieldOffset(Offset = "0x44")]
		private int _ammoCount;

		// Token: 0x0200061B RID: 1563
		[Token(Token = "0x200061B")]
		[Serializable]
		public class RangedWeaponSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x06002806 RID: 10246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002806")]
			[Address(RVA = "0x2DC36A0", Offset = "0x2DC26A0", VA = "0x182DC36A0")]
			public RangedWeaponSaveData()
			{
			}

			// Token: 0x040023E0 RID: 9184
			[Token(Token = "0x40023E0")]
			[FieldOffset(Offset = "0x20")]
			public int AmmoType;

			// Token: 0x040023E1 RID: 9185
			[Token(Token = "0x40023E1")]
			[FieldOffset(Offset = "0x24")]
			public int CurrentAmmo;

			// Token: 0x040023E2 RID: 9186
			[Token(Token = "0x40023E2")]
			[FieldOffset(Offset = "0x28")]
			public List<int> WeaponModIds;
		}
	}
}
