using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000076 RID: 118
[Token(Token = "0x2000076")]
internal class AnimationSequenceState : NetworkState, IAnimationSequenceState, IState, IDisposable
{
	// Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x80A640", Offset = "0x808C40", VA = "0x18080A640")]
	public AnimationSequenceState()
	{
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x060003EA RID: 1002 RVA: 0x00003558 File Offset: 0x00001758
	// (set) Token: 0x060003EB RID: 1003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001FD")]
	public int Stage
	{
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x7B5360", Offset = "0x7B3960", VA = "0x1807B5360", Slot = "31")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x808FF0", Offset = "0x8075F0", VA = "0x180808FF0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x060003EC RID: 1004 RVA: 0x00003570 File Offset: 0x00001770
	// (set) Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001FE")]
	public float StartTime
	{
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0", Slot = "33")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x7B7940", Offset = "0x7B5F40", VA = "0x1807B7940", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x060003EE RID: 1006 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001FF")]
	public BoltEntity Actor
	{
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x80A6A0", Offset = "0x808CA0", VA = "0x18080A6A0", Slot = "35")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x80A740", Offset = "0x808D40", VA = "0x18080A740", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00003588 File Offset: 0x00001788
	// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000200")]
	public int Progress
	{
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40", Slot = "37")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x7B6BA0", Offset = "0x7B51A0", VA = "0x1807B6BA0", Slot = "38")]
		set
		{
		}
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000035A0 File Offset: 0x000017A0
	// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000201")]
	public bool Completed
	{
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x7BBF10", Offset = "0x7BA510", VA = "0x1807BBF10", Slot = "39")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x809C40", Offset = "0x808240", VA = "0x180809C40", Slot = "40")]
		set
		{
		}
	}
}
