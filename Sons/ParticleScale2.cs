using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200021F RID: 543
[Token(Token = "0x200021F")]
[ExecuteInEditMode]
public class ParticleScale2 : MonoBehaviour
{
	// Token: 0x06000E9C RID: 3740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0x371A8A0", Offset = "0x3718EA0", VA = "0x18371A8A0")]
	private void Start()
	{
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x371B4D0", Offset = "0x3719AD0", VA = "0x18371B4D0")]
	private void Update()
	{
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0x371B5E0", Offset = "0x3719BE0", VA = "0x18371B5E0")]
	private void Scale(float scale)
	{
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0x371B940", Offset = "0x3719F40", VA = "0x18371B940")]
	public ParticleScale2()
	{
	}

	// Token: 0x04000D7F RID: 3455
	[Token(Token = "0x4000D7F")]
	[FieldOffset(Offset = "0x20")]
	private float _currentScale;

	// Token: 0x04000D80 RID: 3456
	[Token(Token = "0x4000D80")]
	[FieldOffset(Offset = "0x28")]
	private float[] _startSizes;

	// Token: 0x04000D81 RID: 3457
	[Token(Token = "0x4000D81")]
	[FieldOffset(Offset = "0x30")]
	private float[] _startSpeed;

	// Token: 0x04000D82 RID: 3458
	[Token(Token = "0x4000D82")]
	[FieldOffset(Offset = "0x38")]
	private float[] _startGravity;

	// Token: 0x04000D83 RID: 3459
	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem[] _systems;

	// Token: 0x04000D84 RID: 3460
	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0x48")]
	public float ScaleOfParticles;

	// Token: 0x04000D85 RID: 3461
	[Token(Token = "0x4000D85")]
	[FieldOffset(Offset = "0x4C")]
	public bool AlsoScaleGameobject;
}
