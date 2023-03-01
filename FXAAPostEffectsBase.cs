using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A4 RID: 420
[Token(Token = "0x20001A4")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class FXAAPostEffectsBase : MonoBehaviour
{
	// Token: 0x06000C05 RID: 3077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C05")]
	[Address(RVA = "0x2F63610", Offset = "0x2F62610", VA = "0x182F63610")]
	public Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C06")]
	[Address(RVA = "0x2F63CB0", Offset = "0x2F62CB0", VA = "0x182F63CB0")]
	private Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x2F63EC0", Offset = "0x2F62EC0", VA = "0x182F63EC0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x00004DA0 File Offset: 0x00002FA0
	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x2F63B10", Offset = "0x2F62B10", VA = "0x182F63B10")]
	private bool CheckSupport()
	{
		return default(bool);
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x00004DB8 File Offset: 0x00002FB8
	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x2F63560", Offset = "0x2F62560", VA = "0x182F63560")]
	private bool CheckResources()
	{
		return default(bool);
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x2F63F70", Offset = "0x2F62F70", VA = "0x182F63F70")]
	private void Start()
	{
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x00004DD0 File Offset: 0x00002FD0
	[Token(Token = "0x6000C0B")]
	[Address(RVA = "0x2F63BE0", Offset = "0x2F62BE0", VA = "0x182F63BE0")]
	public bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x00004DE8 File Offset: 0x00002FE8
	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0x2F63B80", Offset = "0x2F62B80", VA = "0x182F63B80")]
	private bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0x2F63ED0", Offset = "0x2F62ED0", VA = "0x182F63ED0")]
	private void ReportAutoDisable()
	{
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x00004E00 File Offset: 0x00003000
	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0x2F63960", Offset = "0x2F62960", VA = "0x182F63960")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x2F63EA0", Offset = "0x2F62EA0", VA = "0x182F63EA0")]
	private void NotSupported()
	{
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x2C68620", Offset = "0x2C67620", VA = "0x182C68620")]
	private void DrawBorder(RenderTexture dest, Material material)
	{
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x93FDA0", Offset = "0x93EDA0", VA = "0x18093FDA0")]
	public FXAAPostEffectsBase()
	{
	}

	// Token: 0x04000ABF RID: 2751
	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x20")]
	protected bool supportHDRTextures;

	// Token: 0x04000AC0 RID: 2752
	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x21")]
	protected bool isSupported;
}
