using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000115 RID: 277
[Token(Token = "0x2000115")]
[ExecuteInEditMode]
public class ElbowFollow : MonoBehaviour
{
	// Token: 0x06000837 RID: 2103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000837")]
	[Address(RVA = "0x2F28E00", Offset = "0x2F27E00", VA = "0x182F28E00")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000838")]
	[Address(RVA = "0x2F28E60", Offset = "0x2F27E60", VA = "0x182F28E60")]
	public void SolveElbow()
	{
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000839")]
	[Address(RVA = "0x2F29710", Offset = "0x2F28710", VA = "0x182F29710")]
	public ElbowFollow()
	{
	}

	// Token: 0x040006A3 RID: 1699
	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x20")]
	public Transform OrientTransform;

	// Token: 0x040006A4 RID: 1700
	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x28")]
	public Transform Shoulder;

	// Token: 0x040006A5 RID: 1701
	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x30")]
	public Transform Hand;

	// Token: 0x040006A6 RID: 1702
	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x38")]
	public Transform elbow;

	// Token: 0x040006A7 RID: 1703
	[Token(Token = "0x40006A7")]
	[FieldOffset(Offset = "0x40")]
	public Transform angleTargetTransform1;

	// Token: 0x040006A8 RID: 1704
	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0x48")]
	public Transform angleTargetTransform2;

	// Token: 0x040006A9 RID: 1705
	[Token(Token = "0x40006A9")]
	[FieldOffset(Offset = "0x50")]
	public Transform angleTargetTransform3;

	// Token: 0x040006AA RID: 1706
	[Token(Token = "0x40006AA")]
	[FieldOffset(Offset = "0x58")]
	public Transform angleTargetTransform4;

	// Token: 0x040006AB RID: 1707
	[Token(Token = "0x40006AB")]
	[FieldOffset(Offset = "0x60")]
	public Transform angleTargetTransform5;

	// Token: 0x040006AC RID: 1708
	[Token(Token = "0x40006AC")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 TargetAnglePos1;

	// Token: 0x040006AD RID: 1709
	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 TargetAnglePos2;

	// Token: 0x040006AE RID: 1710
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 TargetAnglePos3;

	// Token: 0x040006AF RID: 1711
	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 TargetAnglePos4;

	// Token: 0x040006B0 RID: 1712
	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 TargetAnglePos5;

	// Token: 0x040006B1 RID: 1713
	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0xA4")]
	public Vector3 DefaultLocalPos;
}
