using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A8 RID: 424
[Token(Token = "0x20001A8")]
public class simpleFPSCamera : MonoBehaviour
{
	// Token: 0x06000C1F RID: 3103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0x2F74B40", Offset = "0x2F73B40", VA = "0x182F74B40")]
	private void Update()
	{
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x2F74F00", Offset = "0x2F73F00", VA = "0x182F74F00")]
	public simpleFPSCamera()
	{
	}

	// Token: 0x04000AD0 RID: 2768
	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 sensitivity;

	// Token: 0x04000AD1 RID: 2769
	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 speed;

	// Token: 0x04000AD2 RID: 2770
	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0x30")]
	public float minimumY;

	// Token: 0x04000AD3 RID: 2771
	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x34")]
	public float maximumY;

	// Token: 0x04000AD4 RID: 2772
	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0x38")]
	private float rotationY;

	// Token: 0x04000AD5 RID: 2773
	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0x3C")]
	private float rotationX;
}
