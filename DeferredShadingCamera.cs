using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E7 RID: 487
[Token(Token = "0x20001E7")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class DeferredShadingCamera : MonoBehaviour
{
	// Token: 0x06000D84 RID: 3460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D84")]
	[Address(RVA = "0x2F86E10", Offset = "0x2F85E10", VA = "0x182F86E10")]
	private void SetupGbufferTextures()
	{
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x2F86B90", Offset = "0x2F85B90", VA = "0x182F86B90")]
	private void SetupGbufferCamera()
	{
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D86")]
	[Address(RVA = "0x2F871A0", Offset = "0x2F861A0", VA = "0x182F871A0")]
	private void SetupTransparentCamera()
	{
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x2F84BD0", Offset = "0x2F83BD0", VA = "0x182F84BD0")]
	private void Init()
	{
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x2F869A0", Offset = "0x2F859A0", VA = "0x182F869A0")]
	private void RenderGbuffers()
	{
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x2F85390", Offset = "0x2F84390", VA = "0x182F85390")]
	private void SetupCameraForGbufferRender()
	{
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x2F85390", Offset = "0x2F84390", VA = "0x182F85390")]
	private void OnPreRender()
	{
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x2F87280", Offset = "0x2F86280", VA = "0x182F87280")]
	private void SynchronizeGbufferCamera()
	{
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x2F850B0", Offset = "0x2F840B0", VA = "0x182F850B0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x2F85510", Offset = "0x2F84510", VA = "0x182F85510")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x2F85220", Offset = "0x2F84220", VA = "0x182F85220")]
	private void MultiBlit(RenderTexture source, RenderTexture[] targets, Material material, int pass)
	{
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x2F84800", Offset = "0x2F83800", VA = "0x182F84800")]
	public static void AddLight(DeferredLight light)
	{
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x2F84710", Offset = "0x2F83710", VA = "0x182F84710")]
	public static void RemoveLight(DeferredLight light)
	{
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x2F87470", Offset = "0x2F86470", VA = "0x182F87470")]
	public DeferredShadingCamera()
	{
	}

	// Token: 0x04000C9A RID: 3226
	[Token(Token = "0x4000C9A")]
	[FieldOffset(Offset = "0x20")]
	private Camera c;

	// Token: 0x04000C9B RID: 3227
	[Token(Token = "0x4000C9B")]
	[FieldOffset(Offset = "0x28")]
	private Camera transparentCamera;

	// Token: 0x04000C9C RID: 3228
	[Token(Token = "0x4000C9C")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture lastActive;

	// Token: 0x04000C9D RID: 3229
	[Token(Token = "0x4000C9D")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Shader gbufferShader;

	// Token: 0x04000C9E RID: 3230
	[Token(Token = "0x4000C9E")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Shader ssaoShader;

	// Token: 0x04000C9F RID: 3231
	[Token(Token = "0x4000C9F")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public Shader postBlurShader;

	// Token: 0x04000CA0 RID: 3232
	[Token(Token = "0x4000CA0")]
	[FieldOffset(Offset = "0x50")]
	public Texture2D uniformNoise;

	// Token: 0x04000CA1 RID: 3233
	[Token(Token = "0x4000CA1")]
	[FieldOffset(Offset = "0x58")]
	private Material ssaoMaterial;

	// Token: 0x04000CA2 RID: 3234
	[Token(Token = "0x4000CA2")]
	[FieldOffset(Offset = "0x60")]
	private Material postBlurMaterial;

	// Token: 0x04000CA3 RID: 3235
	[Token(Token = "0x4000CA3")]
	[FieldOffset(Offset = "0x68")]
	private Material compositeMaterial;

	// Token: 0x04000CA4 RID: 3236
	[Token(Token = "0x4000CA4")]
	[FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Shader compositeShader;

	// Token: 0x04000CA5 RID: 3237
	[Token(Token = "0x4000CA5")]
	[FieldOffset(Offset = "0x78")]
	public LayerMask gbufferCullingMask;

	// Token: 0x04000CA6 RID: 3238
	[Token(Token = "0x4000CA6")]
	[FieldOffset(Offset = "0x7C")]
	public LayerMask waterRenderingMask;

	// Token: 0x04000CA7 RID: 3239
	[Token(Token = "0x4000CA7")]
	[FieldOffset(Offset = "0x80")]
	public LayerMask particleRenderingMask;

	// Token: 0x04000CA8 RID: 3240
	[Token(Token = "0x4000CA8")]
	[FieldOffset(Offset = "0x88")]
	private RenderTexture[] gbufferTextures;

	// Token: 0x04000CA9 RID: 3241
	[Token(Token = "0x4000CA9")]
	[FieldOffset(Offset = "0x90")]
	private RenderBuffer[] gbufferBuffers;

	// Token: 0x04000CAA RID: 3242
	[Token(Token = "0x4000CAA")]
	[FieldOffset(Offset = "0x98")]
	private RenderTexture depthTexture;

	// Token: 0x04000CAB RID: 3243
	[Token(Token = "0x4000CAB")]
	[FieldOffset(Offset = "0xA0")]
	private RenderBuffer depthBuffer;

	// Token: 0x04000CAC RID: 3244
	[Token(Token = "0x4000CAC")]
	[FieldOffset(Offset = "0xB0")]
	private Vector2 previousRenderSize;

	// Token: 0x04000CAD RID: 3245
	[Token(Token = "0x4000CAD")]
	[FieldOffset(Offset = "0xB8")]
	private Vector2 currentRenderSize;

	// Token: 0x04000CAE RID: 3246
	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0x0")]
	private static List<DeferredLight> sceneLights;

	// Token: 0x04000CAF RID: 3247
	[Token(Token = "0x4000CAF")]
	[FieldOffset(Offset = "0x8")]
	[HideInInspector]
	public static Vector3 directionalLightVector;

	// Token: 0x04000CB0 RID: 3248
	[Token(Token = "0x4000CB0")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public static Color directionalLightColor;

	// Token: 0x04000CB1 RID: 3249
	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0xC0")]
	public bool renderPointLights;

	// Token: 0x04000CB2 RID: 3250
	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0xC1")]
	public bool renderSSAO;

	// Token: 0x04000CB3 RID: 3251
	[Token(Token = "0x4000CB3")]
	[FieldOffset(Offset = "0xC2")]
	public bool renderSSSSS;

	// Token: 0x04000CB4 RID: 3252
	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0xC8")]
	private object initChecker;

	// Token: 0x04000CB5 RID: 3253
	[Token(Token = "0x4000CB5")]
	private const int numBuffers = 3;

	// Token: 0x04000CB6 RID: 3254
	[Token(Token = "0x4000CB6")]
	[FieldOffset(Offset = "0xD0")]
	public DeferredShadingCamera.DebugDisplay displayMode;

	// Token: 0x04000CB7 RID: 3255
	[Token(Token = "0x4000CB7")]
	[FieldOffset(Offset = "0xD8")]
	private Camera gbufferCamera;

	// Token: 0x04000CB8 RID: 3256
	[Token(Token = "0x4000CB8")]
	[FieldOffset(Offset = "0xE0")]
	private int actualCullingMask;

	// Token: 0x020001E8 RID: 488
	[Token(Token = "0x20001E8")]
	public enum DebugDisplay
	{
		// Token: 0x04000CBA RID: 3258
		[Token(Token = "0x4000CBA")]
		gbuffer0,
		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		gbuffer1,
		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		gbuffer2,
		// Token: 0x04000CBD RID: 3261
		[Token(Token = "0x4000CBD")]
		composite
	}
}
