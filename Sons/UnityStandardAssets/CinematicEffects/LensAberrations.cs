using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000330 RID: 816
	[Token(Token = "0x2000330")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Lens Aberrations")]
	public class LensAberrations : MonoBehaviour
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F3")]
		public Shader shader
		{
			[Token(Token = "0x60014E7")]
			[Address(RVA = "0x3264380", Offset = "0x3262980", VA = "0x183264380")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F4")]
		public Material material
		{
			[Token(Token = "0x60014E8")]
			[Address(RVA = "0x32644C0", Offset = "0x3262AC0", VA = "0x1832644C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x3264600", Offset = "0x3262C00", VA = "0x183264600")]
		private void Awake()
		{
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x32649D0", Offset = "0x3262FD0", VA = "0x1832649D0")]
		private void OnEnable()
		{
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x3264AD0", Offset = "0x32630D0", VA = "0x183264AD0")]
		private void OnDisable()
		{
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x3264C20", Offset = "0x3263220", VA = "0x183264C20")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x3265810", Offset = "0x3263E10", VA = "0x183265810")]
		public LensAberrations()
		{
		}

		// Token: 0x0400150F RID: 5391
		[Token(Token = "0x400150F")]
		[FieldOffset(Offset = "0x20")]
		[LensAberrations.SettingsGroup]
		public LensAberrations.DistortionSettings distortion;

		// Token: 0x04001510 RID: 5392
		[Token(Token = "0x4001510")]
		[FieldOffset(Offset = "0x3C")]
		[LensAberrations.SettingsGroup]
		public LensAberrations.VignetteSettings vignette;

		// Token: 0x04001511 RID: 5393
		[Token(Token = "0x4001511")]
		[FieldOffset(Offset = "0x6C")]
		[LensAberrations.SettingsGroup]
		public LensAberrations.ChromaticAberrationSettings chromaticAberration;

		// Token: 0x04001512 RID: 5394
		[Token(Token = "0x4001512")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Shader m_Shader;

		// Token: 0x04001513 RID: 5395
		[Token(Token = "0x4001513")]
		[FieldOffset(Offset = "0x90")]
		private Material m_Material;

		// Token: 0x04001514 RID: 5396
		[Token(Token = "0x4001514")]
		[FieldOffset(Offset = "0x98")]
		private RenderTextureUtility m_RTU;

		// Token: 0x04001515 RID: 5397
		[Token(Token = "0x4001515")]
		[FieldOffset(Offset = "0xA0")]
		private int m_DistCenterScale;

		// Token: 0x04001516 RID: 5398
		[Token(Token = "0x4001516")]
		[FieldOffset(Offset = "0xA4")]
		private int m_DistAmount;

		// Token: 0x04001517 RID: 5399
		[Token(Token = "0x4001517")]
		[FieldOffset(Offset = "0xA8")]
		private int m_ChromaticAberration;

		// Token: 0x04001518 RID: 5400
		[Token(Token = "0x4001518")]
		[FieldOffset(Offset = "0xAC")]
		private int m_VignetteColor;

		// Token: 0x04001519 RID: 5401
		[Token(Token = "0x4001519")]
		[FieldOffset(Offset = "0xB0")]
		private int m_BlurPass;

		// Token: 0x0400151A RID: 5402
		[Token(Token = "0x400151A")]
		[FieldOffset(Offset = "0xB4")]
		private int m_BlurTex;

		// Token: 0x0400151B RID: 5403
		[Token(Token = "0x400151B")]
		[FieldOffset(Offset = "0xB8")]
		private int m_VignetteBlur;

		// Token: 0x0400151C RID: 5404
		[Token(Token = "0x400151C")]
		[FieldOffset(Offset = "0xBC")]
		private int m_VignetteDesat;

		// Token: 0x0400151D RID: 5405
		[Token(Token = "0x400151D")]
		[FieldOffset(Offset = "0xC0")]
		private int m_VignetteCenter;

		// Token: 0x0400151E RID: 5406
		[Token(Token = "0x400151E")]
		[FieldOffset(Offset = "0xC4")]
		private int m_VignetteSettings;

		// Token: 0x02000331 RID: 817
		[Token(Token = "0x2000331")]
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
			// Token: 0x060014EE RID: 5358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014EE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SettingsGroup()
			{
			}
		}

		// Token: 0x02000332 RID: 818
		[Token(Token = "0x2000332")]
		[AttributeUsage(AttributeTargets.Field)]
		public class AdvancedSetting : Attribute
		{
			// Token: 0x060014EF RID: 5359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014EF")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public AdvancedSetting()
			{
			}
		}

		// Token: 0x02000333 RID: 819
		[Token(Token = "0x2000333")]
		[Serializable]
		public struct DistortionSettings
		{
			// Token: 0x170002F5 RID: 757
			// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00006D68 File Offset: 0x00004F68
			[Token(Token = "0x170002F5")]
			public static LensAberrations.DistortionSettings defaultSettings
			{
				[Token(Token = "0x60014F0")]
				[Address(RVA = "0x3265900", Offset = "0x3263F00", VA = "0x183265900")]
				get
				{
					return default(LensAberrations.DistortionSettings);
				}
			}

			// Token: 0x0400151F RID: 5407
			[Token(Token = "0x400151F")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x04001520 RID: 5408
			[Token(Token = "0x4001520")]
			[FieldOffset(Offset = "0x4")]
			[Range(-100f, 100f)]
			[Tooltip("Distortion amount.")]
			public float amount;

			// Token: 0x04001521 RID: 5409
			[Token(Token = "0x4001521")]
			[FieldOffset(Offset = "0x8")]
			[Range(-1f, 1f)]
			[Tooltip("Distortion center point (X axis).")]
			public float centerX;

			// Token: 0x04001522 RID: 5410
			[Token(Token = "0x4001522")]
			[FieldOffset(Offset = "0xC")]
			[Range(-1f, 1f)]
			[Tooltip("Distortion center point (Y axis).")]
			public float centerY;

			// Token: 0x04001523 RID: 5411
			[Token(Token = "0x4001523")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Amount multiplier on X axis. Set it to 0 to disable distortion on this axis.")]
			[Range(0f, 1f)]
			public float amountX;

			// Token: 0x04001524 RID: 5412
			[Token(Token = "0x4001524")]
			[FieldOffset(Offset = "0x14")]
			[Range(0f, 1f)]
			[Tooltip("Amount multiplier on Y axis. Set it to 0 to disable distortion on this axis.")]
			public float amountY;

			// Token: 0x04001525 RID: 5413
			[Token(Token = "0x4001525")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Global screen scaling.")]
			[Range(0.01f, 5f)]
			public float scale;
		}

		// Token: 0x02000334 RID: 820
		[Token(Token = "0x2000334")]
		[Serializable]
		public struct VignetteSettings
		{
			// Token: 0x170002F6 RID: 758
			// (get) Token: 0x060014F1 RID: 5361 RVA: 0x00006D80 File Offset: 0x00004F80
			[Token(Token = "0x170002F6")]
			public static LensAberrations.VignetteSettings defaultSettings
			{
				[Token(Token = "0x60014F1")]
				[Address(RVA = "0x3265930", Offset = "0x3263F30", VA = "0x183265930")]
				get
				{
					return default(LensAberrations.VignetteSettings);
				}
			}

			// Token: 0x04001526 RID: 5414
			[Token(Token = "0x4001526")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x04001527 RID: 5415
			[Token(Token = "0x4001527")]
			[FieldOffset(Offset = "0x4")]
			[ColorUsage(false)]
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			public Color color;

			// Token: 0x04001528 RID: 5416
			[Token(Token = "0x4001528")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			// Token: 0x04001529 RID: 5417
			[Token(Token = "0x4001529")]
			[FieldOffset(Offset = "0x1C")]
			[Range(0f, 6f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			// Token: 0x0400152A RID: 5418
			[Token(Token = "0x400152A")]
			[FieldOffset(Offset = "0x20")]
			[Range(0.01f, 6f)]
			[Tooltip("Smoothness of the vignette borders.")]
			public float smoothness;

			// Token: 0x0400152B RID: 5419
			[Token(Token = "0x400152B")]
			[FieldOffset(Offset = "0x24")]
			[LensAberrations.AdvancedSetting]
			[Tooltip("Lower values will make a square-ish vignette.")]
			[Range(0f, 1f)]
			public float roundness;

			// Token: 0x0400152C RID: 5420
			[Token(Token = "0x400152C")]
			[FieldOffset(Offset = "0x28")]
			[Range(0f, 1f)]
			[Tooltip("Blurs the corners of the screen. Leave this at 0 to disable it.")]
			public float blur;

			// Token: 0x0400152D RID: 5421
			[Token(Token = "0x400152D")]
			[FieldOffset(Offset = "0x2C")]
			[Range(0f, 1f)]
			[Tooltip("Desaturate the corners of the screen. Leave this to 0 to disable it.")]
			public float desaturate;
		}

		// Token: 0x02000335 RID: 821
		[Token(Token = "0x2000335")]
		[Serializable]
		public struct ChromaticAberrationSettings
		{
			// Token: 0x170002F7 RID: 759
			// (get) Token: 0x060014F2 RID: 5362 RVA: 0x00006D98 File Offset: 0x00004F98
			[Token(Token = "0x170002F7")]
			public static LensAberrations.ChromaticAberrationSettings defaultSettings
			{
				[Token(Token = "0x60014F2")]
				[Address(RVA = "0x3265980", Offset = "0x3263F80", VA = "0x183265980")]
				get
				{
					return default(LensAberrations.ChromaticAberrationSettings);
				}
			}

			// Token: 0x0400152E RID: 5422
			[Token(Token = "0x400152E")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			// Token: 0x0400152F RID: 5423
			[Token(Token = "0x400152F")]
			[FieldOffset(Offset = "0x4")]
			[ColorUsage(false)]
			[Tooltip("Channels to apply chromatic aberration to.")]
			public Color color;

			// Token: 0x04001530 RID: 5424
			[Token(Token = "0x4001530")]
			[FieldOffset(Offset = "0x14")]
			[Range(-50f, 50f)]
			[Tooltip("Amount of tangential distortion.")]
			public float amount;
		}

		// Token: 0x02000336 RID: 822
		[Token(Token = "0x2000336")]
		private enum Pass
		{
			// Token: 0x04001532 RID: 5426
			[Token(Token = "0x4001532")]
			BlurPrePass,
			// Token: 0x04001533 RID: 5427
			[Token(Token = "0x4001533")]
			Chroma,
			// Token: 0x04001534 RID: 5428
			[Token(Token = "0x4001534")]
			Distort,
			// Token: 0x04001535 RID: 5429
			[Token(Token = "0x4001535")]
			Vignette,
			// Token: 0x04001536 RID: 5430
			[Token(Token = "0x4001536")]
			ChromaDistort,
			// Token: 0x04001537 RID: 5431
			[Token(Token = "0x4001537")]
			ChromaVignette,
			// Token: 0x04001538 RID: 5432
			[Token(Token = "0x4001538")]
			DistortVignette,
			// Token: 0x04001539 RID: 5433
			[Token(Token = "0x4001539")]
			ChromaDistortVignette
		}
	}
}
