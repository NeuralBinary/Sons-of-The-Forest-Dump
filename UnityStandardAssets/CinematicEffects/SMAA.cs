using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000325 RID: 805
	[Token(Token = "0x2000325")]
	[Serializable]
	public class SMAA : IAntiAliasing
	{
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D7")]
		public Shader shader
		{
			[Token(Token = "0x6001485")]
			[Address(RVA = "0x2CB7790", Offset = "0x2CB6790", VA = "0x182CB7790")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D8")]
		private Texture2D areaTexture
		{
			[Token(Token = "0x6001486")]
			[Address(RVA = "0x2CB7590", Offset = "0x2CB6590", VA = "0x182CB7590")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D9")]
		private Texture2D searchTexture
		{
			[Token(Token = "0x6001487")]
			[Address(RVA = "0x2CB76E0", Offset = "0x2CB66E0", VA = "0x182CB76E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DA")]
		private Material material
		{
			[Token(Token = "0x6001488")]
			[Address(RVA = "0x2CB7640", Offset = "0x2CB6640", VA = "0x182CB7640")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x2CB6270", Offset = "0x2CB5270", VA = "0x182CB6270", Slot = "4")]
		public void Awake()
		{
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x2CB64E0", Offset = "0x2CB54E0", VA = "0x182CB64E0", Slot = "5")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x2CB63D0", Offset = "0x2CB53D0", VA = "0x182CB63D0", Slot = "6")]
		public void OnDisable()
		{
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x2CB6560", Offset = "0x2CB5560", VA = "0x182CB6560", Slot = "7")]
		public void OnPreCull(Camera camera)
		{
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x2CB6530", Offset = "0x2CB5530", VA = "0x182CB6530", Slot = "8")]
		public void OnPostRender(Camera camera)
		{
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x2CB6790", Offset = "0x2CB5790", VA = "0x182CB6790", Slot = "9")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x2CB7440", Offset = "0x2CB6440", VA = "0x182CB7440")]
		private RenderTexture TempRT(int width, int height, RenderTextureFormat format)
		{
			return null;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x2CB7470", Offset = "0x2CB6470", VA = "0x182CB7470")]
		public SMAA()
		{
		}

		// Token: 0x04001453 RID: 5203
		[Token(Token = "0x4001453")]
		[FieldOffset(Offset = "0x10")]
		[SMAA.TopLevelSettings]
		public SMAA.GlobalSettings settings;

		// Token: 0x04001454 RID: 5204
		[Token(Token = "0x4001454")]
		[FieldOffset(Offset = "0x1C")]
		[SMAA.SettingsGroup]
		public SMAA.QualitySettings quality;

		// Token: 0x04001455 RID: 5205
		[Token(Token = "0x4001455")]
		[FieldOffset(Offset = "0x38")]
		[SMAA.SettingsGroup]
		public SMAA.PredicationSettings predication;

		// Token: 0x04001456 RID: 5206
		[Token(Token = "0x4001456")]
		[FieldOffset(Offset = "0x48")]
		[SMAA.ExperimentalGroup]
		[SMAA.SettingsGroup]
		public SMAA.TemporalSettings temporal;

		// Token: 0x04001457 RID: 5207
		[Token(Token = "0x4001457")]
		[FieldOffset(Offset = "0x50")]
		private Matrix4x4 m_ProjectionMatrix;

		// Token: 0x04001458 RID: 5208
		[Token(Token = "0x4001458")]
		[FieldOffset(Offset = "0x90")]
		private Matrix4x4 m_PreviousViewProjectionMatrix;

		// Token: 0x04001459 RID: 5209
		[Token(Token = "0x4001459")]
		[FieldOffset(Offset = "0xD0")]
		private float m_FlipFlop;

		// Token: 0x0400145A RID: 5210
		[Token(Token = "0x400145A")]
		[FieldOffset(Offset = "0xD8")]
		private RenderTexture m_Accumulation;

		// Token: 0x0400145B RID: 5211
		[Token(Token = "0x400145B")]
		[FieldOffset(Offset = "0xE0")]
		private Shader m_Shader;

		// Token: 0x0400145C RID: 5212
		[Token(Token = "0x400145C")]
		[FieldOffset(Offset = "0xE8")]
		private Texture2D m_AreaTexture;

		// Token: 0x0400145D RID: 5213
		[Token(Token = "0x400145D")]
		[FieldOffset(Offset = "0xF0")]
		private Texture2D m_SearchTexture;

		// Token: 0x0400145E RID: 5214
		[Token(Token = "0x400145E")]
		[FieldOffset(Offset = "0xF8")]
		private Material m_Material;

		// Token: 0x0400145F RID: 5215
		[Token(Token = "0x400145F")]
		[FieldOffset(Offset = "0x100")]
		private int m_AreaTex;

		// Token: 0x04001460 RID: 5216
		[Token(Token = "0x4001460")]
		[FieldOffset(Offset = "0x104")]
		private int m_SearchTex;

		// Token: 0x04001461 RID: 5217
		[Token(Token = "0x4001461")]
		[FieldOffset(Offset = "0x108")]
		private int m_Metrics;

		// Token: 0x04001462 RID: 5218
		[Token(Token = "0x4001462")]
		[FieldOffset(Offset = "0x10C")]
		private int m_Params1;

		// Token: 0x04001463 RID: 5219
		[Token(Token = "0x4001463")]
		[FieldOffset(Offset = "0x110")]
		private int m_Params2;

		// Token: 0x04001464 RID: 5220
		[Token(Token = "0x4001464")]
		[FieldOffset(Offset = "0x114")]
		private int m_Params3;

		// Token: 0x04001465 RID: 5221
		[Token(Token = "0x4001465")]
		[FieldOffset(Offset = "0x118")]
		private int m_ReprojectionMatrix;

		// Token: 0x04001466 RID: 5222
		[Token(Token = "0x4001466")]
		[FieldOffset(Offset = "0x11C")]
		private int m_SubsampleIndices;

		// Token: 0x04001467 RID: 5223
		[Token(Token = "0x4001467")]
		[FieldOffset(Offset = "0x120")]
		private int m_BlendTex;

		// Token: 0x04001468 RID: 5224
		[Token(Token = "0x4001468")]
		[FieldOffset(Offset = "0x124")]
		private int m_AccumulationTex;

		// Token: 0x02000326 RID: 806
		[Token(Token = "0x2000326")]
		[AttributeUsage(256)]
		public class SettingsGroup : Attribute
		{
			// Token: 0x06001491 RID: 5265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001491")]
			[Address(RVA = "0x54C690", Offset = "0x54B690", VA = "0x18054C690")]
			public SettingsGroup()
			{
			}
		}

		// Token: 0x02000327 RID: 807
		[Token(Token = "0x2000327")]
		[AttributeUsage(256)]
		public class TopLevelSettings : Attribute
		{
			// Token: 0x06001492 RID: 5266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001492")]
			[Address(RVA = "0x54C690", Offset = "0x54B690", VA = "0x18054C690")]
			public TopLevelSettings()
			{
			}
		}

		// Token: 0x02000328 RID: 808
		[Token(Token = "0x2000328")]
		[AttributeUsage(256)]
		public class ExperimentalGroup : Attribute
		{
			// Token: 0x06001493 RID: 5267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001493")]
			[Address(RVA = "0x54C690", Offset = "0x54B690", VA = "0x18054C690")]
			public ExperimentalGroup()
			{
			}
		}

		// Token: 0x02000329 RID: 809
		[Token(Token = "0x2000329")]
		public enum DebugPass
		{
			// Token: 0x0400146A RID: 5226
			[Token(Token = "0x400146A")]
			Off,
			// Token: 0x0400146B RID: 5227
			[Token(Token = "0x400146B")]
			Edges,
			// Token: 0x0400146C RID: 5228
			[Token(Token = "0x400146C")]
			Weights,
			// Token: 0x0400146D RID: 5229
			[Token(Token = "0x400146D")]
			Accumulation
		}

		// Token: 0x0200032A RID: 810
		[Token(Token = "0x200032A")]
		public enum QualityPreset
		{
			// Token: 0x0400146F RID: 5231
			[Token(Token = "0x400146F")]
			Low,
			// Token: 0x04001470 RID: 5232
			[Token(Token = "0x4001470")]
			Medium,
			// Token: 0x04001471 RID: 5233
			[Token(Token = "0x4001471")]
			High,
			// Token: 0x04001472 RID: 5234
			[Token(Token = "0x4001472")]
			Ultra,
			// Token: 0x04001473 RID: 5235
			[Token(Token = "0x4001473")]
			Custom
		}

		// Token: 0x0200032B RID: 811
		[Token(Token = "0x200032B")]
		public enum EdgeDetectionMethod
		{
			// Token: 0x04001475 RID: 5237
			[Token(Token = "0x4001475")]
			Luma = 1,
			// Token: 0x04001476 RID: 5238
			[Token(Token = "0x4001476")]
			Color,
			// Token: 0x04001477 RID: 5239
			[Token(Token = "0x4001477")]
			Depth
		}

		// Token: 0x0200032C RID: 812
		[Token(Token = "0x200032C")]
		[Serializable]
		public struct GlobalSettings
		{
			// Token: 0x170002DB RID: 731
			// (get) Token: 0x06001494 RID: 5268 RVA: 0x00006A38 File Offset: 0x00004C38
			[Token(Token = "0x170002DB")]
			public static SMAA.GlobalSettings defaultSettings
			{
				[Token(Token = "0x6001494")]
				[Address(RVA = "0x2CB2A00", Offset = "0x2CB1A00", VA = "0x182CB2A00")]
				get
				{
					return default(SMAA.GlobalSettings);
				}
			}

			// Token: 0x04001478 RID: 5240
			[Token(Token = "0x4001478")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Use this to fine tune your settings when working in Custom quality mode. \"Accumulation\" only works when \"Temporal Filtering\" is enabled.")]
			public SMAA.DebugPass debugPass;

			// Token: 0x04001479 RID: 5241
			[Token(Token = "0x4001479")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Low: 60% of the quality.\nMedium: 80% of the quality.\nHigh: 95% of the quality.\nUltra: 99% of the quality (overkill).")]
			public SMAA.QualityPreset quality;

			// Token: 0x0400147A RID: 5242
			[Token(Token = "0x400147A")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("You've three edge detection methods to choose from: luma, color or depth.\nThey represent different quality/performance and anti-aliasing/sharpness tradeoffs, so our recommendation is for you to choose the one that best suits your particular scenario:\n\n- Depth edge detection is usually the fastest but it may miss some edges.\n- Luma edge detection is usually more expensive than depth edge detection, but catches visible edges that depth edge detection can miss.\n- Color edge detection is usually the most expensive one but catches chroma-only edges.")]
			public SMAA.EdgeDetectionMethod edgeDetectionMethod;
		}

		// Token: 0x0200032D RID: 813
		[Token(Token = "0x200032D")]
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x0400147B RID: 5243
			[Token(Token = "0x400147B")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Enables/Disables diagonal processing.")]
			public bool diagonalDetection;

			// Token: 0x0400147C RID: 5244
			[Token(Token = "0x400147C")]
			[FieldOffset(Offset = "0x1")]
			[Tooltip("Enables/Disables corner detection. Leave this on to avoid blurry corners.")]
			public bool cornerDetection;

			// Token: 0x0400147D RID: 5245
			[Token(Token = "0x400147D")]
			[FieldOffset(Offset = "0x4")]
			[Range(0f, 0.5f)]
			[Tooltip("Specifies the threshold or sensitivity to edges. Lowering this value you will be able to detect more edges at the expense of performance.\n0.1 is a reasonable value, and allows to catch most visible edges. 0.05 is a rather overkill value, that allows to catch 'em all.")]
			public float threshold;

			// Token: 0x0400147E RID: 5246
			[Token(Token = "0x400147E")]
			[FieldOffset(Offset = "0x8")]
			[Min(0.0001f)]
			[Tooltip("Specifies the threshold for depth edge detection. Lowering this value you will be able to detect more edges at the expense of performance.")]
			public float depthThreshold;

			// Token: 0x0400147F RID: 5247
			[Token(Token = "0x400147F")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Specifies the maximum steps performed in the horizontal/vertical pattern searches, at each side of the pixel.\nIn number of pixels, it's actually the double. So the maximum line length perfectly handled by, for example 16, is 64 (by perfectly, we meant that longer lines won't look as good, but still antialiased).")]
			[Range(0f, 112f)]
			public int maxSearchSteps;

			// Token: 0x04001480 RID: 5248
			[Token(Token = "0x4001480")]
			[FieldOffset(Offset = "0x10")]
			[Range(0f, 20f)]
			[Tooltip("Specifies the maximum steps performed in the diagonal pattern searches, at each side of the pixel. In this case we jump one pixel at time, instead of two.\nOn high-end machines it is cheap (between a 0.8x and 0.9x slower for 16 steps), but it can have a significant impact on older machines.")]
			public int maxDiagonalSearchSteps;

			// Token: 0x04001481 RID: 5249
			[Token(Token = "0x4001481")]
			[FieldOffset(Offset = "0x14")]
			[Range(0f, 100f)]
			[Tooltip("Specifies how much sharp corners will be rounded.")]
			public int cornerRounding;

			// Token: 0x04001482 RID: 5250
			[Token(Token = "0x4001482")]
			[FieldOffset(Offset = "0x18")]
			[Min(0f)]
			[Tooltip("If there is an neighbor edge that has a local contrast factor times bigger contrast than current edge, current edge will be discarded.\nThis allows to eliminate spurious crossing edges, and is based on the fact that, if there is too much contrast in a direction, that will hide perceptually contrast in the other neighbors.")]
			public float localContrastAdaptationFactor;

			// Token: 0x04001483 RID: 5251
			[Token(Token = "0x4001483")]
			[FieldOffset(Offset = "0x0")]
			public static SMAA.QualitySettings[] presetQualitySettings;
		}

		// Token: 0x0200032E RID: 814
		[Token(Token = "0x200032E")]
		[Serializable]
		public struct TemporalSettings
		{
			// Token: 0x06001496 RID: 5270 RVA: 0x00006A50 File Offset: 0x00004C50
			[Token(Token = "0x6001496")]
			[Address(RVA = "0xDB3230", Offset = "0xDB2230", VA = "0x180DB3230")]
			public bool UseTemporal()
			{
				return default(bool);
			}

			// Token: 0x170002DC RID: 732
			// (get) Token: 0x06001497 RID: 5271 RVA: 0x00006A68 File Offset: 0x00004C68
			[Token(Token = "0x170002DC")]
			public static SMAA.TemporalSettings defaultSettings
			{
				[Token(Token = "0x6001497")]
				[Address(RVA = "0x2CB8A60", Offset = "0x2CB7A60", VA = "0x182CB8A60")]
				get
				{
					return default(SMAA.TemporalSettings);
				}
			}

			// Token: 0x04001484 RID: 5252
			[Token(Token = "0x4001484")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Temporal filtering makes it possible for the SMAA algorithm to benefit from minute subpixel information available that has been accumulated over many frames.")]
			public bool enabled;

			// Token: 0x04001485 RID: 5253
			[Token(Token = "0x4001485")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("The size of the fuzz-displacement (jitter) in pixels applied to the camera's perspective projection matrix.\nUsed for 2x temporal anti-aliasing.")]
			[Range(0.5f, 10f)]
			public float fuzzSize;
		}

		// Token: 0x0200032F RID: 815
		[Token(Token = "0x200032F")]
		[Serializable]
		public struct PredicationSettings
		{
			// Token: 0x170002DD RID: 733
			// (get) Token: 0x06001498 RID: 5272 RVA: 0x00006A80 File Offset: 0x00004C80
			[Token(Token = "0x170002DD")]
			public static SMAA.PredicationSettings defaultSettings
			{
				[Token(Token = "0x6001498")]
				[Address(RVA = "0x2CB57F0", Offset = "0x2CB47F0", VA = "0x182CB57F0")]
				get
				{
					return default(SMAA.PredicationSettings);
				}
			}

			// Token: 0x04001486 RID: 5254
			[Token(Token = "0x4001486")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Predicated thresholding allows to better preserve texture details and to improve performance, by decreasing the number of detected edges using an additional buffer (the detph buffer).\nIt locally decreases the luma or color threshold if an edge is found in an additional buffer (so the global threshold can be higher).")]
			public bool enabled;

			// Token: 0x04001487 RID: 5255
			[Token(Token = "0x4001487")]
			[FieldOffset(Offset = "0x4")]
			[Min(0.0001f)]
			[Tooltip("Threshold to be used in the additional predication buffer.")]
			public float threshold;

			// Token: 0x04001488 RID: 5256
			[Token(Token = "0x4001488")]
			[FieldOffset(Offset = "0x8")]
			[Range(1f, 5f)]
			[Tooltip("How much to scale the global threshold used for luma or color edge detection when using predication.")]
			public float scale;

			// Token: 0x04001489 RID: 5257
			[Token(Token = "0x4001489")]
			[FieldOffset(Offset = "0xC")]
			[Range(0f, 1f)]
			[Tooltip("How much to locally decrease the threshold.")]
			public float strength;
		}
	}
}
