using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
[AddComponentMenu("Path-o-logical/UnityConstraints/Constraint - Look At - Smooth")]
public class SmoothLookAtConstraint : LookAtConstraint
{
	// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x28B34C0", Offset = "0x28B1AC0", VA = "0x1828B34C0", Slot = "9")]
	protected override void OnConstraintUpdate()
	{
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x28B36F0", Offset = "0x28B1CF0", VA = "0x1828B36F0", Slot = "11")]
	protected override void NoTargetDefault()
	{
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x28B3770", Offset = "0x28B1D70", VA = "0x1828B3770")]
	private void OutputTowards(Quaternion destRot)
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x28B37C0", Offset = "0x28B1DC0", VA = "0x1828B37C0")]
	public SmoothLookAtConstraint()
	{
	}

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x88")]
	public UnityConstraints.INTERP_OPTIONS interpolation;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x8C")]
	public float speed;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x90")]
	public UnityConstraints.OUTPUT_ROT_OPTIONS output;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x94")]
	private Quaternion lookRot;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0xA4")]
	private Quaternion usrLookRot;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0xB4")]
	private Quaternion curRot;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0xC4")]
	private Vector3 angles;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0xD0")]
	private Vector3 lookVectCache;
}
