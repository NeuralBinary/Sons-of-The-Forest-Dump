using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F7 RID: 247
[Token(Token = "0x20000F7")]
public class alignWeaponFire : MonoBehaviour
{
	// Token: 0x06000795 RID: 1941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000795")]
	[Address(RVA = "0x3679B00", Offset = "0x3678100", VA = "0x183679B00")]
	private void Awake()
	{
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000796")]
	[Address(RVA = "0x3679B40", Offset = "0x3678140", VA = "0x183679B40")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000797")]
	[Address(RVA = "0x367A330", Offset = "0x3678930", VA = "0x18367A330")]
	public alignWeaponFire()
	{
	}

	// Token: 0x0400060C RID: 1548
	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x0400060D RID: 1549
	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x28")]
	public Transform camLookAtTarget;

	// Token: 0x0400060E RID: 1550
	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0x30")]
	public Transform rotateTransform;

	// Token: 0x0400060F RID: 1551
	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x38")]
	public float rotOffset;

	// Token: 0x04000610 RID: 1552
	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0x3C")]
	public float driftYOffset;

	// Token: 0x04000611 RID: 1553
	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0x40")]
	public bool net;
}
