using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000085 RID: 133
[Token(Token = "0x2000085")]
internal class WeaponUpgradeProxyState : NetworkState, IWeaponUpgradeProxyState, IState, IDisposable
{
	// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046B")]
	[Address(RVA = "0x80EC70", Offset = "0x80D270", VA = "0x18080EC70")]
	public WeaponUpgradeProxyState()
	{
	}

	// Token: 0x1700023A RID: 570
	// (get) Token: 0x0600046C RID: 1132 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700023A")]
	public BoltEntity TargetPlayer
	{
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0", Slot = "31")]
		get
		{
			return null;
		}
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x80ECD0", Offset = "0x80D2D0", VA = "0x18080ECD0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x1700023B RID: 571
	// (get) Token: 0x0600046E RID: 1134 RVA: 0x000037F8 File Offset: 0x000019F8
	// (set) Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700023B")]
	public int ItemId
	{
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50", Slot = "33")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x7B4BB0", Offset = "0x7B31B0", VA = "0x1807B4BB0", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x1700023C RID: 572
	// (get) Token: 0x06000470 RID: 1136 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700023C")]
	public IProtocolToken Token
	{
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x80EF20", Offset = "0x80D520", VA = "0x18080EF20", Slot = "35")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x80EFD0", Offset = "0x80D5D0", VA = "0x18080EFD0", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x1700023D RID: 573
	// (get) Token: 0x06000472 RID: 1138 RVA: 0x00003810 File Offset: 0x00001A10
	// (set) Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700023D")]
	public bool Cloth
	{
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x809B50", Offset = "0x808150", VA = "0x180809B50", Slot = "38")]
		set
		{
		}
	}

	// Token: 0x1700023E RID: 574
	// (get) Token: 0x06000474 RID: 1140 RVA: 0x00003828 File Offset: 0x00001A28
	// (set) Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700023E")]
	public int Color
	{
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500", Slot = "39")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x80F180", Offset = "0x80D780", VA = "0x18080F180", Slot = "40")]
		set
		{
		}
	}

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x06000476 RID: 1142 RVA: 0x00003840 File Offset: 0x00001A40
	// (set) Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700023F")]
	public int AltRenderer
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x7E1E00", Offset = "0x7E0400", VA = "0x1807E1E00", Slot = "41")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x80F280", Offset = "0x80D880", VA = "0x18080F280", Slot = "42")]
		set
		{
		}
	}
}
