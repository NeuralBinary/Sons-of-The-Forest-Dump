using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000112 RID: 274
[Token(Token = "0x2000112")]
[ExecuteInEditMode]
public class ElbowFollow : MonoBehaviour
{
	// Token: 0x0600087E RID: 2174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087E")]
	[Address(RVA = "0x3688690", Offset = "0x3686C90", VA = "0x183688690")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087F")]
	[Address(RVA = "0x3688720", Offset = "0x3686D20", VA = "0x183688720")]
	public void SolveElbow()
	{
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000880")]
	[Address(RVA = "0x3689440", Offset = "0x3687A40", VA = "0x183689440")]
	public ElbowFollow()
	{
	}

	// Token: 0x040006BF RID: 1727
	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x20")]
	public Transform OrientTransform;

	// Token: 0x040006C0 RID: 1728
	[Token(Token = "0x40006C0")]
	[FieldOffset(Offset = "0x28")]
	public Transform Shoulder;

	// Token: 0x040006C1 RID: 1729
	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0x30")]
	public Transform Hand;

	// Token: 0x040006C2 RID: 1730
	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0x38")]
	public Transform elbow;

	// Token: 0x040006C3 RID: 1731
	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0x40")]
	public Transform angleTargetTransform1;

	// Token: 0x040006C4 RID: 1732
	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x48")]
	public Transform angleTargetTransform2;

	// Token: 0x040006C5 RID: 1733
	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x50")]
	public Transform angleTargetTransform3;

	// Token: 0x040006C6 RID: 1734
	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0x58")]
	public Transform angleTargetTransform4;

	// Token: 0x040006C7 RID: 1735
	[Token(Token = "0x40006C7")]
	[FieldOffset(Offset = "0x60")]
	public Transform angleTargetTransform5;

	// Token: 0x040006C8 RID: 1736
	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 TargetAnglePos1;

	// Token: 0x040006C9 RID: 1737
	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 TargetAnglePos2;

	// Token: 0x040006CA RID: 1738
	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 TargetAnglePos3;

	// Token: 0x040006CB RID: 1739
	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 TargetAnglePos4;

	// Token: 0x040006CC RID: 1740
	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 TargetAnglePos5;

	// Token: 0x040006CD RID: 1741
	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0xA4")]
	public Vector3 DefaultLocalPos;
}
