using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
[AddComponentMenu("Path-o-logical/UnityConstraints/Purchase Unity Constraints for More! (Or Install it after TargetPRO)")]
public class TurntableConstraint : ConstraintFrameworkBaseClass
{
	// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x28B37E0", Offset = "0x28B1DE0", VA = "0x1828B37E0", Slot = "5")]
	protected override void OnEnable()
	{
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x28B3910", Offset = "0x28B1F10", VA = "0x1828B3910", Slot = "9")]
	protected override void OnConstraintUpdate()
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x5C7240", Offset = "0x5C5840", VA = "0x1805C7240")]
	public TurntableConstraint()
	{
	}

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x28")]
	public float speed;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x2C")]
	public bool randomStart;
}
