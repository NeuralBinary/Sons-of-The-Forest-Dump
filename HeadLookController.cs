using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000202 RID: 514
[Token(Token = "0x2000202")]
public class HeadLookController : MonoBehaviour
{
	// Token: 0x06000DDE RID: 3550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0x2F8CB90", Offset = "0x2F8BB90", VA = "0x182F8CB90")]
	private void Start()
	{
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0x2F8B7E0", Offset = "0x2F8A7E0", VA = "0x182F8B7E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x000054F0 File Offset: 0x000036F0
	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0x2F8B5B0", Offset = "0x2F8A5B0", VA = "0x182F8B5B0")]
	public static float AngleAroundAxis(Vector3 dirA, Vector3 dirB, Vector3 axis)
	{
		return default(float);
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0x2F8D1B0", Offset = "0x2F8C1B0", VA = "0x182F8D1B0")]
	public HeadLookController()
	{
	}

	// Token: 0x04000CFD RID: 3325
	[Token(Token = "0x4000CFD")]
	[FieldOffset(Offset = "0x20")]
	public Transform rootNode;

	// Token: 0x04000CFE RID: 3326
	[Token(Token = "0x4000CFE")]
	[FieldOffset(Offset = "0x28")]
	public BendingSegment[] segments;

	// Token: 0x04000CFF RID: 3327
	[Token(Token = "0x4000CFF")]
	[FieldOffset(Offset = "0x30")]
	public NonAffectedJoints[] nonAffectedJoints;

	// Token: 0x04000D00 RID: 3328
	[Token(Token = "0x4000D00")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 headLookVector;

	// Token: 0x04000D01 RID: 3329
	[Token(Token = "0x4000D01")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 headUpVector;

	// Token: 0x04000D02 RID: 3330
	[Token(Token = "0x4000D02")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 target;

	// Token: 0x04000D03 RID: 3331
	[Token(Token = "0x4000D03")]
	[FieldOffset(Offset = "0x5C")]
	public float effect;

	// Token: 0x04000D04 RID: 3332
	[Token(Token = "0x4000D04")]
	[FieldOffset(Offset = "0x60")]
	public bool overrideAnimation;
}
