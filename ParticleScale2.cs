using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000220 RID: 544
[Token(Token = "0x2000220")]
[ExecuteInEditMode]
public class ParticleScale2 : MonoBehaviour
{
	// Token: 0x06000E41 RID: 3649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x2F9BCB0", Offset = "0x2F9ACB0", VA = "0x182F9BCB0")]
	private void Start()
	{
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x2F9C2B0", Offset = "0x2F9B2B0", VA = "0x182F9C2B0")]
	private void Update()
	{
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E43")]
	[Address(RVA = "0x2F9BB70", Offset = "0x2F9AB70", VA = "0x182F9BB70")]
	private void Scale(float scale)
	{
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E44")]
	[Address(RVA = "0x2F9C340", Offset = "0x2F9B340", VA = "0x182F9C340")]
	public ParticleScale2()
	{
	}

	// Token: 0x04000D50 RID: 3408
	[Token(Token = "0x4000D50")]
	[FieldOffset(Offset = "0x20")]
	private float _currentScale;

	// Token: 0x04000D51 RID: 3409
	[Token(Token = "0x4000D51")]
	[FieldOffset(Offset = "0x28")]
	private float[] _startSizes;

	// Token: 0x04000D52 RID: 3410
	[Token(Token = "0x4000D52")]
	[FieldOffset(Offset = "0x30")]
	private float[] _startSpeed;

	// Token: 0x04000D53 RID: 3411
	[Token(Token = "0x4000D53")]
	[FieldOffset(Offset = "0x38")]
	private float[] _startGravity;

	// Token: 0x04000D54 RID: 3412
	[Token(Token = "0x4000D54")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem[] _systems;

	// Token: 0x04000D55 RID: 3413
	[Token(Token = "0x4000D55")]
	[FieldOffset(Offset = "0x48")]
	public float ScaleOfParticles;

	// Token: 0x04000D56 RID: 3414
	[Token(Token = "0x4000D56")]
	[FieldOffset(Offset = "0x4C")]
	public bool AlsoScaleGameobject;
}
