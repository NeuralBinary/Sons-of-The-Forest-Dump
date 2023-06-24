using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A3 RID: 419
[Token(Token = "0x20001A3")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class FXAAPostEffectsBase : MonoBehaviour
{
	// Token: 0x06000C5F RID: 3167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x36E56B0", Offset = "0x36E3CB0", VA = "0x1836E56B0")]
	public Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C60")]
	[Address(RVA = "0x36E5BA0", Offset = "0x36E41A0", VA = "0x1836E5BA0")]
	private Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x36E5F30", Offset = "0x36E4530", VA = "0x1836E5F30")]
	private void OnEnable()
	{
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x00004FC8 File Offset: 0x000031C8
	[Token(Token = "0x6000C62")]
	[Address(RVA = "0x36E5F40", Offset = "0x36E4540", VA = "0x1836E5F40")]
	private bool CheckSupport()
	{
		return default(bool);
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x00004FE0 File Offset: 0x000031E0
	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x36E5F80", Offset = "0x36E4580", VA = "0x1836E5F80")]
	private bool CheckResources()
	{
		return default(bool);
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C64")]
	[Address(RVA = "0x36E6030", Offset = "0x36E4630", VA = "0x1836E6030")]
	private void Start()
	{
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x00004FF8 File Offset: 0x000031F8
	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x36E60D0", Offset = "0x36E46D0", VA = "0x1836E60D0")]
	public bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x00005010 File Offset: 0x00003210
	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x36E6180", Offset = "0x36E4780", VA = "0x1836E6180")]
	private bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x36E61D0", Offset = "0x36E47D0", VA = "0x1836E61D0")]
	private void ReportAutoDisable()
	{
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x00005028 File Offset: 0x00003228
	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x36E6270", Offset = "0x36E4870", VA = "0x1836E6270")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x36E6450", Offset = "0x36E4A50", VA = "0x1836E6450")]
	private void NotSupported()
	{
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x31EEEF0", Offset = "0x31ED4F0", VA = "0x1831EEEF0")]
	private void DrawBorder(RenderTexture dest, Material material)
	{
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0xAA91A0", Offset = "0xAA77A0", VA = "0x180AA91A0")]
	public FXAAPostEffectsBase()
	{
	}

	// Token: 0x04000AEA RID: 2794
	[Token(Token = "0x4000AEA")]
	[FieldOffset(Offset = "0x20")]
	protected bool supportHDRTextures;

	// Token: 0x04000AEB RID: 2795
	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0x21")]
	protected bool isSupported;
}
