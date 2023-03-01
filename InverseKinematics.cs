using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C9 RID: 457
[Token(Token = "0x20001C9")]
[ExecuteInEditMode]
public class InverseKinematics : MonoBehaviour
{
	// Token: 0x06000CE9 RID: 3305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0x2F8D8F0", Offset = "0x2F8C8F0", VA = "0x182F8D8F0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0x2F8DA70", Offset = "0x2F8CA70", VA = "0x182F8DA70")]
	public void Solve()
	{
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEB")]
	[Address(RVA = "0x2F8D760", Offset = "0x2F8C760", VA = "0x182F8D760")]
	private void ApplyRotationLimits()
	{
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEC")]
	[Address(RVA = "0x2F8D630", Offset = "0x2F8C630", VA = "0x182F8D630")]
	private void ApplyForearmRotationLimits()
	{
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CED")]
	[Address(RVA = "0x2F8D950", Offset = "0x2F8C950", VA = "0x182F8D950")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0x2F8EA60", Offset = "0x2F8DA60", VA = "0x182F8EA60")]
	public InverseKinematics()
	{
	}

	// Token: 0x04000BC7 RID: 3015
	[Token(Token = "0x4000BC7")]
	[FieldOffset(Offset = "0x20")]
	public Transform upperArm;

	// Token: 0x04000BC8 RID: 3016
	[Token(Token = "0x4000BC8")]
	[FieldOffset(Offset = "0x28")]
	public Transform forearm;

	// Token: 0x04000BC9 RID: 3017
	[Token(Token = "0x4000BC9")]
	[FieldOffset(Offset = "0x30")]
	public Transform hand;

	// Token: 0x04000BCA RID: 3018
	[Token(Token = "0x4000BCA")]
	[FieldOffset(Offset = "0x38")]
	public Transform elbow;

	// Token: 0x04000BCB RID: 3019
	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0x40")]
	public Transform target;

	// Token: 0x04000BCC RID: 3020
	[Token(Token = "0x4000BCC")]
	[FieldOffset(Offset = "0x48")]
	[Space(20f)]
	public Vector3 uppperArm_OffsetRotation;

	// Token: 0x04000BCD RID: 3021
	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 forearm_OffsetRotation;

	// Token: 0x04000BCE RID: 3022
	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 hand_OffsetRotation;

	// Token: 0x04000BCF RID: 3023
	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0x6C")]
	[Space(20f)]
	public bool handMatchesTargetRotation;

	// Token: 0x04000BD0 RID: 3024
	[Token(Token = "0x4000BD0")]
	[FieldOffset(Offset = "0x6D")]
	public bool handMatchesTargetTransform;

	// Token: 0x04000BD1 RID: 3025
	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x6E")]
	[Space(20f)]
	public bool debug;

	// Token: 0x04000BD2 RID: 3026
	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0x70")]
	public Quaternion debugForearmQuat;

	// Token: 0x04000BD3 RID: 3027
	[Token(Token = "0x4000BD3")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 debugForearmEuler;

	// Token: 0x04000BD4 RID: 3028
	[Token(Token = "0x4000BD4")]
	[FieldOffset(Offset = "0x8C")]
	private float angle;

	// Token: 0x04000BD5 RID: 3029
	[Token(Token = "0x4000BD5")]
	[FieldOffset(Offset = "0x90")]
	private float upperArm_Length;

	// Token: 0x04000BD6 RID: 3030
	[Token(Token = "0x4000BD6")]
	[FieldOffset(Offset = "0x94")]
	private float forearm_Length;

	// Token: 0x04000BD7 RID: 3031
	[Token(Token = "0x4000BD7")]
	[FieldOffset(Offset = "0x98")]
	private float arm_Length;

	// Token: 0x04000BD8 RID: 3032
	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0x9C")]
	private float targetDistance;

	// Token: 0x04000BD9 RID: 3033
	[Token(Token = "0x4000BD9")]
	[FieldOffset(Offset = "0xA0")]
	private float adyacent;

	// Token: 0x04000BDA RID: 3034
	[Token(Token = "0x4000BDA")]
	[FieldOffset(Offset = "0xA4")]
	public bool RightSide;

	// Token: 0x04000BDB RID: 3035
	[Token(Token = "0x4000BDB")]
	[FieldOffset(Offset = "0xA8")]
	public float BlendOn;

	// Token: 0x04000BDC RID: 3036
	[Token(Token = "0x4000BDC")]
	[FieldOffset(Offset = "0xAC")]
	public bool applyHandRotationLimits;
}
