using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000206 RID: 518
[Token(Token = "0x2000206")]
public class Bomb : EntityBehaviour<IRigidbodyState>
{
	// Token: 0x06000E49 RID: 3657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E49")]
	[Address(RVA = "0x3716A00", Offset = "0x3715000", VA = "0x183716A00", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0x3716CA0", Offset = "0x37152A0", VA = "0x183716CA0")]
	private void Start()
	{
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0x3716E20", Offset = "0x3715420", VA = "0x183716E20")]
	private void Explode()
	{
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
	private void setWaitTime(int w)
	{
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0x3717410", Offset = "0x3715A10", VA = "0x183717410")]
	public Bomb()
	{
	}

	// Token: 0x04000D40 RID: 3392
	[Token(Token = "0x4000D40")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Explosion;

	// Token: 0x04000D41 RID: 3393
	[Token(Token = "0x4000D41")]
	[FieldOffset(Offset = "0x30")]
	public int WaitTime;

	// Token: 0x04000D42 RID: 3394
	[Token(Token = "0x4000D42")]
	[FieldOffset(Offset = "0x34")]
	public bool SkipAttach;

	// Token: 0x04000D43 RID: 3395
	[Token(Token = "0x4000D43")]
	[FieldOffset(Offset = "0x35")]
	public bool SkipDestroyIfNotOwner;

	// Token: 0x04000D44 RID: 3396
	[Token(Token = "0x4000D44")]
	[FieldOffset(Offset = "0x38")]
	public GameObject DestroyTarget;
}
