using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200003A RID: 58
[Token(Token = "0x200003A")]
internal class Elevator : NetworkState, IElevator, IState, IDisposable
{
	// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x7C2D50", Offset = "0x7C1350", VA = "0x1807C2D50")]
	public Elevator()
	{
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000156 RID: 342 RVA: 0x000027F0 File Offset: 0x000009F0
	// (set) Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000093")]
	public bool Locked
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x7B4A70", Offset = "0x7B3070", VA = "0x1807B4A70", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000158 RID: 344 RVA: 0x00002808 File Offset: 0x00000A08
	// (set) Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000094")]
	public int Door
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x7B4B50", Offset = "0x7B3150", VA = "0x1807B4B50", Slot = "33")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x7C2DB0", Offset = "0x7C13B0", VA = "0x1807C2DB0", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x0600015A RID: 346 RVA: 0x00002820 File Offset: 0x00000A20
	// (set) Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000095")]
	public int Location
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0", Slot = "35")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x7C2EB0", Offset = "0x7C14B0", VA = "0x1807C2EB0", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x0600015C RID: 348 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000096")]
	public string SpawnId
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x7C2FB0", Offset = "0x7C15B0", VA = "0x1807C2FB0", Slot = "37")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x7C3050", Offset = "0x7C1650", VA = "0x1807C3050", Slot = "38")]
		set
		{
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x0600015E RID: 350 RVA: 0x00002838 File Offset: 0x00000A38
	// (set) Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000097")]
	public int PlayerCount
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500", Slot = "39")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x7C31E0", Offset = "0x7C17E0", VA = "0x1807C31E0", Slot = "40")]
		set
		{
		}
	}
}
