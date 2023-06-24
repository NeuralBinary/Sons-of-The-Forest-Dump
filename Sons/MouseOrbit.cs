using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CB RID: 459
[Token(Token = "0x20001CB")]
[AddComponentMenu("Camera-Control/Mouse Orbit")]
[Serializable]
public class MouseOrbit : MonoBehaviour
{
	// Token: 0x06000D55 RID: 3413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D55")]
	[Address(RVA = "0x36FF970", Offset = "0x36FDF70", VA = "0x1836FF970", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D56")]
	[Address(RVA = "0x36FFB80", Offset = "0x36FE180", VA = "0x1836FFB80", Slot = "5")]
	public virtual void LateUpdate()
	{
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x00005598 File Offset: 0x00003798
	[Token(Token = "0x6000D57")]
	[Address(RVA = "0xA2D780", Offset = "0xA2BD80", VA = "0x180A2D780")]
	public static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D58")]
	[Address(RVA = "0x3700040", Offset = "0x36FE640", VA = "0x183700040")]
	public MouseOrbit()
	{
	}

	// Token: 0x04000C26 RID: 3110
	[Token(Token = "0x4000C26")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x04000C27 RID: 3111
	[Token(Token = "0x4000C27")]
	[FieldOffset(Offset = "0x28")]
	public float distance;

	// Token: 0x04000C28 RID: 3112
	[Token(Token = "0x4000C28")]
	[FieldOffset(Offset = "0x2C")]
	public float xSpeed;

	// Token: 0x04000C29 RID: 3113
	[Token(Token = "0x4000C29")]
	[FieldOffset(Offset = "0x30")]
	public float ySpeed;

	// Token: 0x04000C2A RID: 3114
	[Token(Token = "0x4000C2A")]
	[FieldOffset(Offset = "0x34")]
	public int yMinLimit;

	// Token: 0x04000C2B RID: 3115
	[Token(Token = "0x4000C2B")]
	[FieldOffset(Offset = "0x38")]
	public int yMaxLimit;

	// Token: 0x04000C2C RID: 3116
	[Token(Token = "0x4000C2C")]
	[FieldOffset(Offset = "0x3C")]
	private float x;

	// Token: 0x04000C2D RID: 3117
	[Token(Token = "0x4000C2D")]
	[FieldOffset(Offset = "0x40")]
	private float y;
}
