using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
public class FreezeFire : MonoBehaviour
{
	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x5CAEA0", Offset = "0x5C94A0", VA = "0x1805CAEA0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x5CB100", Offset = "0x5C9700", VA = "0x1805CB100")]
	private void Update()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public FreezeFire()
	{
	}

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x20")]
	public bool _FreeFall;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x28")]
	private MaterialPropertyBlock _mpb;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x30")]
	private Transform _trans;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x38")]
	private Renderer _rend;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody _rigid;
}
