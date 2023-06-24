using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002DE RID: 734
[Token(Token = "0x20002DE")]
public class DemoEnemy : MonoBehaviour
{
	// Token: 0x06001347 RID: 4935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001347")]
	[Address(RVA = "0x31F28B0", Offset = "0x31F0EB0", VA = "0x1831F28B0")]
	private void Awake()
	{
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001348")]
	[Address(RVA = "0x31F2B00", Offset = "0x31F1100", VA = "0x1831F2B00")]
	private void OnHit(HitEffectList effects, Target target, Collider other)
	{
	}

	// Token: 0x06001349 RID: 4937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001349")]
	[Address(RVA = "0x31F3060", Offset = "0x31F1660", VA = "0x1831F3060")]
	private void MakeMeGreen(TargetTracker source)
	{
	}

	// Token: 0x0600134A RID: 4938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134A")]
	[Address(RVA = "0x31F3110", Offset = "0x31F1710", VA = "0x1831F3110")]
	private void ResetColor(TargetTracker source)
	{
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134B")]
	[Address(RVA = "0x31F31D0", Offset = "0x31F17D0", VA = "0x1831F31D0")]
	private void MakeMeBig(TargetTracker source)
	{
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134C")]
	[Address(RVA = "0x31F32B0", Offset = "0x31F18B0", VA = "0x1831F32B0")]
	private void MakeMeNormal(TargetTracker source)
	{
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134D")]
	[Address(RVA = "0x31F33A0", Offset = "0x31F19A0", VA = "0x1831F33A0")]
	public DemoEnemy()
	{
	}

	// Token: 0x04001328 RID: 4904
	[Token(Token = "0x4001328")]
	[FieldOffset(Offset = "0x20")]
	public int life;

	// Token: 0x04001329 RID: 4905
	[Token(Token = "0x4001329")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem explosion;

	// Token: 0x0400132A RID: 4906
	[Token(Token = "0x400132A")]
	[FieldOffset(Offset = "0x30")]
	private Color startingColor;

	// Token: 0x0400132B RID: 4907
	[Token(Token = "0x400132B")]
	[FieldOffset(Offset = "0x40")]
	private bool isDead;
}
