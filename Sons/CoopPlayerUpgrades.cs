using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x020000C8 RID: 200
[Token(Token = "0x20000C8")]
public class CoopPlayerUpgrades : EntityBehaviour<IPlayerState>
{
	// Token: 0x06000656 RID: 1622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000656")]
	[Address(RVA = "0x35181A0", Offset = "0x35167A0", VA = "0x1835181A0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000657")]
	[Address(RVA = "0x3518290", Offset = "0x3516890", VA = "0x183518290")]
	private void OnWeaponUpgradesChanged()
	{
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000658")]
	[Address(RVA = "0x3518530", Offset = "0x3516B30", VA = "0x183518530")]
	private void Start()
	{
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000659")]
	[Address(RVA = "0x35185D0", Offset = "0x3516BD0", VA = "0x1835185D0")]
	private void Update()
	{
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065A")]
	[Address(RVA = "0x35185F0", Offset = "0x3516BF0", VA = "0x1835185F0")]
	public CoopPlayerUpgrades()
	{
	}

	// Token: 0x0400056A RID: 1386
	[Token(Token = "0x400056A")]
	[FieldOffset(Offset = "0x28")]
	[Header("max 8 currently")]
	public CoopPlayerUpgrades.Item[] UpgradableItems;

	// Token: 0x0400056B RID: 1387
	[Token(Token = "0x400056B")]
	[FieldOffset(Offset = "0x30")]
	[Header("max 32 currently")]
	public CoopPlayerUpgrades.Upgrade[] Upgrades;

	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	[Serializable]
	public class Upgrade
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Upgrade()
		{
		}

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker]
		public int upgradeId;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x18")]
		public string PlayerNetUpgradeObjectName;
	}

	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	[Serializable]
	public class Item
	{
		// Token: 0x0600065C RID: 1628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Item()
		{
		}

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x10")]
		[ItemIdPicker]
		public int itemId;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x18")]
		public GameObject PlayerNetObject;
	}
}
