using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2000311")]
	[Serializable]
	public class FXAA : IAntiAliasing
	{
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D7")]
		private Shader shader
		{
			[Token(Token = "0x6001497")]
			[Address(RVA = "0x320EC00", Offset = "0x320D200", VA = "0x18320EC00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D8")]
		public Material material
		{
			[Token(Token = "0x6001498")]
			[Address(RVA = "0x320ED20", Offset = "0x320D320", VA = "0x18320ED20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00006BE8 File Offset: 0x00004DE8
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D9")]
		public bool validSourceFormat
		{
			[Token(Token = "0x6001499")]
			[Address(RVA = "0x8F37B0", Offset = "0x8F1DB0", VA = "0x1808F37B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600149A")]
			[Address(RVA = "0x14B6A50", Offset = "0x14B5050", VA = "0x1814B6A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x320EE50", Offset = "0x320D450", VA = "0x18320EE50", Slot = "4")]
		public void Awake()
		{
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x320EF30", Offset = "0x320D530", VA = "0x18320EF30", Slot = "5")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x320EFC0", Offset = "0x320D5C0", VA = "0x18320EFC0", Slot = "6")]
		public void OnDisable()
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public void OnPreCull(Camera camera)
		{
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public void OnPostRender(Camera camera)
		{
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x320F0A0", Offset = "0x320D6A0", VA = "0x18320F0A0", Slot = "9")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x320F280", Offset = "0x320D880", VA = "0x18320F280")]
		public FXAA()
		{
		}

		// Token: 0x0400145C RID: 5212
		[Token(Token = "0x400145C")]
		[FieldOffset(Offset = "0x10")]
		private Shader m_Shader;

		// Token: 0x0400145D RID: 5213
		[Token(Token = "0x400145D")]
		[FieldOffset(Offset = "0x18")]
		private Material m_Material;

		// Token: 0x0400145E RID: 5214
		[Token(Token = "0x400145E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		public FXAA.Preset preset;

		// Token: 0x0400145F RID: 5215
		[Token(Token = "0x400145F")]
		[FieldOffset(Offset = "0x0")]
		public static FXAA.Preset[] availablePresets;

		// Token: 0x04001461 RID: 5217
		[Token(Token = "0x4001461")]
		[FieldOffset(Offset = "0x40")]
		private int m_QualitySettings;

		// Token: 0x04001462 RID: 5218
		[Token(Token = "0x4001462")]
		[FieldOffset(Offset = "0x44")]
		private int m_ConsoleSettings;

		// Token: 0x02000312 RID: 786
		[Token(Token = "0x2000312")]
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x04001463 RID: 5219
			[Token(Token = "0x4001463")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
			[Range(0f, 1f)]
			public float subpixelAliasingRemovalAmount;

			// Token: 0x04001464 RID: 5220
			[Token(Token = "0x4001464")]
			[FieldOffset(Offset = "0x4")]
			[Range(0.063f, 0.333f)]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			public float edgeDetectionThreshold;

			// Token: 0x04001465 RID: 5221
			[Token(Token = "0x4001465")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0f, 0.0833f)]
			public float minimumRequiredLuminance;
		}

		// Token: 0x02000313 RID: 787
		[Token(Token = "0x2000313")]
		[Serializable]
		public struct ConsoleSettings
		{
			// Token: 0x04001466 RID: 5222
			[Token(Token = "0x4001466")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
			[Range(0.33f, 0.5f)]
			public float subpixelSpreadAmount;

			// Token: 0x04001467 RID: 5223
			[Token(Token = "0x4001467")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
			[Range(2f, 8f)]
			public float edgeSharpnessAmount;

			// Token: 0x04001468 RID: 5224
			[Token(Token = "0x4001468")]
			[FieldOffset(Offset = "0x8")]
			[Range(0.125f, 0.25f)]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			public float edgeDetectionThreshold;

			// Token: 0x04001469 RID: 5225
			[Token(Token = "0x4001469")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0.04f, 0.06f)]
			public float minimumRequiredLuminance;
		}

		// Token: 0x02000314 RID: 788
		[Token(Token = "0x2000314")]
		[Serializable]
		public struct Preset
		{
			// Token: 0x170002DA RID: 730
			// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00006C00 File Offset: 0x00004E00
			[Token(Token = "0x170002DA")]
			public static FXAA.Preset extremePerformancePreset
			{
				[Token(Token = "0x60014A3")]
				[Address(RVA = "0x320F610", Offset = "0x320DC10", VA = "0x18320F610")]
				get
				{
					return default(FXAA.Preset);
				}
			}

			// Token: 0x170002DB RID: 731
			// (get) Token: 0x060014A4 RID: 5284 RVA: 0x00006C18 File Offset: 0x00004E18
			[Token(Token = "0x170002DB")]
			public static FXAA.Preset performancePreset
			{
				[Token(Token = "0x60014A4")]
				[Address(RVA = "0x320F680", Offset = "0x320DC80", VA = "0x18320F680")]
				get
				{
					return default(FXAA.Preset);
				}
			}

			// Token: 0x170002DC RID: 732
			// (get) Token: 0x060014A5 RID: 5285 RVA: 0x00006C30 File Offset: 0x00004E30
			[Token(Token = "0x170002DC")]
			public static FXAA.Preset defaultPreset
			{
				[Token(Token = "0x60014A5")]
				[Address(RVA = "0x320F6F0", Offset = "0x320DCF0", VA = "0x18320F6F0")]
				get
				{
					return default(FXAA.Preset);
				}
			}

			// Token: 0x170002DD RID: 733
			// (get) Token: 0x060014A6 RID: 5286 RVA: 0x00006C48 File Offset: 0x00004E48
			[Token(Token = "0x170002DD")]
			public static FXAA.Preset qualityPreset
			{
				[Token(Token = "0x60014A6")]
				[Address(RVA = "0x320F760", Offset = "0x320DD60", VA = "0x18320F760")]
				get
				{
					return default(FXAA.Preset);
				}
			}

			// Token: 0x170002DE RID: 734
			// (get) Token: 0x060014A7 RID: 5287 RVA: 0x00006C60 File Offset: 0x00004E60
			[Token(Token = "0x170002DE")]
			public static FXAA.Preset extremeQualityPreset
			{
				[Token(Token = "0x60014A7")]
				[Address(RVA = "0x320F7D0", Offset = "0x320DDD0", VA = "0x18320F7D0")]
				get
				{
					return default(FXAA.Preset);
				}
			}

			// Token: 0x0400146A RID: 5226
			[Token(Token = "0x400146A")]
			[FieldOffset(Offset = "0x0")]
			[FXAA.Preset.LayoutAttribute]
			public FXAA.QualitySettings qualitySettings;

			// Token: 0x0400146B RID: 5227
			[Token(Token = "0x400146B")]
			[FieldOffset(Offset = "0xC")]
			[FXAA.Preset.LayoutAttribute]
			public FXAA.ConsoleSettings consoleSettings;

			// Token: 0x0400146C RID: 5228
			[Token(Token = "0x400146C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly FXAA.Preset s_ExtremePerformance;

			// Token: 0x0400146D RID: 5229
			[Token(Token = "0x400146D")]
			[FieldOffset(Offset = "0x1C")]
			private static readonly FXAA.Preset s_Performance;

			// Token: 0x0400146E RID: 5230
			[Token(Token = "0x400146E")]
			[FieldOffset(Offset = "0x38")]
			private static readonly FXAA.Preset s_Default;

			// Token: 0x0400146F RID: 5231
			[Token(Token = "0x400146F")]
			[FieldOffset(Offset = "0x54")]
			private static readonly FXAA.Preset s_Quality;

			// Token: 0x04001470 RID: 5232
			[Token(Token = "0x4001470")]
			[FieldOffset(Offset = "0x70")]
			private static readonly FXAA.Preset s_ExtremeQuality;

			// Token: 0x02000315 RID: 789
			[Token(Token = "0x2000315")]
			[AttributeUsage(AttributeTargets.Field)]
			public class LayoutAttribute : PropertyAttribute
			{
				// Token: 0x060014A9 RID: 5289 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60014A9")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public LayoutAttribute()
				{
				}
			}
		}
	}
}
