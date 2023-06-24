using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000A6 RID: 166
[Token(Token = "0x20000A6")]
internal class GameModeState : NetworkState, IGameModeState, IState, IDisposable
{
	// Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x82BFF0", Offset = "0x82A5F0", VA = "0x18082BFF0")]
	public GameModeState()
	{
	}

	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x06000736 RID: 1846 RVA: 0x00004BC0 File Offset: 0x00002DC0
	// (set) Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003FE")]
	public int Game
	{
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360", Slot = "31")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x7C1F60", Offset = "0x7C0560", VA = "0x1807C1F60", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x170003FF RID: 1023
	// (get) Token: 0x06000738 RID: 1848 RVA: 0x00004BD8 File Offset: 0x00002DD8
	// (set) Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003FF")]
	public float Timer
	{
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0", Slot = "33")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x7B7940", Offset = "0x7B5F40", VA = "0x1807B7940", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x17000400 RID: 1024
	// (get) Token: 0x0600073A RID: 1850 RVA: 0x00004BF0 File Offset: 0x00002DF0
	// (set) Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000400")]
	public int Phase
	{
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0", Slot = "35")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x7C2050", Offset = "0x7C0650", VA = "0x1807C2050", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x17000401 RID: 1025
	// (get) Token: 0x0600073C RID: 1852 RVA: 0x00004C08 File Offset: 0x00002E08
	// (set) Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000401")]
	public float NewProperty
	{
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x7C2150", Offset = "0x7C0750", VA = "0x1807C2150", Slot = "37")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x7C21B0", Offset = "0x7C07B0", VA = "0x1807C21B0", Slot = "38")]
		set
		{
		}
	}
}
