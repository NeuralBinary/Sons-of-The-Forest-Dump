using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200002E RID: 46
[Token(Token = "0x200002E")]
internal class VailWorldState : NetworkState, IVailWorldState, IState, IDisposable
{
	// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x7BE420", Offset = "0x7BCA20", VA = "0x1807BE420")]
	public VailWorldState()
	{
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060000F2 RID: 242 RVA: 0x000025F8 File Offset: 0x000007F8
	// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000062")]
	public int OpenCaveMask
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360", Slot = "31")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x7B53B0", Offset = "0x7B39B0", VA = "0x1807B53B0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002610 File Offset: 0x00000810
	// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000063")]
	public int WorldFlags
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50", Slot = "33")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x7B4BB0", Offset = "0x7B31B0", VA = "0x1807B4BB0", Slot = "34")]
		set
		{
		}
	}
}
