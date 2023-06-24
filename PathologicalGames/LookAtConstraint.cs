using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
[AddComponentMenu("Path-o-logical/UnityConstraints/Constraint - Look At")]
public class LookAtConstraint : LookAtBaseClass
{
	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000074 RID: 116 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x1700001D")]
	protected virtual Vector3 lookVect
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x28B2FF0", Offset = "0x28B15F0", VA = "0x1828B2FF0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000075 RID: 117 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x1700001E")]
	protected Vector3 upVect
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x28B3140", Offset = "0x28B1740", VA = "0x1828B3140")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x28B3360", Offset = "0x28B1960", VA = "0x1828B3360", Slot = "9")]
	protected override void OnConstraintUpdate()
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x28B34B0", Offset = "0x28B1AB0", VA = "0x1828B34B0")]
	public LookAtConstraint()
	{
	}

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x80")]
	public Transform upTarget;
}
