using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D2 RID: 466
[Token(Token = "0x20001D2")]
public class BreakCrate : EntityBehaviour
{
	// Token: 0x06000D7E RID: 3454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x3701F10", Offset = "0x3700510", VA = "0x183701F10")]
	private void Hit(int damage)
	{
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0x3701F30", Offset = "0x3700530", VA = "0x183701F30")]
	private void Explosion()
	{
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x3702130", Offset = "0x3700730", VA = "0x183702130", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D81")]
	[Address(RVA = "0x3702220", Offset = "0x3700820", VA = "0x183702220")]
	private void ExplosionReal()
	{
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D82")]
	[Address(RVA = "0x3702560", Offset = "0x3700B60", VA = "0x183702560")]
	public BreakCrate()
	{
	}

	// Token: 0x04000C4A RID: 3146
	[Token(Token = "0x4000C4A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Broken;

	// Token: 0x04000C4B RID: 3147
	[Token(Token = "0x4000C4B")]
	[FieldOffset(Offset = "0x30")]
	public int health;

	// Token: 0x04000C4C RID: 3148
	[Token(Token = "0x4000C4C")]
	[FieldOffset(Offset = "0x38")]
	[Header("FMOD")]
	public string breakEvent;
}
