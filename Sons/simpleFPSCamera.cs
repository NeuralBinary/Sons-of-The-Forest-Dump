using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A7 RID: 423
[Token(Token = "0x20001A7")]
public class simpleFPSCamera : MonoBehaviour
{
	// Token: 0x06000C79 RID: 3193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x36E7310", Offset = "0x36E5910", VA = "0x1836E7310")]
	private void Update()
	{
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x36E7B20", Offset = "0x36E6120", VA = "0x1836E7B20")]
	public simpleFPSCamera()
	{
	}

	// Token: 0x04000AFB RID: 2811
	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 sensitivity;

	// Token: 0x04000AFC RID: 2812
	[Token(Token = "0x4000AFC")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 speed;

	// Token: 0x04000AFD RID: 2813
	[Token(Token = "0x4000AFD")]
	[FieldOffset(Offset = "0x30")]
	public float minimumY;

	// Token: 0x04000AFE RID: 2814
	[Token(Token = "0x4000AFE")]
	[FieldOffset(Offset = "0x34")]
	public float maximumY;

	// Token: 0x04000AFF RID: 2815
	[Token(Token = "0x4000AFF")]
	[FieldOffset(Offset = "0x38")]
	private float rotationY;

	// Token: 0x04000B00 RID: 2816
	[Token(Token = "0x4000B00")]
	[FieldOffset(Offset = "0x3C")]
	private float rotationX;
}
