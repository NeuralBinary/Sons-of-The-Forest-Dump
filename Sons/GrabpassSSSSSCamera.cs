using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000199 RID: 409
[Token(Token = "0x2000199")]
[ExecuteInEditMode]
public class GrabpassSSSSSCamera : MonoBehaviour
{
	// Token: 0x06000C37 RID: 3127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C37")]
	[Address(RVA = "0x36E26A0", Offset = "0x36E0CA0", VA = "0x1836E26A0")]
	private void ToggleKeyword(bool toggle, string keywordON, string keywordOFF)
	{
	}

	// Token: 0x06000C38 RID: 3128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x36E2770", Offset = "0x36E0D70", VA = "0x1836E2770")]
	private void OnPreRender()
	{
	}

	// Token: 0x06000C39 RID: 3129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x36E29F0", Offset = "0x36E0FF0", VA = "0x1836E29F0")]
	public GrabpassSSSSSCamera()
	{
	}

	// Token: 0x04000AD0 RID: 2768
	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0x20")]
	[Range(0.01f, 10f)]
	public float ConvolutionRadius;

	// Token: 0x04000AD1 RID: 2769
	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 1f)]
	public float SkinAmbientSpecular;
}
