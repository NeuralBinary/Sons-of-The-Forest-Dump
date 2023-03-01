using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000200 RID: 512
[Token(Token = "0x2000200")]
[Serializable]
public class BendingSegment
{
	// Token: 0x06000DDC RID: 3548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0x2F7DA70", Offset = "0x2F7CA70", VA = "0x182F7DA70")]
	public BendingSegment()
	{
	}

	// Token: 0x04000CED RID: 3309
	[Token(Token = "0x4000CED")]
	[FieldOffset(Offset = "0x10")]
	public Transform firstTransform;

	// Token: 0x04000CEE RID: 3310
	[Token(Token = "0x4000CEE")]
	[FieldOffset(Offset = "0x18")]
	public Transform lastTransform;

	// Token: 0x04000CEF RID: 3311
	[Token(Token = "0x4000CEF")]
	[FieldOffset(Offset = "0x20")]
	public float thresholdAngleDifference;

	// Token: 0x04000CF0 RID: 3312
	[Token(Token = "0x4000CF0")]
	[FieldOffset(Offset = "0x24")]
	public float bendingMultiplier;

	// Token: 0x04000CF1 RID: 3313
	[Token(Token = "0x4000CF1")]
	[FieldOffset(Offset = "0x28")]
	public float maxAngleDifference;

	// Token: 0x04000CF2 RID: 3314
	[Token(Token = "0x4000CF2")]
	[FieldOffset(Offset = "0x2C")]
	public float maxBendingAngle;

	// Token: 0x04000CF3 RID: 3315
	[Token(Token = "0x4000CF3")]
	[FieldOffset(Offset = "0x30")]
	public float responsiveness;

	// Token: 0x04000CF4 RID: 3316
	[Token(Token = "0x4000CF4")]
	[FieldOffset(Offset = "0x34")]
	internal float angleH;

	// Token: 0x04000CF5 RID: 3317
	[Token(Token = "0x4000CF5")]
	[FieldOffset(Offset = "0x38")]
	internal float angleV;

	// Token: 0x04000CF6 RID: 3318
	[Token(Token = "0x4000CF6")]
	[FieldOffset(Offset = "0x3C")]
	internal Vector3 dirUp;

	// Token: 0x04000CF7 RID: 3319
	[Token(Token = "0x4000CF7")]
	[FieldOffset(Offset = "0x48")]
	internal Vector3 referenceLookDir;

	// Token: 0x04000CF8 RID: 3320
	[Token(Token = "0x4000CF8")]
	[FieldOffset(Offset = "0x54")]
	internal Vector3 referenceUpDir;

	// Token: 0x04000CF9 RID: 3321
	[Token(Token = "0x4000CF9")]
	[FieldOffset(Offset = "0x60")]
	internal int chainLength;

	// Token: 0x04000CFA RID: 3322
	[Token(Token = "0x4000CFA")]
	[FieldOffset(Offset = "0x68")]
	internal Quaternion[] origRotations;
}
