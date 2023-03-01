using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200034E RID: 846
	[Token(Token = "0x200034E")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Tonemapping and Color Grading")]
	[ImageEffectAllowedInSceneView]
	public class TonemappingColorGrading : MonoBehaviour
	{
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x00006BD0 File Offset: 0x00004DD0
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002F9")]
		public TonemappingColorGrading.EyeAdaptationSettings eyeAdaptation
		{
			[Token(Token = "0x60014E2")]
			[Address(RVA = "0x894D60", Offset = "0x893D60", VA = "0x180894D60")]
			get
			{
				return default(TonemappingColorGrading.EyeAdaptationSettings);
			}
			[Token(Token = "0x60014E3")]
			[Address(RVA = "0x894D80", Offset = "0x893D80", VA = "0x180894D80")]
			set
			{
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x00006BE8 File Offset: 0x00004DE8
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002FA")]
		public TonemappingColorGrading.TonemappingSettings tonemapping
		{
			[Token(Token = "0x60014E4")]
			[Address(RVA = "0x1CE2EE0", Offset = "0x1CE1EE0", VA = "0x181CE2EE0")]
			get
			{
				return default(TonemappingColorGrading.TonemappingSettings);
			}
			[Token(Token = "0x60014E5")]
			[Address(RVA = "0x2CBDCB0", Offset = "0x2CBCCB0", VA = "0x182CBDCB0")]
			set
			{
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00006C00 File Offset: 0x00004E00
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002FB")]
		public TonemappingColorGrading.ColorGradingSettings colorGrading
		{
			[Token(Token = "0x60014E6")]
			[Address(RVA = "0x2CBD460", Offset = "0x2CBC460", VA = "0x182CBD460")]
			get
			{
				return default(TonemappingColorGrading.ColorGradingSettings);
			}
			[Token(Token = "0x60014E7")]
			[Address(RVA = "0x2CBDBE0", Offset = "0x2CBCBE0", VA = "0x182CBDBE0")]
			set
			{
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x00006C18 File Offset: 0x00004E18
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002FC")]
		public TonemappingColorGrading.LUTSettings lut
		{
			[Token(Token = "0x60014E8")]
			[Address(RVA = "0x2CBD900", Offset = "0x2CBC900", VA = "0x182CBD900")]
			get
			{
				return default(TonemappingColorGrading.LUTSettings);
			}
			[Token(Token = "0x60014E9")]
			[Address(RVA = "0x2CBDC80", Offset = "0x2CBCC80", VA = "0x182CBDC80")]
			set
			{
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FD")]
		private Texture2D identityLut
		{
			[Token(Token = "0x60014EA")]
			[Address(RVA = "0x2CBD610", Offset = "0x2CBC610", VA = "0x182CBD610")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FE")]
		private RenderTexture internalLutRt
		{
			[Token(Token = "0x60014EB")]
			[Address(RVA = "0x2CBD700", Offset = "0x2CBC700", VA = "0x182CBD700")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FF")]
		private Texture2D curveTexture
		{
			[Token(Token = "0x60014EC")]
			[Address(RVA = "0x2CBD4E0", Offset = "0x2CBC4E0", VA = "0x182CBD4E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000300")]
		private Texture2D tonemapperCurve
		{
			[Token(Token = "0x60014ED")]
			[Address(RVA = "0x2CBDA60", Offset = "0x2CBCA60", VA = "0x182CBDA60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000301")]
		public Shader shader
		{
			[Token(Token = "0x60014EE")]
			[Address(RVA = "0x2CBD9C0", Offset = "0x2CBC9C0", VA = "0x182CBD9C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000302")]
		public Material material
		{
			[Token(Token = "0x60014EF")]
			[Address(RVA = "0x2CBD920", Offset = "0x2CBC920", VA = "0x182CBD920")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00006C30 File Offset: 0x00004E30
		[Token(Token = "0x17000303")]
		public bool isGammaColorSpace
		{
			[Token(Token = "0x60014F0")]
			[Address(RVA = "0x2CBD8C0", Offset = "0x2CBC8C0", VA = "0x182CBD8C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x00006C48 File Offset: 0x00004E48
		[Token(Token = "0x17000304")]
		public int lutSize
		{
			[Token(Token = "0x60014F1")]
			[Address(RVA = "0x2CBD8E0", Offset = "0x2CBC8E0", VA = "0x182CBD8E0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x00006C60 File Offset: 0x00004E60
		// (set) Token: 0x060014F3 RID: 5363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000305")]
		public bool validRenderTextureFormat
		{
			[Token(Token = "0x60014F2")]
			[Address(RVA = "0x2CBDBC0", Offset = "0x2CBCBC0", VA = "0x182CBDBC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60014F3")]
			[Address(RVA = "0x2CBDCF0", Offset = "0x2CBCCF0", VA = "0x182CBDCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00006C78 File Offset: 0x00004E78
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000306")]
		public bool validUserLutSize
		{
			[Token(Token = "0x60014F4")]
			[Address(RVA = "0x2CBDBD0", Offset = "0x2CBCBD0", VA = "0x182CBDBD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60014F5")]
			[Address(RVA = "0x2CBDD00", Offset = "0x2CBCD00", VA = "0x182CBDD00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x2CBD210", Offset = "0x2CBC210", VA = "0x182CBD210")]
		public void SetDirty()
		{
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x2CBD220", Offset = "0x2CBC220", VA = "0x182CBD220")]
		public void SetTonemapperDirty()
		{
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x2CB8A80", Offset = "0x2CB7A80", VA = "0x182CB8A80")]
		private void Awake()
		{
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x2CB9F70", Offset = "0x2CB8F70", VA = "0x182CB9F70")]
		private void OnEnable()
		{
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x2CB9C90", Offset = "0x2CB8C90", VA = "0x182CB9C90")]
		private void OnDisable()
		{
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x2CBD200", Offset = "0x2CBC200", VA = "0x182CBD200")]
		private void OnValidate()
		{
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x2CB9490", Offset = "0x2CB8490", VA = "0x182CB9490")]
		private static Texture2D GenerateIdentityLut(int dim)
		{
			return null;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00006C90 File Offset: 0x00004E90
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x2CBD230", Offset = "0x2CBC230", VA = "0x182CBD230")]
		private float StandardIlluminantY(float x)
		{
			return default(float);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00006CA8 File Offset: 0x00004EA8
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x2CB8F60", Offset = "0x2CB7F60", VA = "0x182CB8F60")]
		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00006CC0 File Offset: 0x00004EC0
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x2CB9A90", Offset = "0x2CB8A90", VA = "0x182CB9A90")]
		private Vector3 GetWhiteBalance()
		{
			return default(Vector3);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00006CD8 File Offset: 0x00004ED8
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x2CB9BD0", Offset = "0x2CB8BD0", VA = "0x182CB9BD0")]
		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x2CB9670", Offset = "0x2CB8670", VA = "0x182CB9670")]
		private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain)
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x2CB91C0", Offset = "0x2CB81C0", VA = "0x182CB91C0")]
		private void GenCurveTexture()
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x2CB9110", Offset = "0x2CB8110", VA = "0x182CB9110")]
		private bool CheckUserLut()
		{
			return default(bool);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00006D08 File Offset: 0x00004F08
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x2CB8FF0", Offset = "0x2CB7FF0", VA = "0x182CB8FF0")]
		private bool CheckSmallAdaptiveRt()
		{
			return default(bool);
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x2CB9FC0", Offset = "0x2CB8FC0", VA = "0x182CB9FC0")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x2CB8DD0", Offset = "0x2CB7DD0", VA = "0x182CB8DD0")]
		public Texture2D BakeLUT()
		{
			return null;
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x2CBD260", Offset = "0x2CBC260", VA = "0x182CBD260")]
		public TonemappingColorGrading()
		{
		}

		// Token: 0x0400153D RID: 5437
		[Token(Token = "0x400153D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[TonemappingColorGrading.SettingsGroup]
		private TonemappingColorGrading.EyeAdaptationSettings m_EyeAdaptation;

		// Token: 0x0400153E RID: 5438
		[Token(Token = "0x400153E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[TonemappingColorGrading.SettingsGroup]
		private TonemappingColorGrading.TonemappingSettings m_Tonemapping;

		// Token: 0x0400153F RID: 5439
		[Token(Token = "0x400153F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[TonemappingColorGrading.SettingsGroup]
		private TonemappingColorGrading.ColorGradingSettings m_ColorGrading;

		// Token: 0x04001540 RID: 5440
		[Token(Token = "0x4001540")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[TonemappingColorGrading.SettingsGroup]
		private TonemappingColorGrading.LUTSettings m_Lut;

		// Token: 0x04001541 RID: 5441
		[Token(Token = "0x4001541")]
		[FieldOffset(Offset = "0x118")]
		private Texture2D m_IdentityLut;

		// Token: 0x04001542 RID: 5442
		[Token(Token = "0x4001542")]
		[FieldOffset(Offset = "0x120")]
		private RenderTexture m_InternalLut;

		// Token: 0x04001543 RID: 5443
		[Token(Token = "0x4001543")]
		[FieldOffset(Offset = "0x128")]
		private Texture2D m_CurveTexture;

		// Token: 0x04001544 RID: 5444
		[Token(Token = "0x4001544")]
		[FieldOffset(Offset = "0x130")]
		private Texture2D m_TonemapperCurve;

		// Token: 0x04001545 RID: 5445
		[Token(Token = "0x4001545")]
		[FieldOffset(Offset = "0x138")]
		private float m_TonemapperCurveRange;

		// Token: 0x04001546 RID: 5446
		[Token(Token = "0x4001546")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Shader m_Shader;

		// Token: 0x04001547 RID: 5447
		[Token(Token = "0x4001547")]
		[FieldOffset(Offset = "0x148")]
		private Material m_Material;

		// Token: 0x0400154A RID: 5450
		[Token(Token = "0x400154A")]
		[FieldOffset(Offset = "0x152")]
		private bool m_Dirty;

		// Token: 0x0400154B RID: 5451
		[Token(Token = "0x400154B")]
		[FieldOffset(Offset = "0x153")]
		private bool m_TonemapperDirty;

		// Token: 0x0400154C RID: 5452
		[Token(Token = "0x400154C")]
		[FieldOffset(Offset = "0x158")]
		private RenderTexture m_SmallAdaptiveRt;

		// Token: 0x0400154D RID: 5453
		[Token(Token = "0x400154D")]
		[FieldOffset(Offset = "0x160")]
		private RenderTextureFormat m_AdaptiveRtFormat;

		// Token: 0x0400154E RID: 5454
		[Token(Token = "0x400154E")]
		[FieldOffset(Offset = "0x164")]
		private int m_AdaptationSpeed;

		// Token: 0x0400154F RID: 5455
		[Token(Token = "0x400154F")]
		[FieldOffset(Offset = "0x168")]
		private int m_MiddleGrey;

		// Token: 0x04001550 RID: 5456
		[Token(Token = "0x4001550")]
		[FieldOffset(Offset = "0x16C")]
		private int m_AdaptationMin;

		// Token: 0x04001551 RID: 5457
		[Token(Token = "0x4001551")]
		[FieldOffset(Offset = "0x170")]
		private int m_AdaptationMax;

		// Token: 0x04001552 RID: 5458
		[Token(Token = "0x4001552")]
		[FieldOffset(Offset = "0x174")]
		private int m_LumTex;

		// Token: 0x04001553 RID: 5459
		[Token(Token = "0x4001553")]
		[FieldOffset(Offset = "0x178")]
		private int m_ToneCurveRange;

		// Token: 0x04001554 RID: 5460
		[Token(Token = "0x4001554")]
		[FieldOffset(Offset = "0x17C")]
		private int m_ToneCurve;

		// Token: 0x04001555 RID: 5461
		[Token(Token = "0x4001555")]
		[FieldOffset(Offset = "0x180")]
		private int m_Exposure;

		// Token: 0x04001556 RID: 5462
		[Token(Token = "0x4001556")]
		[FieldOffset(Offset = "0x184")]
		private int m_NeutralTonemapperParams1;

		// Token: 0x04001557 RID: 5463
		[Token(Token = "0x4001557")]
		[FieldOffset(Offset = "0x188")]
		private int m_NeutralTonemapperParams2;

		// Token: 0x04001558 RID: 5464
		[Token(Token = "0x4001558")]
		[FieldOffset(Offset = "0x18C")]
		private int m_WhiteBalance;

		// Token: 0x04001559 RID: 5465
		[Token(Token = "0x4001559")]
		[FieldOffset(Offset = "0x190")]
		private int m_Lift;

		// Token: 0x0400155A RID: 5466
		[Token(Token = "0x400155A")]
		[FieldOffset(Offset = "0x194")]
		private int m_Gamma;

		// Token: 0x0400155B RID: 5467
		[Token(Token = "0x400155B")]
		[FieldOffset(Offset = "0x198")]
		private int m_Gain;

		// Token: 0x0400155C RID: 5468
		[Token(Token = "0x400155C")]
		[FieldOffset(Offset = "0x19C")]
		private int m_ContrastGainGamma;

		// Token: 0x0400155D RID: 5469
		[Token(Token = "0x400155D")]
		[FieldOffset(Offset = "0x1A0")]
		private int m_Vibrance;

		// Token: 0x0400155E RID: 5470
		[Token(Token = "0x400155E")]
		[FieldOffset(Offset = "0x1A4")]
		private int m_HSV;

		// Token: 0x0400155F RID: 5471
		[Token(Token = "0x400155F")]
		[FieldOffset(Offset = "0x1A8")]
		private int m_ChannelMixerRed;

		// Token: 0x04001560 RID: 5472
		[Token(Token = "0x4001560")]
		[FieldOffset(Offset = "0x1AC")]
		private int m_ChannelMixerGreen;

		// Token: 0x04001561 RID: 5473
		[Token(Token = "0x4001561")]
		[FieldOffset(Offset = "0x1B0")]
		private int m_ChannelMixerBlue;

		// Token: 0x04001562 RID: 5474
		[Token(Token = "0x4001562")]
		[FieldOffset(Offset = "0x1B4")]
		private int m_CurveTex;

		// Token: 0x04001563 RID: 5475
		[Token(Token = "0x4001563")]
		[FieldOffset(Offset = "0x1B8")]
		private int m_InternalLutTex;

		// Token: 0x04001564 RID: 5476
		[Token(Token = "0x4001564")]
		[FieldOffset(Offset = "0x1BC")]
		private int m_InternalLutParams;

		// Token: 0x04001565 RID: 5477
		[Token(Token = "0x4001565")]
		[FieldOffset(Offset = "0x1C0")]
		private int m_UserLutTex;

		// Token: 0x04001566 RID: 5478
		[Token(Token = "0x4001566")]
		[FieldOffset(Offset = "0x1C4")]
		private int m_UserLutParams;

		// Token: 0x04001567 RID: 5479
		[Token(Token = "0x4001567")]
		[FieldOffset(Offset = "0x1C8")]
		private RenderTexture[] m_AdaptRts;

		// Token: 0x0200034F RID: 847
		[Token(Token = "0x200034F")]
		[AttributeUsage(256)]
		public class SettingsGroup : Attribute
		{
			// Token: 0x06001508 RID: 5384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001508")]
			[Address(RVA = "0x54C690", Offset = "0x54B690", VA = "0x18054C690")]
			public SettingsGroup()
			{
			}
		}

		// Token: 0x02000350 RID: 848
		[Token(Token = "0x2000350")]
		public class IndentedGroup : PropertyAttribute
		{
			// Token: 0x06001509 RID: 5385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001509")]
			[Address(RVA = "0x62A570", Offset = "0x629570", VA = "0x18062A570")]
			public IndentedGroup()
			{
			}
		}

		// Token: 0x02000351 RID: 849
		[Token(Token = "0x2000351")]
		public class ChannelMixer : PropertyAttribute
		{
			// Token: 0x0600150A RID: 5386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600150A")]
			[Address(RVA = "0x62A570", Offset = "0x629570", VA = "0x18062A570")]
			public ChannelMixer()
			{
			}
		}

		// Token: 0x02000352 RID: 850
		[Token(Token = "0x2000352")]
		public class ColorWheelGroup : PropertyAttribute
		{
			// Token: 0x0600150B RID: 5387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600150B")]
			[Address(RVA = "0x2CAE950", Offset = "0x2CAD950", VA = "0x182CAE950")]
			public ColorWheelGroup()
			{
			}

			// Token: 0x0600150C RID: 5388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600150C")]
			[Address(RVA = "0x2CAE970", Offset = "0x2CAD970", VA = "0x182CAE970")]
			public ColorWheelGroup(int minSizePerWheel, int maxSizePerWheel)
			{
			}

			// Token: 0x04001568 RID: 5480
			[Token(Token = "0x4001568")]
			[FieldOffset(Offset = "0x18")]
			public int minSizePerWheel;

			// Token: 0x04001569 RID: 5481
			[Token(Token = "0x4001569")]
			[FieldOffset(Offset = "0x1C")]
			public int maxSizePerWheel;
		}

		// Token: 0x02000353 RID: 851
		[Token(Token = "0x2000353")]
		public class Curve : PropertyAttribute
		{
			// Token: 0x0600150D RID: 5389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600150D")]
			[Address(RVA = "0x2CAE9E0", Offset = "0x2CAD9E0", VA = "0x182CAE9E0")]
			public Curve()
			{
			}

			// Token: 0x0600150E RID: 5390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600150E")]
			[Address(RVA = "0x2CAEA00", Offset = "0x2CADA00", VA = "0x182CAEA00")]
			public Curve(float r, float g, float b, float a)
			{
			}

			// Token: 0x0400156A RID: 5482
			[Token(Token = "0x400156A")]
			[FieldOffset(Offset = "0x18")]
			public Color color;
		}

		// Token: 0x02000354 RID: 852
		[Token(Token = "0x2000354")]
		[Serializable]
		public struct EyeAdaptationSettings
		{
			// Token: 0x17000307 RID: 775
			// (get) Token: 0x0600150F RID: 5391 RVA: 0x00006D20 File Offset: 0x00004F20
			[Token(Token = "0x17000307")]
			public static TonemappingColorGrading.EyeAdaptationSettings defaultSettings
			{
				[Token(Token = "0x600150F")]
				[Address(RVA = "0x2CB2810", Offset = "0x2CB1810", VA = "0x182CB2810")]
				get
				{
					return default(TonemappingColorGrading.EyeAdaptationSettings);
				}
			}

			// Token: 0x0400156B RID: 5483
			[Token(Token = "0x400156B")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x0400156C RID: 5484
			[Token(Token = "0x400156C")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Midpoint Adjustment.")]
			[Min(0f)]
			public float middleGrey;

			// Token: 0x0400156D RID: 5485
			[Token(Token = "0x400156D")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("The lowest possible exposure value; adjust this value to modify the brightest areas of your level.")]
			public float min;

			// Token: 0x0400156E RID: 5486
			[Token(Token = "0x400156E")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("The highest possible exposure value; adjust this value to modify the darkest areas of your level.")]
			public float max;

			// Token: 0x0400156F RID: 5487
			[Token(Token = "0x400156F")]
			[FieldOffset(Offset = "0x10")]
			[Min(0f)]
			[Tooltip("Speed of linear adaptation. Higher is faster.")]
			public float speed;

			// Token: 0x04001570 RID: 5488
			[Token(Token = "0x4001570")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Displays a luminosity helper in the GameView.")]
			public bool showDebug;
		}

		// Token: 0x02000355 RID: 853
		[Token(Token = "0x2000355")]
		public enum Tonemapper
		{
			// Token: 0x04001572 RID: 5490
			[Token(Token = "0x4001572")]
			ACES,
			// Token: 0x04001573 RID: 5491
			[Token(Token = "0x4001573")]
			Curve,
			// Token: 0x04001574 RID: 5492
			[Token(Token = "0x4001574")]
			Hable,
			// Token: 0x04001575 RID: 5493
			[Token(Token = "0x4001575")]
			HejlDawson,
			// Token: 0x04001576 RID: 5494
			[Token(Token = "0x4001576")]
			Photographic,
			// Token: 0x04001577 RID: 5495
			[Token(Token = "0x4001577")]
			Reinhard,
			// Token: 0x04001578 RID: 5496
			[Token(Token = "0x4001578")]
			Neutral
		}

		// Token: 0x02000356 RID: 854
		[Token(Token = "0x2000356")]
		[Serializable]
		public struct TonemappingSettings
		{
			// Token: 0x17000308 RID: 776
			// (get) Token: 0x06001510 RID: 5392 RVA: 0x00006D38 File Offset: 0x00004F38
			[Token(Token = "0x17000308")]
			public static TonemappingColorGrading.TonemappingSettings defaultSettings
			{
				[Token(Token = "0x6001510")]
				[Address(RVA = "0x2CBDD10", Offset = "0x2CBCD10", VA = "0x182CBDD10")]
				get
				{
					return default(TonemappingColorGrading.TonemappingSettings);
				}
			}

			// Token: 0x04001579 RID: 5497
			[Token(Token = "0x4001579")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x0400157A RID: 5498
			[Token(Token = "0x400157A")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Tonemapping technique to use. ACES is the recommended one.")]
			public TonemappingColorGrading.Tonemapper tonemapper;

			// Token: 0x0400157B RID: 5499
			[Token(Token = "0x400157B")]
			[FieldOffset(Offset = "0x8")]
			[Min(0f)]
			[Tooltip("Adjusts the overall exposure of the scene.")]
			public float exposure;

			// Token: 0x0400157C RID: 5500
			[Token(Token = "0x400157C")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Custom tonemapping curve.")]
			public AnimationCurve curve;

			// Token: 0x0400157D RID: 5501
			[Token(Token = "0x400157D")]
			[FieldOffset(Offset = "0x18")]
			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			// Token: 0x0400157E RID: 5502
			[Token(Token = "0x400157E")]
			[FieldOffset(Offset = "0x1C")]
			[Range(1f, 20f)]
			public float neutralWhiteIn;

			// Token: 0x0400157F RID: 5503
			[Token(Token = "0x400157F")]
			[FieldOffset(Offset = "0x20")]
			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			// Token: 0x04001580 RID: 5504
			[Token(Token = "0x4001580")]
			[FieldOffset(Offset = "0x24")]
			[Range(1f, 19f)]
			public float neutralWhiteOut;

			// Token: 0x04001581 RID: 5505
			[Token(Token = "0x4001581")]
			[FieldOffset(Offset = "0x28")]
			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			// Token: 0x04001582 RID: 5506
			[Token(Token = "0x4001582")]
			[FieldOffset(Offset = "0x2C")]
			[Range(1f, 10f)]
			public float neutralWhiteClip;
		}

		// Token: 0x02000357 RID: 855
		[Token(Token = "0x2000357")]
		[Serializable]
		public struct LUTSettings
		{
			// Token: 0x17000309 RID: 777
			// (get) Token: 0x06001511 RID: 5393 RVA: 0x00006D50 File Offset: 0x00004F50
			[Token(Token = "0x17000309")]
			public static TonemappingColorGrading.LUTSettings defaultSettings
			{
				[Token(Token = "0x6001511")]
				[Address(RVA = "0x2CB2EC0", Offset = "0x2CB1EC0", VA = "0x182CB2EC0")]
				get
				{
					return default(TonemappingColorGrading.LUTSettings);
				}
			}

			// Token: 0x04001583 RID: 5507
			[Token(Token = "0x4001583")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x04001584 RID: 5508
			[Token(Token = "0x4001584")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture texture;

			// Token: 0x04001585 RID: 5509
			[Token(Token = "0x4001585")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Blending factor.")]
			[Range(0f, 1f)]
			public float contribution;
		}

		// Token: 0x02000358 RID: 856
		[Token(Token = "0x2000358")]
		[Serializable]
		public struct ColorWheelsSettings
		{
			// Token: 0x1700030A RID: 778
			// (get) Token: 0x06001512 RID: 5394 RVA: 0x00006D68 File Offset: 0x00004F68
			[Token(Token = "0x1700030A")]
			public static TonemappingColorGrading.ColorWheelsSettings defaultSettings
			{
				[Token(Token = "0x6001512")]
				[Address(RVA = "0x2CAE9C0", Offset = "0x2CAD9C0", VA = "0x182CAE9C0")]
				get
				{
					return default(TonemappingColorGrading.ColorWheelsSettings);
				}
			}

			// Token: 0x04001586 RID: 5510
			[Token(Token = "0x4001586")]
			[FieldOffset(Offset = "0x0")]
			[ColorUsage(false)]
			public Color shadows;

			// Token: 0x04001587 RID: 5511
			[Token(Token = "0x4001587")]
			[FieldOffset(Offset = "0x10")]
			[ColorUsage(false)]
			public Color midtones;

			// Token: 0x04001588 RID: 5512
			[Token(Token = "0x4001588")]
			[FieldOffset(Offset = "0x20")]
			[ColorUsage(false)]
			public Color highlights;
		}

		// Token: 0x02000359 RID: 857
		[Token(Token = "0x2000359")]
		[Serializable]
		public struct BasicsSettings
		{
			// Token: 0x1700030B RID: 779
			// (get) Token: 0x06001513 RID: 5395 RVA: 0x00006D80 File Offset: 0x00004F80
			[Token(Token = "0x1700030B")]
			public static TonemappingColorGrading.BasicsSettings defaultSettings
			{
				[Token(Token = "0x6001513")]
				[Address(RVA = "0x2CADCF0", Offset = "0x2CACCF0", VA = "0x182CADCF0")]
				get
				{
					return default(TonemappingColorGrading.BasicsSettings);
				}
			}

			// Token: 0x04001589 RID: 5513
			[Token(Token = "0x4001589")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Sets the white balance to a custom color temperature.")]
			[Range(-2f, 2f)]
			public float temperatureShift;

			// Token: 0x0400158A RID: 5514
			[Token(Token = "0x400158A")]
			[FieldOffset(Offset = "0x4")]
			[Range(-2f, 2f)]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			// Token: 0x0400158B RID: 5515
			[Token(Token = "0x400158B")]
			[FieldOffset(Offset = "0x8")]
			[Range(-0.5f, 0.5f)]
			[Tooltip("Shift the hue of all colors.")]
			[Space]
			public float hue;

			// Token: 0x0400158C RID: 5516
			[Token(Token = "0x400158C")]
			[FieldOffset(Offset = "0xC")]
			[Range(0f, 2f)]
			[Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			// Token: 0x0400158D RID: 5517
			[Token(Token = "0x400158D")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Adjusts the saturation so that clipping is minimized as colors approach full saturation.")]
			[Range(-1f, 1f)]
			public float vibrance;

			// Token: 0x0400158E RID: 5518
			[Token(Token = "0x400158E")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Brightens or darkens all colors.")]
			[Range(0f, 10f)]
			public float value;

			// Token: 0x0400158F RID: 5519
			[Token(Token = "0x400158F")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			[Space]
			[Range(0f, 2f)]
			public float contrast;

			// Token: 0x04001590 RID: 5520
			[Token(Token = "0x4001590")]
			[FieldOffset(Offset = "0x1C")]
			[Range(0.01f, 5f)]
			[Tooltip("Contrast gain curve. Controls the steepness of the curve.")]
			public float gain;

			// Token: 0x04001591 RID: 5521
			[Token(Token = "0x4001591")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Applies a pow function to the source.")]
			[Range(0.01f, 5f)]
			public float gamma;
		}

		// Token: 0x0200035A RID: 858
		[Token(Token = "0x200035A")]
		[Serializable]
		public struct ChannelMixerSettings
		{
			// Token: 0x1700030C RID: 780
			// (get) Token: 0x06001514 RID: 5396 RVA: 0x00006D98 File Offset: 0x00004F98
			[Token(Token = "0x1700030C")]
			public static TonemappingColorGrading.ChannelMixerSettings defaultSettings
			{
				[Token(Token = "0x6001514")]
				[Address(RVA = "0x2CAE590", Offset = "0x2CAD590", VA = "0x182CAE590")]
				get
				{
					return default(TonemappingColorGrading.ChannelMixerSettings);
				}
			}

			// Token: 0x04001592 RID: 5522
			[Token(Token = "0x4001592")]
			[FieldOffset(Offset = "0x0")]
			public int currentChannel;

			// Token: 0x04001593 RID: 5523
			[Token(Token = "0x4001593")]
			[FieldOffset(Offset = "0x8")]
			public Vector3[] channels;
		}

		// Token: 0x0200035B RID: 859
		[Token(Token = "0x200035B")]
		[Serializable]
		public struct CurvesSettings
		{
			// Token: 0x1700030D RID: 781
			// (get) Token: 0x06001515 RID: 5397 RVA: 0x00006DB0 File Offset: 0x00004FB0
			[Token(Token = "0x1700030D")]
			public static TonemappingColorGrading.CurvesSettings defaultSettings
			{
				[Token(Token = "0x6001515")]
				[Address(RVA = "0x2CAEBD0", Offset = "0x2CADBD0", VA = "0x182CAEBD0")]
				get
				{
					return default(TonemappingColorGrading.CurvesSettings);
				}
			}

			// Token: 0x1700030E RID: 782
			// (get) Token: 0x06001516 RID: 5398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700030E")]
			public static AnimationCurve defaultCurve
			{
				[Token(Token = "0x6001516")]
				[Address(RVA = "0x2CAEA80", Offset = "0x2CADA80", VA = "0x182CAEA80")]
				get
				{
					return null;
				}
			}

			// Token: 0x04001594 RID: 5524
			[Token(Token = "0x4001594")]
			[FieldOffset(Offset = "0x0")]
			[TonemappingColorGrading.Curve]
			public AnimationCurve master;

			// Token: 0x04001595 RID: 5525
			[Token(Token = "0x4001595")]
			[FieldOffset(Offset = "0x8")]
			[TonemappingColorGrading.Curve(1f, 0f, 0f, 1f)]
			public AnimationCurve red;

			// Token: 0x04001596 RID: 5526
			[Token(Token = "0x4001596")]
			[FieldOffset(Offset = "0x10")]
			[TonemappingColorGrading.Curve(0f, 1f, 0f, 1f)]
			public AnimationCurve green;

			// Token: 0x04001597 RID: 5527
			[Token(Token = "0x4001597")]
			[FieldOffset(Offset = "0x18")]
			[TonemappingColorGrading.Curve(0f, 1f, 1f, 1f)]
			public AnimationCurve blue;
		}

		// Token: 0x0200035C RID: 860
		[Token(Token = "0x200035C")]
		public enum ColorGradingPrecision
		{
			// Token: 0x04001599 RID: 5529
			[Token(Token = "0x4001599")]
			Normal = 16,
			// Token: 0x0400159A RID: 5530
			[Token(Token = "0x400159A")]
			High = 32
		}

		// Token: 0x0200035D RID: 861
		[Token(Token = "0x200035D")]
		[Serializable]
		public struct ColorGradingSettings
		{
			// Token: 0x1700030F RID: 783
			// (get) Token: 0x06001517 RID: 5399 RVA: 0x00006DC8 File Offset: 0x00004FC8
			[Token(Token = "0x1700030F")]
			public static TonemappingColorGrading.ColorGradingSettings defaultSettings
			{
				[Token(Token = "0x6001517")]
				[Address(RVA = "0x2CAE730", Offset = "0x2CAD730", VA = "0x182CAE730")]
				get
				{
					return default(TonemappingColorGrading.ColorGradingSettings);
				}
			}

			// Token: 0x06001518 RID: 5400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001518")]
			[Address(RVA = "0x2CAE690", Offset = "0x2CAD690", VA = "0x182CAE690")]
			internal void Reset()
			{
			}

			// Token: 0x0400159B RID: 5531
			[Token(Token = "0x400159B")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x0400159C RID: 5532
			[Token(Token = "0x400159C")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Internal LUT precision. \"Normal\" is 256x16, \"High\" is 1024x32. Prefer \"Normal\" on mobile devices.")]
			public TonemappingColorGrading.ColorGradingPrecision precision;

			// Token: 0x0400159D RID: 5533
			[Token(Token = "0x400159D")]
			[FieldOffset(Offset = "0x8")]
			[TonemappingColorGrading.ColorWheelGroup]
			[Space]
			public TonemappingColorGrading.ColorWheelsSettings colorWheels;

			// Token: 0x0400159E RID: 5534
			[Token(Token = "0x400159E")]
			[FieldOffset(Offset = "0x38")]
			[Space]
			[TonemappingColorGrading.IndentedGroup]
			public TonemappingColorGrading.BasicsSettings basics;

			// Token: 0x0400159F RID: 5535
			[Token(Token = "0x400159F")]
			[FieldOffset(Offset = "0x60")]
			[TonemappingColorGrading.ChannelMixer]
			[Space]
			public TonemappingColorGrading.ChannelMixerSettings channelMixer;

			// Token: 0x040015A0 RID: 5536
			[Token(Token = "0x40015A0")]
			[FieldOffset(Offset = "0x70")]
			[TonemappingColorGrading.IndentedGroup]
			[Space]
			public TonemappingColorGrading.CurvesSettings curves;

			// Token: 0x040015A1 RID: 5537
			[Token(Token = "0x40015A1")]
			[FieldOffset(Offset = "0x90")]
			[Space]
			[Tooltip("Use dithering to try and minimize color banding in dark areas.")]
			public bool useDithering;

			// Token: 0x040015A2 RID: 5538
			[Token(Token = "0x40015A2")]
			[FieldOffset(Offset = "0x91")]
			[Tooltip("Displays the generated LUT in the top left corner of the GameView.")]
			public bool showDebug;
		}

		// Token: 0x0200035E RID: 862
		[Token(Token = "0x200035E")]
		private enum Pass
		{
			// Token: 0x040015A4 RID: 5540
			[Token(Token = "0x40015A4")]
			LutGen,
			// Token: 0x040015A5 RID: 5541
			[Token(Token = "0x40015A5")]
			AdaptationLog,
			// Token: 0x040015A6 RID: 5542
			[Token(Token = "0x40015A6")]
			AdaptationExpBlend,
			// Token: 0x040015A7 RID: 5543
			[Token(Token = "0x40015A7")]
			AdaptationExp,
			// Token: 0x040015A8 RID: 5544
			[Token(Token = "0x40015A8")]
			TonemappingOff,
			// Token: 0x040015A9 RID: 5545
			[Token(Token = "0x40015A9")]
			TonemappingACES,
			// Token: 0x040015AA RID: 5546
			[Token(Token = "0x40015AA")]
			TonemappingCurve,
			// Token: 0x040015AB RID: 5547
			[Token(Token = "0x40015AB")]
			TonemappingHable,
			// Token: 0x040015AC RID: 5548
			[Token(Token = "0x40015AC")]
			TonemappingHejlDawson,
			// Token: 0x040015AD RID: 5549
			[Token(Token = "0x40015AD")]
			TonemappingPhotographic,
			// Token: 0x040015AE RID: 5550
			[Token(Token = "0x40015AE")]
			TonemappingReinhard,
			// Token: 0x040015AF RID: 5551
			[Token(Token = "0x40015AF")]
			TonemappingNeutral,
			// Token: 0x040015B0 RID: 5552
			[Token(Token = "0x40015B0")]
			AdaptationDebug
		}
	}
}
