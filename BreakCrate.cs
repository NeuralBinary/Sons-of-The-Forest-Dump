using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D3 RID: 467
[Token(Token = "0x20001D3")]
public class BreakCrate : EntityBehaviour
{
	// Token: 0x06000D23 RID: 3363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D23")]
	[Address(RVA = "0x2F7E910", Offset = "0x2F7D910", VA = "0x182F7E910")]
	private void Hit(int damage)
	{
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D24")]
	[Address(RVA = "0x2F7E830", Offset = "0x2F7D830", VA = "0x182F7E830")]
	private void Explosion()
	{
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D25")]
	[Address(RVA = "0x2F7E580", Offset = "0x2F7D580", VA = "0x182F7E580", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D26")]
	[Address(RVA = "0x2F7E640", Offset = "0x2F7D640", VA = "0x182F7E640")]
	private void ExplosionReal()
	{
	}

	// Token: 0x06000D27 RID: 3367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D27")]
	[Address(RVA = "0x2F7EA00", Offset = "0x2F7DA00", VA = "0x182F7EA00")]
	public BreakCrate()
	{
	}

	// Token: 0x04000C1B RID: 3099
	[Token(Token = "0x4000C1B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Broken;

	// Token: 0x04000C1C RID: 3100
	[Token(Token = "0x4000C1C")]
	[FieldOffset(Offset = "0x30")]
	public int health;

	// Token: 0x04000C1D RID: 3101
	[Token(Token = "0x4000C1D")]
	[FieldOffset(Offset = "0x38")]
	[Header("FMOD")]
	public string breakEvent;
}
