using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000183 RID: 387
[Token(Token = "0x2000183")]
[ExecuteInEditMode]
public class twistFollow : MonoBehaviour
{
	// Token: 0x06000B53 RID: 2899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Start()
	{
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x2F78A80", Offset = "0x2F77A80", VA = "0x182F78A80")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x2F78C10", Offset = "0x2F77C10", VA = "0x182F78C10")]
	public twistFollow()
	{
	}

	// Token: 0x04000A1F RID: 2591
	[Token(Token = "0x4000A1F")]
	[FieldOffset(Offset = "0x20")]
	public Transform[] twistJoints;

	// Token: 0x04000A20 RID: 2592
	[Token(Token = "0x4000A20")]
	[FieldOffset(Offset = "0x28")]
	public Transform wristTarget;

	// Token: 0x04000A21 RID: 2593
	[Token(Token = "0x4000A21")]
	[FieldOffset(Offset = "0x30")]
	public float TwistOffset;

	// Token: 0x04000A22 RID: 2594
	[Token(Token = "0x4000A22")]
	[FieldOffset(Offset = "0x34")]
	public float blendAmount;
}
