using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000345 RID: 837
	[Token(Token = "0x2000345")]
	[RequireComponent(typeof(Camera))]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Stylistic Fog")]
	public class StylisticFog : MonoBehaviour
	{
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F0")]
		public Camera camera_
		{
			[Token(Token = "0x60014C8")]
			[Address(RVA = "0x2CB8510", Offset = "0x2CB7510", VA = "0x182CB8510")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F1")]
		public Texture2D distanceColorTexture
		{
			[Token(Token = "0x60014C9")]
			[Address(RVA = "0x2CB85B0", Offset = "0x2CB75B0", VA = "0x182CB85B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F2")]
		public Texture2D heightColorTexture
		{
			[Token(Token = "0x60014CA")]
			[Address(RVA = "0x2CB87F0", Offset = "0x2CB77F0", VA = "0x182CB87F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F3")]
		public Texture2D distanceFogIntensityTexture
		{
			[Token(Token = "0x60014CB")]
			[Address(RVA = "0x2CB86E0", Offset = "0x2CB76E0", VA = "0x182CB86E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F4")]
		public Shader shader
		{
			[Token(Token = "0x60014CC")]
			[Address(RVA = "0x2CB89C0", Offset = "0x2CB79C0", VA = "0x182CB89C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F5")]
		public Material material
		{
			[Token(Token = "0x60014CD")]
			[Address(RVA = "0x2CB8920", Offset = "0x2CB7920", VA = "0x182CB8920")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x2CB82B0", Offset = "0x2CB72B0", VA = "0x182CB82B0")]
		public void UpdateProperties()
		{
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x2CB8110", Offset = "0x2CB7110", VA = "0x182CB8110")]
		private void UpdateDistanceFogTextures(StylisticFog.ColorSelectionType selectionType)
		{
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x2CB81E0", Offset = "0x2CB71E0", VA = "0x182CB81E0")]
		private void UpdateHeightFogTextures(StylisticFog.ColorSelectionType selectionType)
		{
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0x2CB7B00", Offset = "0x2CB6B00", VA = "0x182CB7B00")]
		private void OnEnable()
		{
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D2")]
		[Address(RVA = "0x2CB79C0", Offset = "0x2CB69C0", VA = "0x182CB79C0")]
		private void OnDisable()
		{
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x2CB7C50", Offset = "0x2CB6C50", VA = "0x182CB7C50")]
		private void SetDistanceFogUniforms()
		{
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x2CB7CB0", Offset = "0x2CB6CB0", VA = "0x182CB7CB0")]
		private void SetHeightFogUniforms()
		{
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x2CB7D70", Offset = "0x2CB6D70", VA = "0x182CB7D70")]
		private StylisticFog.FogTypePass SetMaterialUniforms()
		{
			return StylisticFog.FogTypePass.DistanceOnly;
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x2CB7B90", Offset = "0x2CB6B90", VA = "0x182CB7B90")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x2CB7830", Offset = "0x2CB6830", VA = "0x182CB7830")]
		public void BakeFogColor(Texture2D target, Gradient gradient)
		{
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x2CB8440", Offset = "0x2CB7440", VA = "0x182CB8440")]
		public StylisticFog()
		{
		}

		// Token: 0x0400151C RID: 5404
		[Token(Token = "0x400151C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[StylisticFog.SettingsGroup]
		public StylisticFog.DistanceFogSettings distanceFog;

		// Token: 0x0400151D RID: 5405
		[Token(Token = "0x400151D")]
		[FieldOffset(Offset = "0x2C")]
		[StylisticFog.SettingsGroup]
		[SerializeField]
		public StylisticFog.HeightFogSettings heightFog;

		// Token: 0x0400151E RID: 5406
		[Token(Token = "0x400151E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public StylisticFog.FogColorSource distanceColorSource;

		// Token: 0x0400151F RID: 5407
		[Token(Token = "0x400151F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public StylisticFog.FogColorSource heightColorSource;

		// Token: 0x04001520 RID: 5408
		[Token(Token = "0x4001520")]
		[FieldOffset(Offset = "0x60")]
		private Camera m_Camera;

		// Token: 0x04001521 RID: 5409
		[Token(Token = "0x4001521")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Texture2D m_DistanceColorTexture;

		// Token: 0x04001522 RID: 5410
		[Token(Token = "0x4001522")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Texture2D m_HeightColorTexture;

		// Token: 0x04001523 RID: 5411
		[Token(Token = "0x4001523")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Texture2D m_distanceFogIntensityTexture;

		// Token: 0x04001524 RID: 5412
		[Token(Token = "0x4001524")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		// Token: 0x04001525 RID: 5413
		[Token(Token = "0x4001525")]
		[FieldOffset(Offset = "0x88")]
		private Material m_Material;

		// Token: 0x02000346 RID: 838
		// (Invoke) Token: 0x060014DA RID: 5338
		[Token(Token = "0x2000346")]
		public delegate string WarningDelegate();

		// Token: 0x02000347 RID: 839
		[Token(Token = "0x2000347")]
		[AttributeUsage(256)]
		public class SettingsGroup : Attribute
		{
			// Token: 0x060014DD RID: 5341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014DD")]
			[Address(RVA = "0x54C690", Offset = "0x54B690", VA = "0x18054C690")]
			public SettingsGroup()
			{
			}
		}

		// Token: 0x02000348 RID: 840
		[Token(Token = "0x2000348")]
		[Serializable]
		public enum ColorSelectionType
		{
			// Token: 0x04001527 RID: 5415
			[Token(Token = "0x4001527")]
			Gradient = 1,
			// Token: 0x04001528 RID: 5416
			[Token(Token = "0x4001528")]
			TextureRamp,
			// Token: 0x04001529 RID: 5417
			[Token(Token = "0x4001529")]
			CopyOther
		}

		// Token: 0x02000349 RID: 841
		[Token(Token = "0x2000349")]
		private enum FogTypePass
		{
			// Token: 0x0400152B RID: 5419
			[Token(Token = "0x400152B")]
			DistanceOnly,
			// Token: 0x0400152C RID: 5420
			[Token(Token = "0x400152C")]
			HeightOnly,
			// Token: 0x0400152D RID: 5421
			[Token(Token = "0x400152D")]
			BothSharedColorSettings,
			// Token: 0x0400152E RID: 5422
			[Token(Token = "0x400152E")]
			BothSeperateColorSettinsg,
			// Token: 0x0400152F RID: 5423
			[Token(Token = "0x400152F")]
			None
		}

		// Token: 0x0200034A RID: 842
		[Token(Token = "0x200034A")]
		[Serializable]
		public struct FogColorSource
		{
			// Token: 0x170002F6 RID: 758
			// (get) Token: 0x060014DE RID: 5342 RVA: 0x00006B88 File Offset: 0x00004D88
			[Token(Token = "0x170002F6")]
			public static StylisticFog.FogColorSource defaultSettings
			{
				[Token(Token = "0x60014DE")]
				[Address(RVA = "0x2CB28B0", Offset = "0x2CB18B0", VA = "0x182CB28B0")]
				get
				{
					return default(StylisticFog.FogColorSource);
				}
			}

			// Token: 0x04001530 RID: 5424
			[Token(Token = "0x4001530")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Color gradient.")]
			[StylisticFog.FogColorSource.DisplayOnSelectionType(StylisticFog.ColorSelectionType.Gradient)]
			public Gradient gradient;

			// Token: 0x04001531 RID: 5425
			[Token(Token = "0x4001531")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Custom fog color ramp.")]
			[StylisticFog.FogColorSource.DisplayOnSelectionType(StylisticFog.ColorSelectionType.TextureRamp)]
			public Texture2D colorRamp;

			// Token: 0x0200034B RID: 843
			[Token(Token = "0x200034B")]
			[AttributeUsage(256)]
			public class DisplayOnSelectionType : Attribute
			{
				// Token: 0x060014DF RID: 5343 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60014DF")]
				[Address(RVA = "0x6C3270", Offset = "0x6C2270", VA = "0x1806C3270")]
				public DisplayOnSelectionType(StylisticFog.ColorSelectionType _selectionType)
				{
				}

				// Token: 0x04001532 RID: 5426
				[Token(Token = "0x4001532")]
				[FieldOffset(Offset = "0x10")]
				public readonly StylisticFog.ColorSelectionType selectionType;
			}
		}

		// Token: 0x0200034C RID: 844
		[Token(Token = "0x200034C")]
		[Serializable]
		public struct DistanceFogSettings
		{
			// Token: 0x170002F7 RID: 759
			// (get) Token: 0x060014E0 RID: 5344 RVA: 0x00006BA0 File Offset: 0x00004DA0
			[Token(Token = "0x170002F7")]
			public static StylisticFog.DistanceFogSettings defaultSettings
			{
				[Token(Token = "0x60014E0")]
				[Address(RVA = "0x2CB2270", Offset = "0x2CB1270", VA = "0x182CB2270")]
				get
				{
					return default(StylisticFog.DistanceFogSettings);
				}
			}

			// Token: 0x04001533 RID: 5427
			[Token(Token = "0x4001533")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Wheter or not to apply distance based fog.")]
			public bool enabled;

			// Token: 0x04001534 RID: 5428
			[Token(Token = "0x4001534")]
			[FieldOffset(Offset = "0x1")]
			[Tooltip("Wheter or not to apply distance based fog to the skybox.")]
			public bool fogSkybox;

			// Token: 0x04001535 RID: 5429
			[Token(Token = "0x4001535")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Fog is fully saturated beyond this distance.")]
			public float endDistance;

			// Token: 0x04001536 RID: 5430
			[Token(Token = "0x4001536")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Color selection for distance fog")]
			public StylisticFog.ColorSelectionType colorSelectionType;
		}

		// Token: 0x0200034D RID: 845
		[Token(Token = "0x200034D")]
		[Serializable]
		public struct HeightFogSettings
		{
			// Token: 0x170002F8 RID: 760
			// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00006BB8 File Offset: 0x00004DB8
			[Token(Token = "0x170002F8")]
			public static StylisticFog.HeightFogSettings defaultSettings
			{
				[Token(Token = "0x60014E1")]
				[Address(RVA = "0x2CB2A40", Offset = "0x2CB1A40", VA = "0x182CB2A40")]
				get
				{
					return default(StylisticFog.HeightFogSettings);
				}
			}

			// Token: 0x04001537 RID: 5431
			[Token(Token = "0x4001537")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Wheter or not to apply height based fog.")]
			public bool enabled;

			// Token: 0x04001538 RID: 5432
			[Token(Token = "0x4001538")]
			[FieldOffset(Offset = "0x1")]
			[Tooltip("Wheter or not to apply height based fog to the skybox.")]
			public bool fogSkybox;

			// Token: 0x04001539 RID: 5433
			[Token(Token = "0x4001539")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Height where the fog starts.")]
			public float baseHeight;

			// Token: 0x0400153A RID: 5434
			[Token(Token = "0x400153A")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Fog density at fog altitude given by height.")]
			public float baseDensity;

			// Token: 0x0400153B RID: 5435
			[Token(Token = "0x400153B")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("The rate at which the thickness of the fog decays with altitude.")]
			[Range(0.001f, 1f)]
			public float densityFalloff;

			// Token: 0x0400153C RID: 5436
			[Token(Token = "0x400153C")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Color selection for height fog.")]
			public StylisticFog.ColorSelectionType colorSelectionType;
		}
	}
}
