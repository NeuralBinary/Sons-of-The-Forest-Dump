using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200006D RID: 109
[Token(Token = "0x200006D")]
internal class LogState : NetworkState, ILogState, ILogPickup, IState, IDisposable
{
	// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x8085A0", Offset = "0x806BA0", VA = "0x1808085A0")]
	public LogState()
	{
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x060003A6 RID: 934 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001DF")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "33")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x060003A7 RID: 935 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001E0")]
	public BoltEntity FromTree
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x7BEA80", Offset = "0x7BD080", VA = "0x1807BEA80", Slot = "31")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x808600", Offset = "0x806C00", VA = "0x180808600", Slot = "32")]
		set
		{
		}
	}
}
