using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2000340")]
	[ImageEffectAllowedInSceneView]
	[AddComponentMenu("Image Effects/Cinematic/Tonemapping and Color Grading")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class TonemappingColorGrading : MonoBehaviour
	{
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x00006E10 File Offset: 0x00005010
		// (set) Token: 0x0600150E RID: 5390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000301")]
		public TonemappingColorGrading.EyeAdaptationSettings eyeAdaptation
		{
			[Token(Token = "0x600150D")]
			[Address(RVA = "0x9CDF50", Offset = "0x9CC550", VA = "0x1809CDF50")]
			get
			{
				return default(TonemappingColorGrading.EyeAdaptationSettings);
			}
			[Token(Token = "0x600150E")]
			[Address(RVA = "0x9CDF70", Offset = "0x9CC570", VA = "0x1809CDF70")]
			set
			{
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x00006E28 File Offset: 0x00005028
		// (set) Token: 0x06001510 RID: 5392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000302")]
		public TonemappingColorGrading.TonemappingSettings tonemapping
		{
			[Token(Token = "0x600150F")]
			[Address(RVA = "0x1FFDAE0", Offset = "0x1FFC0E0", VA = "0x181FFDAE0")]
			get
			{
				return default(TonemappingColorGrading.TonemappingSettings);
			}
			[Token(Token = "0x6001510")]
			[Address(RVA = "0x3267AF0", Offset = "0x32660F0", VA = "0x183267AF0")]
			set
			{
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x00006E40 File Offset: 0x00005040
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000303")]
		public TonemappingColorGrading.ColorGradingSettings colorGrading
		{
			[Token(Token = "0x6001511")]
			[Address(RVA = "0x3267B70", Offset = "0x3266170", VA = "0x183267B70")]
			get
			{
				return default(TonemappingColorGrading.ColorGradingSettings);
			}
			[Token(Token = "0x6001512")]
			[Address(RVA = "0x3267BF0", Offset = "0x32661F0", VA = "0x183267BF0")]
			set
			{
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x00006E58 File Offset: 0x00005058
		// (set) Token: 0x06001514 RID: 5396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000304")]
		public TonemappingColorGrading.LUTSettings lut
		{
			[Token(Token = "0x6001513")]
			[Address(RVA = "0x3267CC0", Offset = "0x32662C0", VA = "0x183267CC0")]
			get
			{
				return default(TonemappingColorGrading.LUTSettings);
			}
			[Token(Token = "0x6001514")]
			[Address(RVA = "0x3267CE0", Offset = "0x32662E0", VA = "0x183267CE0")]
			set
			{
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000305")]
		private Texture2D identityLut
		{
			[Token(Token = "0x6001515")]
			[Address(RVA = "0x3267D50", Offset = "0x3266350", VA = "0x183267D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000306")]
		private RenderTexture internalLutRt
		{
			[Token(Token = "0x6001516")]
			[Address(RVA = "0x3267ED0", Offset = "0x32664D0", VA = "0x183267ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000307")]
		private Texture2D curveTexture
		{
			[Token(Token = "0x6001517")]
			[Address(RVA = "0x3268220", Offset = "0x3266820", VA = "0x183268220")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000308")]
		private Texture2D tonemapperCurve
		{
			[Token(Token = "0x6001518")]
			[Address(RVA = "0x3268500", Offset = "0x3266B00", VA = "0x183268500")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000309")]
		public Shader shader
		{
			[Token(Token = "0x6001519")]
			[Address(RVA = "0x3268810", Offset = "0x3266E10", VA = "0x183268810")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030A")]
		public Material material
		{
			[Token(Token = "0x600151A")]
			[Address(RVA = "0x3268950", Offset = "0x3266F50", VA = "0x183268950")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x1700030B")]
		public bool isGammaColorSpace
		{
			[Token(Token = "0x600151B")]
			[Address(RVA = "0x3268A90", Offset = "0x3267090", VA = "0x183268A90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x1700030C")]
		public int lutSize
		{
			[Token(Token = "0x600151C")]
			[Address(RVA = "0x3268AE0", Offset = "0x32670E0", VA = "0x183268AE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x00006EA0 File Offset: 0x000050A0
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030D")]
		public bool validRenderTextureFormat
		{
			[Token(Token = "0x600151D")]
			[Address(RVA = "0x3268B00", Offset = "0x3267100", VA = "0x183268B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600151E")]
			[Address(RVA = "0x3268B10", Offset = "0x3267110", VA = "0x183268B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x00006EB8 File Offset: 0x000050B8
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030E")]
		public bool validUserLutSize
		{
			[Token(Token = "0x600151F")]
			[Address(RVA = "0x3268B20", Offset = "0x3267120", VA = "0x183268B20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001520")]
			[Address(RVA = "0x3268B30", Offset = "0x3267130", VA = "0x183268B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001521")]
		[Address(RVA = "0x3268B40", Offset = "0x3267140", VA = "0x183268B40")]
		public void SetDirty()
		{
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001522")]
		[Address(RVA = "0x3268B50", Offset = "0x3267150", VA = "0x183268B50")]
		public void SetTonemapperDirty()
		{
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001523")]
		[Address(RVA = "0x3268B60", Offset = "0x3267160", VA = "0x183268B60")]
		private void Awake()
		{
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001524")]
		[Address(RVA = "0x32694B0", Offset = "0x3267AB0", VA = "0x1832694B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001525")]
		[Address(RVA = "0x3269540", Offset = "0x3267B40", VA = "0x183269540")]
		private void OnDisable()
		{
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001526")]
		[Address(RVA = "0x3269BB0", Offset = "0x32681B0", VA = "0x183269BB0")]
		private void OnValidate()
		{
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001527")]
		[Address(RVA = "0x3269BC0", Offset = "0x32681C0", VA = "0x183269BC0")]
		private static Texture2D GenerateIdentityLut(int dim)
		{
			return null;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x6001528")]
		[Address(RVA = "0x3269EA0", Offset = "0x32684A0", VA = "0x183269EA0")]
		private float StandardIlluminantY(float x)
		{
			return 0f;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x6001529")]
		[Address(RVA = "0x3269ED0", Offset = "0x32684D0", VA = "0x183269ED0")]
		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x3269F60", Offset = "0x3268560", VA = "0x183269F60")]
		private Vector3 GetWhiteBalance()
		{
			return default(Vector3);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x600152B")]
		[Address(RVA = "0x326A0A0", Offset = "0x32686A0", VA = "0x18326A0A0")]
		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152C")]
		[Address(RVA = "0x326A160", Offset = "0x3268760", VA = "0x18326A160")]
		private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain)
		{
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152D")]
		[Address(RVA = "0x326A580", Offset = "0x3268B80", VA = "0x18326A580")]
		private void GenCurveTexture()
		{
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x600152E")]
		[Address(RVA = "0x326A980", Offset = "0x3268F80", VA = "0x18326A980")]
		private bool CheckUserLut()
		{
			return default(bool);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x326AA30", Offset = "0x3269030", VA = "0x18326AA30")]
		private bool CheckSmallAdaptiveRt()
		{
			return default(bool);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001530")]
		[Address(RVA = "0x326AC20", Offset = "0x3269220", VA = "0x18326AC20")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x326D090", Offset = "0x326B690", VA = "0x18326D090")]
		public Texture2D BakeLUT()
		{
			return null;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x326D2F0", Offset = "0x326B8F0", VA = "0x18326D2F0")]
		public TonemappingColorGrading()
		{
		}

		// Token: 0x0400155B RID: 5467
		[Token(Token = "0x400155B")]
		[FieldOffset(Offset = "0x20")]
		[TonemappingColorGrading.SettingsGroup]
		[SerializeField]
		private TonemappingColorGrading.EyeAdaptationSettings m_EyeAdaptation;

		// Token: 0x0400155C RID: 5468
		[Token(Token = "0x400155C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[TonemappingColorGrading.SettingsGroup]
		private TonemappingColorGrading.TonemappingSettings m_Tonemapping;

		// Token: 0x0400155D RID: 5469
		[Token(Token = "0x400155D")]
		[FieldOffset(Offset = "0x68")]
		[TonemappingColorGrading.SettingsGroup]
		[SerializeField]
		private TonemappingColorGrading.ColorGradingSettings m_ColorGrading;

		// Token: 0x0400155E RID: 5470
		[Token(Token = "0x400155E")]
		[FieldOffset(Offset = "0x100")]
		[TonemappingColorGrading.SettingsGroup]
		[SerializeField]
		private TonemappingColorGrading.LUTSettings m_Lut;

		// Token: 0x0400155F RID: 5471
		[Token(Token = "0x400155F")]
		[FieldOffset(Offset = "0x118")]
		private Texture2D m_IdentityLut;

		// Token: 0x04001560 RID: 5472
		[Token(Token = "0x4001560")]
		[FieldOffset(Offset = "0x120")]
		private RenderTexture m_InternalLut;

		// Token: 0x04001561 RID: 5473
		[Token(Token = "0x4001561")]
		[FieldOffset(Offset = "0x128")]
		private Texture2D m_CurveTexture;

		// Token: 0x04001562 RID: 5474
		[Token(Token = "0x4001562")]
		[FieldOffset(Offset = "0x130")]
		private Texture2D m_TonemapperCurve;

		// Token: 0x04001563 RID: 5475
		[Token(Token = "0x4001563")]
		[FieldOffset(Offset = "0x138")]
		private float m_TonemapperCurveRange;

		// Token: 0x04001564 RID: 5476
		[Token(Token = "0x4001564")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Shader m_Shader;

		// Token: 0x04001565 RID: 5477
		[Token(Token = "0x4001565")]
		[FieldOffset(Offset = "0x148")]
		private Material m_Material;

		// Token: 0x04001568 RID: 5480
		[Token(Token = "0x4001568")]
		[FieldOffset(Offset = "0x152")]
		private bool m_Dirty;

		// Token: 0x04001569 RID: 5481
		[Token(Token = "0x4001569")]
		[FieldOffset(Offset = "0x153")]
		private bool m_TonemapperDirty;

		// Token: 0x0400156A RID: 5482
		[Token(Token = "0x400156A")]
		[FieldOffset(Offset = "0x158")]
		private RenderTexture m_SmallAdaptiveRt;

		// Token: 0x0400156B RID: 5483
		[Token(Token = "0x400156B")]
		[FieldOffset(Offset = "0x160")]
		private RenderTextureFormat m_AdaptiveRtFormat;

		// Token: 0x0400156C RID: 5484
		[Token(Token = "0x400156C")]
		[FieldOffset(Offset = "0x164")]
		private int m_AdaptationSpeed;

		// Token: 0x0400156D RID: 5485
		[Token(Token = "0x400156D")]
		[FieldOffset(Offset = "0x168")]
		private int m_MiddleGrey;

		// Token: 0x0400156E RID: 5486
		[Token(Token = "0x400156E")]
		[FieldOffset(Offset = "0x16C")]
		private int m_AdaptationMin;

		// Token: 0x0400156F RID: 5487
		[Token(Token = "0x400156F")]
		[FieldOffset(Offset = "0x170")]
		private int m_AdaptationMax;

		// Token: 0x04001570 RID: 5488
		[Token(Token = "0x4001570")]
		[FieldOffset(Offset = "0x174")]
		private int m_LumTex;

		// Token: 0x04001571 RID: 5489
		[Token(Token = "0x4001571")]
		[FieldOffset(Offset = "0x178")]
		private int m_ToneCurveRange;

		// Token: 0x04001572 RID: 5490
		[Token(Token = "0x4001572")]
		[FieldOffset(Offset = "0x17C")]
		private int m_ToneCurve;

		// Token: 0x04001573 RID: 5491
		[Token(Token = "0x4001573")]
		[FieldOffset(Offset = "0x180")]
		private int m_Exposure;

		// Token: 0x04001574 RID: 5492
		[Token(Token = "0x4001574")]
		[FieldOffset(Offset = "0x184")]
		private int m_NeutralTonemapperParams1;

		// Token: 0x04001575 RID: 5493
		[Token(Token = "0x4001575")]
		[FieldOffset(Offset = "0x188")]
		private int m_NeutralTonemapperParams2;

		// Token: 0x04001576 RID: 5494
		[Token(Token = "0x4001576")]
		[FieldOffset(Offset = "0x18C")]
		private int m_WhiteBalance;

		// Token: 0x04001577 RID: 5495
		[Token(Token = "0x4001577")]
		[FieldOffset(Offset = "0x190")]
		private int m_Lift;

		// Token: 0x04001578 RID: 5496
		[Token(Token = "0x4001578")]
		[FieldOffset(Offset = "0x194")]
		private int m_Gamma;

		// Token: 0x04001579 RID: 5497
		[Token(Token = "0x4001579")]
		[FieldOffset(Offset = "0x198")]
		private int m_Gain;

		// Token: 0x0400157A RID: 5498
		[Token(Token = "0x400157A")]
		[FieldOffset(Offset = "0x19C")]
		private int m_ContrastGainGamma;

		// Token: 0x0400157B RID: 5499
		[Token(Token = "0x400157B")]
		[FieldOffset(Offset = "0x1A0")]
		private int m_Vibrance;

		// Token: 0x0400157C RID: 5500
		[Token(Token = "0x400157C")]
		[FieldOffset(Offset = "0x1A4")]
		private int m_HSV;

		// Token: 0x0400157D RID: 5501
		[Token(Token = "0x400157D")]
		[FieldOffset(Offset = "0x1A8")]
		private int m_ChannelMixerRed;

		// Token: 0x0400157E RID: 5502
		[Token(Token = "0x400157E")]
		[FieldOffset(Offset = "0x1AC")]
		private int m_ChannelMixerGreen;

		// Token: 0x0400157F RID: 5503
		[Token(Token = "0x400157F")]
		[FieldOffset(Offset = "0x1B0")]
		private int m_ChannelMixerBlue;

		// Token: 0x04001580 RID: 5504
		[Token(Token = "0x4001580")]
		[FieldOffset(Offset = "0x1B4")]
		private int m_CurveTex;

		// Token: 0x04001581 RID: 5505
		[Token(Token = "0x4001581")]
		[FieldOffset(Offset = "0x1B8")]
		private int m_InternalLutTex;

		// Token: 0x04001582 RID: 5506
		[Token(Token = "0x4001582")]
		[FieldOffset(Offset = "0x1BC")]
		private int m_InternalLutParams;

		// Token: 0x04001583 RID: 5507
		[Token(Token = "0x4001583")]
		[FieldOffset(Offset = "0x1C0")]
		private int m_UserLutTex;

		// Token: 0x04001584 RID: 5508
		[Token(Token = "0x4001584")]
		[FieldOffset(Offset = "0x1C4")]
		private int m_UserLutParams;

		// Token: 0x04001585 RID: 5509
		[Token(Token = "0x4001585")]
		[FieldOffset(Offset = "0x1C8")]
		private RenderTexture[] m_AdaptRts;

		// Token: 0x02000341 RID: 833
		[Token(Token = "0x2000341")]
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
			// Token: 0x06001533 RID: 5427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001533")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SettingsGroup()
			{
			}
		}

		// Token: 0x02000342 RID: 834
		[Token(Token = "0x2000342")]
		public class IndentedGroup : PropertyAttribute
		{
			// Token: 0x06001534 RID: 5428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001534")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public IndentedGroup()
			{
			}
		}

		// Token: 0x02000343 RID: 835
		[Token(Token = "0x2000343")]
		public class ChannelMixer : PropertyAttribute
		{
			// Token: 0x06001535 RID: 5429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001535")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ChannelMixer()
			{
			}
		}

		// Token: 0x02000344 RID: 836
		[Token(Token = "0x2000344")]
		public class ColorWheelGroup : PropertyAttribute
		{
			// Token: 0x06001536 RID: 5430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001536")]
			[Address(RVA = "0x326D670", Offset = "0x326BC70", VA = "0x18326D670")]
			public ColorWheelGroup()
			{
			}

			// Token: 0x06001537 RID: 5431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001537")]
			[Address(RVA = "0x326D680", Offset = "0x326BC80", VA = "0x18326D680")]
			public ColorWheelGroup(int minSizePerWheel, int maxSizePerWheel)
			{
			}

			// Token: 0x04001586 RID: 5510
			[Token(Token = "0x4001586")]
			[FieldOffset(Offset = "0x18")]
			public int minSizePerWheel;

			// Token: 0x04001587 RID: 5511
			[Token(Token = "0x4001587")]
			[FieldOffset(Offset = "0x1C")]
			public int maxSizePerWheel;
		}

		// Token: 0x02000345 RID: 837
		[Token(Token = "0x2000345")]
		public class Curve : PropertyAttribute
		{
			// Token: 0x06001538 RID: 5432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001538")]
			[Address(RVA = "0x326D690", Offset = "0x326BC90", VA = "0x18326D690")]
			public Curve()
			{
			}

			// Token: 0x06001539 RID: 5433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001539")]
			[Address(RVA = "0x326D6A0", Offset = "0x326BCA0", VA = "0x18326D6A0")]
			public Curve(float r, float g, float b, float a)
			{
			}

			// Token: 0x04001588 RID: 5512
			[Token(Token = "0x4001588")]
			[FieldOffset(Offset = "0x18")]
			public Color color;
		}

		// Token: 0x02000346 RID: 838
		[Token(Token = "0x2000346")]
		[Serializable]
		public struct EyeAdaptationSettings
		{
			// Token: 0x1700030F RID: 783
			// (get) Token: 0x0600153A RID: 5434 RVA: 0x00006F60 File Offset: 0x00005160
			[Token(Token = "0x1700030F")]
			public static TonemappingColorGrading.EyeAdaptationSettings defaultSettings
			{
				[Token(Token = "0x600153A")]
				[Address(RVA = "0x326D6E0", Offset = "0x326BCE0", VA = "0x18326D6E0")]
				get
				{
					return default(TonemappingColorGrading.EyeAdaptationSettings);
				}
			}

			// Token: 0x04001589 RID: 5513
			[Token(Token = "0x4001589")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x0400158A RID: 5514
			[Token(Token = "0x400158A")]
			[FieldOffset(Offset = "0x4")]
			[Min(0f)]
			[Tooltip("Midpoint Adjustment.")]
			public float middleGrey;

			// Token: 0x0400158B RID: 5515
			[Token(Token = "0x400158B")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("The lowest possible exposure value; adjust this value to modify the brightest areas of your level.")]
			public float min;

			// Token: 0x0400158C RID: 5516
			[Token(Token = "0x400158C")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("The highest possible exposure value; adjust this value to modify the darkest areas of your level.")]
			public float max;

			// Token: 0x0400158D RID: 5517
			[Token(Token = "0x400158D")]
			[FieldOffset(Offset = "0x10")]
			[Min(0f)]
			[Tooltip("Speed of linear adaptation. Higher is faster.")]
			public float speed;

			// Token: 0x0400158E RID: 5518
			[Token(Token = "0x400158E")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Displays a luminosity helper in the GameView.")]
			public bool showDebug;
		}

		// Token: 0x02000347 RID: 839
		[Token(Token = "0x2000347")]
		public enum Tonemapper
		{
			// Token: 0x04001590 RID: 5520
			[Token(Token = "0x4001590")]
			ACES,
			// Token: 0x04001591 RID: 5521
			[Token(Token = "0x4001591")]
			Curve,
			// Token: 0x04001592 RID: 5522
			[Token(Token = "0x4001592")]
			Hable,
			// Token: 0x04001593 RID: 5523
			[Token(Token = "0x4001593")]
			HejlDawson,
			// Token: 0x04001594 RID: 5524
			[Token(Token = "0x4001594")]
			Photographic,
			// Token: 0x04001595 RID: 5525
			[Token(Token = "0x4001595")]
			Reinhard,
			// Token: 0x04001596 RID: 5526
			[Token(Token = "0x4001596")]
			Neutral
		}

		// Token: 0x02000348 RID: 840
		[Token(Token = "0x2000348")]
		[Serializable]
		public struct TonemappingSettings
		{
			// Token: 0x17000310 RID: 784
			// (get) Token: 0x0600153B RID: 5435 RVA: 0x00006F78 File Offset: 0x00005178
			[Token(Token = "0x17000310")]
			public static TonemappingColorGrading.TonemappingSettings defaultSettings
			{
				[Token(Token = "0x600153B")]
				[Address(RVA = "0x326D710", Offset = "0x326BD10", VA = "0x18326D710")]
				get
				{
					return default(TonemappingColorGrading.TonemappingSettings);
				}
			}

			// Token: 0x04001597 RID: 5527
			[Token(Token = "0x4001597")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x04001598 RID: 5528
			[Token(Token = "0x4001598")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Tonemapping technique to use. ACES is the recommended one.")]
			public TonemappingColorGrading.Tonemapper tonemapper;

			// Token: 0x04001599 RID: 5529
			[Token(Token = "0x4001599")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Adjusts the overall exposure of the scene.")]
			[Min(0f)]
			public float exposure;

			// Token: 0x0400159A RID: 5530
			[Token(Token = "0x400159A")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Custom tonemapping curve.")]
			public AnimationCurve curve;

			// Token: 0x0400159B RID: 5531
			[Token(Token = "0x400159B")]
			[FieldOffset(Offset = "0x18")]
			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			// Token: 0x0400159C RID: 5532
			[Token(Token = "0x400159C")]
			[FieldOffset(Offset = "0x1C")]
			[Range(1f, 20f)]
			public float neutralWhiteIn;

			// Token: 0x0400159D RID: 5533
			[Token(Token = "0x400159D")]
			[FieldOffset(Offset = "0x20")]
			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			// Token: 0x0400159E RID: 5534
			[Token(Token = "0x400159E")]
			[FieldOffset(Offset = "0x24")]
			[Range(1f, 19f)]
			public float neutralWhiteOut;

			// Token: 0x0400159F RID: 5535
			[Token(Token = "0x400159F")]
			[FieldOffset(Offset = "0x28")]
			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			// Token: 0x040015A0 RID: 5536
			[Token(Token = "0x40015A0")]
			[FieldOffset(Offset = "0x2C")]
			[Range(1f, 10f)]
			public float neutralWhiteClip;
		}

		// Token: 0x02000349 RID: 841
		[Token(Token = "0x2000349")]
		[Serializable]
		public struct LUTSettings
		{
			// Token: 0x17000311 RID: 785
			// (get) Token: 0x0600153C RID: 5436 RVA: 0x00006F90 File Offset: 0x00005190
			[Token(Token = "0x17000311")]
			public static TonemappingColorGrading.LUTSettings defaultSettings
			{
				[Token(Token = "0x600153C")]
				[Address(RVA = "0x326D7C0", Offset = "0x326BDC0", VA = "0x18326D7C0")]
				get
				{
					return default(TonemappingColorGrading.LUTSettings);
				}
			}

			// Token: 0x040015A1 RID: 5537
			[Token(Token = "0x40015A1")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x040015A2 RID: 5538
			[Token(Token = "0x40015A2")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture texture;

			// Token: 0x040015A3 RID: 5539
			[Token(Token = "0x40015A3")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Blending factor.")]
			[Range(0f, 1f)]
			public float contribution;
		}

		// Token: 0x0200034A RID: 842
		[Token(Token = "0x200034A")]
		[Serializable]
		public struct ColorWheelsSettings
		{
			// Token: 0x17000312 RID: 786
			// (get) Token: 0x0600153D RID: 5437 RVA: 0x00006FA8 File Offset: 0x000051A8
			[Token(Token = "0x17000312")]
			public static TonemappingColorGrading.ColorWheelsSettings defaultSettings
			{
				[Token(Token = "0x600153D")]
				[Address(RVA = "0x326D830", Offset = "0x326BE30", VA = "0x18326D830")]
				get
				{
					return default(TonemappingColorGrading.ColorWheelsSettings);
				}
			}

			// Token: 0x040015A4 RID: 5540
			[Token(Token = "0x40015A4")]
			[FieldOffset(Offset = "0x0")]
			[ColorUsage(false)]
			public Color shadows;

			// Token: 0x040015A5 RID: 5541
			[Token(Token = "0x40015A5")]
			[FieldOffset(Offset = "0x10")]
			[ColorUsage(false)]
			public Color midtones;

			// Token: 0x040015A6 RID: 5542
			[Token(Token = "0x40015A6")]
			[FieldOffset(Offset = "0x20")]
			[ColorUsage(false)]
			public Color highlights;
		}

		// Token: 0x0200034B RID: 843
		[Token(Token = "0x200034B")]
		[Serializable]
		public struct BasicsSettings
		{
			// Token: 0x17000313 RID: 787
			// (get) Token: 0x0600153E RID: 5438 RVA: 0x00006FC0 File Offset: 0x000051C0
			[Token(Token = "0x17000313")]
			public static TonemappingColorGrading.BasicsSettings defaultSettings
			{
				[Token(Token = "0x600153E")]
				[Address(RVA = "0x326D850", Offset = "0x326BE50", VA = "0x18326D850")]
				get
				{
					return default(TonemappingColorGrading.BasicsSettings);
				}
			}

			// Token: 0x040015A7 RID: 5543
			[Token(Token = "0x40015A7")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Sets the white balance to a custom color temperature.")]
			[Range(-2f, 2f)]
			public float temperatureShift;

			// Token: 0x040015A8 RID: 5544
			[Token(Token = "0x40015A8")]
			[FieldOffset(Offset = "0x4")]
			[Range(-2f, 2f)]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			// Token: 0x040015A9 RID: 5545
			[Token(Token = "0x40015A9")]
			[FieldOffset(Offset = "0x8")]
			[Range(-0.5f, 0.5f)]
			[Space]
			[Tooltip("Shift the hue of all colors.")]
			public float hue;

			// Token: 0x040015AA RID: 5546
			[Token(Token = "0x40015AA")]
			[FieldOffset(Offset = "0xC")]
			[Range(0f, 2f)]
			[Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			// Token: 0x040015AB RID: 5547
			[Token(Token = "0x40015AB")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Adjusts the saturation so that clipping is minimized as colors approach full saturation.")]
			[Range(-1f, 1f)]
			public float vibrance;

			// Token: 0x040015AC RID: 5548
			[Token(Token = "0x40015AC")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Brightens or darkens all colors.")]
			[Range(0f, 10f)]
			public float value;

			// Token: 0x040015AD RID: 5549
			[Token(Token = "0x40015AD")]
			[FieldOffset(Offset = "0x18")]
			[Space]
			[Range(0f, 2f)]
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			public float contrast;

			// Token: 0x040015AE RID: 5550
			[Token(Token = "0x40015AE")]
			[FieldOffset(Offset = "0x1C")]
			[Tooltip("Contrast gain curve. Controls the steepness of the curve.")]
			[Range(0.01f, 5f)]
			public float gain;

			// Token: 0x040015AF RID: 5551
			[Token(Token = "0x40015AF")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Applies a pow function to the source.")]
			[Range(0.01f, 5f)]
			public float gamma;
		}

		// Token: 0x0200034C RID: 844
		[Token(Token = "0x200034C")]
		[Serializable]
		public struct ChannelMixerSettings
		{
			// Token: 0x17000314 RID: 788
			// (get) Token: 0x0600153F RID: 5439 RVA: 0x00006FD8 File Offset: 0x000051D8
			[Token(Token = "0x17000314")]
			public static TonemappingColorGrading.ChannelMixerSettings defaultSettings
			{
				[Token(Token = "0x600153F")]
				[Address(RVA = "0x326D880", Offset = "0x326BE80", VA = "0x18326D880")]
				get
				{
					return default(TonemappingColorGrading.ChannelMixerSettings);
				}
			}

			// Token: 0x040015B0 RID: 5552
			[Token(Token = "0x40015B0")]
			[FieldOffset(Offset = "0x0")]
			public int currentChannel;

			// Token: 0x040015B1 RID: 5553
			[Token(Token = "0x40015B1")]
			[FieldOffset(Offset = "0x8")]
			public Vector3[] channels;
		}

		// Token: 0x0200034D RID: 845
		[Token(Token = "0x200034D")]
		[Serializable]
		public struct CurvesSettings
		{
			// Token: 0x17000315 RID: 789
			// (get) Token: 0x06001540 RID: 5440 RVA: 0x00006FF0 File Offset: 0x000051F0
			[Token(Token = "0x17000315")]
			public static TonemappingColorGrading.CurvesSettings defaultSettings
			{
				[Token(Token = "0x6001540")]
				[Address(RVA = "0x326D9B0", Offset = "0x326BFB0", VA = "0x18326D9B0")]
				get
				{
					return default(TonemappingColorGrading.CurvesSettings);
				}
			}

			// Token: 0x17000316 RID: 790
			// (get) Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000316")]
			public static AnimationCurve defaultCurve
			{
				[Token(Token = "0x6001541")]
				[Address(RVA = "0x326DB30", Offset = "0x326C130", VA = "0x18326DB30")]
				get
				{
					return null;
				}
			}

			// Token: 0x040015B2 RID: 5554
			[Token(Token = "0x40015B2")]
			[FieldOffset(Offset = "0x0")]
			[TonemappingColorGrading.Curve]
			public AnimationCurve master;

			// Token: 0x040015B3 RID: 5555
			[Token(Token = "0x40015B3")]
			[FieldOffset(Offset = "0x8")]
			[TonemappingColorGrading.Curve(1f, 0f, 0f, 1f)]
			public AnimationCurve red;

			// Token: 0x040015B4 RID: 5556
			[Token(Token = "0x40015B4")]
			[FieldOffset(Offset = "0x10")]
			[TonemappingColorGrading.Curve(0f, 1f, 0f, 1f)]
			public AnimationCurve green;

			// Token: 0x040015B5 RID: 5557
			[Token(Token = "0x40015B5")]
			[FieldOffset(Offset = "0x18")]
			[TonemappingColorGrading.Curve(0f, 1f, 1f, 1f)]
			public AnimationCurve blue;
		}

		// Token: 0x0200034E RID: 846
		[Token(Token = "0x200034E")]
		public enum ColorGradingPrecision
		{
			// Token: 0x040015B7 RID: 5559
			[Token(Token = "0x40015B7")]
			Normal = 16,
			// Token: 0x040015B8 RID: 5560
			[Token(Token = "0x40015B8")]
			High = 32
		}

		// Token: 0x0200034F RID: 847
		[Token(Token = "0x200034F")]
		[Serializable]
		public struct ColorGradingSettings
		{
			// Token: 0x17000317 RID: 791
			// (get) Token: 0x06001542 RID: 5442 RVA: 0x00007008 File Offset: 0x00005208
			[Token(Token = "0x17000317")]
			public static TonemappingColorGrading.ColorGradingSettings defaultSettings
			{
				[Token(Token = "0x6001542")]
				[Address(RVA = "0x326DC50", Offset = "0x326C250", VA = "0x18326DC50")]
				get
				{
					return default(TonemappingColorGrading.ColorGradingSettings);
				}
			}

			// Token: 0x06001543 RID: 5443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001543")]
			[Address(RVA = "0x326DF00", Offset = "0x326C500", VA = "0x18326DF00")]
			internal void Reset()
			{
			}

			// Token: 0x040015B9 RID: 5561
			[Token(Token = "0x40015B9")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x040015BA RID: 5562
			[Token(Token = "0x40015BA")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Internal LUT precision. \"Normal\" is 256x16, \"High\" is 1024x32. Prefer \"Normal\" on mobile devices.")]
			public TonemappingColorGrading.ColorGradingPrecision precision;

			// Token: 0x040015BB RID: 5563
			[Token(Token = "0x40015BB")]
			[FieldOffset(Offset = "0x8")]
			[Space]
			[TonemappingColorGrading.ColorWheelGroup]
			public TonemappingColorGrading.ColorWheelsSettings colorWheels;

			// Token: 0x040015BC RID: 5564
			[Token(Token = "0x40015BC")]
			[FieldOffset(Offset = "0x38")]
			[TonemappingColorGrading.IndentedGroup]
			[Space]
			public TonemappingColorGrading.BasicsSettings basics;

			// Token: 0x040015BD RID: 5565
			[Token(Token = "0x40015BD")]
			[FieldOffset(Offset = "0x60")]
			[TonemappingColorGrading.ChannelMixer]
			[Space]
			public TonemappingColorGrading.ChannelMixerSettings channelMixer;

			// Token: 0x040015BE RID: 5566
			[Token(Token = "0x40015BE")]
			[FieldOffset(Offset = "0x70")]
			[TonemappingColorGrading.IndentedGroup]
			[Space]
			public TonemappingColorGrading.CurvesSettings curves;

			// Token: 0x040015BF RID: 5567
			[Token(Token = "0x40015BF")]
			[FieldOffset(Offset = "0x90")]
			[Tooltip("Use dithering to try and minimize color banding in dark areas.")]
			[Space]
			public bool useDithering;

			// Token: 0x040015C0 RID: 5568
			[Token(Token = "0x40015C0")]
			[FieldOffset(Offset = "0x91")]
			[Tooltip("Displays the generated LUT in the top left corner of the GameView.")]
			public bool showDebug;
		}

		// Token: 0x02000350 RID: 848
		[Token(Token = "0x2000350")]
		private enum Pass
		{
			// Token: 0x040015C2 RID: 5570
			[Token(Token = "0x40015C2")]
			LutGen,
			// Token: 0x040015C3 RID: 5571
			[Token(Token = "0x40015C3")]
			AdaptationLog,
			// Token: 0x040015C4 RID: 5572
			[Token(Token = "0x40015C4")]
			AdaptationExpBlend,
			// Token: 0x040015C5 RID: 5573
			[Token(Token = "0x40015C5")]
			AdaptationExp,
			// Token: 0x040015C6 RID: 5574
			[Token(Token = "0x40015C6")]
			TonemappingOff,
			// Token: 0x040015C7 RID: 5575
			[Token(Token = "0x40015C7")]
			TonemappingACES,
			// Token: 0x040015C8 RID: 5576
			[Token(Token = "0x40015C8")]
			TonemappingCurve,
			// Token: 0x040015C9 RID: 5577
			[Token(Token = "0x40015C9")]
			TonemappingHable,
			// Token: 0x040015CA RID: 5578
			[Token(Token = "0x40015CA")]
			TonemappingHejlDawson,
			// Token: 0x040015CB RID: 5579
			[Token(Token = "0x40015CB")]
			TonemappingPhotographic,
			// Token: 0x040015CC RID: 5580
			[Token(Token = "0x40015CC")]
			TonemappingReinhard,
			// Token: 0x040015CD RID: 5581
			[Token(Token = "0x40015CD")]
			TonemappingNeutral,
			// Token: 0x040015CE RID: 5582
			[Token(Token = "0x40015CE")]
			AdaptationDebug
		}
	}
}
