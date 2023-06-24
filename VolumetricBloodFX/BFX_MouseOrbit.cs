using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
public class BFX_MouseOrbit : MonoBehaviour
{
	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x4B0A210", Offset = "0x4B08810", VA = "0x184B0A210")]
	private void Start()
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x4B0A300", Offset = "0x4B08900", VA = "0x184B0A300")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000206C File Offset: 0x0000026C
	[Token(Token = "0x6000019")]
	[Address(RVA = "0xA2D780", Offset = "0xA2BD80", VA = "0x180A2D780")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x4B0B600", Offset = "0x4B09C00", VA = "0x184B0B600")]
	public BFX_MouseOrbit()
	{
	}

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x20")]
	public GameObject target;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x28")]
	public float distance;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x2C")]
	public float xSpeed;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x30")]
	public float ySpeed;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x34")]
	public float yMinLimit;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x38")]
	public float yMaxLimit;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x3C")]
	private float x;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x40")]
	private float y;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x44")]
	private float prevDistance;
}
