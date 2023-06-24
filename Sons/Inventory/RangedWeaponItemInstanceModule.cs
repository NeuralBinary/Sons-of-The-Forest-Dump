using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using Sons.Weapon;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000630 RID: 1584
	[Token(Token = "0x2000630")]
	[Serializable]
	public class RangedWeaponItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000561")]
		public RangedWeapon RangedWeapon
		{
			[Token(Token = "0x600291B")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000562")]
		public List<WeaponMod> ActiveMods
		{
			[Token(Token = "0x600291C")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291D")]
		[Address(RVA = "0x2960BE0", Offset = "0x295F1E0", VA = "0x182960BE0")]
		public void SetAmmoCount(int count)
		{
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291E")]
		[Address(RVA = "0x9048C0", Offset = "0x902EC0", VA = "0x1809048C0")]
		public void SetAmmoType(int itemId)
		{
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002920")]
		[Address(RVA = "0x33E80E0", Offset = "0x33E66E0", VA = "0x1833E80E0", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002921")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002922")]
		[Address(RVA = "0x33E87A0", Offset = "0x33E6DA0", VA = "0x1833E87A0")]
		public void AddWeaponMod(WeaponMod weaponMod)
		{
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002923")]
		[Address(RVA = "0x33E88A0", Offset = "0x33E6EA0", VA = "0x1833E88A0")]
		public void RemoveAllMods()
		{
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x0000C258 File Offset: 0x0000A458
		[Token(Token = "0x6002924")]
		[Address(RVA = "0x33E8900", Offset = "0x33E6F00", VA = "0x1833E8900")]
		public bool TryGetActiveModItemIds(out List<int> modItemIds)
		{
			return default(bool);
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002925")]
		[Address(RVA = "0x33E8B80", Offset = "0x33E7180", VA = "0x1833E8B80")]
		private void SwitchMods()
		{
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x0000C270 File Offset: 0x0000A470
		[Token(Token = "0x6002926")]
		[Address(RVA = "0x33E8C60", Offset = "0x33E7260", VA = "0x1833E8C60")]
		public bool IsWeaponModCompatible(WeaponMod potentialMod)
		{
			return default(bool);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x0000C288 File Offset: 0x0000A488
		[Token(Token = "0x6002927")]
		[Address(RVA = "0x33E8E40", Offset = "0x33E7440", VA = "0x1833E8E40")]
		public bool IsSlotAvailable(WeaponMod.Slot slot)
		{
			return default(bool);
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		[Token(Token = "0x6002928")]
		[Address(RVA = "0x33E8F00", Offset = "0x33E7500", VA = "0x1833E8F00")]
		public bool HasRequiredSlot(WeaponMod.Slot requiredSlot)
		{
			return default(bool);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002929")]
		[Address(RVA = "0x33E8FD0", Offset = "0x33E75D0", VA = "0x1833E8FD0", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292A")]
		[Address(RVA = "0x33E9390", Offset = "0x33E7990", VA = "0x1833E9390", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600292B")]
		[Address(RVA = "0x33E95F0", Offset = "0x33E7BF0", VA = "0x1833E95F0", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292C")]
		[Address(RVA = "0x33E97F0", Offset = "0x33E7DF0", VA = "0x1833E97F0", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292D")]
		[Address(RVA = "0x33E9B60", Offset = "0x33E8160", VA = "0x1833E9B60")]
		public RangedWeaponItemInstanceModule()
		{
		}

		// Token: 0x040024D0 RID: 9424
		[Token(Token = "0x40024D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RangedWeapon _rangedWeapon;

		// Token: 0x040024D1 RID: 9425
		[Token(Token = "0x40024D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<WeaponMod> _weaponMods;

		// Token: 0x040024D2 RID: 9426
		[Token(Token = "0x40024D2")]
		[FieldOffset(Offset = "0x30")]
		private WeaponMods _weaponModsComponent;

		// Token: 0x040024D3 RID: 9427
		[Token(Token = "0x40024D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RangedWeapon.Ammo _ammo;

		// Token: 0x040024D4 RID: 9428
		[Token(Token = "0x40024D4")]
		[FieldOffset(Offset = "0x40")]
		private int _ammoType;

		// Token: 0x040024D5 RID: 9429
		[Token(Token = "0x40024D5")]
		[FieldOffset(Offset = "0x44")]
		private int _ammoCount;

		// Token: 0x02000631 RID: 1585
		[Token(Token = "0x2000631")]
		[Serializable]
		public class RangedWeaponSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x0600292E RID: 10542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600292E")]
			[Address(RVA = "0x33E9C20", Offset = "0x33E8220", VA = "0x1833E9C20")]
			public RangedWeaponSaveData()
			{
			}

			// Token: 0x040024D6 RID: 9430
			[Token(Token = "0x40024D6")]
			[FieldOffset(Offset = "0x20")]
			public int AmmoType;

			// Token: 0x040024D7 RID: 9431
			[Token(Token = "0x40024D7")]
			[FieldOffset(Offset = "0x24")]
			public int CurrentAmmo;

			// Token: 0x040024D8 RID: 9432
			[Token(Token = "0x40024D8")]
			[FieldOffset(Offset = "0x28")]
			public List<int> WeaponModIds;
		}
	}
}
