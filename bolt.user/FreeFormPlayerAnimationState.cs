using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000094 RID: 148
[Token(Token = "0x2000094")]
internal class FreeFormPlayerAnimationState : NetworkState, IFreeFormPlayerAnimationState, IState, IDisposable
{
	// Token: 0x0600067C RID: 1660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600067C")]
	[Address(RVA = "0x823C80", Offset = "0x822280", VA = "0x180823C80")]
	public FreeFormPlayerAnimationState()
	{
	}

	// Token: 0x170003A3 RID: 931
	// (get) Token: 0x0600067D RID: 1661 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600067E RID: 1662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003A3")]
	public BoltEntity TargetPlayer
	{
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0", Slot = "31")]
		get
		{
			return null;
		}
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x823CE0", Offset = "0x8222E0", VA = "0x180823CE0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x170003A4 RID: 932
	// (get) Token: 0x0600067F RID: 1663 RVA: 0x00004728 File Offset: 0x00002928
	// (set) Token: 0x06000680 RID: 1664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003A4")]
	public int LeftHandAccessory
	{
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50", Slot = "33")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x823F30", Offset = "0x822530", VA = "0x180823F30", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x170003A5 RID: 933
	// (get) Token: 0x06000681 RID: 1665 RVA: 0x00004740 File Offset: 0x00002940
	// (set) Token: 0x06000682 RID: 1666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003A5")]
	public int RightHandAccessory
	{
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0", Slot = "35")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x824020", Offset = "0x822620", VA = "0x180824020", Slot = "36")]
		set
		{
		}
	}
}
