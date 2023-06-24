using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Expanse
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[ExecuteInEditMode]
	public class LightControl : MonoBehaviour
	{
		// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x8DCFD0", Offset = "0x8DB5D0", VA = "0x1808DCFD0")]
		public void SetAtmosphereIndex(int index)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0xAF0770", Offset = "0xAEED70", VA = "0x180AF0770")]
		public void SetCloudIndex(int index)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039C")]
		[Address(RVA = "0xAF0780", Offset = "0xAEED80", VA = "0x180AF0780")]
		public void SetCloudShadowIndex(int index)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x600039D")]
		[Address(RVA = "0xAF0790", Offset = "0xAEED90", VA = "0x180AF0790")]
		public Light GetLight()
		{
			return null;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x600039E")]
		[Address(RVA = "0xAF0900", Offset = "0xAEEF00", VA = "0x180AF0900")]
		public HDAdditionalLightData GetHDAdditionalLightData()
		{
			return null;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0xAF0AA0", Offset = "0xAEF0A0", VA = "0x180AF0AA0")]
		public void SetRotation(Vector3 rotation)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xAF0C40", Offset = "0xAEF240", VA = "0x180AF0C40")]
		private void OnEnable()
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xAF0C90", Offset = "0xAEF290", VA = "0x180AF0C90")]
		private void OnDisable()
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xAF0CE0", Offset = "0xAEF2E0", VA = "0x180AF0CE0")]
		private void Update()
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xAF1930", Offset = "0xAEFF30", VA = "0x180AF1930")]
		public LightControl()
		{
		}

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Light intensity in lux. In particular this is the illuminance on the ground when the body is at the zenith position. A typical value for the sun is 150000, but this does not always integrate well with existing material workflows that are not physically-based.")]
		public float m_lightIntensity;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Specify color via blackbody temperature.")]
		public bool m_useTemperature;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Light color, or if using in temperature mode, filter applied to chosen temperature (in this case an artistic override). If this is a directional light, the intensity is specified in Lux. If it's a point light, the intensity is specified in lumens.")]
		public Color m_lightColor;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x38")]
		[Range(1000f, 20000f)]
		[Tooltip("Celestial body's temperature, used to set color in a physically-based way, according to the blackbody spectrum.")]
		public float m_lightTemperature;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Whether or not this light will illuminate clouds.")]
		public bool m_lightClouds;

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x3D")]
		[Tooltip("Whether or not this light will cast volumetric geometry cloud shadows.")]
		public bool m_volumetricGeometryShadows;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x3E")]
		[Tooltip("If this light is the main directional light, check this parameter to use the shadowmap for volumetric shadows instead of the depth buffer.")]
		public bool m_shadowmapVolumetricShadows;

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Maximum distance from camera over which volumetric shadows are applied. If you set this too high, you can lose detail in your close-up shadows.")]
		[Min(0f)]
		public float m_maxVolumetricShadowmapDistance;

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Artistic override to affect how much light gets transmitted through the atmosphere. For instance, if you feel like there's not enough light peeking through your fog at sunset, you can adjust this value above 1.")]
		[Min(0f)]
		public float m_transmittanceMultiplier;

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Light's angular radius in the sky, specified in degrees. Used when calculating penumbra.")]
		[Range(0f, 90f)]
		public float m_angularRadius;

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x4C")]
		[Min(0f)]
		[Tooltip("Multiplier on the angular radius used to compute the light's penumbra. Good for smoothing out the sky shadow for smaller bodies. 1 is a \"physical\" value, though the way Expanse compute sun disc illumination is an approximation anyway.")]
		public float m_penumbra;

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Whether or not this light will cast volumetric cloud shadows.")]
		public bool m_volumetricCloudShadows;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x51")]
		[Tooltip("Whether or not this light will cast cloud shadows.")]
		public bool m_castCloudShadows;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x52")]
		[Tooltip("Whether or not to raymarch the point light. If this is disabled, an analytical integration is used. The analytical integration strategy is very good and so this should be unnecessary.")]
		public bool m_raymarch;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x53")]
		[Tooltip("Whether or not this light will illuminate fog.")]
		public bool m_lightFog;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("Multiplier on the fog scattering.")]
		[Min(0f)]
		public float m_fogMultiplier;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 m_direction;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x64")]
		public float m_range;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x68")]
		public LightType m_lightType;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x6C")]
		public bool m_lightHasShadowmap;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x70")]
		private int m_atmosphereIndex;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x74")]
		private int m_cloudIndex;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x78")]
		private int m_cloudShadowIndex;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private bool _skipLightUpdate;
	}
}
