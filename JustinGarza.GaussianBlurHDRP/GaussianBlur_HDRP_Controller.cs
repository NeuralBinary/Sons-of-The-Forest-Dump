using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class GaussianBlur_HDRP_Controller : MonoBehaviour
{
	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x20794F0", Offset = "0x2077AF0", VA = "0x1820794F0")]
	private void Update()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2079570", Offset = "0x2077B70", VA = "0x182079570")]
	public GaussianBlur_HDRP_Controller()
	{
	}

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x20")]
	public Material GaussianBlurMat;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	public float blurAmount;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 1f)]
	public float metallic;
}
