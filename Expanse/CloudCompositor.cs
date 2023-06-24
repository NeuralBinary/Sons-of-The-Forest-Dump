using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	public class CloudCompositor : IRenderer
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xACD880", Offset = "0xACBE80", VA = "0x180ACD880", Slot = "5")]
		public override void build()
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xACE3C0", Offset = "0xACC9C0", VA = "0x180ACE3C0", Slot = "6")]
		public override void cleanup()
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xACE6B0", Offset = "0xACCCB0", VA = "0x180ACE6B0")]
		private void allocateFullscreenFramebuffers(Vector2Int res)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xACE840", Offset = "0xACCE40", VA = "0x180ACE840")]
		private void cleanupFullscreenFramebuffers()
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xACE9D0", Offset = "0xACCFD0", VA = "0x180ACE9D0")]
		private void allocateReflectionFramebuffers(Vector2Int res)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xACEB60", Offset = "0xACD160", VA = "0x180ACEB60")]
		private void cleanupReflectionFramebuffers()
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xACECF0", Offset = "0xACD2F0", VA = "0x180ACECF0")]
		private void allocateShadowMapFramebuffers(int numShadowMapBuffers, Vector2Int res)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xACF2B0", Offset = "0xACD8B0", VA = "0x180ACF2B0")]
		private void cleanupShadowMapFramebuffers()
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xACF540", Offset = "0xACDB40", VA = "0x180ACF540")]
		private void buildComputeShaders()
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xACF720", Offset = "0xACDD20", VA = "0x180ACF720", Slot = "4")]
		public override void render(BuiltinSkyParameters builtinParams, IRenderer[] dependencies)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xACFB90", Offset = "0xACE190", VA = "0x180ACFB90")]
		private void compositeFullscreen(BuiltinSkyParameters builtinParams, CloudRenderer cloudRenderer)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xAD0730", Offset = "0xACED30", VA = "0x180AD0730")]
		private void compositeShadowMaps(BuiltinSkyParameters builtinParams, CloudRenderer cloudRenderer)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xAD0BC0", Offset = "0xACF1C0", VA = "0x180AD0BC0")]
		private void compositeBodyShadowMap(BuiltinSkyParameters builtinParams, CloudRenderer cloudRenderer, int i)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xAD16A0", Offset = "0xACFCA0", VA = "0x180AD16A0")]
		private void renderLightAttenuation(BuiltinSkyParameters builtinParams, int shadowBodies)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xAD1E50", Offset = "0xAD0450", VA = "0x180AD1E50")]
		private void disableShadowMaps()
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xAD1F70", Offset = "0xAD0570", VA = "0x180AD1F70")]
		private void clearLightAttenuation()
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xAD2130", Offset = "0xAD0730", VA = "0x180AD2130")]
		private int chooseFullscreenKernel(int enabledLayers, bool compositeByHeight)
		{
			return 0;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xAD2220", Offset = "0xAD0820", VA = "0x180AD2220")]
		private void checkAndResizeFramebuffers(Vector2 screenSize)
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xAD2390", Offset = "0xAD0990", VA = "0x180AD2390")]
		private void checkAndResizeShadowMapFramebuffers(int numShadowMapBuffers, Vector2Int resolution)
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xAD2400", Offset = "0xAD0A00", VA = "0x180AD2400", Slot = "7")]
		public override IReadOnlyCollection<string> getTextureNames()
		{
			return null;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xAD2450", Offset = "0xAD0A50", VA = "0x180AD2450", Slot = "8")]
		public override void setTexture(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xAD24F0", Offset = "0xAD0AF0", VA = "0x180AD24F0", Slot = "9")]
		public override void setTexture(string texture, string shaderVariable, ComputeShader computeShader, int kernelHandle)
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xAD25A0", Offset = "0xAD0BA0", VA = "0x180AD25A0", Slot = "10")]
		public override void setTexture(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xAD2680", Offset = "0xAD0C80", VA = "0x180AD2680", Slot = "11")]
		public override void setTexture(string texture, int shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xAC8E30", Offset = "0xAC7430", VA = "0x180AC8E30", Slot = "12")]
		public override void setTextureResolution(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xAC8ED0", Offset = "0xAC74D0", VA = "0x180AC8ED0", Slot = "13")]
		public override void setTextureResolution(string texture, string shaderVariable, ComputeShader computeShader)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xAC8F70", Offset = "0xAC7570", VA = "0x180AC8F70", Slot = "14")]
		public override void setTextureResolution(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xAD27A0", Offset = "0xAD0DA0", VA = "0x180AD27A0", Slot = "15")]
		public override Vector3 getTextureResolution(string texture)
		{
			return default(Vector3);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xAD28D0", Offset = "0xAD0ED0", VA = "0x180AD28D0")]
		public static RTHandle getShadowMap(int bodyIndex)
		{
			return null;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xAD2940", Offset = "0xAD0F40", VA = "0x180AD2940")]
		private void setFullscreenShaderVariables(BuiltinSkyParameters builtinParams, CommandBuffer cmd, ComputeShader cs, int handle)
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xAD3380", Offset = "0xAD1980", VA = "0x180AD3380")]
		private void setFullscreenTextures(CloudRenderer cloudRenderer, ComputeShader cs, int handle)
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xAD35E0", Offset = "0xAD1BE0", VA = "0x180AD35E0")]
		private void setShadowMapShaderVariables(CloudRenderer cloudRenderer, ComputeShader cs, int shadowBodyIndex)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xAD3700", Offset = "0xAD1D00", VA = "0x180AD3700")]
		public CloudCompositor()
		{
		}

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, RTHandle[]> m_framebuffers;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		private const string kFullscreenLightingFramebuffer = "fullscreenLighting";

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		private const string kFullscreenTransmittanceAndHitFramebuffer = "fullscreenTransmittanceAndHit";

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		private const string kReflectionFramebuffer = "reflection";

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		private const string kReflectionTFramebuffer = "reflectionT";

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x18")]
		private string[] kShadowMapFramebuffer;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		private const string kLightAttenuationFramebuffer = "lightAttenuation";

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x20")]
		private int m_numShadowMapBuffers;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x0")]
		private static RTHandle[] m_shadowMaps;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x28")]
		private RTHandle m_defaultTexture2D;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x30")]
		private ProfilingSampler m_fullscreenSampler;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x38")]
		private ProfilingSampler m_reflectionSampler;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x40")]
		private ProfilingSampler m_shadowSampler;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x48")]
		private ProfilingSampler m_shadowBlurSampler;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x50")]
		private ProfilingSampler m_lightAttenuationSampler;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x58")]
		private ComputeShader m_fullscreenCS;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x60")]
		private ComputeShader[] m_shadowMapCS;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		private const string kFullscreen0Kernel = "FULLSCREEN_0";

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		private const string kFullscreen1Kernel = "FULLSCREEN_1";

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		private const string kFullscreen2Kernel = "FULLSCREEN_2";

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		private const string kFullscreenNKernel = "FULLSCREEN_N";

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		private const string kFullscreenSortedNKernel = "FULLSCREEN_SORTED_N";

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		private const string kReflectionKernel = "REFLECTION";

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		private const string kShadowMapKernel = "SHADOWMAP";

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		private const string kBlurHorizontalKernel = "BLURHORIZONTAL";

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		private const string kBlurVerticalKernel = "BLURVERTICAL";

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		private const string kLightAttenuationKernel = "LIGHTATTENUATION";

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		private const string kCompositeLightingFramebufferTexture = "_LightingFramebuffer";

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		private const string kCompositeTransmittanceHitFramebufferTexture = "_TransmittanceAndHitFramebuffer";

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		private const string kCompositeShadowMapFramebufferTexture = "_ShadowMapFramebuffer";

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		private const string kReflectionTFramebufferTexture = "_ReflectionTFramebuffer";

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		private const string kLightingFramebufferTexture = "_CloudLightingFramebuffers";

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		private const string kLightAttenuationTexture = "_LightAttenuationFramebuffer";

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		private const string kGBufferTexture = "_CloudGBuffers";

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		private const string kReflectionTexture = "_CloudReflectionFramebuffers";

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		private const string kReflectionTTexture = "_CloudReflectionTFramebuffers";

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		private const string kTransmittanceHitFramebufferTexture = "_CloudTransmittanceHitFramebuffers";

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		private const string kShadowMapFramebufferToBlurTexture = "_ShadowMapFramebufferToBlur";

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		private const string kBodyShadowmapTexture = "_BodyShadowMap";

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		private const string kSortedIndexBuffer = "_SortedLayerIndexBuffer";

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		private const int kShadowMapCompositeResolutionFactor = 1;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x68")]
		private Vector2Int m_shadowMapResolution;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x70")]
		private bool m_prerenderedNullResult;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x71")]
		private bool m_clearedLightAttenuation;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x78")]
		private ComputeBuffer m_indexBuffer;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x8")]
		private static int[] kHasShadowMapIDs;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x10")]
		private static int[] kBodyShadowmapTextureIDs;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x18")]
		private static string[] kShadowmapTextureNames;
	}
}
