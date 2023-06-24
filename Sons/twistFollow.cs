using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000182 RID: 386
[Token(Token = "0x2000182")]
[ExecuteInEditMode]
public class twistFollow : MonoBehaviour
{
	// Token: 0x06000BAC RID: 2988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Start()
	{
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x36D7680", Offset = "0x36D5C80", VA = "0x1836D7680")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x36D78F0", Offset = "0x36D5EF0", VA = "0x1836D78F0")]
	public twistFollow()
	{
	}

	// Token: 0x04000A48 RID: 2632
	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0x20")]
	public Transform[] twistJoints;

	// Token: 0x04000A49 RID: 2633
	[Token(Token = "0x4000A49")]
	[FieldOffset(Offset = "0x28")]
	public Transform wristTarget;

	// Token: 0x04000A4A RID: 2634
	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x30")]
	public float TwistOffset;

	// Token: 0x04000A4B RID: 2635
	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x34")]
	public float blendAmount;
}
