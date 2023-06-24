using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200007C RID: 124
[Token(Token = "0x200007C")]
internal class BreakableObjectState : NetworkState, IBreakableObjectState, IRigidbodyState, IState, IDisposable
{
	// Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x80BC10", Offset = "0x80A210", VA = "0x18080BC10")]
	public BreakableObjectState()
	{
	}

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x0600040E RID: 1038 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700020D")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "33")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x0600040F RID: 1039 RVA: 0x00003630 File Offset: 0x00001830
	// (set) Token: 0x06000410 RID: 1040 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700020E")]
	public bool IsBroken
	{
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x7BB410", Offset = "0x7B9A10", VA = "0x1807BB410", Slot = "32")]
		set
		{
		}
	}
}
