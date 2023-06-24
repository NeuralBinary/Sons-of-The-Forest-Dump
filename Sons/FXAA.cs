using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A2 RID: 418
[Token(Token = "0x20001A2")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/FXAA")]
public class FXAA : FXAAPostEffectsBase
{
	// Token: 0x06000C5B RID: 3163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x36E52D0", Offset = "0x36E38D0", VA = "0x1836E52D0")]
	private void CreateMaterials()
	{
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x36E5400", Offset = "0x36E3A00", VA = "0x1836E5400")]
	private void Start()
	{
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0x36E54D0", Offset = "0x36E3AD0", VA = "0x1836E54D0")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0xAA91A0", Offset = "0xAA77A0", VA = "0x180AA91A0")]
	public FXAA()
	{
	}

	// Token: 0x04000AE8 RID: 2792
	[Token(Token = "0x4000AE8")]
	[FieldOffset(Offset = "0x28")]
	public Shader shader;

	// Token: 0x04000AE9 RID: 2793
	[Token(Token = "0x4000AE9")]
	[FieldOffset(Offset = "0x30")]
	private Material mat;
}
