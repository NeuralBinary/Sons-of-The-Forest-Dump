using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000035 RID: 53
[Token(Token = "0x2000035")]
public class SpawnEffect : MonoBehaviour
{
	// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x5E08B0", Offset = "0x5DEEB0", VA = "0x1805E08B0")]
	private void Start()
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x5E0B20", Offset = "0x5DF120", VA = "0x1805E0B20")]
	private void Update()
	{
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x5E0D50", Offset = "0x5DF350", VA = "0x1805E0D50")]
	public SpawnEffect()
	{
	}

	// Token: 0x04000197 RID: 407
	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x20")]
	public float spawnEffectTime;

	// Token: 0x04000198 RID: 408
	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x24")]
	public float pause;

	// Token: 0x04000199 RID: 409
	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve fadeIn;

	// Token: 0x0400019A RID: 410
	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem ps;

	// Token: 0x0400019B RID: 411
	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x38")]
	private float timer;

	// Token: 0x0400019C RID: 412
	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x40")]
	private Renderer _renderer;

	// Token: 0x0400019D RID: 413
	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x48")]
	private int shaderProperty;
}
