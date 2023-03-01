using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002EA RID: 746
[Token(Token = "0x20002EA")]
public class DemoEnemy : MonoBehaviour
{
	// Token: 0x06001311 RID: 4881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001311")]
	[Address(RVA = "0x2C62830", Offset = "0x2C61830", VA = "0x182C62830")]
	private void Awake()
	{
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001312")]
	[Address(RVA = "0x2C62BA0", Offset = "0x2C61BA0", VA = "0x182C62BA0")]
	private void OnHit(HitEffectList effects, Target target, Collider other)
	{
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001313")]
	[Address(RVA = "0x2C62AA0", Offset = "0x2C61AA0", VA = "0x182C62AA0")]
	private void MakeMeGreen(TargetTracker source)
	{
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001314")]
	[Address(RVA = "0x2C62EB0", Offset = "0x2C61EB0", VA = "0x182C62EB0")]
	private void ResetColor(TargetTracker source)
	{
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001315")]
	[Address(RVA = "0x2C62A40", Offset = "0x2C61A40", VA = "0x182C62A40")]
	private void MakeMeBig(TargetTracker source)
	{
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001316")]
	[Address(RVA = "0x2C62B20", Offset = "0x2C61B20", VA = "0x182C62B20")]
	private void MakeMeNormal(TargetTracker source)
	{
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001317")]
	[Address(RVA = "0x2C62820", Offset = "0x2C61820", VA = "0x182C62820")]
	public DemoEnemy()
	{
	}

	// Token: 0x04001300 RID: 4864
	[Token(Token = "0x4001300")]
	[FieldOffset(Offset = "0x20")]
	public int life;

	// Token: 0x04001301 RID: 4865
	[Token(Token = "0x4001301")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem explosion;

	// Token: 0x04001302 RID: 4866
	[Token(Token = "0x4001302")]
	[FieldOffset(Offset = "0x30")]
	private Color startingColor;

	// Token: 0x04001303 RID: 4867
	[Token(Token = "0x4001303")]
	[FieldOffset(Offset = "0x40")]
	private bool isDead;
}
