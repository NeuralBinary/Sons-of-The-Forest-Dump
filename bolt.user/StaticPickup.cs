using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200005E RID: 94
[Token(Token = "0x200005E")]
internal class StaticPickup : NetworkState, IStaticPickup, IState, IDisposable
{
	// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x804F20", Offset = "0x803520", VA = "0x180804F20")]
	public StaticPickup()
	{
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06000352 RID: 850 RVA: 0x000032E8 File Offset: 0x000014E8
	// (set) Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001B7")]
	public bool burning
	{
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x7B4A70", Offset = "0x7B3070", VA = "0x1807B4A70", Slot = "32")]
		set
		{
		}
	}
}
