using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
public class GetSkyTexture : MonoBehaviour
{
	// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x3165A80", Offset = "0x3164080", VA = "0x183165A80")]
	private void OnEnable()
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x3165AA0", Offset = "0x31640A0", VA = "0x183165AA0")]
	private void SetupRendertex()
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x3165DD0", Offset = "0x31643D0", VA = "0x183165DD0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3165EE0", Offset = "0x31644E0", VA = "0x183165EE0")]
	private void Update()
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x3166150", Offset = "0x3164750", VA = "0x183166150")]
	private void GetSky()
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x31664A0", Offset = "0x3164AA0", VA = "0x1831664A0")]
	private void CopySky()
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x31665D0", Offset = "0x3164BD0", VA = "0x1831665D0")]
	public GetSkyTexture()
	{
	}

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x20")]
	private Texture _skyTexture;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture _finalSky;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x30")]
	private int _renderTextureResolution;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x34")]
	private bool _initialized;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x38")]
	private ReflectionProbe _reflectionProbe;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x40")]
	private HDAdditionalReflectionData _reflectionData;

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _SkyTexture;
}
