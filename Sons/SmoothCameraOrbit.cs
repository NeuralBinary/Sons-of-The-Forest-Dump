using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C9 RID: 457
[Token(Token = "0x20001C9")]
[AddComponentMenu("Camera-Control/Smooth Mouse Orbit - Unluck Software")]
public class SmoothCameraOrbit : MonoBehaviour
{
	// Token: 0x06000D4A RID: 3402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4A")]
	[Address(RVA = "0x36FDA80", Offset = "0x36FC080", VA = "0x1836FDA80")]
	private void Start()
	{
	}

	// Token: 0x06000D4B RID: 3403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4B")]
	[Address(RVA = "0x36FDA80", Offset = "0x36FC080", VA = "0x1836FDA80")]
	private void OnEnable()
	{
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4C")]
	[Address(RVA = "0x36FDA90", Offset = "0x36FC090", VA = "0x1836FDA90")]
	public void Init()
	{
	}

	// Token: 0x06000D4D RID: 3405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4D")]
	[Address(RVA = "0x36FE3D0", Offset = "0x36FC9D0", VA = "0x1836FE3D0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x00005580 File Offset: 0x00003780
	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0xA2D780", Offset = "0xA2BD80", VA = "0x180A2D780")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D4F")]
	[Address(RVA = "0x36FF0B0", Offset = "0x36FD6B0", VA = "0x1836FF0B0")]
	public SmoothCameraOrbit()
	{
	}

	// Token: 0x04000C0C RID: 3084
	[Token(Token = "0x4000C0C")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x04000C0D RID: 3085
	[Token(Token = "0x4000C0D")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 targetOffset;

	// Token: 0x04000C0E RID: 3086
	[Token(Token = "0x4000C0E")]
	[FieldOffset(Offset = "0x34")]
	public float distance;

	// Token: 0x04000C0F RID: 3087
	[Token(Token = "0x4000C0F")]
	[FieldOffset(Offset = "0x38")]
	public float maxDistance;

	// Token: 0x04000C10 RID: 3088
	[Token(Token = "0x4000C10")]
	[FieldOffset(Offset = "0x3C")]
	public float minDistance;

	// Token: 0x04000C11 RID: 3089
	[Token(Token = "0x4000C11")]
	[FieldOffset(Offset = "0x40")]
	public float xSpeed;

	// Token: 0x04000C12 RID: 3090
	[Token(Token = "0x4000C12")]
	[FieldOffset(Offset = "0x44")]
	public float ySpeed;

	// Token: 0x04000C13 RID: 3091
	[Token(Token = "0x4000C13")]
	[FieldOffset(Offset = "0x48")]
	public int yMinLimit;

	// Token: 0x04000C14 RID: 3092
	[Token(Token = "0x4000C14")]
	[FieldOffset(Offset = "0x4C")]
	public int yMaxLimit;

	// Token: 0x04000C15 RID: 3093
	[Token(Token = "0x4000C15")]
	[FieldOffset(Offset = "0x50")]
	public int zoomRate;

	// Token: 0x04000C16 RID: 3094
	[Token(Token = "0x4000C16")]
	[FieldOffset(Offset = "0x54")]
	public float panSpeed;

	// Token: 0x04000C17 RID: 3095
	[Token(Token = "0x4000C17")]
	[FieldOffset(Offset = "0x58")]
	public float zoomDampening;

	// Token: 0x04000C18 RID: 3096
	[Token(Token = "0x4000C18")]
	[FieldOffset(Offset = "0x5C")]
	public float autoRotate;

	// Token: 0x04000C19 RID: 3097
	[Token(Token = "0x4000C19")]
	[FieldOffset(Offset = "0x60")]
	private float xDeg;

	// Token: 0x04000C1A RID: 3098
	[Token(Token = "0x4000C1A")]
	[FieldOffset(Offset = "0x64")]
	private float yDeg;

	// Token: 0x04000C1B RID: 3099
	[Token(Token = "0x4000C1B")]
	[FieldOffset(Offset = "0x68")]
	private float currentDistance;

	// Token: 0x04000C1C RID: 3100
	[Token(Token = "0x4000C1C")]
	[FieldOffset(Offset = "0x6C")]
	private float desiredDistance;

	// Token: 0x04000C1D RID: 3101
	[Token(Token = "0x4000C1D")]
	[FieldOffset(Offset = "0x70")]
	private Quaternion currentRotation;

	// Token: 0x04000C1E RID: 3102
	[Token(Token = "0x4000C1E")]
	[FieldOffset(Offset = "0x80")]
	private Quaternion desiredRotation;

	// Token: 0x04000C1F RID: 3103
	[Token(Token = "0x4000C1F")]
	[FieldOffset(Offset = "0x90")]
	private Quaternion rotation;

	// Token: 0x04000C20 RID: 3104
	[Token(Token = "0x4000C20")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 position;

	// Token: 0x04000C21 RID: 3105
	[Token(Token = "0x4000C21")]
	[FieldOffset(Offset = "0xAC")]
	private float idleTimer;

	// Token: 0x04000C22 RID: 3106
	[Token(Token = "0x4000C22")]
	[FieldOffset(Offset = "0xB0")]
	private float idleSmooth;
}
