using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000332 RID: 818
	[Token(Token = "0x2000332")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Depth Of Field")]
	[ExecuteInEditMode]
	public class DepthOfField : MonoBehaviour
	{
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DF")]
		public Shader filmicDepthOfFieldShader
		{
			[Token(Token = "0x60014A0")]
			[Address(RVA = "0x2CB1EB0", Offset = "0x2CB0EB0", VA = "0x182CB1EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E0")]
		public Shader medianFilterShader
		{
			[Token(Token = "0x60014A1")]
			[Address(RVA = "0x2CB1FE0", Offset = "0x2CB0FE0", VA = "0x182CB1FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E1")]
		public Shader textureBokehShader
		{
			[Token(Token = "0x60014A2")]
			[Address(RVA = "0x2CB21D0", Offset = "0x2CB11D0", VA = "0x182CB21D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E2")]
		public Material filmicDepthOfFieldMaterial
		{
			[Token(Token = "0x60014A3")]
			[Address(RVA = "0x2CB1E10", Offset = "0x2CB0E10", VA = "0x182CB1E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E3")]
		public Material medianFilterMaterial
		{
			[Token(Token = "0x60014A4")]
			[Address(RVA = "0x2CB1F40", Offset = "0x2CB0F40", VA = "0x182CB1F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E4")]
		public Material textureBokehMaterial
		{
			[Token(Token = "0x60014A5")]
			[Address(RVA = "0x2CB2130", Offset = "0x2CB1130", VA = "0x182CB2130")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E5")]
		public ComputeBuffer computeBufferDrawArgs
		{
			[Token(Token = "0x60014A6")]
			[Address(RVA = "0x2CB1C90", Offset = "0x2CB0C90", VA = "0x182CB1C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E6")]
		public ComputeBuffer computeBufferPoints
		{
			[Token(Token = "0x60014A7")]
			[Address(RVA = "0x2CB1D80", Offset = "0x2CB0D80", VA = "0x182CB1D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x2CAF4C0", Offset = "0x2CAE4C0", VA = "0x182CAF4C0")]
		private void Awake()
		{
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x2CB1790", Offset = "0x2CB0790", VA = "0x182CB1790")]
		private void OnEnable()
		{
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x2CB1590", Offset = "0x2CB0590", VA = "0x182CB1590")]
		private void OnDisable()
		{
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x2CB18B0", Offset = "0x2CB08B0", VA = "0x182CB18B0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x2CAFE40", Offset = "0x2CAEE40", VA = "0x182CAFE40")]
		private void DoDepthOfField(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x2CB0D80", Offset = "0x2CAFD80", VA = "0x182CB0D80")]
		private void DoHexagonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x2CB10F0", Offset = "0x2CB00F0", VA = "0x182CB10F0")]
		private void DoOctogonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x2CAFD00", Offset = "0x2CAED00", VA = "0x182CAFD00")]
		private void DoCircularBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x2CAF940", Offset = "0x2CAE940", VA = "0x182CAF940")]
		private void ComputeCocParameters(out Vector4 blurParams, out Vector4 blurCoe)
		{
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x2CB1AA0", Offset = "0x2CB0AA0", VA = "0x182CB1AA0")]
		private void ReleaseComputeResources()
		{
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x2CAF650", Offset = "0x2CAE650", VA = "0x182CAF650")]
		private void ComputeBlurDirections(bool force)
		{
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[Token(Token = "0x170002E7")]
		private bool shouldPerformBokeh
		{
			[Token(Token = "0x60014B3")]
			[Address(RVA = "0x2CB2080", Offset = "0x2CB1080", VA = "0x182CB2080")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x2CB1B10", Offset = "0x2CB0B10", VA = "0x182CB1B10")]
		private static void Rotate2D(ref Vector4 direction, float cosinus, float sinus)
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0xBE79F0", Offset = "0xBE69F0", VA = "0x180BE79F0")]
		private static void SwapRenderTexture(ref RenderTexture src, ref RenderTexture dst)
		{
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x2CB14A0", Offset = "0x2CB04A0", VA = "0x182CB14A0")]
		private static void GetDirectionalBlurPassesFromRadius(RenderTexture blurredFgCoc, float maxRadius, out int blurPass, out int blurAndMergePass)
		{
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x2CB1B50", Offset = "0x2CB0B50", VA = "0x182CB1B50")]
		public DepthOfField()
		{
		}

		// Token: 0x0400148B RID: 5259
		[Token(Token = "0x400148B")]
		private const float kMaxBlur = 40f;

		// Token: 0x0400148C RID: 5260
		[Token(Token = "0x400148C")]
		[FieldOffset(Offset = "0x20")]
		public DepthOfField.GlobalSettings settings;

		// Token: 0x0400148D RID: 5261
		[Token(Token = "0x400148D")]
		[FieldOffset(Offset = "0x38")]
		public DepthOfField.FocusSettings focus;

		// Token: 0x0400148E RID: 5262
		[Token(Token = "0x400148E")]
		[FieldOffset(Offset = "0x60")]
		public DepthOfField.BokehTextureSettings bokehTexture;

		// Token: 0x0400148F RID: 5263
		[Token(Token = "0x400148F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Shader m_FilmicDepthOfFieldShader;

		// Token: 0x04001490 RID: 5264
		[Token(Token = "0x4001490")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Shader m_MedianFilterShader;

		// Token: 0x04001491 RID: 5265
		[Token(Token = "0x4001491")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Shader m_TextureBokehShader;

		// Token: 0x04001492 RID: 5266
		[Token(Token = "0x4001492")]
		[FieldOffset(Offset = "0x90")]
		private RenderTextureUtility m_RTU;

		// Token: 0x04001493 RID: 5267
		[Token(Token = "0x4001493")]
		[FieldOffset(Offset = "0x98")]
		private Material m_FilmicDepthOfFieldMaterial;

		// Token: 0x04001494 RID: 5268
		[Token(Token = "0x4001494")]
		[FieldOffset(Offset = "0xA0")]
		private Material m_MedianFilterMaterial;

		// Token: 0x04001495 RID: 5269
		[Token(Token = "0x4001495")]
		[FieldOffset(Offset = "0xA8")]
		private Material m_TextureBokehMaterial;

		// Token: 0x04001496 RID: 5270
		[Token(Token = "0x4001496")]
		[FieldOffset(Offset = "0xB0")]
		private ComputeBuffer m_ComputeBufferDrawArgs;

		// Token: 0x04001497 RID: 5271
		[Token(Token = "0x4001497")]
		[FieldOffset(Offset = "0xB8")]
		private ComputeBuffer m_ComputeBufferPoints;

		// Token: 0x04001498 RID: 5272
		[Token(Token = "0x4001498")]
		[FieldOffset(Offset = "0xC0")]
		private DepthOfField.QualitySettings m_CurrentQualitySettings;

		// Token: 0x04001499 RID: 5273
		[Token(Token = "0x4001499")]
		[FieldOffset(Offset = "0xCC")]
		private float m_LastApertureOrientation;

		// Token: 0x0400149A RID: 5274
		[Token(Token = "0x400149A")]
		[FieldOffset(Offset = "0xD0")]
		private Vector4 m_OctogonalBokehDirection1;

		// Token: 0x0400149B RID: 5275
		[Token(Token = "0x400149B")]
		[FieldOffset(Offset = "0xE0")]
		private Vector4 m_OctogonalBokehDirection2;

		// Token: 0x0400149C RID: 5276
		[Token(Token = "0x400149C")]
		[FieldOffset(Offset = "0xF0")]
		private Vector4 m_OctogonalBokehDirection3;

		// Token: 0x0400149D RID: 5277
		[Token(Token = "0x400149D")]
		[FieldOffset(Offset = "0x100")]
		private Vector4 m_OctogonalBokehDirection4;

		// Token: 0x0400149E RID: 5278
		[Token(Token = "0x400149E")]
		[FieldOffset(Offset = "0x110")]
		private Vector4 m_HexagonalBokehDirection1;

		// Token: 0x0400149F RID: 5279
		[Token(Token = "0x400149F")]
		[FieldOffset(Offset = "0x120")]
		private Vector4 m_HexagonalBokehDirection2;

		// Token: 0x040014A0 RID: 5280
		[Token(Token = "0x40014A0")]
		[FieldOffset(Offset = "0x130")]
		private Vector4 m_HexagonalBokehDirection3;

		// Token: 0x040014A1 RID: 5281
		[Token(Token = "0x40014A1")]
		[FieldOffset(Offset = "0x140")]
		private int m_BlurParams;

		// Token: 0x040014A2 RID: 5282
		[Token(Token = "0x40014A2")]
		[FieldOffset(Offset = "0x144")]
		private int m_BlurCoe;

		// Token: 0x040014A3 RID: 5283
		[Token(Token = "0x40014A3")]
		[FieldOffset(Offset = "0x148")]
		private int m_Offsets;

		// Token: 0x040014A4 RID: 5284
		[Token(Token = "0x40014A4")]
		[FieldOffset(Offset = "0x14C")]
		private int m_BlurredColor;

		// Token: 0x040014A5 RID: 5285
		[Token(Token = "0x40014A5")]
		[FieldOffset(Offset = "0x150")]
		private int m_SpawnHeuristic;

		// Token: 0x040014A6 RID: 5286
		[Token(Token = "0x40014A6")]
		[FieldOffset(Offset = "0x154")]
		private int m_BokehParams;

		// Token: 0x040014A7 RID: 5287
		[Token(Token = "0x40014A7")]
		[FieldOffset(Offset = "0x158")]
		private int m_Convolved_TexelSize;

		// Token: 0x040014A8 RID: 5288
		[Token(Token = "0x40014A8")]
		[FieldOffset(Offset = "0x15C")]
		private int m_SecondTex;

		// Token: 0x040014A9 RID: 5289
		[Token(Token = "0x40014A9")]
		[FieldOffset(Offset = "0x160")]
		private int m_ThirdTex;

		// Token: 0x040014AA RID: 5290
		[Token(Token = "0x40014AA")]
		[FieldOffset(Offset = "0x164")]
		private int m_MainTex;

		// Token: 0x040014AB RID: 5291
		[Token(Token = "0x40014AB")]
		[FieldOffset(Offset = "0x168")]
		private int m_Screen;

		// Token: 0x02000333 RID: 819
		[Token(Token = "0x2000333")]
		private enum Passes
		{
			// Token: 0x040014AD RID: 5293
			[Token(Token = "0x40014AD")]
			BlurAlphaWeighted,
			// Token: 0x040014AE RID: 5294
			[Token(Token = "0x40014AE")]
			BoxBlur,
			// Token: 0x040014AF RID: 5295
			[Token(Token = "0x40014AF")]
			DilateFgCocFromColor,
			// Token: 0x040014B0 RID: 5296
			[Token(Token = "0x40014B0")]
			DilateFgCoc,
			// Token: 0x040014B1 RID: 5297
			[Token(Token = "0x40014B1")]
			CaptureCocExplicit,
			// Token: 0x040014B2 RID: 5298
			[Token(Token = "0x40014B2")]
			VisualizeCocExplicit,
			// Token: 0x040014B3 RID: 5299
			[Token(Token = "0x40014B3")]
			CocPrefilter,
			// Token: 0x040014B4 RID: 5300
			[Token(Token = "0x40014B4")]
			CircleBlur,
			// Token: 0x040014B5 RID: 5301
			[Token(Token = "0x40014B5")]
			CircleBlurWithDilatedFg,
			// Token: 0x040014B6 RID: 5302
			[Token(Token = "0x40014B6")]
			CircleBlurLowQuality,
			// Token: 0x040014B7 RID: 5303
			[Token(Token = "0x40014B7")]
			CircleBlowLowQualityWithDilatedFg,
			// Token: 0x040014B8 RID: 5304
			[Token(Token = "0x40014B8")]
			MergeExplicit,
			// Token: 0x040014B9 RID: 5305
			[Token(Token = "0x40014B9")]
			ShapeLowQuality,
			// Token: 0x040014BA RID: 5306
			[Token(Token = "0x40014BA")]
			ShapeLowQualityDilateFg,
			// Token: 0x040014BB RID: 5307
			[Token(Token = "0x40014BB")]
			ShapeLowQualityMerge,
			// Token: 0x040014BC RID: 5308
			[Token(Token = "0x40014BC")]
			ShapeLowQualityMergeDilateFg,
			// Token: 0x040014BD RID: 5309
			[Token(Token = "0x40014BD")]
			ShapeMediumQuality,
			// Token: 0x040014BE RID: 5310
			[Token(Token = "0x40014BE")]
			ShapeMediumQualityDilateFg,
			// Token: 0x040014BF RID: 5311
			[Token(Token = "0x40014BF")]
			ShapeMediumQualityMerge,
			// Token: 0x040014C0 RID: 5312
			[Token(Token = "0x40014C0")]
			ShapeMediumQualityMergeDilateFg,
			// Token: 0x040014C1 RID: 5313
			[Token(Token = "0x40014C1")]
			ShapeHighQuality,
			// Token: 0x040014C2 RID: 5314
			[Token(Token = "0x40014C2")]
			ShapeHighQualityDilateFg,
			// Token: 0x040014C3 RID: 5315
			[Token(Token = "0x40014C3")]
			ShapeHighQualityMerge,
			// Token: 0x040014C4 RID: 5316
			[Token(Token = "0x40014C4")]
			ShapeHighQualityMergeDilateFg
		}

		// Token: 0x02000334 RID: 820
		[Token(Token = "0x2000334")]
		private enum MedianPasses
		{
			// Token: 0x040014C6 RID: 5318
			[Token(Token = "0x40014C6")]
			Median3,
			// Token: 0x040014C7 RID: 5319
			[Token(Token = "0x40014C7")]
			Median3X3
		}

		// Token: 0x02000335 RID: 821
		[Token(Token = "0x2000335")]
		private enum BokehTexturesPasses
		{
			// Token: 0x040014C9 RID: 5321
			[Token(Token = "0x40014C9")]
			Apply,
			// Token: 0x040014CA RID: 5322
			[Token(Token = "0x40014CA")]
			Collect
		}

		// Token: 0x02000336 RID: 822
		[Token(Token = "0x2000336")]
		public enum TweakMode
		{
			// Token: 0x040014CC RID: 5324
			[Token(Token = "0x40014CC")]
			Range,
			// Token: 0x040014CD RID: 5325
			[Token(Token = "0x40014CD")]
			Explicit
		}

		// Token: 0x02000337 RID: 823
		[Token(Token = "0x2000337")]
		public enum ApertureShape
		{
			// Token: 0x040014CF RID: 5327
			[Token(Token = "0x40014CF")]
			Circular,
			// Token: 0x040014D0 RID: 5328
			[Token(Token = "0x40014D0")]
			Hexagonal,
			// Token: 0x040014D1 RID: 5329
			[Token(Token = "0x40014D1")]
			Octogonal
		}

		// Token: 0x02000338 RID: 824
		[Token(Token = "0x2000338")]
		public enum QualityPreset
		{
			// Token: 0x040014D3 RID: 5331
			[Token(Token = "0x40014D3")]
			Low,
			// Token: 0x040014D4 RID: 5332
			[Token(Token = "0x40014D4")]
			Medium,
			// Token: 0x040014D5 RID: 5333
			[Token(Token = "0x40014D5")]
			High
		}

		// Token: 0x02000339 RID: 825
		[Token(Token = "0x2000339")]
		public enum FilterQuality
		{
			// Token: 0x040014D7 RID: 5335
			[Token(Token = "0x40014D7")]
			None,
			// Token: 0x040014D8 RID: 5336
			[Token(Token = "0x40014D8")]
			Normal,
			// Token: 0x040014D9 RID: 5337
			[Token(Token = "0x40014D9")]
			High
		}

		// Token: 0x0200033A RID: 826
		[Token(Token = "0x200033A")]
		[Serializable]
		public struct GlobalSettings
		{
			// Token: 0x170002E8 RID: 744
			// (get) Token: 0x060014B8 RID: 5304 RVA: 0x00006AE0 File Offset: 0x00004CE0
			[Token(Token = "0x170002E8")]
			public static DepthOfField.GlobalSettings defaultSettings
			{
				[Token(Token = "0x60014B8")]
				[Address(RVA = "0x2CB2A20", Offset = "0x2CB1A20", VA = "0x182CB2A20")]
				get
				{
					return default(DepthOfField.GlobalSettings);
				}
			}

			// Token: 0x040014DA RID: 5338
			[Token(Token = "0x40014DA")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Allows to view where the blur will be applied. Yellow for near blur, blue for far blur.")]
			public bool visualizeFocus;

			// Token: 0x040014DB RID: 5339
			[Token(Token = "0x40014DB")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Setup mode. Use \"Advanced\" if you need more control on blur settings and/or want to use a bokeh texture. \"Explicit\" is the same as \"Advanced\" but makes use of \"Near Plane\" and \"Far Plane\" values instead of \"F-Stop\".")]
			public DepthOfField.TweakMode tweakMode;

			// Token: 0x040014DC RID: 5340
			[Token(Token = "0x40014DC")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Quality presets. Use \"Custom\" for more advanced settings.")]
			public DepthOfField.QualityPreset filteringQuality;

			// Token: 0x040014DD RID: 5341
			[Token(Token = "0x40014DD")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("\"Circular\" is the fastest, followed by \"Hexagonal\" and \"Octogonal\".")]
			public DepthOfField.ApertureShape apertureShape;

			// Token: 0x040014DE RID: 5342
			[Token(Token = "0x40014DE")]
			[FieldOffset(Offset = "0x10")]
			[Range(0f, 179f)]
			[Tooltip("Rotates the aperture when working with \"Hexagonal\" and \"Ortogonal\".")]
			public float apertureOrientation;
		}

		// Token: 0x0200033B RID: 827
		[Token(Token = "0x200033B")]
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x040014DF RID: 5343
			[Token(Token = "0x40014DF")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Enable this to get smooth bokeh.")]
			public bool prefilterBlur;

			// Token: 0x040014E0 RID: 5344
			[Token(Token = "0x40014E0")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Applies a median filter for even smoother bokeh.")]
			public DepthOfField.FilterQuality medianFilter;

			// Token: 0x040014E1 RID: 5345
			[Token(Token = "0x40014E1")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Dilates near blur over in focus area.")]
			public bool dilateNearBlur;

			// Token: 0x040014E2 RID: 5346
			[Token(Token = "0x40014E2")]
			[FieldOffset(Offset = "0x0")]
			public static DepthOfField.QualitySettings[] presetQualitySettings;
		}

		// Token: 0x0200033C RID: 828
		[Token(Token = "0x200033C")]
		[Serializable]
		public struct FocusSettings
		{
			// Token: 0x170002E9 RID: 745
			// (get) Token: 0x060014BA RID: 5306 RVA: 0x00006AF8 File Offset: 0x00004CF8
			[Token(Token = "0x170002E9")]
			public static DepthOfField.FocusSettings defaultSettings
			{
				[Token(Token = "0x60014BA")]
				[Address(RVA = "0x2CB2840", Offset = "0x2CB1840", VA = "0x182CB2840")]
				get
				{
					return default(DepthOfField.FocusSettings);
				}
			}

			// Token: 0x040014E3 RID: 5347
			[Token(Token = "0x40014E3")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Auto-focus on a selected transform.")]
			public Transform transform;

			// Token: 0x040014E4 RID: 5348
			[Token(Token = "0x40014E4")]
			[FieldOffset(Offset = "0x8")]
			[Min(0f)]
			[Tooltip("Focus distance (in world units).")]
			public float focusPlane;

			// Token: 0x040014E5 RID: 5349
			[Token(Token = "0x40014E5")]
			[FieldOffset(Offset = "0xC")]
			[Min(0.1f)]
			[Tooltip("Focus range (in world units). The focus plane is located in the center of the range.")]
			public float range;

			// Token: 0x040014E6 RID: 5350
			[Token(Token = "0x40014E6")]
			[FieldOffset(Offset = "0x10")]
			[Min(0f)]
			[Tooltip("Near focus distance (in world units).")]
			public float nearPlane;

			// Token: 0x040014E7 RID: 5351
			[Token(Token = "0x40014E7")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Near blur falloff (in world units).")]
			[Min(0f)]
			public float nearFalloff;

			// Token: 0x040014E8 RID: 5352
			[Token(Token = "0x40014E8")]
			[FieldOffset(Offset = "0x18")]
			[Min(0f)]
			[Tooltip("Far focus distance (in world units).")]
			public float farPlane;

			// Token: 0x040014E9 RID: 5353
			[Token(Token = "0x40014E9")]
			[FieldOffset(Offset = "0x1C")]
			[Min(0f)]
			[Tooltip("Far blur falloff (in world units).")]
			public float farFalloff;

			// Token: 0x040014EA RID: 5354
			[Token(Token = "0x40014EA")]
			[FieldOffset(Offset = "0x20")]
			[Range(0f, 40f)]
			[Tooltip("Maximum blur radius for the near plane.")]
			public float nearBlurRadius;

			// Token: 0x040014EB RID: 5355
			[Token(Token = "0x40014EB")]
			[FieldOffset(Offset = "0x24")]
			[Range(0f, 40f)]
			[Tooltip("Maximum blur radius for the far plane.")]
			public float farBlurRadius;
		}

		// Token: 0x0200033D RID: 829
		[Token(Token = "0x200033D")]
		[Serializable]
		public struct BokehTextureSettings
		{
			// Token: 0x170002EA RID: 746
			// (get) Token: 0x060014BB RID: 5307 RVA: 0x00006B10 File Offset: 0x00004D10
			[Token(Token = "0x170002EA")]
			public static DepthOfField.BokehTextureSettings defaultSettings
			{
				[Token(Token = "0x60014BB")]
				[Address(RVA = "0x2CADD20", Offset = "0x2CACD20", VA = "0x182CADD20")]
				get
				{
					return default(DepthOfField.BokehTextureSettings);
				}
			}

			// Token: 0x040014EC RID: 5356
			[Token(Token = "0x40014EC")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Adding a texture to this field will enable the use of \"Bokeh Textures\". Use with care. This feature is only available on Shader Model 5 compatible-hardware and performance scale with the amount of bokeh.")]
			public Texture2D texture;

			// Token: 0x040014ED RID: 5357
			[Token(Token = "0x40014ED")]
			[FieldOffset(Offset = "0x8")]
			[Range(0.01f, 10f)]
			[Tooltip("Maximum size of bokeh textures on screen.")]
			public float scale;

			// Token: 0x040014EE RID: 5358
			[Token(Token = "0x40014EE")]
			[FieldOffset(Offset = "0xC")]
			[Range(0.01f, 100f)]
			[Tooltip("Bokeh brightness.")]
			public float intensity;

			// Token: 0x040014EF RID: 5359
			[Token(Token = "0x40014EF")]
			[FieldOffset(Offset = "0x10")]
			[Range(0.01f, 5f)]
			[Tooltip("Controls the amount of bokeh textures. Lower values mean more bokeh splats.")]
			public float threshold;

			// Token: 0x040014F0 RID: 5360
			[Token(Token = "0x40014F0")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Controls the spawn conditions. Lower values mean more visible bokeh.")]
			[Range(0.01f, 1f)]
			public float spawnHeuristic;
		}
	}
}
