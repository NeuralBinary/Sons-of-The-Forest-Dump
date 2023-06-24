using System;
using System.Collections;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002DF RID: 735
[Token(Token = "0x20002DF")]
public class DemoEnemyWithLOS : MonoBehaviour
{
	// Token: 0x0600134E RID: 4942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134E")]
	[Address(RVA = "0x31F33F0", Offset = "0x31F19F0", VA = "0x1831F33F0")]
	private void Awake()
	{
	}

	// Token: 0x0600134F RID: 4943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134F")]
	[Address(RVA = "0x31F35C0", Offset = "0x31F1BC0", VA = "0x1831F35C0")]
	private void OnHit(HitEffectList effects, Target target, Collider other)
	{
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001350")]
	[Address(RVA = "0x31F3B20", Offset = "0x31F2120", VA = "0x1831F3B20")]
	private void OnDetected(TargetTracker source)
	{
	}

	// Token: 0x06001351 RID: 4945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001351")]
	[Address(RVA = "0x31F3C30", Offset = "0x31F2230", VA = "0x1831F3C30")]
	private void OnNotDetected(TargetTracker source)
	{
	}

	// Token: 0x06001352 RID: 4946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001352")]
	[Address(RVA = "0x31F3C90", Offset = "0x31F2290", VA = "0x1831F3C90")]
	private void ResetStates()
	{
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001353")]
	[Address(RVA = "0x31F3E20", Offset = "0x31F2420", VA = "0x1831F3E20")]
	private IEnumerator UpdateStartWhileDetected(TargetTracker source)
	{
		return null;
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001354")]
	[Address(RVA = "0x31F33A0", Offset = "0x31F19A0", VA = "0x1831F33A0")]
	public DemoEnemyWithLOS()
	{
	}

	// Token: 0x0400132C RID: 4908
	[Token(Token = "0x400132C")]
	[FieldOffset(Offset = "0x20")]
	public int life;

	// Token: 0x0400132D RID: 4909
	[Token(Token = "0x400132D")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem explosion;

	// Token: 0x0400132E RID: 4910
	[Token(Token = "0x400132E")]
	[FieldOffset(Offset = "0x30")]
	private Color startingColor;

	// Token: 0x0400132F RID: 4911
	[Token(Token = "0x400132F")]
	[FieldOffset(Offset = "0x40")]
	private bool isDead;
}
