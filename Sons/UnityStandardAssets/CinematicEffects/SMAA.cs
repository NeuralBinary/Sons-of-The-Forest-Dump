using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	[Serializable]
	public class SMAA : IAntiAliasing
	{
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DF")]
		public Shader shader
		{
			[Token(Token = "0x60014B0")]
			[Address(RVA = "0x320FAA0", Offset = "0x320E0A0", VA = "0x18320FAA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E0")]
		private Texture2D areaTexture
		{
			[Token(Token = "0x60014B1")]
			[Address(RVA = "0x320FBE0", Offset = "0x320E1E0", VA = "0x18320FBE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E1")]
		private Texture2D searchTexture
		{
			[Token(Token = "0x60014B2")]
			[Address(RVA = "0x320FD30", Offset = "0x320E330", VA = "0x18320FD30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E2")]
		private Material material
		{
			[Token(Token = "0x60014B3")]
			[Address(RVA = "0x320FE80", Offset = "0x320E480", VA = "0x18320FE80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x320FFC0", Offset = "0x320E5C0", VA = "0x18320FFC0", Slot = "4")]
		public void Awake()
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x3210390", Offset = "0x320E990", VA = "0x183210390", Slot = "5")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x3210420", Offset = "0x320EA20", VA = "0x183210420", Slot = "6")]
		public void OnDisable()
		{
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x3210660", Offset = "0x320EC60", VA = "0x183210660", Slot = "7")]
		public void OnPreCull(Camera camera)
		{
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x32109E0", Offset = "0x320EFE0", VA = "0x1832109E0", Slot = "8")]
		public void OnPostRender(Camera camera)
		{
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x3210A50", Offset = "0x320F050", VA = "0x183210A50", Slot = "9")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x32120A0", Offset = "0x32106A0", VA = "0x1832120A0")]
		private RenderTexture TempRT(int width, int height, RenderTextureFormat format)
		{
			return null;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x3212100", Offset = "0x3210700", VA = "0x183212100")]
		public SMAA()
		{
		}

		// Token: 0x04001471 RID: 5233
		[Token(Token = "0x4001471")]
		[FieldOffset(Offset = "0x10")]
		[SMAA.TopLevelSettings]
		public SMAA.GlobalSettings settings;

		// Token: 0x04001472 RID: 5234
		[Token(Token = "0x4001472")]
		[FieldOffset(Offset = "0x1C")]
		[SMAA.SettingsGroup]
		public SMAA.QualitySettings quality;

		// Token: 0x04001473 RID: 5235
		[Token(Token = "0x4001473")]
		[FieldOffset(Offset = "0x38")]
		[SMAA.SettingsGroup]
		public SMAA.PredicationSettings predication;

		// Token: 0x04001474 RID: 5236
		[Token(Token = "0x4001474")]
		[FieldOffset(Offset = "0x48")]
		[SMAA.ExperimentalGroup]
		[SMAA.SettingsGroup]
		public SMAA.TemporalSettings temporal;

		// Token: 0x04001475 RID: 5237
		[Token(Token = "0x4001475")]
		[FieldOffset(Offset = "0x50")]
		private Matrix4x4 m_ProjectionMatrix;

		// Token: 0x04001476 RID: 5238
		[Token(Token = "0x4001476")]
		[FieldOffset(Offset = "0x90")]
		private Matrix4x4 m_PreviousViewProjectionMatrix;

		// Token: 0x04001477 RID: 5239
		[Token(Token = "0x4001477")]
		[FieldOffset(Offset = "0xD0")]
		private float m_FlipFlop;

		// Token: 0x04001478 RID: 5240
		[Token(Token = "0x4001478")]
		[FieldOffset(Offset = "0xD8")]
		private RenderTexture m_Accumulation;

		// Token: 0x04001479 RID: 5241
		[Token(Token = "0x4001479")]
		[FieldOffset(Offset = "0xE0")]
		private Shader m_Shader;

		// Token: 0x0400147A RID: 5242
		[Token(Token = "0x400147A")]
		[FieldOffset(Offset = "0xE8")]
		private Texture2D m_AreaTexture;

		// Token: 0x0400147B RID: 5243
		[Token(Token = "0x400147B")]
		[FieldOffset(Offset = "0xF0")]
		private Texture2D m_SearchTexture;

		// Token: 0x0400147C RID: 5244
		[Token(Token = "0x400147C")]
		[FieldOffset(Offset = "0xF8")]
		private Material m_Material;

		// Token: 0x0400147D RID: 5245
		[Token(Token = "0x400147D")]
		[FieldOffset(Offset = "0x100")]
		private int m_AreaTex;

		// Token: 0x0400147E RID: 5246
		[Token(Token = "0x400147E")]
		[FieldOffset(Offset = "0x104")]
		private int m_SearchTex;

		// Token: 0x0400147F RID: 5247
		[Token(Token = "0x400147F")]
		[FieldOffset(Offset = "0x108")]
		private int m_Metrics;

		// Token: 0x04001480 RID: 5248
		[Token(Token = "0x4001480")]
		[FieldOffset(Offset = "0x10C")]
		private int m_Params1;

		// Token: 0x04001481 RID: 5249
		[Token(Token = "0x4001481")]
		[FieldOffset(Offset = "0x110")]
		private int m_Params2;

		// Token: 0x04001482 RID: 5250
		[Token(Token = "0x4001482")]
		[FieldOffset(Offset = "0x114")]
		private int m_Params3;

		// Token: 0x04001483 RID: 5251
		[Token(Token = "0x4001483")]
		[FieldOffset(Offset = "0x118")]
		private int m_ReprojectionMatrix;

		// Token: 0x04001484 RID: 5252
		[Token(Token = "0x4001484")]
		[FieldOffset(Offset = "0x11C")]
		private int m_SubsampleIndices;

		// Token: 0x04001485 RID: 5253
		[Token(Token = "0x4001485")]
		[FieldOffset(Offset = "0x120")]
		private int m_BlendTex;

		// Token: 0x04001486 RID: 5254
		[Token(Token = "0x4001486")]
		[FieldOffset(Offset = "0x124")]
		private int m_AccumulationTex;

		// Token: 0x02000318 RID: 792
		[Token(Token = "0x2000318")]
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
			// Token: 0x060014BC RID: 5308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014BC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SettingsGroup()
			{
			}
		}

		// Token: 0x02000319 RID: 793
		[Token(Token = "0x2000319")]
		[AttributeUsage(AttributeTargets.Field)]
		public class TopLevelSettings : Attribute
		{
			// Token: 0x060014BD RID: 5309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014BD")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public TopLevelSettings()
			{
			}
		}

		// Token: 0x0200031A RID: 794
		[Token(Token = "0x200031A")]
		[AttributeUsage(AttributeTargets.Field)]
		public class ExperimentalGroup : Attribute
		{
			// Token: 0x060014BE RID: 5310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014BE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ExperimentalGroup()
			{
			}
		}

		// Token: 0x0200031B RID: 795
		[Token(Token = "0x200031B")]
		public enum DebugPass
		{
			// Token: 0x04001488 RID: 5256
			[Token(Token = "0x4001488")]
			Off,
			// Token: 0x04001489 RID: 5257
			[Token(Token = "0x4001489")]
			Edges,
			// Token: 0x0400148A RID: 5258
			[Token(Token = "0x400148A")]
			Weights,
			// Token: 0x0400148B RID: 5259
			[Token(Token = "0x400148B")]
			Accumulation
		}

		// Token: 0x0200031C RID: 796
		[Token(Token = "0x200031C")]
		public enum QualityPreset
		{
			// Token: 0x0400148D RID: 5261
			[Token(Token = "0x400148D")]
			Low,
			// Token: 0x0400148E RID: 5262
			[Token(Token = "0x400148E")]
			Medium,
			// Token: 0x0400148F RID: 5263
			[Token(Token = "0x400148F")]
			High,
			// Token: 0x04001490 RID: 5264
			[Token(Token = "0x4001490")]
			Ultra,
			// Token: 0x04001491 RID: 5265
			[Token(Token = "0x4001491")]
			Custom
		}

		// Token: 0x0200031D RID: 797
		[Token(Token = "0x200031D")]
		public enum EdgeDetectionMethod
		{
			// Token: 0x04001493 RID: 5267
			[Token(Token = "0x4001493")]
			Luma = 1,
			// Token: 0x04001494 RID: 5268
			[Token(Token = "0x4001494")]
			Color,
			// Token: 0x04001495 RID: 5269
			[Token(Token = "0x4001495")]
			Depth
		}

		// Token: 0x0200031E RID: 798
		[Token(Token = "0x200031E")]
		[Serializable]
		public struct GlobalSettings
		{
			// Token: 0x170002E3 RID: 739
			// (get) Token: 0x060014BF RID: 5311 RVA: 0x00006C78 File Offset: 0x00004E78
			[Token(Token = "0x170002E3")]
			public static SMAA.GlobalSettings defaultSettings
			{
				[Token(Token = "0x60014BF")]
				[Address(RVA = "0x325EC60", Offset = "0x325D260", VA = "0x18325EC60")]
				get
				{
					return default(SMAA.GlobalSettings);
				}
			}

			// Token: 0x04001496 RID: 5270
			[Token(Token = "0x4001496")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Use this to fine tune your settings when working in Custom quality mode. \"Accumulation\" only works when \"Temporal Filtering\" is enabled.")]
			public SMAA.DebugPass debugPass;

			// Token: 0x04001497 RID: 5271
			[Token(Token = "0x4001497")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Low: 60% of the quality.\nMedium: 80% of the quality.\nHigh: 95% of the quality.\nUltra: 99% of the quality (overkill).")]
			public SMAA.QualityPreset quality;

			// Token: 0x04001498 RID: 5272
			[Token(Token = "0x4001498")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("You've three edge detection methods to choose from: luma, color or depth.\nThey represent different quality/performance and anti-aliasing/sharpness tradeoffs, so our recommendation is for you to choose the one that best suits your particular scenario:\n\n- Depth edge detection is usually the fastest but it may miss some edges.\n- Luma edge detection is usually more expensive than depth edge detection, but catches visible edges that depth edge detection can miss.\n- Color edge detection is usually the most expensive one but catches chroma-only edges.")]
			public SMAA.EdgeDetectionMethod edgeDetectionMethod;
		}

		// Token: 0x0200031F RID: 799
		[Token(Token = "0x200031F")]
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x04001499 RID: 5273
			[Token(Token = "0x4001499")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Enables/Disables diagonal processing.")]
			public bool diagonalDetection;

			// Token: 0x0400149A RID: 5274
			[Token(Token = "0x400149A")]
			[FieldOffset(Offset = "0x1")]
			[Tooltip("Enables/Disables corner detection. Leave this on to avoid blurry corners.")]
			public bool cornerDetection;

			// Token: 0x0400149B RID: 5275
			[Token(Token = "0x400149B")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Specifies the threshold or sensitivity to edges. Lowering this value you will be able to detect more edges at the expense of performance.\n0.1 is a reasonable value, and allows to catch most visible edges. 0.05 is a rather overkill value, that allows to catch 'em all.")]
			[Range(0f, 0.5f)]
			public float threshold;

			// Token: 0x0400149C RID: 5276
			[Token(Token = "0x400149C")]
			[FieldOffset(Offset = "0x8")]
			[Min(0.0001f)]
			[Tooltip("Specifies the threshold for depth edge detection. Lowering this value you will be able to detect more edges at the expense of performance.")]
			public float depthThreshold;

			// Token: 0x0400149D RID: 5277
			[Token(Token = "0x400149D")]
			[FieldOffset(Offset = "0xC")]
			[Range(0f, 112f)]
			[Tooltip("Specifies the maximum steps performed in the horizontal/vertical pattern searches, at each side of the pixel.\nIn number of pixels, it's actually the double. So the maximum line length perfectly handled by, for example 16, is 64 (by perfectly, we meant that longer lines won't look as good, but still antialiased).")]
			public int maxSearchSteps;

			// Token: 0x0400149E RID: 5278
			[Token(Token = "0x400149E")]
			[FieldOffset(Offset = "0x10")]
			[Range(0f, 20f)]
			[Tooltip("Specifies the maximum steps performed in the diagonal pattern searches, at each side of the pixel. In this case we jump one pixel at time, instead of two.\nOn high-end machines it is cheap (between a 0.8x and 0.9x slower for 16 steps), but it can have a significant impact on older machines.")]
			public int maxDiagonalSearchSteps;

			// Token: 0x0400149F RID: 5279
			[Token(Token = "0x400149F")]
			[FieldOffset(Offset = "0x14")]
			[Range(0f, 100f)]
			[Tooltip("Specifies how much sharp corners will be rounded.")]
			public int cornerRounding;

			// Token: 0x040014A0 RID: 5280
			[Token(Token = "0x40014A0")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("If there is an neighbor edge that has a local contrast factor times bigger contrast than current edge, current edge will be discarded.\nThis allows to eliminate spurious crossing edges, and is based on the fact that, if there is too much contrast in a direction, that will hide perceptually contrast in the other neighbors.")]
			[Min(0f)]
			public float localContrastAdaptationFactor;

			// Token: 0x040014A1 RID: 5281
			[Token(Token = "0x40014A1")]
			[FieldOffset(Offset = "0x0")]
			public static SMAA.QualitySettings[] presetQualitySettings;
		}

		// Token: 0x02000320 RID: 800
		[Token(Token = "0x2000320")]
		[Serializable]
		public struct TemporalSettings
		{
			// Token: 0x060014C1 RID: 5313 RVA: 0x00006C90 File Offset: 0x00004E90
			[Token(Token = "0x60014C1")]
			[Address(RVA = "0xF9A560", Offset = "0xF98B60", VA = "0x180F9A560")]
			public bool UseTemporal()
			{
				return default(bool);
			}

			// Token: 0x170002E4 RID: 740
			// (get) Token: 0x060014C2 RID: 5314 RVA: 0x00006CA8 File Offset: 0x00004EA8
			[Token(Token = "0x170002E4")]
			public static SMAA.TemporalSettings defaultSettings
			{
				[Token(Token = "0x60014C2")]
				[Address(RVA = "0x325EE50", Offset = "0x325D450", VA = "0x18325EE50")]
				get
				{
					return default(SMAA.TemporalSettings);
				}
			}

			// Token: 0x040014A2 RID: 5282
			[Token(Token = "0x40014A2")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Temporal filtering makes it possible for the SMAA algorithm to benefit from minute subpixel information available that has been accumulated over many frames.")]
			public bool enabled;

			// Token: 0x040014A3 RID: 5283
			[Token(Token = "0x40014A3")]
			[FieldOffset(Offset = "0x4")]
			[Range(0.5f, 10f)]
			[Tooltip("The size of the fuzz-displacement (jitter) in pixels applied to the camera's perspective projection matrix.\nUsed for 2x temporal anti-aliasing.")]
			public float fuzzSize;
		}

		// Token: 0x02000321 RID: 801
		[Token(Token = "0x2000321")]
		[Serializable]
		public struct PredicationSettings
		{
			// Token: 0x170002E5 RID: 741
			// (get) Token: 0x060014C3 RID: 5315 RVA: 0x00006CC0 File Offset: 0x00004EC0
			[Token(Token = "0x170002E5")]
			public static SMAA.PredicationSettings defaultSettings
			{
				[Token(Token = "0x60014C3")]
				[Address(RVA = "0x325EE70", Offset = "0x325D470", VA = "0x18325EE70")]
				get
				{
					return default(SMAA.PredicationSettings);
				}
			}

			// Token: 0x040014A4 RID: 5284
			[Token(Token = "0x40014A4")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Predicated thresholding allows to better preserve texture details and to improve performance, by decreasing the number of detected edges using an additional buffer (the detph buffer).\nIt locally decreases the luma or color threshold if an edge is found in an additional buffer (so the global threshold can be higher).")]
			public bool enabled;

			// Token: 0x040014A5 RID: 5285
			[Token(Token = "0x40014A5")]
			[FieldOffset(Offset = "0x4")]
			[Min(0.0001f)]
			[Tooltip("Threshold to be used in the additional predication buffer.")]
			public float threshold;

			// Token: 0x040014A6 RID: 5286
			[Token(Token = "0x40014A6")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("How much to scale the global threshold used for luma or color edge detection when using predication.")]
			[Range(1f, 5f)]
			public float scale;

			// Token: 0x040014A7 RID: 5287
			[Token(Token = "0x40014A7")]
			[FieldOffset(Offset = "0xC")]
			[Range(0f, 1f)]
			[Tooltip("How much to locally decrease the threshold.")]
			public float strength;
		}
	}
}
