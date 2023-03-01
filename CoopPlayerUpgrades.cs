using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x020000CA RID: 202
[Token(Token = "0x20000CA")]
public class CoopPlayerUpgrades : EntityBehaviour<IPlayerState>
{
	// Token: 0x0600061E RID: 1566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061E")]
	[Address(RVA = "0x2E7AEC0", Offset = "0x2E79EC0", VA = "0x182E7AEC0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061F")]
	[Address(RVA = "0x2E7AF90", Offset = "0x2E79F90", VA = "0x182E7AF90")]
	private void OnWeaponUpgradesChanged()
	{
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000620")]
	[Address(RVA = "0x2E7B1B0", Offset = "0x2E7A1B0", VA = "0x182E7B1B0")]
	private void Start()
	{
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000621")]
	[Address(RVA = "0x2E7B210", Offset = "0x2E7A210", VA = "0x182E7B210")]
	private void Update()
	{
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000622")]
	[Address(RVA = "0x2E7B230", Offset = "0x2E7A230", VA = "0x182E7B230")]
	public CoopPlayerUpgrades()
	{
	}

	// Token: 0x04000550 RID: 1360
	[Token(Token = "0x4000550")]
	[FieldOffset(Offset = "0x28")]
	[Header("max 8 currently")]
	public CoopPlayerUpgrades.Item[] UpgradableItems;

	// Token: 0x04000551 RID: 1361
	[Token(Token = "0x4000551")]
	[FieldOffset(Offset = "0x30")]
	[Header("max 32 currently")]
	public CoopPlayerUpgrades.Upgrade[] Upgrades;

	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	[Serializable]
	public class Upgrade
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public Upgrade()
		{
		}

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker]
		public int upgradeId;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x18")]
		public string PlayerNetUpgradeObjectName;
	}

	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	[Serializable]
	public class Item
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public Item()
		{
		}

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker]
		public int itemId;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x18")]
		public GameObject PlayerNetObject;
	}
}
