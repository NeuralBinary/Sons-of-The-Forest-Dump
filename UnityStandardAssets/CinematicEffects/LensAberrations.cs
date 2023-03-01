using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200033E RID: 830
	[Token(Token = "0x200033E")]
	[AddComponentMenu("Image Effects/Cinematic/Lens Aberrations")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class LensAberrations : MonoBehaviour
	{
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EB")]
		public Shader shader
		{
			[Token(Token = "0x60014BC")]
			[Address(RVA = "0x2CB3D70", Offset = "0x2CB2D70", VA = "0x182CB3D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EC")]
		public Material material
		{
			[Token(Token = "0x60014BD")]
			[Address(RVA = "0x2CB3CD0", Offset = "0x2CB2CD0", VA = "0x182CB3CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x2CB2EF0", Offset = "0x2CB1EF0", VA = "0x182CB2EF0")]
		private void Awake()
		{
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x2CB3120", Offset = "0x2CB2120", VA = "0x182CB3120")]
		private void OnEnable()
		{
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x2CB3050", Offset = "0x2CB2050", VA = "0x182CB3050")]
		private void OnDisable()
		{
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x2CB31C0", Offset = "0x2CB21C0", VA = "0x182CB31C0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x2CB3C10", Offset = "0x2CB2C10", VA = "0x182CB3C10")]
		public LensAberrations()
		{
		}

		// Token: 0x040014F1 RID: 5361
		[Token(Token = "0x40014F1")]
		[FieldOffset(Offset = "0x20")]
		[LensAberrations.SettingsGroup]
		public LensAberrations.DistortionSettings distortion;

		// Token: 0x040014F2 RID: 5362
		[Token(Token = "0x40014F2")]
		[FieldOffset(Offset = "0x3C")]
		[LensAberrations.SettingsGroup]
		public LensAberrations.VignetteSettings vignette;

		// Token: 0x040014F3 RID: 5363
		[Token(Token = "0x40014F3")]
		[FieldOffset(Offset = "0x6C")]
		[LensAberrations.SettingsGroup]
		public LensAberrations.ChromaticAberrationSettings chromaticAberration;

		// Token: 0x040014F4 RID: 5364
		[Token(Token = "0x40014F4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Shader m_Shader;

		// Token: 0x040014F5 RID: 5365
		[Token(Token = "0x40014F5")]
		[FieldOffset(Offset = "0x90")]
		private Material m_Material;

		// Token: 0x040014F6 RID: 5366
		[Token(Token = "0x40014F6")]
		[FieldOffset(Offset = "0x98")]
		private RenderTextureUtility m_RTU;

		// Token: 0x040014F7 RID: 5367
		[Token(Token = "0x40014F7")]
		[FieldOffset(Offset = "0xA0")]
		private int m_DistCenterScale;

		// Token: 0x040014F8 RID: 5368
		[Token(Token = "0x40014F8")]
		[FieldOffset(Offset = "0xA4")]
		private int m_DistAmount;

		// Token: 0x040014F9 RID: 5369
		[Token(Token = "0x40014F9")]
		[FieldOffset(Offset = "0xA8")]
		private int m_ChromaticAberration;

		// Token: 0x040014FA RID: 5370
		[Token(Token = "0x40014FA")]
		[FieldOffset(Offset = "0xAC")]
		private int m_VignetteColor;

		// Token: 0x040014FB RID: 5371
		[Token(Token = "0x40014FB")]
		[FieldOffset(Offset = "0xB0")]
		private int m_BlurPass;

		// Token: 0x040014FC RID: 5372
		[Token(Token = "0x40014FC")]
		[FieldOffset(Offset = "0xB4")]
		private int m_BlurTex;

		// Token: 0x040014FD RID: 5373
		[Token(Token = "0x40014FD")]
		[FieldOffset(Offset = "0xB8")]
		private int m_VignetteBlur;

		// Token: 0x040014FE RID: 5374
		[Token(Token = "0x40014FE")]
		[FieldOffset(Offset = "0xBC")]
		private int m_VignetteDesat;

		// Token: 0x040014FF RID: 5375
		[Token(Token = "0x40014FF")]
		[FieldOffset(Offset = "0xC0")]
		private int m_VignetteCenter;

		// Token: 0x04001500 RID: 5376
		[Token(Token = "0x4001500")]
		[FieldOffset(Offset = "0xC4")]
		private int m_VignetteSettings;

		// Token: 0x0200033F RID: 831
		[Token(Token = "0x200033F")]
		[AttributeUsage(256)]
		public class SettingsGroup : Attribute
		{
			// Token: 0x060014C3 RID: 5315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014C3")]
			[Address(RVA = "0x54C690", Offset = "0x54B690", VA = "0x18054C690")]
			public SettingsGroup()
			{
			}
		}

		// Token: 0x02000340 RID: 832
		[Token(Token = "0x2000340")]
		[AttributeUsage(256)]
		public class AdvancedSetting : Attribute
		{
			// Token: 0x060014C4 RID: 5316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014C4")]
			[Address(RVA = "0x54C690", Offset = "0x54B690", VA = "0x18054C690")]
			public AdvancedSetting()
			{
			}
		}

		// Token: 0x02000341 RID: 833
		[Token(Token = "0x2000341")]
		[Serializable]
		public struct DistortionSettings
		{
			// Token: 0x170002ED RID: 749
			// (get) Token: 0x060014C5 RID: 5317 RVA: 0x00006B28 File Offset: 0x00004D28
			[Token(Token = "0x170002ED")]
			public static LensAberrations.DistortionSettings defaultSettings
			{
				[Token(Token = "0x60014C5")]
				[Address(RVA = "0x2CB2290", Offset = "0x2CB1290", VA = "0x182CB2290")]
				get
				{
					return default(LensAberrations.DistortionSettings);
				}
			}

			// Token: 0x04001501 RID: 5377
			[Token(Token = "0x4001501")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x04001502 RID: 5378
			[Token(Token = "0x4001502")]
			[FieldOffset(Offset = "0x4")]
			[Range(-100f, 100f)]
			[Tooltip("Distortion amount.")]
			public float amount;

			// Token: 0x04001503 RID: 5379
			[Token(Token = "0x4001503")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Distortion center point (X axis).")]
			[Range(-1f, 1f)]
			public float centerX;

			// Token: 0x04001504 RID: 5380
			[Token(Token = "0x4001504")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Distortion center point (Y axis).")]
			[Range(-1f, 1f)]
			public float centerY;

			// Token: 0x04001505 RID: 5381
			[Token(Token = "0x4001505")]
			[FieldOffset(Offset = "0x10")]
			[Range(0f, 1f)]
			[Tooltip("Amount multiplier on X axis. Set it to 0 to disable distortion on this axis.")]
			public float amountX;

			// Token: 0x04001506 RID: 5382
			[Token(Token = "0x4001506")]
			[FieldOffset(Offset = "0x14")]
			[Range(0f, 1f)]
			[Tooltip("Amount multiplier on Y axis. Set it to 0 to disable distortion on this axis.")]
			public float amountY;

			// Token: 0x04001507 RID: 5383
			[Token(Token = "0x4001507")]
			[FieldOffset(Offset = "0x18")]
			[Range(0.01f, 5f)]
			[Tooltip("Global screen scaling.")]
			public float scale;
		}

		// Token: 0x02000342 RID: 834
		[Token(Token = "0x2000342")]
		[Serializable]
		public struct VignetteSettings
		{
			// Token: 0x170002EE RID: 750
			// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00006B40 File Offset: 0x00004D40
			[Token(Token = "0x170002EE")]
			public static LensAberrations.VignetteSettings defaultSettings
			{
				[Token(Token = "0x60014C6")]
				[Address(RVA = "0x2CC1430", Offset = "0x2CC0430", VA = "0x182CC1430")]
				get
				{
					return default(LensAberrations.VignetteSettings);
				}
			}

			// Token: 0x04001508 RID: 5384
			[Token(Token = "0x4001508")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x04001509 RID: 5385
			[Token(Token = "0x4001509")]
			[FieldOffset(Offset = "0x4")]
			[ColorUsage(false)]
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			public Color color;

			// Token: 0x0400150A RID: 5386
			[Token(Token = "0x400150A")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			// Token: 0x0400150B RID: 5387
			[Token(Token = "0x400150B")]
			[FieldOffset(Offset = "0x1C")]
			[Range(0f, 6f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			// Token: 0x0400150C RID: 5388
			[Token(Token = "0x400150C")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Smoothness of the vignette borders.")]
			[Range(0.01f, 6f)]
			public float smoothness;

			// Token: 0x0400150D RID: 5389
			[Token(Token = "0x400150D")]
			[FieldOffset(Offset = "0x24")]
			[Tooltip("Lower values will make a square-ish vignette.")]
			[Range(0f, 1f)]
			[LensAberrations.AdvancedSetting]
			public float roundness;

			// Token: 0x0400150E RID: 5390
			[Token(Token = "0x400150E")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("Blurs the corners of the screen. Leave this at 0 to disable it.")]
			[Range(0f, 1f)]
			public float blur;

			// Token: 0x0400150F RID: 5391
			[Token(Token = "0x400150F")]
			[FieldOffset(Offset = "0x2C")]
			[Tooltip("Desaturate the corners of the screen. Leave this to 0 to disable it.")]
			[Range(0f, 1f)]
			public float desaturate;
		}

		// Token: 0x02000343 RID: 835
		[Token(Token = "0x2000343")]
		[Serializable]
		public struct ChromaticAberrationSettings
		{
			// Token: 0x170002EF RID: 751
			// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00006B58 File Offset: 0x00004D58
			[Token(Token = "0x170002EF")]
			public static LensAberrations.ChromaticAberrationSettings defaultSettings
			{
				[Token(Token = "0x60014C7")]
				[Address(RVA = "0x2CAE670", Offset = "0x2CAD670", VA = "0x182CAE670")]
				get
				{
					return default(LensAberrations.ChromaticAberrationSettings);
				}
			}

			// Token: 0x04001510 RID: 5392
			[Token(Token = "0x4001510")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x04001511 RID: 5393
			[Token(Token = "0x4001511")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Channels to apply chromatic aberration to.")]
			[ColorUsage(false)]
			public Color color;

			// Token: 0x04001512 RID: 5394
			[Token(Token = "0x4001512")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Amount of tangential distortion.")]
			[Range(-50f, 50f)]
			public float amount;
		}

		// Token: 0x02000344 RID: 836
		[Token(Token = "0x2000344")]
		private enum Pass
		{
			// Token: 0x04001514 RID: 5396
			[Token(Token = "0x4001514")]
			BlurPrePass,
			// Token: 0x04001515 RID: 5397
			[Token(Token = "0x4001515")]
			Chroma,
			// Token: 0x04001516 RID: 5398
			[Token(Token = "0x4001516")]
			Distort,
			// Token: 0x04001517 RID: 5399
			[Token(Token = "0x4001517")]
			Vignette,
			// Token: 0x04001518 RID: 5400
			[Token(Token = "0x4001518")]
			ChromaDistort,
			// Token: 0x04001519 RID: 5401
			[Token(Token = "0x4001519")]
			ChromaVignette,
			// Token: 0x0400151A RID: 5402
			[Token(Token = "0x400151A")]
			DistortVignette,
			// Token: 0x0400151B RID: 5403
			[Token(Token = "0x400151B")]
			ChromaDistortVignette
		}
	}
}
