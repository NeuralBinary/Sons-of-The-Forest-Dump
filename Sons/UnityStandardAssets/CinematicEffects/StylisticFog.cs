using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000337 RID: 823
	[Token(Token = "0x2000337")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Stylistic Fog")]
	[ImageEffectAllowedInSceneView]
	public class StylisticFog : MonoBehaviour
	{
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F8")]
		public Camera camera_
		{
			[Token(Token = "0x60014F3")]
			[Address(RVA = "0x32659A0", Offset = "0x3263FA0", VA = "0x1832659A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F9")]
		public Texture2D distanceColorTexture
		{
			[Token(Token = "0x60014F4")]
			[Address(RVA = "0x3265AE0", Offset = "0x32640E0", VA = "0x183265AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FA")]
		public Texture2D heightColorTexture
		{
			[Token(Token = "0x60014F5")]
			[Address(RVA = "0x3265D90", Offset = "0x3264390", VA = "0x183265D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FB")]
		public Texture2D distanceFogIntensityTexture
		{
			[Token(Token = "0x60014F6")]
			[Address(RVA = "0x3266040", Offset = "0x3264640", VA = "0x183266040")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FC")]
		public Shader shader
		{
			[Token(Token = "0x60014F7")]
			[Address(RVA = "0x32662D0", Offset = "0x32648D0", VA = "0x1832662D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FD")]
		public Material material
		{
			[Token(Token = "0x60014F8")]
			[Address(RVA = "0x3266410", Offset = "0x3264A10", VA = "0x183266410")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x3266550", Offset = "0x3264B50", VA = "0x183266550")]
		public void UpdateProperties()
		{
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x3266840", Offset = "0x3264E40", VA = "0x183266840")]
		private void UpdateDistanceFogTextures(StylisticFog.ColorSelectionType selectionType)
		{
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x32669A0", Offset = "0x3264FA0", VA = "0x1832669A0")]
		private void UpdateHeightFogTextures(StylisticFog.ColorSelectionType selectionType)
		{
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x3266B00", Offset = "0x3265100", VA = "0x183266B00")]
		private void OnEnable()
		{
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x3266C40", Offset = "0x3265240", VA = "0x183266C40")]
		private void OnDisable()
		{
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x3266EE0", Offset = "0x32654E0", VA = "0x183266EE0")]
		private void SetDistanceFogUniforms()
		{
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x3266F40", Offset = "0x3265540", VA = "0x183266F40")]
		private void SetHeightFogUniforms()
		{
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x3267000", Offset = "0x3265600", VA = "0x183267000")]
		private StylisticFog.FogTypePass SetMaterialUniforms()
		{
			return StylisticFog.FogTypePass.DistanceOnly;
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x32673D0", Offset = "0x32659D0", VA = "0x1832673D0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x3267490", Offset = "0x3265A90", VA = "0x183267490")]
		public void BakeFogColor(Texture2D target, Gradient gradient)
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x3267710", Offset = "0x3265D10", VA = "0x183267710")]
		public StylisticFog()
		{
		}

		// Token: 0x0400153A RID: 5434
		[Token(Token = "0x400153A")]
		[FieldOffset(Offset = "0x20")]
		[StylisticFog.SettingsGroup]
		[SerializeField]
		public StylisticFog.DistanceFogSettings distanceFog;

		// Token: 0x0400153B RID: 5435
		[Token(Token = "0x400153B")]
		[FieldOffset(Offset = "0x2C")]
		[StylisticFog.SettingsGroup]
		[SerializeField]
		public StylisticFog.HeightFogSettings heightFog;

		// Token: 0x0400153C RID: 5436
		[Token(Token = "0x400153C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public StylisticFog.FogColorSource distanceColorSource;

		// Token: 0x0400153D RID: 5437
		[Token(Token = "0x400153D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public StylisticFog.FogColorSource heightColorSource;

		// Token: 0x0400153E RID: 5438
		[Token(Token = "0x400153E")]
		[FieldOffset(Offset = "0x60")]
		private Camera m_Camera;

		// Token: 0x0400153F RID: 5439
		[Token(Token = "0x400153F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Texture2D m_DistanceColorTexture;

		// Token: 0x04001540 RID: 5440
		[Token(Token = "0x4001540")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Texture2D m_HeightColorTexture;

		// Token: 0x04001541 RID: 5441
		[Token(Token = "0x4001541")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Texture2D m_distanceFogIntensityTexture;

		// Token: 0x04001542 RID: 5442
		[Token(Token = "0x4001542")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		// Token: 0x04001543 RID: 5443
		[Token(Token = "0x4001543")]
		[FieldOffset(Offset = "0x88")]
		private Material m_Material;

		// Token: 0x02000338 RID: 824
		// (Invoke) Token: 0x06001505 RID: 5381
		[Token(Token = "0x2000338")]
		public delegate string WarningDelegate();

		// Token: 0x02000339 RID: 825
		[Token(Token = "0x2000339")]
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
			// Token: 0x06001508 RID: 5384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001508")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SettingsGroup()
			{
			}
		}

		// Token: 0x0200033A RID: 826
		[Token(Token = "0x200033A")]
		[Serializable]
		public enum ColorSelectionType
		{
			// Token: 0x04001545 RID: 5445
			[Token(Token = "0x4001545")]
			Gradient = 1,
			// Token: 0x04001546 RID: 5446
			[Token(Token = "0x4001546")]
			TextureRamp,
			// Token: 0x04001547 RID: 5447
			[Token(Token = "0x4001547")]
			CopyOther
		}

		// Token: 0x0200033B RID: 827
		[Token(Token = "0x200033B")]
		private enum FogTypePass
		{
			// Token: 0x04001549 RID: 5449
			[Token(Token = "0x4001549")]
			DistanceOnly,
			// Token: 0x0400154A RID: 5450
			[Token(Token = "0x400154A")]
			HeightOnly,
			// Token: 0x0400154B RID: 5451
			[Token(Token = "0x400154B")]
			BothSharedColorSettings,
			// Token: 0x0400154C RID: 5452
			[Token(Token = "0x400154C")]
			BothSeperateColorSettinsg,
			// Token: 0x0400154D RID: 5453
			[Token(Token = "0x400154D")]
			None
		}

		// Token: 0x0200033C RID: 828
		[Token(Token = "0x200033C")]
		[Serializable]
		public struct FogColorSource
		{
			// Token: 0x170002FE RID: 766
			// (get) Token: 0x06001509 RID: 5385 RVA: 0x00006DC8 File Offset: 0x00004FC8
			[Token(Token = "0x170002FE")]
			public static StylisticFog.FogColorSource defaultSettings
			{
				[Token(Token = "0x6001509")]
				[Address(RVA = "0x32678B0", Offset = "0x3265EB0", VA = "0x1832678B0")]
				get
				{
					return default(StylisticFog.FogColorSource);
				}
			}

			// Token: 0x0400154E RID: 5454
			[Token(Token = "0x400154E")]
			[FieldOffset(Offset = "0x0")]
			[StylisticFog.FogColorSource.DisplayOnSelectionType(StylisticFog.ColorSelectionType.Gradient)]
			[Tooltip("Color gradient.")]
			public Gradient gradient;

			// Token: 0x0400154F RID: 5455
			[Token(Token = "0x400154F")]
			[FieldOffset(Offset = "0x8")]
			[StylisticFog.FogColorSource.DisplayOnSelectionType(StylisticFog.ColorSelectionType.TextureRamp)]
			[Tooltip("Custom fog color ramp.")]
			public Texture2D colorRamp;

			// Token: 0x0200033D RID: 829
			[Token(Token = "0x200033D")]
			[AttributeUsage(AttributeTargets.Field)]
			public class DisplayOnSelectionType : Attribute
			{
				// Token: 0x0600150A RID: 5386 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600150A")]
				[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
				public DisplayOnSelectionType(StylisticFog.ColorSelectionType _selectionType)
				{
				}

				// Token: 0x04001550 RID: 5456
				[Token(Token = "0x4001550")]
				[FieldOffset(Offset = "0x10")]
				public readonly StylisticFog.ColorSelectionType selectionType;
			}
		}

		// Token: 0x0200033E RID: 830
		[Token(Token = "0x200033E")]
		[Serializable]
		public struct DistanceFogSettings
		{
			// Token: 0x170002FF RID: 767
			// (get) Token: 0x0600150B RID: 5387 RVA: 0x00006DE0 File Offset: 0x00004FE0
			[Token(Token = "0x170002FF")]
			public static StylisticFog.DistanceFogSettings defaultSettings
			{
				[Token(Token = "0x600150B")]
				[Address(RVA = "0x3267AB0", Offset = "0x32660B0", VA = "0x183267AB0")]
				get
				{
					return default(StylisticFog.DistanceFogSettings);
				}
			}

			// Token: 0x04001551 RID: 5457
			[Token(Token = "0x4001551")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Wheter or not to apply distance based fog.")]
			public bool enabled;

			// Token: 0x04001552 RID: 5458
			[Token(Token = "0x4001552")]
			[FieldOffset(Offset = "0x1")]
			[Tooltip("Wheter or not to apply distance based fog to the skybox.")]
			public bool fogSkybox;

			// Token: 0x04001553 RID: 5459
			[Token(Token = "0x4001553")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Fog is fully saturated beyond this distance.")]
			public float endDistance;

			// Token: 0x04001554 RID: 5460
			[Token(Token = "0x4001554")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Color selection for distance fog")]
			public StylisticFog.ColorSelectionType colorSelectionType;
		}

		// Token: 0x0200033F RID: 831
		[Token(Token = "0x200033F")]
		[Serializable]
		public struct HeightFogSettings
		{
			// Token: 0x17000300 RID: 768
			// (get) Token: 0x0600150C RID: 5388 RVA: 0x00006DF8 File Offset: 0x00004FF8
			[Token(Token = "0x17000300")]
			public static StylisticFog.HeightFogSettings defaultSettings
			{
				[Token(Token = "0x600150C")]
				[Address(RVA = "0x3267AD0", Offset = "0x32660D0", VA = "0x183267AD0")]
				get
				{
					return default(StylisticFog.HeightFogSettings);
				}
			}

			// Token: 0x04001555 RID: 5461
			[Token(Token = "0x4001555")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Wheter or not to apply height based fog.")]
			public bool enabled;

			// Token: 0x04001556 RID: 5462
			[Token(Token = "0x4001556")]
			[FieldOffset(Offset = "0x1")]
			[Tooltip("Wheter or not to apply height based fog to the skybox.")]
			public bool fogSkybox;

			// Token: 0x04001557 RID: 5463
			[Token(Token = "0x4001557")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Height where the fog starts.")]
			public float baseHeight;

			// Token: 0x04001558 RID: 5464
			[Token(Token = "0x4001558")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Fog density at fog altitude given by height.")]
			public float baseDensity;

			// Token: 0x04001559 RID: 5465
			[Token(Token = "0x4001559")]
			[FieldOffset(Offset = "0xC")]
			[Range(0.001f, 1f)]
			[Tooltip("The rate at which the thickness of the fog decays with altitude.")]
			public float densityFalloff;

			// Token: 0x0400155A RID: 5466
			[Token(Token = "0x400155A")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Color selection for height fog.")]
			public StylisticFog.ColorSelectionType colorSelectionType;
		}
	}
}
