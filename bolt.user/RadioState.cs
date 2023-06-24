using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200009D RID: 157
[Token(Token = "0x200009D")]
internal class RadioState : NetworkState, IRadioState, IRigidbodyState, IState, IDisposable
{
	// Token: 0x060006B8 RID: 1720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x8266F0", Offset = "0x824CF0", VA = "0x1808266F0")]
	public RadioState()
	{
	}

	// Token: 0x170003BF RID: 959
	// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003BF")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "39")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003C0 RID: 960
	// (get) Token: 0x060006BA RID: 1722 RVA: 0x00004818 File Offset: 0x00002A18
	// (set) Token: 0x060006BB RID: 1723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003C0")]
	public bool OnOff
	{
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x7BB410", Offset = "0x7B9A10", VA = "0x1807BB410", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x170003C1 RID: 961
	// (get) Token: 0x060006BC RID: 1724 RVA: 0x00004830 File Offset: 0x00002A30
	// (set) Token: 0x060006BD RID: 1725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003C1")]
	public int RandomHash
	{
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500", Slot = "33")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x7BB560", Offset = "0x7B9B60", VA = "0x1807BB560", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x170003C2 RID: 962
	// (get) Token: 0x060006BE RID: 1726 RVA: 0x00004848 File Offset: 0x00002A48
	// (set) Token: 0x060006BF RID: 1727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003C2")]
	public bool Broken
	{
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x826750", Offset = "0x824D50", VA = "0x180826750", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x8267B0", Offset = "0x824DB0", VA = "0x1808267B0", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x170003C3 RID: 963
	// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00004860 File Offset: 0x00002A60
	// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003C3")]
	public int TrackHash
	{
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x8268A0", Offset = "0x824EA0", VA = "0x1808268A0", Slot = "37")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x826900", Offset = "0x824F00", VA = "0x180826900", Slot = "38")]
		set
		{
		}
	}
}
