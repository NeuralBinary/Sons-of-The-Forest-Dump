using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000049 RID: 73
[Token(Token = "0x2000049")]
internal class CaveBoardsState : NetworkState, ICaveBoardsState, IState, IDisposable
{
	// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x7D3650", Offset = "0x7D1C50", VA = "0x1807D3650")]
	public CaveBoardsState()
	{
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x060002D0 RID: 720 RVA: 0x00003060 File Offset: 0x00001260
	// (set) Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000178")]
	public int BoardMask
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360", Slot = "31")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x7B53B0", Offset = "0x7B39B0", VA = "0x1807B53B0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x060002D2 RID: 722 RVA: 0x00003078 File Offset: 0x00001278
	// (set) Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000179")]
	public int AreaMask
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50", Slot = "33")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x7B4BB0", Offset = "0x7B31B0", VA = "0x1807B4BB0", Slot = "34")]
		set
		{
		}
	}
}
