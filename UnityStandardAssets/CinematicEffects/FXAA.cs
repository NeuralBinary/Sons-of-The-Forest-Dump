using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200031F RID: 799
	[Token(Token = "0x200031F")]
	[Serializable]
	public class FXAA : IAntiAliasing
	{
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CF")]
		private Shader shader
		{
			[Token(Token = "0x600146C")]
			[Address(RVA = "0x2C64C40", Offset = "0x2C63C40", VA = "0x182C64C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D0")]
		public Material material
		{
			[Token(Token = "0x600146D")]
			[Address(RVA = "0x2C64BB0", Offset = "0x2C63BB0", VA = "0x182C64BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x000069A8 File Offset: 0x00004BA8
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D1")]
		public bool validSourceFormat
		{
			[Token(Token = "0x600146E")]
			[Address(RVA = "0x7C8830", Offset = "0x7C7830", VA = "0x1807C8830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600146F")]
			[Address(RVA = "0x128BA00", Offset = "0x128AA00", VA = "0x18128BA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x2C645F0", Offset = "0x2C635F0", VA = "0x182C645F0", Slot = "4")]
		public void Awake()
		{
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x2C646E0", Offset = "0x2C636E0", VA = "0x182C646E0", Slot = "5")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x2C64650", Offset = "0x2C63650", VA = "0x182C64650", Slot = "6")]
		public void OnDisable()
		{
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "7")]
		public void OnPreCull(Camera camera)
		{
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "8")]
		public void OnPostRender(Camera camera)
		{
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x2C64730", Offset = "0x2C63730", VA = "0x182C64730", Slot = "9")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x2C64B10", Offset = "0x2C63B10", VA = "0x182C64B10")]
		public FXAA()
		{
		}

		// Token: 0x0400143E RID: 5182
		[Token(Token = "0x400143E")]
		[FieldOffset(Offset = "0x10")]
		private Shader m_Shader;

		// Token: 0x0400143F RID: 5183
		[Token(Token = "0x400143F")]
		[FieldOffset(Offset = "0x18")]
		private Material m_Material;

		// Token: 0x04001440 RID: 5184
		[Token(Token = "0x4001440")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		public FXAA.Preset preset;

		// Token: 0x04001441 RID: 5185
		[Token(Token = "0x4001441")]
		[FieldOffset(Offset = "0x0")]
		public static FXAA.Preset[] availablePresets;

		// Token: 0x04001443 RID: 5187
		[Token(Token = "0x4001443")]
		[FieldOffset(Offset = "0x40")]
		private int m_QualitySettings;

		// Token: 0x04001444 RID: 5188
		[Token(Token = "0x4001444")]
		[FieldOffset(Offset = "0x44")]
		private int m_ConsoleSettings;

		// Token: 0x02000320 RID: 800
		[Token(Token = "0x2000320")]
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x04001445 RID: 5189
			[Token(Token = "0x4001445")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
			[Range(0f, 1f)]
			public float subpixelAliasingRemovalAmount;

			// Token: 0x04001446 RID: 5190
			[Token(Token = "0x4001446")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			[Range(0.063f, 0.333f)]
			public float edgeDetectionThreshold;

			// Token: 0x04001447 RID: 5191
			[Token(Token = "0x4001447")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0f, 0.0833f)]
			public float minimumRequiredLuminance;
		}

		// Token: 0x02000321 RID: 801
		[Token(Token = "0x2000321")]
		[Serializable]
		public struct ConsoleSettings
		{
			// Token: 0x04001448 RID: 5192
			[Token(Token = "0x4001448")]
			[FieldOffset(Offset = "0x0")]
			[Range(0.33f, 0.5f)]
			[Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
			public float subpixelSpreadAmount;

			// Token: 0x04001449 RID: 5193
			[Token(Token = "0x4001449")]
			[FieldOffset(Offset = "0x4")]
			[Range(2f, 8f)]
			[Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
			public float edgeSharpnessAmount;

			// Token: 0x0400144A RID: 5194
			[Token(Token = "0x400144A")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			[Range(0.125f, 0.25f)]
			public float edgeDetectionThreshold;

			// Token: 0x0400144B RID: 5195
			[Token(Token = "0x400144B")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0.04f, 0.06f)]
			public float minimumRequiredLuminance;
		}

		// Token: 0x02000322 RID: 802
		[Token(Token = "0x2000322")]
		[Serializable]
		public struct Preset
		{
			// Token: 0x170002D2 RID: 722
			// (get) Token: 0x06001478 RID: 5240 RVA: 0x000069C0 File Offset: 0x00004BC0
			[Token(Token = "0x170002D2")]
			public static FXAA.Preset extremePerformancePreset
			{
				[Token(Token = "0x6001478")]
				[Address(RVA = "0x2C69620", Offset = "0x2C68620", VA = "0x182C69620")]
				get
				{
					return default(FXAA.Preset);
				}
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x06001479 RID: 5241 RVA: 0x000069D8 File Offset: 0x00004BD8
			[Token(Token = "0x170002D3")]
			public static FXAA.Preset performancePreset
			{
				[Token(Token = "0x6001479")]
				[Address(RVA = "0x2C69710", Offset = "0x2C68710", VA = "0x182C69710")]
				get
				{
					return default(FXAA.Preset);
				}
			}

			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x0600147A RID: 5242 RVA: 0x000069F0 File Offset: 0x00004BF0
			[Token(Token = "0x170002D4")]
			public static FXAA.Preset defaultPreset
			{
				[Token(Token = "0x600147A")]
				[Address(RVA = "0x2C695B0", Offset = "0x2C685B0", VA = "0x182C695B0")]
				get
				{
					return default(FXAA.Preset);
				}
			}

			// Token: 0x170002D5 RID: 725
			// (get) Token: 0x0600147B RID: 5243 RVA: 0x00006A08 File Offset: 0x00004C08
			[Token(Token = "0x170002D5")]
			public static FXAA.Preset qualityPreset
			{
				[Token(Token = "0x600147B")]
				[Address(RVA = "0x2C69780", Offset = "0x2C68780", VA = "0x182C69780")]
				get
				{
					return default(FXAA.Preset);
				}
			}

			// Token: 0x170002D6 RID: 726
			// (get) Token: 0x0600147C RID: 5244 RVA: 0x00006A20 File Offset: 0x00004C20
			[Token(Token = "0x170002D6")]
			public static FXAA.Preset extremeQualityPreset
			{
				[Token(Token = "0x600147C")]
				[Address(RVA = "0x2C69690", Offset = "0x2C68690", VA = "0x182C69690")]
				get
				{
					return default(FXAA.Preset);
				}
			}

			// Token: 0x0400144C RID: 5196
			[Token(Token = "0x400144C")]
			[FieldOffset(Offset = "0x0")]
			[FXAA.Preset.LayoutAttribute]
			public FXAA.QualitySettings qualitySettings;

			// Token: 0x0400144D RID: 5197
			[Token(Token = "0x400144D")]
			[FieldOffset(Offset = "0xC")]
			[FXAA.Preset.LayoutAttribute]
			public FXAA.ConsoleSettings consoleSettings;

			// Token: 0x0400144E RID: 5198
			[Token(Token = "0x400144E")]
			[FieldOffset(Offset = "0x0")]
			private static readonly FXAA.Preset s_ExtremePerformance;

			// Token: 0x0400144F RID: 5199
			[Token(Token = "0x400144F")]
			[FieldOffset(Offset = "0x1C")]
			private static readonly FXAA.Preset s_Performance;

			// Token: 0x04001450 RID: 5200
			[Token(Token = "0x4001450")]
			[FieldOffset(Offset = "0x38")]
			private static readonly FXAA.Preset s_Default;

			// Token: 0x04001451 RID: 5201
			[Token(Token = "0x4001451")]
			[FieldOffset(Offset = "0x54")]
			private static readonly FXAA.Preset s_Quality;

			// Token: 0x04001452 RID: 5202
			[Token(Token = "0x4001452")]
			[FieldOffset(Offset = "0x70")]
			private static readonly FXAA.Preset s_ExtremeQuality;

			// Token: 0x02000323 RID: 803
			[Token(Token = "0x2000323")]
			[AttributeUsage(256)]
			public class LayoutAttribute : PropertyAttribute
			{
				// Token: 0x0600147E RID: 5246 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600147E")]
				[Address(RVA = "0x62A570", Offset = "0x629570", VA = "0x18062A570")]
				public LayoutAttribute()
				{
				}
			}
		}
	}
}
