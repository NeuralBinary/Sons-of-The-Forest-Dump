using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E6 RID: 486
[Token(Token = "0x20001E6")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class DeferredShadingCamera : MonoBehaviour
{
	// Token: 0x06000DDF RID: 3551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0x370BB60", Offset = "0x370A160", VA = "0x18370BB60")]
	private void SetupGbufferTextures()
	{
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0x370C080", Offset = "0x370A680", VA = "0x18370C080")]
	private void SetupGbufferCamera()
	{
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0x370C720", Offset = "0x370AD20", VA = "0x18370C720")]
	private void SetupTransparentCamera()
	{
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0x370C8B0", Offset = "0x370AEB0", VA = "0x18370C8B0")]
	private void Init()
	{
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0x370D230", Offset = "0x370B830", VA = "0x18370D230")]
	private void RenderGbuffers()
	{
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0x370D6A0", Offset = "0x370BCA0", VA = "0x18370D6A0")]
	private void SetupCameraForGbufferRender()
	{
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0x370D9B0", Offset = "0x370BFB0", VA = "0x18370D9B0")]
	private void OnPreRender()
	{
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x370D9C0", Offset = "0x370BFC0", VA = "0x18370D9C0")]
	private void SynchronizeGbufferCamera()
	{
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x370DF60", Offset = "0x370C560", VA = "0x18370DF60")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0x370E0D0", Offset = "0x370C6D0", VA = "0x18370E0D0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x370F560", Offset = "0x370DB60", VA = "0x18370F560")]
	private void MultiBlit(RenderTexture source, RenderTexture[] targets, Material material, int pass)
	{
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x370F860", Offset = "0x370DE60", VA = "0x18370F860")]
	public static void AddLight(DeferredLight light)
	{
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0x370B9B0", Offset = "0x3709FB0", VA = "0x18370B9B0")]
	public static void RemoveLight(DeferredLight light)
	{
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x370FAB0", Offset = "0x370E0B0", VA = "0x18370FAB0")]
	public DeferredShadingCamera()
	{
	}

	// Token: 0x04000CC9 RID: 3273
	[Token(Token = "0x4000CC9")]
	[FieldOffset(Offset = "0x20")]
	private Camera c;

	// Token: 0x04000CCA RID: 3274
	[Token(Token = "0x4000CCA")]
	[FieldOffset(Offset = "0x28")]
	private Camera transparentCamera;

	// Token: 0x04000CCB RID: 3275
	[Token(Token = "0x4000CCB")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture lastActive;

	// Token: 0x04000CCC RID: 3276
	[Token(Token = "0x4000CCC")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Shader gbufferShader;

	// Token: 0x04000CCD RID: 3277
	[Token(Token = "0x4000CCD")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Shader ssaoShader;

	// Token: 0x04000CCE RID: 3278
	[Token(Token = "0x4000CCE")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public Shader postBlurShader;

	// Token: 0x04000CCF RID: 3279
	[Token(Token = "0x4000CCF")]
	[FieldOffset(Offset = "0x50")]
	public Texture2D uniformNoise;

	// Token: 0x04000CD0 RID: 3280
	[Token(Token = "0x4000CD0")]
	[FieldOffset(Offset = "0x58")]
	private Material ssaoMaterial;

	// Token: 0x04000CD1 RID: 3281
	[Token(Token = "0x4000CD1")]
	[FieldOffset(Offset = "0x60")]
	private Material postBlurMaterial;

	// Token: 0x04000CD2 RID: 3282
	[Token(Token = "0x4000CD2")]
	[FieldOffset(Offset = "0x68")]
	private Material compositeMaterial;

	// Token: 0x04000CD3 RID: 3283
	[Token(Token = "0x4000CD3")]
	[FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Shader compositeShader;

	// Token: 0x04000CD4 RID: 3284
	[Token(Token = "0x4000CD4")]
	[FieldOffset(Offset = "0x78")]
	public LayerMask gbufferCullingMask;

	// Token: 0x04000CD5 RID: 3285
	[Token(Token = "0x4000CD5")]
	[FieldOffset(Offset = "0x7C")]
	public LayerMask waterRenderingMask;

	// Token: 0x04000CD6 RID: 3286
	[Token(Token = "0x4000CD6")]
	[FieldOffset(Offset = "0x80")]
	public LayerMask particleRenderingMask;

	// Token: 0x04000CD7 RID: 3287
	[Token(Token = "0x4000CD7")]
	[FieldOffset(Offset = "0x88")]
	private RenderTexture[] gbufferTextures;

	// Token: 0x04000CD8 RID: 3288
	[Token(Token = "0x4000CD8")]
	[FieldOffset(Offset = "0x90")]
	private RenderBuffer[] gbufferBuffers;

	// Token: 0x04000CD9 RID: 3289
	[Token(Token = "0x4000CD9")]
	[FieldOffset(Offset = "0x98")]
	private RenderTexture depthTexture;

	// Token: 0x04000CDA RID: 3290
	[Token(Token = "0x4000CDA")]
	[FieldOffset(Offset = "0xA0")]
	private RenderBuffer depthBuffer;

	// Token: 0x04000CDB RID: 3291
	[Token(Token = "0x4000CDB")]
	[FieldOffset(Offset = "0xB0")]
	private Vector2 previousRenderSize;

	// Token: 0x04000CDC RID: 3292
	[Token(Token = "0x4000CDC")]
	[FieldOffset(Offset = "0xB8")]
	private Vector2 currentRenderSize;

	// Token: 0x04000CDD RID: 3293
	[Token(Token = "0x4000CDD")]
	[FieldOffset(Offset = "0x0")]
	private static List<DeferredLight> sceneLights;

	// Token: 0x04000CDE RID: 3294
	[Token(Token = "0x4000CDE")]
	[FieldOffset(Offset = "0x8")]
	[HideInInspector]
	public static Vector3 directionalLightVector;

	// Token: 0x04000CDF RID: 3295
	[Token(Token = "0x4000CDF")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public static Color directionalLightColor;

	// Token: 0x04000CE0 RID: 3296
	[Token(Token = "0x4000CE0")]
	[FieldOffset(Offset = "0xC0")]
	public bool renderPointLights;

	// Token: 0x04000CE1 RID: 3297
	[Token(Token = "0x4000CE1")]
	[FieldOffset(Offset = "0xC1")]
	public bool renderSSAO;

	// Token: 0x04000CE2 RID: 3298
	[Token(Token = "0x4000CE2")]
	[FieldOffset(Offset = "0xC2")]
	public bool renderSSSSS;

	// Token: 0x04000CE3 RID: 3299
	[Token(Token = "0x4000CE3")]
	[FieldOffset(Offset = "0xC8")]
	private object initChecker;

	// Token: 0x04000CE4 RID: 3300
	[Token(Token = "0x4000CE4")]
	private const int numBuffers = 3;

	// Token: 0x04000CE5 RID: 3301
	[Token(Token = "0x4000CE5")]
	[FieldOffset(Offset = "0xD0")]
	public DeferredShadingCamera.DebugDisplay displayMode;

	// Token: 0x04000CE6 RID: 3302
	[Token(Token = "0x4000CE6")]
	[FieldOffset(Offset = "0xD8")]
	private Camera gbufferCamera;

	// Token: 0x04000CE7 RID: 3303
	[Token(Token = "0x4000CE7")]
	[FieldOffset(Offset = "0xE0")]
	private int actualCullingMask;

	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x20001E7")]
	public enum DebugDisplay
	{
		// Token: 0x04000CE9 RID: 3305
		[Token(Token = "0x4000CE9")]
		gbuffer0,
		// Token: 0x04000CEA RID: 3306
		[Token(Token = "0x4000CEA")]
		gbuffer1,
		// Token: 0x04000CEB RID: 3307
		[Token(Token = "0x4000CEB")]
		gbuffer2,
		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		composite
	}
}
