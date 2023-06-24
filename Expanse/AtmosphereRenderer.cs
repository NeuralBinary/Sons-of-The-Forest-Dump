using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public class AtmosphereRenderer : IRenderer
	{
		// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027C")]
		[Address(RVA = "0xAC5430", Offset = "0xAC3A30", VA = "0x180AC5430", Slot = "5")]
		public override void build()
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0xAC5B40", Offset = "0xAC4140", VA = "0x180AC5B40", Slot = "6")]
		public override void cleanup()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0xAC5DA0", Offset = "0xAC43A0", VA = "0x180AC5DA0", Slot = "4")]
		public override void render(BuiltinSkyParameters builtinParams, IRenderer[] dependencies)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027F")]
		[Address(RVA = "0xAC70E0", Offset = "0xAC56E0", VA = "0x180AC70E0")]
		public void renderScreenspaceVolumetrics(BuiltinSkyParameters builtinParams, IRenderer[] dependencies)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0xAC8000", Offset = "0xAC6600", VA = "0x180AC8000")]
		private void checkAndResizeDownsampledDepthBuffer(float newDepthDownsampleFactor)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0xAC8350", Offset = "0xAC6950", VA = "0x180AC8350")]
		private void onTLightsReadback(AsyncGPUReadbackRequest tLightsRequest)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x6000282")]
		[Address(RVA = "0xAC8680", Offset = "0xAC6C80", VA = "0x180AC8680")]
		public static Color GetBodyTransmittance(int bodyIndex)
		{
			return default(Color);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000283")]
		[Address(RVA = "0xAC8710", Offset = "0xAC6D10", VA = "0x180AC8710")]
		public void setScreenSize(Vector2 screenSize)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000284")]
		[Address(RVA = "0xAC8AB0", Offset = "0xAC70B0", VA = "0x180AC8AB0", Slot = "7")]
		public override IReadOnlyCollection<string> getTextureNames()
		{
			return null;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000285")]
		[Address(RVA = "0xAC8B00", Offset = "0xAC7100", VA = "0x180AC8B00", Slot = "8")]
		public override void setTexture(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000286")]
		[Address(RVA = "0xAC8BA0", Offset = "0xAC71A0", VA = "0x180AC8BA0", Slot = "9")]
		public override void setTexture(string texture, string shaderVariable, ComputeShader computeShader, int kernelHandle)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000287")]
		[Address(RVA = "0xAC8C50", Offset = "0xAC7250", VA = "0x180AC8C50", Slot = "10")]
		public override void setTexture(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0xAC8D20", Offset = "0xAC7320", VA = "0x180AC8D20", Slot = "11")]
		public override void setTexture(string texture, int shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0xAC8E30", Offset = "0xAC7430", VA = "0x180AC8E30", Slot = "12")]
		public override void setTextureResolution(string texture, string shaderVariable, MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028A")]
		[Address(RVA = "0xAC8ED0", Offset = "0xAC74D0", VA = "0x180AC8ED0", Slot = "13")]
		public override void setTextureResolution(string texture, string shaderVariable, ComputeShader computeShader)
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028B")]
		[Address(RVA = "0xAC8F70", Offset = "0xAC7570", VA = "0x180AC8F70", Slot = "14")]
		public override void setTextureResolution(string texture, string shaderVariable, CommandBuffer cmd)
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x600028C")]
		[Address(RVA = "0xAC9010", Offset = "0xAC7610", VA = "0x180AC9010", Slot = "15")]
		public override Vector3 getTextureResolution(string texture)
		{
			return default(Vector3);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0xAC9150", Offset = "0xAC7750", VA = "0x180AC9150")]
		private void setShaderVariables(BuiltinSkyParameters builtinParams)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028E")]
		[Address(RVA = "0xAC93A0", Offset = "0xAC79A0", VA = "0x180AC93A0")]
		private void setGlobalBuffers(BuiltinSkyParameters builtinParams, int numCloudLayers)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028F")]
		[Address(RVA = "0xAC9480", Offset = "0xAC7A80", VA = "0x180AC9480")]
		private void setAtmosphereSettings(BuiltinSkyParameters builtinParams)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000290")]
		[Address(RVA = "0xAC9790", Offset = "0xAC7D90", VA = "0x180AC9790")]
		public AtmosphereRenderer()
		{
		}

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x10")]
		private AtmosphereRenderer.AtmosphereRenderTextures m_renderTextures;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x18")]
		private Texture2D m_lightTransmittancesCPU;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x0")]
		public static Color[] m_bodyTransmittances;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x20")]
		private float m_depthDownsampleFactor;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x28")]
		private RTHandle m_mipMappedDepthBuffer;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x30")]
		private RTHandle m_downsampledDepthBuffer;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x38")]
		private ComputeBuffer m_settingsBuffer;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		private const string kSettingsBuffer = "_atmosphereSettingsBuffer";

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x40")]
		private AtmosphereRenderer.AtmosphereSettings[] m_atmosphereSettings;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x48")]
		private ProfilingSampler m_precomputeTProfilingSampler;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x50")]
		private ProfilingSampler m_sampleTLightsProfilingSampler;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x58")]
		private ProfilingSampler m_compositeMSProfilingSampler;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x60")]
		private ProfilingSampler m_precomputeMSProfilingSampler;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x68")]
		private ProfilingSampler m_renderSkyViewProfilingSampler;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x70")]
		private ProfilingSampler m_renderAPProfilingSampler;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x78")]
		private ProfilingSampler m_renderScreenspaceProfilingSampler;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x80")]
		private ProfilingSampler m_denoiseScreenspaceProfilingSampler;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x88")]
		private ComputeShader m_CS;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		private const string kTKernel = "T";

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		private const string kTLightsKernel = "TLIGHTS";

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		private const string kCompositeMSKernel = "COMPOSITEMS";

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		private const string kMSKernel = "MS";

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		private const string kSkyViewKernel = "SKYVIEW";

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		private const string kAPKernel = "AP";

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		private const string kCopyDepthKernel = "COPYDEPTH";

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		private const string kBlurDepthKernel = "BLURDEPTH";

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		private const string kScreenspaceKernel = "SCREENSPACE";

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		private const string kDenoiseScreenspaceKernel = "DENOISE_SCREENSPACE";

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x90")]
		private int m_handleT;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x94")]
		private int m_handleTLights;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x98")]
		private int m_handleCompositeMS;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x9C")]
		private int m_handleMS;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0xA0")]
		private int m_handleSkyView;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0xA4")]
		private int m_handleAP;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0xA8")]
		private int m_handleCopyDepth;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0xAC")]
		private int m_handleBlurDepth;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0xB0")]
		private int m_handleScreenspace;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0xB4")]
		private int m_handleDenoiseScreenspace;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		private const string kTTexture = "_T";

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		private const string kTLightsTexture = "_TLights";

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		private const string kMSTexture = "_MS";

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		private const string kMSMultithreadedTexture = "_MSMultithreaded";

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		private const string kSkyViewTexture = "_SkyView";

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		private const string kAPTexture = "_AP";

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		private const string kDownsampleDepthTexture = "_DownsampledDepth";

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		private const string kScreenspaceTexture = "_ScreenSpace";

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		private const string kScreenspaceHistoryTexture = "_ScreenSpaceHistory";

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		private const string kTReadOnlyTexture = "_TTex";

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		private const string kMSReadOnlyTexture = "_MSTex";

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		private const string kSkyViewReadOnlyTexture = "_SkyViewTex";

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		private const string kTLightsReadOnlyTexture = "_TLightsTex";

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		private const string kDownsampleDepthReadOnlyTexture = "_DownsampledDepthTex";

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		private const string kCloudTransmittanceTexture = "_CloudTransmittance";

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		private const string kCloudTransmittanceArrayTexture = "_CloudTransmittanceArray";

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		private const string kLightAttenuationTexture = "_CloudLightAttenuation";

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 m_screenSize;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		private const int ksqrtMSParallelSampleGroups = 2;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0xC0")]
		private int m_nullScreenspaceResultPrerendered;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0xC4")]
		private Matrix4x4 m_previousViewMatrix;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x104")]
		private Matrix4x4 m_previousProjMatrix;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int kPreviousViewMatrixID;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int kPreviousProjectionMatrixID;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int kPixelCoordToViewDirWSID;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int kPixelCoordToViewDirWS_ManualSetID;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int kWorldSpaceCameraPos1ID;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int kSettingsBufferID;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x148")]
		private byte[] onTLightsReadbackTempBuffer;

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		private class AtmosphereRenderTextures
		{
			// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000292")]
			[Address(RVA = "0xACA450", Offset = "0xAC8A50", VA = "0x180ACA450")]
			public AtmosphereRenderTextures()
			{
			}

			// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000293")]
			[Address(RVA = "0xACA530", Offset = "0xAC8B30", VA = "0x180ACA530")]
			public void cleanup()
			{
			}

			// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000294")]
			[Address(RVA = "0xACA700", Offset = "0xAC8D00", VA = "0x180ACA700")]
			public void checkAndResize(Datatypes.Quality atmosphereQuality, Datatypes.Quality screenspaceQuality, Vector2 screenSize)
			{
			}

			// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000295")]
			[Address(RVA = "0xACA8C0", Offset = "0xAC8EC0", VA = "0x180ACA8C0")]
			private void rebuildTextures()
			{
			}

			// Token: 0x06000296 RID: 662 RVA: 0x00004F08 File Offset: 0x00003108
			[Token(Token = "0x6000296")]
			[Address(RVA = "0xACAD10", Offset = "0xAC9310", VA = "0x180ACAD10")]
			public static AtmosphereRenderer.AtmosphereRenderTextures.AtmosphereRenderTextureResolutions qualityToResolution(Datatypes.Quality atmosphereQuality, Datatypes.Quality screenspaceQuality)
			{
				return default(AtmosphereRenderer.AtmosphereRenderTextures.AtmosphereRenderTextureResolutions);
			}

			// Token: 0x04000250 RID: 592
			[Token(Token = "0x4000250")]
			[FieldOffset(Offset = "0x10")]
			public AtmosphereRenderer.AtmosphereRenderTextures.AtmosphereRenderTextureResolutions res;

			// Token: 0x04000251 RID: 593
			[Token(Token = "0x4000251")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, RTHandle> m_framebuffers;

			// Token: 0x02000030 RID: 48
			[Token(Token = "0x2000030")]
			public struct AtmosphereRenderTextureResolutions
			{
				// Token: 0x06000297 RID: 663 RVA: 0x00004F20 File Offset: 0x00003120
				[Token(Token = "0x6000297")]
				[Address(RVA = "0xACAFD0", Offset = "0xAC95D0", VA = "0x180ACAFD0")]
				public static bool areEqual(AtmosphereRenderer.AtmosphereRenderTextures.AtmosphereRenderTextureResolutions a, AtmosphereRenderer.AtmosphereRenderTextures.AtmosphereRenderTextureResolutions b)
				{
					return default(bool);
				}

				// Token: 0x04000252 RID: 594
				[Token(Token = "0x4000252")]
				[FieldOffset(Offset = "0x0")]
				public Vector2Int T;

				// Token: 0x04000253 RID: 595
				[Token(Token = "0x4000253")]
				[FieldOffset(Offset = "0x8")]
				public Vector2Int MS;

				// Token: 0x04000254 RID: 596
				[Token(Token = "0x4000254")]
				[FieldOffset(Offset = "0x10")]
				public Vector2Int skyView;

				// Token: 0x04000255 RID: 597
				[Token(Token = "0x4000255")]
				[FieldOffset(Offset = "0x18")]
				public Vector3Int AP;

				// Token: 0x04000256 RID: 598
				[Token(Token = "0x4000256")]
				[FieldOffset(Offset = "0x24")]
				public Vector3Int screenspace;
			}
		}

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\atmosphere\\AtmosphereRenderer.cs", needAccessors = false)]
		private struct AtmosphereSettings
		{
			// Token: 0x04000257 RID: 599
			[Token(Token = "0x4000257")]
			[FieldOffset(Offset = "0x0")]
			public int frameCount;

			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 screenSize;

			// Token: 0x04000259 RID: 601
			[Token(Token = "0x4000259")]
			[FieldOffset(Offset = "0xC")]
			public float farClip;

			// Token: 0x0400025A RID: 602
			[Token(Token = "0x400025A")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 resT;

			// Token: 0x0400025B RID: 603
			[Token(Token = "0x400025B")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 resMS;

			// Token: 0x0400025C RID: 604
			[Token(Token = "0x400025C")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 resSkyView;

			// Token: 0x0400025D RID: 605
			[Token(Token = "0x400025D")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 resAP;

			// Token: 0x0400025E RID: 606
			[Token(Token = "0x400025E")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 resScreenspace;

			// Token: 0x0400025F RID: 607
			[Token(Token = "0x400025F")]
			[FieldOffset(Offset = "0x40")]
			public Vector2 resDownsampledDepth;
		}
	}
}
