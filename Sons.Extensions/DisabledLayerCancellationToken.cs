using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public class DisabledLayerCancellationToken : ICancellationToken
{
	// Token: 0x0600000D RID: 13 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2FCA4C0", Offset = "0x2FC8AC0", VA = "0x182FCA4C0")]
	public DisabledLayerCancellationToken(Animator animator, int layer)
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x20A0A60", Offset = "0x209F060", VA = "0x1820A0A60", Slot = "5")]
	public void Start()
	{
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600000F RID: 15 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x17000005")]
	public bool Cancelled
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2FCA520", Offset = "0x2FC8B20", VA = "0x182FCA520", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x10")]
	private bool _cancelled;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x14")]
	private int _layer;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x18")]
	private Animator _animator;
}
