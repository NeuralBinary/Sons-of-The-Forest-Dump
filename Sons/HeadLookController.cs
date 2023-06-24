using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000201 RID: 513
[Token(Token = "0x2000201")]
public class HeadLookController : MonoBehaviour
{
	// Token: 0x06000E39 RID: 3641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x3713550", Offset = "0x3711B50", VA = "0x183713550")]
	private void Start()
	{
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E3A")]
	[Address(RVA = "0x3713EB0", Offset = "0x37124B0", VA = "0x183713EB0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x00005730 File Offset: 0x00003930
	[Token(Token = "0x6000E3B")]
	[Address(RVA = "0x3715800", Offset = "0x3713E00", VA = "0x183715800")]
	public static float AngleAroundAxis(Vector3 dirA, Vector3 dirB, Vector3 axis)
	{
		return 0f;
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E3C")]
	[Address(RVA = "0x3715A30", Offset = "0x3714030", VA = "0x183715A30")]
	public HeadLookController()
	{
	}

	// Token: 0x04000D2C RID: 3372
	[Token(Token = "0x4000D2C")]
	[FieldOffset(Offset = "0x20")]
	public Transform rootNode;

	// Token: 0x04000D2D RID: 3373
	[Token(Token = "0x4000D2D")]
	[FieldOffset(Offset = "0x28")]
	public BendingSegment[] segments;

	// Token: 0x04000D2E RID: 3374
	[Token(Token = "0x4000D2E")]
	[FieldOffset(Offset = "0x30")]
	public NonAffectedJoints[] nonAffectedJoints;

	// Token: 0x04000D2F RID: 3375
	[Token(Token = "0x4000D2F")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 headLookVector;

	// Token: 0x04000D30 RID: 3376
	[Token(Token = "0x4000D30")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 headUpVector;

	// Token: 0x04000D31 RID: 3377
	[Token(Token = "0x4000D31")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 target;

	// Token: 0x04000D32 RID: 3378
	[Token(Token = "0x4000D32")]
	[FieldOffset(Offset = "0x5C")]
	public float effect;

	// Token: 0x04000D33 RID: 3379
	[Token(Token = "0x4000D33")]
	[FieldOffset(Offset = "0x60")]
	public bool overrideAnimation;
}
