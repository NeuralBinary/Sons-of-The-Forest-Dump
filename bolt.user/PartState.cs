using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000067 RID: 103
[Token(Token = "0x2000067")]
internal class PartState : NetworkState, IPartState, IState, IDisposable
{
	// Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000386")]
	[Address(RVA = "0x8072E0", Offset = "0x8058E0", VA = "0x1808072E0")]
	public PartState()
	{
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06000387 RID: 903 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001D2")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "31")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06000388 RID: 904 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001D3")]
	public BoltEntity Effigy
	{
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x7BEA80", Offset = "0x7BD080", VA = "0x1807BEA80", Slot = "32")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x807340", Offset = "0x805940", VA = "0x180807340", Slot = "33")]
		set
		{
		}
	}
}
