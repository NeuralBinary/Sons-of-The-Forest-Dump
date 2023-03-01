using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A3 RID: 419
[Token(Token = "0x20001A3")]
[AddComponentMenu("Image Effects/FXAA")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class FXAA : FXAAPostEffectsBase
{
	// Token: 0x06000C01 RID: 3073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C01")]
	[Address(RVA = "0x2F64010", Offset = "0x2F63010", VA = "0x182F64010")]
	private void CreateMaterials()
	{
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C02")]
	[Address(RVA = "0x2F64210", Offset = "0x2F63210", VA = "0x182F64210")]
	private void Start()
	{
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C03")]
	[Address(RVA = "0x2F640A0", Offset = "0x2F630A0", VA = "0x182F640A0")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C04")]
	[Address(RVA = "0x93FDA0", Offset = "0x93EDA0", VA = "0x18093FDA0")]
	public FXAA()
	{
	}

	// Token: 0x04000ABD RID: 2749
	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x28")]
	public Shader shader;

	// Token: 0x04000ABE RID: 2750
	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x30")]
	private Material mat;
}
