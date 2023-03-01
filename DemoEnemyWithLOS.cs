using System;
using System.Collections;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002EB RID: 747
[Token(Token = "0x20002EB")]
public class DemoEnemyWithLOS : MonoBehaviour
{
	// Token: 0x06001318 RID: 4888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001318")]
	[Address(RVA = "0x2C62160", Offset = "0x2C61160", VA = "0x182C62160")]
	private void Awake()
	{
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001319")]
	[Address(RVA = "0x2C62380", Offset = "0x2C61380", VA = "0x182C62380")]
	private void OnHit(HitEffectList effects, Target target, Collider other)
	{
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131A")]
	[Address(RVA = "0x2C622F0", Offset = "0x2C612F0", VA = "0x182C622F0")]
	private void OnDetected(TargetTracker source)
	{
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131B")]
	[Address(RVA = "0x2C62690", Offset = "0x2C61690", VA = "0x182C62690")]
	private void OnNotDetected(TargetTracker source)
	{
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131C")]
	[Address(RVA = "0x2C626B0", Offset = "0x2C616B0", VA = "0x182C626B0")]
	private void ResetStates()
	{
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600131D")]
	[Address(RVA = "0x2C62790", Offset = "0x2C61790", VA = "0x182C62790")]
	private IEnumerator UpdateStartWhileDetected(TargetTracker source)
	{
		return null;
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131E")]
	[Address(RVA = "0x2C62820", Offset = "0x2C61820", VA = "0x182C62820")]
	public DemoEnemyWithLOS()
	{
	}

	// Token: 0x04001304 RID: 4868
	[Token(Token = "0x4001304")]
	[FieldOffset(Offset = "0x20")]
	public int life;

	// Token: 0x04001305 RID: 4869
	[Token(Token = "0x4001305")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem explosion;

	// Token: 0x04001306 RID: 4870
	[Token(Token = "0x4001306")]
	[FieldOffset(Offset = "0x30")]
	private Color startingColor;

	// Token: 0x04001307 RID: 4871
	[Token(Token = "0x4001307")]
	[FieldOffset(Offset = "0x40")]
	private bool isDead;
}
