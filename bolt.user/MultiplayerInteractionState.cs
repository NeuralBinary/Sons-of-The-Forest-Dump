using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000046 RID: 70
[Token(Token = "0x2000046")]
internal class MultiplayerInteractionState : NetworkState, IMultiplayerInteractionState, IState, IDisposable
{
	// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x7D2740", Offset = "0x7D0D40", VA = "0x1807D2740")]
	public MultiplayerInteractionState()
	{
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x060002BC RID: 700 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016F")]
	public string InteractionId
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x7D27A0", Offset = "0x7D0DA0", VA = "0x1807D27A0", Slot = "31")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x7D2830", Offset = "0x7D0E30", VA = "0x1807D2830", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x060002BE RID: 702 RVA: 0x00003000 File Offset: 0x00001200
	// (set) Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000170")]
	public bool Ready
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x7B5490", Offset = "0x7B3A90", VA = "0x1807B5490", Slot = "33")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x7B54F0", Offset = "0x7B3AF0", VA = "0x1807B54F0", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x060002C0 RID: 704 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000171")]
	public NetworkArray_Objects<NetworkConnectionId> ActivePlayers
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x7D29B0", Offset = "0x7D0FB0", VA = "0x1807D29B0", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x060002C1 RID: 705 RVA: 0x00003018 File Offset: 0x00001218
	// (set) Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000172")]
	public int LastPerformed
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x7D2A70", Offset = "0x7D1070", VA = "0x1807D2A70", Slot = "36")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x7D2AD0", Offset = "0x7D10D0", VA = "0x1807D2AD0", Slot = "37")]
		set
		{
		}
	}
}
