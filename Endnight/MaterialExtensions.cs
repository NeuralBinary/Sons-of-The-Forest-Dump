using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public static class MaterialExtensions
{
	// Token: 0x06000009 RID: 9 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000009")]
	[Address(RVA = "0xA5D390", Offset = "0xA5B990", VA = "0x180A5D390")]
	public static Material CreateMaterialShaderInstance(this Material sourceMaterial, Shader shader)
	{
		return null;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0xA5D660", Offset = "0xA5BC60", VA = "0x180A5D660")]
	public static void UpdateEmissiveColorFromIntensityAndEmissiveColorLDR(this Material material)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0xA5D850", Offset = "0xA5BE50", VA = "0x180A5D850")]
	public static void SetEmissiveIntensity(this Material material, float intensity)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x600000C")]
	[Address(RVA = "0xA5D940", Offset = "0xA5BF40", VA = "0x180A5D940")]
	private static float ConvertEvToLuminance(float ev)
	{
		return 0f;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0xA5D9C0", Offset = "0xA5BFC0", VA = "0x180A5D9C0")]
	public static void SetEmissiveColor(this Material material, Color color)
	{
	}

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	private const string _kEmissiveColorLDR = "_EmissiveColorLDR";

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	private const string _kEmissiveColor = "_EmissiveColor";

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	private const string _kEmissiveIntensity = "_EmissiveIntensity";

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int SurfaceTypeId;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x8")]
	private static LocalKeyword _transparentLocalKeyword;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x20")]
	private static bool _transparentLocalKeywordSetup;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int RenderQueueType;
}
