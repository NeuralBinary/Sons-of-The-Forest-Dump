using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000324 RID: 804
	[Token(Token = "0x2000324")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Cinematic/Depth Of Field")]
	public class DepthOfField : MonoBehaviour
	{
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E7")]
		public Shader filmicDepthOfFieldShader
		{
			[Token(Token = "0x60014CB")]
			[Address(RVA = "0x325F920", Offset = "0x325DF20", VA = "0x18325F920")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E8")]
		public Shader medianFilterShader
		{
			[Token(Token = "0x60014CC")]
			[Address(RVA = "0x325FA40", Offset = "0x325E040", VA = "0x18325FA40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E9")]
		public Shader textureBokehShader
		{
			[Token(Token = "0x60014CD")]
			[Address(RVA = "0x325FB80", Offset = "0x325E180", VA = "0x18325FB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EA")]
		public Material filmicDepthOfFieldMaterial
		{
			[Token(Token = "0x60014CE")]
			[Address(RVA = "0x325FCC0", Offset = "0x325E2C0", VA = "0x18325FCC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EB")]
		public Material medianFilterMaterial
		{
			[Token(Token = "0x60014CF")]
			[Address(RVA = "0x325FE00", Offset = "0x325E400", VA = "0x18325FE00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EC")]
		public Material textureBokehMaterial
		{
			[Token(Token = "0x60014D0")]
			[Address(RVA = "0x325FF40", Offset = "0x325E540", VA = "0x18325FF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002ED")]
		public ComputeBuffer computeBufferDrawArgs
		{
			[Token(Token = "0x60014D1")]
			[Address(RVA = "0x3260080", Offset = "0x325E680", VA = "0x183260080")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EE")]
		public ComputeBuffer computeBufferPoints
		{
			[Token(Token = "0x60014D2")]
			[Address(RVA = "0x32601B0", Offset = "0x325E7B0", VA = "0x1832601B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x3260280", Offset = "0x325E880", VA = "0x183260280")]
		private void Awake()
		{
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x32606B0", Offset = "0x325ECB0", VA = "0x1832606B0")]
		private void OnEnable()
		{
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x3260810", Offset = "0x325EE10", VA = "0x183260810")]
		private void OnDisable()
		{
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x3260C40", Offset = "0x325F240", VA = "0x183260C40")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x3260EF0", Offset = "0x325F4F0", VA = "0x183260EF0")]
		private void DoDepthOfField(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x3262610", Offset = "0x3260C10", VA = "0x183262610")]
		private void DoHexagonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x3262AB0", Offset = "0x32610B0", VA = "0x183262AB0")]
		private void DoOctogonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x3263010", Offset = "0x3261610", VA = "0x183263010")]
		private void DoCircularBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x32631A0", Offset = "0x32617A0", VA = "0x1832631A0")]
		private void ComputeCocParameters(out Vector4 blurParams, out Vector4 blurCoe)
		{
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x3263710", Offset = "0x3261D10", VA = "0x183263710")]
		private void ReleaseComputeResources()
		{
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0x3263800", Offset = "0x3261E00", VA = "0x183263800")]
		private void ComputeBlurDirections(bool force)
		{
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x00006D08 File Offset: 0x00004F08
		[Token(Token = "0x170002EF")]
		private bool shouldPerformBokeh
		{
			[Token(Token = "0x60014DE")]
			[Address(RVA = "0x3263AF0", Offset = "0x32620F0", VA = "0x183263AF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x3263C70", Offset = "0x3262270", VA = "0x183263C70")]
		private static void Rotate2D(ref Vector4 direction, float cosinus, float sinus)
		{
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0xDB0A10", Offset = "0xDAF010", VA = "0x180DB0A10")]
		private static void SwapRenderTexture(ref RenderTexture src, ref RenderTexture dst)
		{
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x3263CB0", Offset = "0x32622B0", VA = "0x183263CB0")]
		private static void GetDirectionalBlurPassesFromRadius(RenderTexture blurredFgCoc, float maxRadius, out int blurPass, out int blurAndMergePass)
		{
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x3263E00", Offset = "0x3262400", VA = "0x183263E00")]
		public DepthOfField()
		{
		}

		// Token: 0x040014A9 RID: 5289
		[Token(Token = "0x40014A9")]
		private const float kMaxBlur = 40f;

		// Token: 0x040014AA RID: 5290
		[Token(Token = "0x40014AA")]
		[FieldOffset(Offset = "0x20")]
		public DepthOfField.GlobalSettings settings;

		// Token: 0x040014AB RID: 5291
		[Token(Token = "0x40014AB")]
		[FieldOffset(Offset = "0x38")]
		public DepthOfField.FocusSettings focus;

		// Token: 0x040014AC RID: 5292
		[Token(Token = "0x40014AC")]
		[FieldOffset(Offset = "0x60")]
		public DepthOfField.BokehTextureSettings bokehTexture;

		// Token: 0x040014AD RID: 5293
		[Token(Token = "0x40014AD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Shader m_FilmicDepthOfFieldShader;

		// Token: 0x040014AE RID: 5294
		[Token(Token = "0x40014AE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Shader m_MedianFilterShader;

		// Token: 0x040014AF RID: 5295
		[Token(Token = "0x40014AF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Shader m_TextureBokehShader;

		// Token: 0x040014B0 RID: 5296
		[Token(Token = "0x40014B0")]
		[FieldOffset(Offset = "0x90")]
		private RenderTextureUtility m_RTU;

		// Token: 0x040014B1 RID: 5297
		[Token(Token = "0x40014B1")]
		[FieldOffset(Offset = "0x98")]
		private Material m_FilmicDepthOfFieldMaterial;

		// Token: 0x040014B2 RID: 5298
		[Token(Token = "0x40014B2")]
		[FieldOffset(Offset = "0xA0")]
		private Material m_MedianFilterMaterial;

		// Token: 0x040014B3 RID: 5299
		[Token(Token = "0x40014B3")]
		[FieldOffset(Offset = "0xA8")]
		private Material m_TextureBokehMaterial;

		// Token: 0x040014B4 RID: 5300
		[Token(Token = "0x40014B4")]
		[FieldOffset(Offset = "0xB0")]
		private ComputeBuffer m_ComputeBufferDrawArgs;

		// Token: 0x040014B5 RID: 5301
		[Token(Token = "0x40014B5")]
		[FieldOffset(Offset = "0xB8")]
		private ComputeBuffer m_ComputeBufferPoints;

		// Token: 0x040014B6 RID: 5302
		[Token(Token = "0x40014B6")]
		[FieldOffset(Offset = "0xC0")]
		private DepthOfField.QualitySettings m_CurrentQualitySettings;

		// Token: 0x040014B7 RID: 5303
		[Token(Token = "0x40014B7")]
		[FieldOffset(Offset = "0xCC")]
		private float m_LastApertureOrientation;

		// Token: 0x040014B8 RID: 5304
		[Token(Token = "0x40014B8")]
		[FieldOffset(Offset = "0xD0")]
		private Vector4 m_OctogonalBokehDirection1;

		// Token: 0x040014B9 RID: 5305
		[Token(Token = "0x40014B9")]
		[FieldOffset(Offset = "0xE0")]
		private Vector4 m_OctogonalBokehDirection2;

		// Token: 0x040014BA RID: 5306
		[Token(Token = "0x40014BA")]
		[FieldOffset(Offset = "0xF0")]
		private Vector4 m_OctogonalBokehDirection3;

		// Token: 0x040014BB RID: 5307
		[Token(Token = "0x40014BB")]
		[FieldOffset(Offset = "0x100")]
		private Vector4 m_OctogonalBokehDirection4;

		// Token: 0x040014BC RID: 5308
		[Token(Token = "0x40014BC")]
		[FieldOffset(Offset = "0x110")]
		private Vector4 m_HexagonalBokehDirection1;

		// Token: 0x040014BD RID: 5309
		[Token(Token = "0x40014BD")]
		[FieldOffset(Offset = "0x120")]
		private Vector4 m_HexagonalBokehDirection2;

		// Token: 0x040014BE RID: 5310
		[Token(Token = "0x40014BE")]
		[FieldOffset(Offset = "0x130")]
		private Vector4 m_HexagonalBokehDirection3;

		// Token: 0x040014BF RID: 5311
		[Token(Token = "0x40014BF")]
		[FieldOffset(Offset = "0x140")]
		private int m_BlurParams;

		// Token: 0x040014C0 RID: 5312
		[Token(Token = "0x40014C0")]
		[FieldOffset(Offset = "0x144")]
		private int m_BlurCoe;

		// Token: 0x040014C1 RID: 5313
		[Token(Token = "0x40014C1")]
		[FieldOffset(Offset = "0x148")]
		private int m_Offsets;

		// Token: 0x040014C2 RID: 5314
		[Token(Token = "0x40014C2")]
		[FieldOffset(Offset = "0x14C")]
		private int m_BlurredColor;

		// Token: 0x040014C3 RID: 5315
		[Token(Token = "0x40014C3")]
		[FieldOffset(Offset = "0x150")]
		private int m_SpawnHeuristic;

		// Token: 0x040014C4 RID: 5316
		[Token(Token = "0x40014C4")]
		[FieldOffset(Offset = "0x154")]
		private int m_BokehParams;

		// Token: 0x040014C5 RID: 5317
		[Token(Token = "0x40014C5")]
		[FieldOffset(Offset = "0x158")]
		private int m_Convolved_TexelSize;

		// Token: 0x040014C6 RID: 5318
		[Token(Token = "0x40014C6")]
		[FieldOffset(Offset = "0x15C")]
		private int m_SecondTex;

		// Token: 0x040014C7 RID: 5319
		[Token(Token = "0x40014C7")]
		[FieldOffset(Offset = "0x160")]
		private int m_ThirdTex;

		// Token: 0x040014C8 RID: 5320
		[Token(Token = "0x40014C8")]
		[FieldOffset(Offset = "0x164")]
		private int m_MainTex;

		// Token: 0x040014C9 RID: 5321
		[Token(Token = "0x40014C9")]
		[FieldOffset(Offset = "0x168")]
		private int m_Screen;

		// Token: 0x02000325 RID: 805
		[Token(Token = "0x2000325")]
		private enum Passes
		{
			// Token: 0x040014CB RID: 5323
			[Token(Token = "0x40014CB")]
			BlurAlphaWeighted,
			// Token: 0x040014CC RID: 5324
			[Token(Token = "0x40014CC")]
			BoxBlur,
			// Token: 0x040014CD RID: 5325
			[Token(Token = "0x40014CD")]
			DilateFgCocFromColor,
			// Token: 0x040014CE RID: 5326
			[Token(Token = "0x40014CE")]
			DilateFgCoc,
			// Token: 0x040014CF RID: 5327
			[Token(Token = "0x40014CF")]
			CaptureCocExplicit,
			// Token: 0x040014D0 RID: 5328
			[Token(Token = "0x40014D0")]
			VisualizeCocExplicit,
			// Token: 0x040014D1 RID: 5329
			[Token(Token = "0x40014D1")]
			CocPrefilter,
			// Token: 0x040014D2 RID: 5330
			[Token(Token = "0x40014D2")]
			CircleBlur,
			// Token: 0x040014D3 RID: 5331
			[Token(Token = "0x40014D3")]
			CircleBlurWithDilatedFg,
			// Token: 0x040014D4 RID: 5332
			[Token(Token = "0x40014D4")]
			CircleBlurLowQuality,
			// Token: 0x040014D5 RID: 5333
			[Token(Token = "0x40014D5")]
			CircleBlowLowQualityWithDilatedFg,
			// Token: 0x040014D6 RID: 5334
			[Token(Token = "0x40014D6")]
			MergeExplicit,
			// Token: 0x040014D7 RID: 5335
			[Token(Token = "0x40014D7")]
			ShapeLowQuality,
			// Token: 0x040014D8 RID: 5336
			[Token(Token = "0x40014D8")]
			ShapeLowQualityDilateFg,
			// Token: 0x040014D9 RID: 5337
			[Token(Token = "0x40014D9")]
			ShapeLowQualityMerge,
			// Token: 0x040014DA RID: 5338
			[Token(Token = "0x40014DA")]
			ShapeLowQualityMergeDilateFg,
			// Token: 0x040014DB RID: 5339
			[Token(Token = "0x40014DB")]
			ShapeMediumQuality,
			// Token: 0x040014DC RID: 5340
			[Token(Token = "0x40014DC")]
			ShapeMediumQualityDilateFg,
			// Token: 0x040014DD RID: 5341
			[Token(Token = "0x40014DD")]
			ShapeMediumQualityMerge,
			// Token: 0x040014DE RID: 5342
			[Token(Token = "0x40014DE")]
			ShapeMediumQualityMergeDilateFg,
			// Token: 0x040014DF RID: 5343
			[Token(Token = "0x40014DF")]
			ShapeHighQuality,
			// Token: 0x040014E0 RID: 5344
			[Token(Token = "0x40014E0")]
			ShapeHighQualityDilateFg,
			// Token: 0x040014E1 RID: 5345
			[Token(Token = "0x40014E1")]
			ShapeHighQualityMerge,
			// Token: 0x040014E2 RID: 5346
			[Token(Token = "0x40014E2")]
			ShapeHighQualityMergeDilateFg
		}

		// Token: 0x02000326 RID: 806
		[Token(Token = "0x2000326")]
		private enum MedianPasses
		{
			// Token: 0x040014E4 RID: 5348
			[Token(Token = "0x40014E4")]
			Median3,
			// Token: 0x040014E5 RID: 5349
			[Token(Token = "0x40014E5")]
			Median3X3
		}

		// Token: 0x02000327 RID: 807
		[Token(Token = "0x2000327")]
		private enum BokehTexturesPasses
		{
			// Token: 0x040014E7 RID: 5351
			[Token(Token = "0x40014E7")]
			Apply,
			// Token: 0x040014E8 RID: 5352
			[Token(Token = "0x40014E8")]
			Collect
		}

		// Token: 0x02000328 RID: 808
		[Token(Token = "0x2000328")]
		public enum TweakMode
		{
			// Token: 0x040014EA RID: 5354
			[Token(Token = "0x40014EA")]
			Range,
			// Token: 0x040014EB RID: 5355
			[Token(Token = "0x40014EB")]
			Explicit
		}

		// Token: 0x02000329 RID: 809
		[Token(Token = "0x2000329")]
		public enum ApertureShape
		{
			// Token: 0x040014ED RID: 5357
			[Token(Token = "0x40014ED")]
			Circular,
			// Token: 0x040014EE RID: 5358
			[Token(Token = "0x40014EE")]
			Hexagonal,
			// Token: 0x040014EF RID: 5359
			[Token(Token = "0x40014EF")]
			Octogonal
		}

		// Token: 0x0200032A RID: 810
		[Token(Token = "0x200032A")]
		public enum QualityPreset
		{
			// Token: 0x040014F1 RID: 5361
			[Token(Token = "0x40014F1")]
			Low,
			// Token: 0x040014F2 RID: 5362
			[Token(Token = "0x40014F2")]
			Medium,
			// Token: 0x040014F3 RID: 5363
			[Token(Token = "0x40014F3")]
			High
		}

		// Token: 0x0200032B RID: 811
		[Token(Token = "0x200032B")]
		public enum FilterQuality
		{
			// Token: 0x040014F5 RID: 5365
			[Token(Token = "0x40014F5")]
			None,
			// Token: 0x040014F6 RID: 5366
			[Token(Token = "0x40014F6")]
			Normal,
			// Token: 0x040014F7 RID: 5367
			[Token(Token = "0x40014F7")]
			High
		}

		// Token: 0x0200032C RID: 812
		[Token(Token = "0x200032C")]
		[Serializable]
		public struct GlobalSettings
		{
			// Token: 0x170002F0 RID: 752
			// (get) Token: 0x060014E3 RID: 5347 RVA: 0x00006D20 File Offset: 0x00004F20
			[Token(Token = "0x170002F0")]
			public static DepthOfField.GlobalSettings defaultSettings
			{
				[Token(Token = "0x60014E3")]
				[Address(RVA = "0x32640F0", Offset = "0x32626F0", VA = "0x1832640F0")]
				get
				{
					return default(DepthOfField.GlobalSettings);
				}
			}

			// Token: 0x040014F8 RID: 5368
			[Token(Token = "0x40014F8")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Allows to view where the blur will be applied. Yellow for near blur, blue for far blur.")]
			public bool visualizeFocus;

			// Token: 0x040014F9 RID: 5369
			[Token(Token = "0x40014F9")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Setup mode. Use \"Advanced\" if you need more control on blur settings and/or want to use a bokeh texture. \"Explicit\" is the same as \"Advanced\" but makes use of \"Near Plane\" and \"Far Plane\" values instead of \"F-Stop\".")]
			public DepthOfField.TweakMode tweakMode;

			// Token: 0x040014FA RID: 5370
			[Token(Token = "0x40014FA")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Quality presets. Use \"Custom\" for more advanced settings.")]
			public DepthOfField.QualityPreset filteringQuality;

			// Token: 0x040014FB RID: 5371
			[Token(Token = "0x40014FB")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("\"Circular\" is the fastest, followed by \"Hexagonal\" and \"Octogonal\".")]
			public DepthOfField.ApertureShape apertureShape;

			// Token: 0x040014FC RID: 5372
			[Token(Token = "0x40014FC")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Rotates the aperture when working with \"Hexagonal\" and \"Ortogonal\".")]
			[Range(0f, 179f)]
			public float apertureOrientation;
		}

		// Token: 0x0200032D RID: 813
		[Token(Token = "0x200032D")]
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x040014FD RID: 5373
			[Token(Token = "0x40014FD")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Enable this to get smooth bokeh.")]
			public bool prefilterBlur;

			// Token: 0x040014FE RID: 5374
			[Token(Token = "0x40014FE")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Applies a median filter for even smoother bokeh.")]
			public DepthOfField.FilterQuality medianFilter;

			// Token: 0x040014FF RID: 5375
			[Token(Token = "0x40014FF")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Dilates near blur over in focus area.")]
			public bool dilateNearBlur;

			// Token: 0x04001500 RID: 5376
			[Token(Token = "0x4001500")]
			[FieldOffset(Offset = "0x0")]
			public static DepthOfField.QualitySettings[] presetQualitySettings;
		}

		// Token: 0x0200032E RID: 814
		[Token(Token = "0x200032E")]
		[Serializable]
		public struct FocusSettings
		{
			// Token: 0x170002F1 RID: 753
			// (get) Token: 0x060014E5 RID: 5349 RVA: 0x00006D38 File Offset: 0x00004F38
			[Token(Token = "0x170002F1")]
			public static DepthOfField.FocusSettings defaultSettings
			{
				[Token(Token = "0x60014E5")]
				[Address(RVA = "0x3264260", Offset = "0x3262860", VA = "0x183264260")]
				get
				{
					return default(DepthOfField.FocusSettings);
				}
			}

			// Token: 0x04001501 RID: 5377
			[Token(Token = "0x4001501")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Auto-focus on a selected transform.")]
			public Transform transform;

			// Token: 0x04001502 RID: 5378
			[Token(Token = "0x4001502")]
			[FieldOffset(Offset = "0x8")]
			[Min(0f)]
			[Tooltip("Focus distance (in world units).")]
			public float focusPlane;

			// Token: 0x04001503 RID: 5379
			[Token(Token = "0x4001503")]
			[FieldOffset(Offset = "0xC")]
			[Min(0.1f)]
			[Tooltip("Focus range (in world units). The focus plane is located in the center of the range.")]
			public float range;

			// Token: 0x04001504 RID: 5380
			[Token(Token = "0x4001504")]
			[FieldOffset(Offset = "0x10")]
			[Min(0f)]
			[Tooltip("Near focus distance (in world units).")]
			public float nearPlane;

			// Token: 0x04001505 RID: 5381
			[Token(Token = "0x4001505")]
			[FieldOffset(Offset = "0x14")]
			[Min(0f)]
			[Tooltip("Near blur falloff (in world units).")]
			public float nearFalloff;

			// Token: 0x04001506 RID: 5382
			[Token(Token = "0x4001506")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Far focus distance (in world units).")]
			[Min(0f)]
			public float farPlane;

			// Token: 0x04001507 RID: 5383
			[Token(Token = "0x4001507")]
			[FieldOffset(Offset = "0x1C")]
			[Min(0f)]
			[Tooltip("Far blur falloff (in world units).")]
			public float farFalloff;

			// Token: 0x04001508 RID: 5384
			[Token(Token = "0x4001508")]
			[FieldOffset(Offset = "0x20")]
			[Range(0f, 40f)]
			[Tooltip("Maximum blur radius for the near plane.")]
			public float nearBlurRadius;

			// Token: 0x04001509 RID: 5385
			[Token(Token = "0x4001509")]
			[FieldOffset(Offset = "0x24")]
			[Range(0f, 40f)]
			[Tooltip("Maximum blur radius for the far plane.")]
			public float farBlurRadius;
		}

		// Token: 0x0200032F RID: 815
		[Token(Token = "0x200032F")]
		[Serializable]
		public struct BokehTextureSettings
		{
			// Token: 0x170002F2 RID: 754
			// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00006D50 File Offset: 0x00004F50
			[Token(Token = "0x170002F2")]
			public static DepthOfField.BokehTextureSettings defaultSettings
			{
				[Token(Token = "0x60014E6")]
				[Address(RVA = "0x3264300", Offset = "0x3262900", VA = "0x183264300")]
				get
				{
					return default(DepthOfField.BokehTextureSettings);
				}
			}

			// Token: 0x0400150A RID: 5386
			[Token(Token = "0x400150A")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Adding a texture to this field will enable the use of \"Bokeh Textures\". Use with care. This feature is only available on Shader Model 5 compatible-hardware and performance scale with the amount of bokeh.")]
			public Texture2D texture;

			// Token: 0x0400150B RID: 5387
			[Token(Token = "0x400150B")]
			[FieldOffset(Offset = "0x8")]
			[Range(0.01f, 10f)]
			[Tooltip("Maximum size of bokeh textures on screen.")]
			public float scale;

			// Token: 0x0400150C RID: 5388
			[Token(Token = "0x400150C")]
			[FieldOffset(Offset = "0xC")]
			[Range(0.01f, 100f)]
			[Tooltip("Bokeh brightness.")]
			public float intensity;

			// Token: 0x0400150D RID: 5389
			[Token(Token = "0x400150D")]
			[FieldOffset(Offset = "0x10")]
			[Range(0.01f, 5f)]
			[Tooltip("Controls the amount of bokeh textures. Lower values mean more bokeh splats.")]
			public float threshold;

			// Token: 0x0400150E RID: 5390
			[Token(Token = "0x400150E")]
			[FieldOffset(Offset = "0x14")]
			[Range(0.01f, 1f)]
			[Tooltip("Controls the spawn conditions. Lower values mean more visible bokeh.")]
			public float spawnHeuristic;
		}
	}
}
