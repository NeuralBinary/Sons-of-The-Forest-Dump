using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000037 RID: 55
[Token(Token = "0x2000037")]
internal class GameModeState_Mod : NetworkState, IGameModeState_Mod, IGameModeState, IState, IDisposable
{
	// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000138")]
	[Address(RVA = "0x7C1F00", Offset = "0x7C0500", VA = "0x1807C1F00")]
	public GameModeState_Mod()
	{
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000139 RID: 313 RVA: 0x00002748 File Offset: 0x00000948
	// (set) Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000086")]
	public int Game
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360", Slot = "33")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x7C1F60", Offset = "0x7C0560", VA = "0x1807C1F60", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x0600013B RID: 315 RVA: 0x00002760 File Offset: 0x00000960
	// (set) Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000087")]
	public float Timer
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0", Slot = "35")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x7B7940", Offset = "0x7B5F40", VA = "0x1807B7940", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x0600013D RID: 317 RVA: 0x00002778 File Offset: 0x00000978
	// (set) Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000088")]
	public int Phase
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x7B97E0", Offset = "0x7B7DE0", VA = "0x1807B97E0", Slot = "37")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x7C2050", Offset = "0x7C0650", VA = "0x1807C2050", Slot = "38")]
		set
		{
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x0600013F RID: 319 RVA: 0x00002790 File Offset: 0x00000990
	// (set) Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000089")]
	public float NewProperty
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x7C2150", Offset = "0x7C0750", VA = "0x1807C2150", Slot = "39")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x7C21B0", Offset = "0x7C07B0", VA = "0x1807C21B0", Slot = "40")]
		set
		{
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x06000141 RID: 321 RVA: 0x000027A8 File Offset: 0x000009A8
	// (set) Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700008A")]
	public Guid ModId
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x7C22A0", Offset = "0x7C08A0", VA = "0x1807C22A0", Slot = "31")]
		get
		{
			return default(Guid);
		}
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x7C2310", Offset = "0x7C0910", VA = "0x1807C2310", Slot = "32")]
		set
		{
		}
	}
}
