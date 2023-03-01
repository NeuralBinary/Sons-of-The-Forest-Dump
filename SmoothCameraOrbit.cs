using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CA RID: 458
[Token(Token = "0x20001CA")]
[AddComponentMenu("Camera-Control/Smooth Mouse Orbit - Unluck Software")]
public class SmoothCameraOrbit : MonoBehaviour
{
	// Token: 0x06000CEF RID: 3311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x2F90C10", Offset = "0x2F8FC10", VA = "0x182F90C10")]
	private void Start()
	{
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x2F90C10", Offset = "0x2F8FC10", VA = "0x182F90C10")]
	private void OnEnable()
	{
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0x2F90110", Offset = "0x2F8F110", VA = "0x182F90110")]
	public void Init()
	{
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x2F905B0", Offset = "0x2F8F5B0", VA = "0x182F905B0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x00005340 File Offset: 0x00003540
	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x8E1E60", Offset = "0x8E0E60", VA = "0x1808E1E60")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0x2F90C20", Offset = "0x2F8FC20", VA = "0x182F90C20")]
	public SmoothCameraOrbit()
	{
	}

	// Token: 0x04000BDD RID: 3037
	[Token(Token = "0x4000BDD")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x04000BDE RID: 3038
	[Token(Token = "0x4000BDE")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 targetOffset;

	// Token: 0x04000BDF RID: 3039
	[Token(Token = "0x4000BDF")]
	[FieldOffset(Offset = "0x34")]
	public float distance;

	// Token: 0x04000BE0 RID: 3040
	[Token(Token = "0x4000BE0")]
	[FieldOffset(Offset = "0x38")]
	public float maxDistance;

	// Token: 0x04000BE1 RID: 3041
	[Token(Token = "0x4000BE1")]
	[FieldOffset(Offset = "0x3C")]
	public float minDistance;

	// Token: 0x04000BE2 RID: 3042
	[Token(Token = "0x4000BE2")]
	[FieldOffset(Offset = "0x40")]
	public float xSpeed;

	// Token: 0x04000BE3 RID: 3043
	[Token(Token = "0x4000BE3")]
	[FieldOffset(Offset = "0x44")]
	public float ySpeed;

	// Token: 0x04000BE4 RID: 3044
	[Token(Token = "0x4000BE4")]
	[FieldOffset(Offset = "0x48")]
	public int yMinLimit;

	// Token: 0x04000BE5 RID: 3045
	[Token(Token = "0x4000BE5")]
	[FieldOffset(Offset = "0x4C")]
	public int yMaxLimit;

	// Token: 0x04000BE6 RID: 3046
	[Token(Token = "0x4000BE6")]
	[FieldOffset(Offset = "0x50")]
	public int zoomRate;

	// Token: 0x04000BE7 RID: 3047
	[Token(Token = "0x4000BE7")]
	[FieldOffset(Offset = "0x54")]
	public float panSpeed;

	// Token: 0x04000BE8 RID: 3048
	[Token(Token = "0x4000BE8")]
	[FieldOffset(Offset = "0x58")]
	public float zoomDampening;

	// Token: 0x04000BE9 RID: 3049
	[Token(Token = "0x4000BE9")]
	[FieldOffset(Offset = "0x5C")]
	public float autoRotate;

	// Token: 0x04000BEA RID: 3050
	[Token(Token = "0x4000BEA")]
	[FieldOffset(Offset = "0x60")]
	private float xDeg;

	// Token: 0x04000BEB RID: 3051
	[Token(Token = "0x4000BEB")]
	[FieldOffset(Offset = "0x64")]
	private float yDeg;

	// Token: 0x04000BEC RID: 3052
	[Token(Token = "0x4000BEC")]
	[FieldOffset(Offset = "0x68")]
	private float currentDistance;

	// Token: 0x04000BED RID: 3053
	[Token(Token = "0x4000BED")]
	[FieldOffset(Offset = "0x6C")]
	private float desiredDistance;

	// Token: 0x04000BEE RID: 3054
	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x70")]
	private Quaternion currentRotation;

	// Token: 0x04000BEF RID: 3055
	[Token(Token = "0x4000BEF")]
	[FieldOffset(Offset = "0x80")]
	private Quaternion desiredRotation;

	// Token: 0x04000BF0 RID: 3056
	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0x90")]
	private Quaternion rotation;

	// Token: 0x04000BF1 RID: 3057
	[Token(Token = "0x4000BF1")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 position;

	// Token: 0x04000BF2 RID: 3058
	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0xAC")]
	private float idleTimer;

	// Token: 0x04000BF3 RID: 3059
	[Token(Token = "0x4000BF3")]
	[FieldOffset(Offset = "0xB0")]
	private float idleSmooth;
}
