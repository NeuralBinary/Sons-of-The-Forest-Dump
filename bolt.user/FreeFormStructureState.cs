using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000070 RID: 112
[Token(Token = "0x2000070")]
internal class FreeFormStructureState : NetworkState, IFreeFormStructureState, IState, IDisposable
{
	// Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x808F90", Offset = "0x807590", VA = "0x180808F90")]
	public FreeFormStructureState()
	{
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x060003B6 RID: 950 RVA: 0x00003468 File Offset: 0x00001668
	// (set) Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001E6")]
	public int TypeID
	{
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360", Slot = "31")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x808FF0", Offset = "0x8075F0", VA = "0x180808FF0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x060003B8 RID: 952 RVA: 0x00003480 File Offset: 0x00001680
	// (set) Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001E7")]
	public int InstanceID
	{
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50", Slot = "33")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x7B4BB0", Offset = "0x7B31B0", VA = "0x1807B4BB0", Slot = "34")]
		set
		{
		}
	}
}
