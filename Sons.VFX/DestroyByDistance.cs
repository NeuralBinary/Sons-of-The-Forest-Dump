using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
public class DestroyByDistance : MonoBehaviour
{
	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x31620B0", Offset = "0x31606B0", VA = "0x1831620B0")]
	private void Update()
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x3162130", Offset = "0x3160730", VA = "0x183162130")]
	private void OnEnable()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3162330", Offset = "0x3160930", VA = "0x183162330")]
	private void OnValidate()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x3162630", Offset = "0x3160C30", VA = "0x183162630")]
	private void CheckForDestroy()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x3162990", Offset = "0x3160F90", VA = "0x183162990")]
	public DestroyByDistance()
	{
	}

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _invert;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _testDelay;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _destoryBeyondDistance;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Transform> _transforms;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x38")]
	private float _age;
}
