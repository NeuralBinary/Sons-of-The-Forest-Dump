using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C8 RID: 456
[Token(Token = "0x20001C8")]
[ExecuteInEditMode]
public class InverseKinematics : MonoBehaviour
{
	// Token: 0x06000D44 RID: 3396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D44")]
	[Address(RVA = "0x36FB850", Offset = "0x36F9E50", VA = "0x1836FB850")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D45")]
	[Address(RVA = "0x36FB8F0", Offset = "0x36F9EF0", VA = "0x1836FB8F0")]
	public void Solve()
	{
	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D46")]
	[Address(RVA = "0x36FD4A0", Offset = "0x36FBAA0", VA = "0x1836FD4A0")]
	private void ApplyRotationLimits()
	{
	}

	// Token: 0x06000D47 RID: 3399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D47")]
	[Address(RVA = "0x36FD610", Offset = "0x36FBC10", VA = "0x1836FD610")]
	private void ApplyForearmRotationLimits()
	{
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D48")]
	[Address(RVA = "0x36FD730", Offset = "0x36FBD30", VA = "0x1836FD730")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D49")]
	[Address(RVA = "0x36FDA30", Offset = "0x36FC030", VA = "0x1836FDA30")]
	public InverseKinematics()
	{
	}

	// Token: 0x04000BF6 RID: 3062
	[Token(Token = "0x4000BF6")]
	[FieldOffset(Offset = "0x20")]
	public Transform upperArm;

	// Token: 0x04000BF7 RID: 3063
	[Token(Token = "0x4000BF7")]
	[FieldOffset(Offset = "0x28")]
	public Transform forearm;

	// Token: 0x04000BF8 RID: 3064
	[Token(Token = "0x4000BF8")]
	[FieldOffset(Offset = "0x30")]
	public Transform hand;

	// Token: 0x04000BF9 RID: 3065
	[Token(Token = "0x4000BF9")]
	[FieldOffset(Offset = "0x38")]
	public Transform elbow;

	// Token: 0x04000BFA RID: 3066
	[Token(Token = "0x4000BFA")]
	[FieldOffset(Offset = "0x40")]
	public Transform target;

	// Token: 0x04000BFB RID: 3067
	[Token(Token = "0x4000BFB")]
	[FieldOffset(Offset = "0x48")]
	[Space(20f)]
	public Vector3 uppperArm_OffsetRotation;

	// Token: 0x04000BFC RID: 3068
	[Token(Token = "0x4000BFC")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 forearm_OffsetRotation;

	// Token: 0x04000BFD RID: 3069
	[Token(Token = "0x4000BFD")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 hand_OffsetRotation;

	// Token: 0x04000BFE RID: 3070
	[Token(Token = "0x4000BFE")]
	[FieldOffset(Offset = "0x6C")]
	[Space(20f)]
	public bool handMatchesTargetRotation;

	// Token: 0x04000BFF RID: 3071
	[Token(Token = "0x4000BFF")]
	[FieldOffset(Offset = "0x6D")]
	public bool handMatchesTargetTransform;

	// Token: 0x04000C00 RID: 3072
	[Token(Token = "0x4000C00")]
	[FieldOffset(Offset = "0x6E")]
	[Space(20f)]
	public bool debug;

	// Token: 0x04000C01 RID: 3073
	[Token(Token = "0x4000C01")]
	[FieldOffset(Offset = "0x70")]
	public Quaternion debugForearmQuat;

	// Token: 0x04000C02 RID: 3074
	[Token(Token = "0x4000C02")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 debugForearmEuler;

	// Token: 0x04000C03 RID: 3075
	[Token(Token = "0x4000C03")]
	[FieldOffset(Offset = "0x8C")]
	private float angle;

	// Token: 0x04000C04 RID: 3076
	[Token(Token = "0x4000C04")]
	[FieldOffset(Offset = "0x90")]
	private float upperArm_Length;

	// Token: 0x04000C05 RID: 3077
	[Token(Token = "0x4000C05")]
	[FieldOffset(Offset = "0x94")]
	private float forearm_Length;

	// Token: 0x04000C06 RID: 3078
	[Token(Token = "0x4000C06")]
	[FieldOffset(Offset = "0x98")]
	private float arm_Length;

	// Token: 0x04000C07 RID: 3079
	[Token(Token = "0x4000C07")]
	[FieldOffset(Offset = "0x9C")]
	private float targetDistance;

	// Token: 0x04000C08 RID: 3080
	[Token(Token = "0x4000C08")]
	[FieldOffset(Offset = "0xA0")]
	private float adyacent;

	// Token: 0x04000C09 RID: 3081
	[Token(Token = "0x4000C09")]
	[FieldOffset(Offset = "0xA4")]
	public bool RightSide;

	// Token: 0x04000C0A RID: 3082
	[Token(Token = "0x4000C0A")]
	[FieldOffset(Offset = "0xA8")]
	public float BlendOn;

	// Token: 0x04000C0B RID: 3083
	[Token(Token = "0x4000C0B")]
	[FieldOffset(Offset = "0xAC")]
	public bool applyHandRotationLimits;
}
