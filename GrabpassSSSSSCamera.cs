using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200019A RID: 410
[Token(Token = "0x200019A")]
[ExecuteInEditMode]
public class GrabpassSSSSSCamera : MonoBehaviour
{
	// Token: 0x06000BDD RID: 3037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x2F64F50", Offset = "0x2F63F50", VA = "0x182F64F50")]
	private void ToggleKeyword(bool toggle, string keywordON, string keywordOFF)
	{
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDE")]
	[Address(RVA = "0x2F64E10", Offset = "0x2F63E10", VA = "0x182F64E10")]
	private void OnPreRender()
	{
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0x2F64FA0", Offset = "0x2F63FA0", VA = "0x182F64FA0")]
	public GrabpassSSSSSCamera()
	{
	}

	// Token: 0x04000AA5 RID: 2725
	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0x20")]
	[Range(0.01f, 10f)]
	public float ConvolutionRadius;

	// Token: 0x04000AA6 RID: 2726
	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 1f)]
	public float SkinAmbientSpecular;
}
