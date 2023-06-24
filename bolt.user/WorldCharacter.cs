using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200003D RID: 61
[Token(Token = "0x200003D")]
internal class WorldCharacter : NetworkState, IWorldCharacter, IState, IDisposable
{
	// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016F")]
	[Address(RVA = "0x7C3C10", Offset = "0x7C2210", VA = "0x1807C3C10")]
	public WorldCharacter()
	{
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000170 RID: 368 RVA: 0x00002880 File Offset: 0x00000A80
	// (set) Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A0")]
	public float CharacterScale
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x7C3C70", Offset = "0x7C2270", VA = "0x1807C3C70", Slot = "31")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x7C3CD0", Offset = "0x7C22D0", VA = "0x1807C3CD0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000172 RID: 370 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000A1")]
	public NetworkArray_Integer MecanimLayerHashes
	{
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x7C3DB0", Offset = "0x7C23B0", VA = "0x1807C3DB0", Slot = "33")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000173 RID: 371 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000A2")]
	public NetworkArray_Float MecanimLayerWeights
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x7C3E70", Offset = "0x7C2470", VA = "0x1807C3E70", Slot = "34")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000174 RID: 372 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000A3")]
	public NetworkArray_Float MecanimLayerTimes
	{
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x7C3F30", Offset = "0x7C2530", VA = "0x1807C3F30", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000175 RID: 373 RVA: 0x00002898 File Offset: 0x00000A98
	// (set) Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A4")]
	public float MecanimSpeed
	{
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x7C3FF0", Offset = "0x7C25F0", VA = "0x1807C3FF0", Slot = "36")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x7C4050", Offset = "0x7C2650", VA = "0x1807C4050", Slot = "37")]
		set
		{
		}
	}
}
