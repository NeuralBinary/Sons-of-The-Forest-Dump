using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000021 RID: 33
[Token(Token = "0x2000021")]
internal class RenderOrthoCameraPass : CustomPass
{
	// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x5D7460", Offset = "0x5D5A60", VA = "0x1805D7460", Slot = "10")]
	protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x5D7C40", Offset = "0x5D6240", VA = "0x1805D7C40", Slot = "9")]
	protected override void Execute(CustomPassContext ctx)
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x5D9C00", Offset = "0x5D8200", VA = "0x1805D9C00", Slot = "11")]
	protected override void Cleanup()
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x5DA000", Offset = "0x5D8600", VA = "0x1805DA000")]
	public RenderOrthoCameraPass()
	{
	}

	// Token: 0x04000102 RID: 258
	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x90")]
	public float OrthographicSize;

	// Token: 0x04000103 RID: 259
	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x98")]
	private RenderTexture m_WaterNormalRenderTex;

	// Token: 0x04000104 RID: 260
	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0xA0")]
	private RenderTexture m_DiggingRenderTex;

	// Token: 0x04000105 RID: 261
	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0xA8")]
	[Range(0f, 3f)]
	public int DiggingMipLevel;

	// Token: 0x04000106 RID: 262
	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0xAC")]
	private int DiggingMipLevelPowTwo;

	// Token: 0x04000107 RID: 263
	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0xB0")]
	public RenderOrthoCameraPass.GrassDisplacementRes GrassDisplacementResolution;

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0xB4")]
	public float _GrassRecoveringSpeed;

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0xB8")]
	private RenderTexture m_GrassRenderTex;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0xC0")]
	private RenderTexture m_GrassRenderTexFinalA;

	// Token: 0x0400010B RID: 267
	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0xC8")]
	private RenderTexture m_GrassRenderTexFinalB;

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0xD0")]
	private bool activeGrassBuffer;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0xD8")]
	private Shader m_BlitGrassShader;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0xE0")]
	private Material m_BlitGrassMaterial;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0xE8")]
	private int GrassDispRes;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0xEC")]
	private Color clearColWaterDisplacement;

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0xFC")]
	private Color clearColDigging;

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x10C")]
	private Color clearColGrass;

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x11C")]
	private Color clearColGrassCombined;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x12C")]
	private Vector3 camShift;

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x138")]
	private Vector3 camPos;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x144")]
	private Vector3 previousCamPos;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x150")]
	private bool initialized;

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x154")]
	private Vector2 prevOffset;

	// Token: 0x04000119 RID: 281
	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x15C")]
	private Vector4 LuxWaterProjectorParams;

	// Token: 0x0400011A RID: 282
	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x16C")]
	private Vector4 TerrainDisplacementParams;

	// Token: 0x0400011B RID: 283
	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x17C")]
	private Vector4 GrassDisplacementParams;

	// Token: 0x0400011C RID: 284
	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x18C")]
	private Matrix4x4 projectionMatrix;

	// Token: 0x0400011D RID: 285
	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0x1CC")]
	private Matrix4x4 worldToCameraMatrix;

	// Token: 0x0400011E RID: 286
	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _OrthoViewProjMatrixPID;

	// Token: 0x0400011F RID: 287
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int _QuantizedOrthoViewProjMatrixPID;

	// Token: 0x04000120 RID: 288
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int _QuantizedOrthoGrassViewProjMatrixPID;

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int _OrthoCamHeightPID;

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int _CurrentDepthPID;

	// Token: 0x04000123 RID: 291
	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int _PrevOffsetPID;

	// Token: 0x04000124 RID: 292
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int _GrassRecoveringPID;

	// Token: 0x04000125 RID: 293
	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int _SonsGrassRecoveringPID;

	// Token: 0x04000126 RID: 294
	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int _PreviousDepthPID;

	// Token: 0x04000127 RID: 295
	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int _SonsGrassDisplacementPID;

	// Token: 0x04000128 RID: 296
	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x28")]
	private static readonly int _SonsGrassDisplacementPreviousPID;

	// Token: 0x04000129 RID: 297
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly int _LuxWaterProjectorParamsPID;

	// Token: 0x0400012A RID: 298
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x30")]
	private static readonly int _TerrainDisplacementParamsPID;

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x34")]
	private static readonly int _GrassDisplacementParamsPID;

	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[Serializable]
	public enum GrassDisplacementRes
	{
		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		_384 = 384,
		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		_512 = 512,
		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		_1024 = 1024,
		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		_2048 = 2048
	}
}
