using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000207 RID: 519
[Token(Token = "0x2000207")]
public class Bomb : EntityBehaviour<IRigidbodyState>
{
	// Token: 0x06000DEE RID: 3566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x2F7DEF0", Offset = "0x2F7CEF0", VA = "0x182F7DEF0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0x2F7E430", Offset = "0x2F7D430", VA = "0x182F7E430")]
	private void Start()
	{
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x2F7E0D0", Offset = "0x2F7D0D0", VA = "0x182F7E0D0")]
	private void Explode()
	{
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x5CEF80", Offset = "0x5CDF80", VA = "0x1805CEF80")]
	private void setWaitTime(int w)
	{
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0x2F7E540", Offset = "0x2F7D540", VA = "0x182F7E540")]
	public Bomb()
	{
	}

	// Token: 0x04000D11 RID: 3345
	[Token(Token = "0x4000D11")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Explosion;

	// Token: 0x04000D12 RID: 3346
	[Token(Token = "0x4000D12")]
	[FieldOffset(Offset = "0x30")]
	public int WaitTime;

	// Token: 0x04000D13 RID: 3347
	[Token(Token = "0x4000D13")]
	[FieldOffset(Offset = "0x34")]
	public bool SkipAttach;

	// Token: 0x04000D14 RID: 3348
	[Token(Token = "0x4000D14")]
	[FieldOffset(Offset = "0x35")]
	public bool SkipDestroyIfNotOwner;

	// Token: 0x04000D15 RID: 3349
	[Token(Token = "0x4000D15")]
	[FieldOffset(Offset = "0x38")]
	public GameObject DestroyTarget;
}
