using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FF RID: 511
[Token(Token = "0x20001FF")]
[Serializable]
public class BendingSegment
{
	// Token: 0x06000E37 RID: 3639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x3713530", Offset = "0x3711B30", VA = "0x183713530")]
	public BendingSegment()
	{
	}

	// Token: 0x04000D1C RID: 3356
	[Token(Token = "0x4000D1C")]
	[FieldOffset(Offset = "0x10")]
	public Transform firstTransform;

	// Token: 0x04000D1D RID: 3357
	[Token(Token = "0x4000D1D")]
	[FieldOffset(Offset = "0x18")]
	public Transform lastTransform;

	// Token: 0x04000D1E RID: 3358
	[Token(Token = "0x4000D1E")]
	[FieldOffset(Offset = "0x20")]
	public float thresholdAngleDifference;

	// Token: 0x04000D1F RID: 3359
	[Token(Token = "0x4000D1F")]
	[FieldOffset(Offset = "0x24")]
	public float bendingMultiplier;

	// Token: 0x04000D20 RID: 3360
	[Token(Token = "0x4000D20")]
	[FieldOffset(Offset = "0x28")]
	public float maxAngleDifference;

	// Token: 0x04000D21 RID: 3361
	[Token(Token = "0x4000D21")]
	[FieldOffset(Offset = "0x2C")]
	public float maxBendingAngle;

	// Token: 0x04000D22 RID: 3362
	[Token(Token = "0x4000D22")]
	[FieldOffset(Offset = "0x30")]
	public float responsiveness;

	// Token: 0x04000D23 RID: 3363
	[Token(Token = "0x4000D23")]
	[FieldOffset(Offset = "0x34")]
	internal float angleH;

	// Token: 0x04000D24 RID: 3364
	[Token(Token = "0x4000D24")]
	[FieldOffset(Offset = "0x38")]
	internal float angleV;

	// Token: 0x04000D25 RID: 3365
	[Token(Token = "0x4000D25")]
	[FieldOffset(Offset = "0x3C")]
	internal Vector3 dirUp;

	// Token: 0x04000D26 RID: 3366
	[Token(Token = "0x4000D26")]
	[FieldOffset(Offset = "0x48")]
	internal Vector3 referenceLookDir;

	// Token: 0x04000D27 RID: 3367
	[Token(Token = "0x4000D27")]
	[FieldOffset(Offset = "0x54")]
	internal Vector3 referenceUpDir;

	// Token: 0x04000D28 RID: 3368
	[Token(Token = "0x4000D28")]
	[FieldOffset(Offset = "0x60")]
	internal int chainLength;

	// Token: 0x04000D29 RID: 3369
	[Token(Token = "0x4000D29")]
	[FieldOffset(Offset = "0x68")]
	internal Quaternion[] origRotations;
}
