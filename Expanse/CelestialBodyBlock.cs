using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[ExecuteInEditMode]
	[Serializable]
	public class CelestialBodyBlock : MonoBehaviour
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xAB5BB0", Offset = "0xAB41B0", VA = "0x180AB5BB0")]
		private void OnEnable()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xAB5E10", Offset = "0xAB4410", VA = "0x180AB5E10")]
		private void OnDisable()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xAB5FB0", Offset = "0xAB45B0", VA = "0x180AB5FB0")]
		private void Update()
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xAB6480", Offset = "0xAB4A80", VA = "0x180AB6480")]
		public CelestialBodyBlock()
		{
		}

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x20")]
		public string m_name;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Directional light this celestial body controls.")]
		public GameObject m_directionalLight;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x30")]
		public bool m_lightHasShadowmap;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Celestial body's direction.")]
		public Vector3 m_direction;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Celestial body's angular radius in the sky, specified in degrees.")]
		[Range(0f, 90f)]
		public float m_angularRadius;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Multiplier on the angular radius used to compute the celestial body's penumbra. Good for smoothing out the sky shadow for smaller bodies. 1 is a \"physical\" value, though the way Expanse compute sun disc illumination is an approximation anyway.")]
		[Min(0f)]
		public float m_penumbra;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Celestial body's distance from the planet, in meters.")]
		[Min(0f)]
		public float m_distance;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Specify color via celestial body temperature.")]
		public bool m_useTemperature;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Light intensity of the celestial body, in lux. In particular this is the illuminance on the ground when the body is at the zenith position. A typical value for the sun is 150000, but this does not always integrate well with existing material workflows that are not physically-based.")]
		public float m_lightIntensity;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("Celestial body's light color, or if using in temperature mode, filter applied to chosen temperature (in this case an artistic override).")]
		public Color m_lightColor;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x64")]
		[Range(1000f, 20000f)]
		[Tooltip("Celestial body's temperature, used to set color in a physically-based way, according to the blackbody spectrum.")]
		public float m_lightTemperature;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Whether or not this celestial body will illuminate clouds.")]
		public bool m_lightClouds;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x69")]
		[Tooltip("Whether or not this celestial body will cast cloud shadows.")]
		public bool m_castCloudShadows;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x6A")]
		[Tooltip("Whether or not this celestial body casts volumetric geometry shadows.")]
		public bool m_volumetricGeometryShadows;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x6B")]
		[Tooltip("Whether or not this celestial body casts volumetric cloud shadows.")]
		public bool m_volumetricCloudShadows;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x6C")]
		[Tooltip("If this celestial body's light is the main directional light, check this parameter to use the shadowmap for volumetric shadows instead of the depth buffer.")]
		public bool m_shadowmapVolumetricShadows;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x70")]
		[Min(0f)]
		[Tooltip("Maximum distance from camera over which volumetric shadows are applied. If you set this too high, you can lose detail in your close-up shadows.")]
		public float m_maxVolumetricShadowmapDistance;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x74")]
		[Min(0f)]
		[Tooltip("Artistic override to affect how much light gets transmitted through the atmosphere. For instance, if you feel like there's not enough light peeking through your fog at sunset, you can adjust this value above 1.")]
		public float m_transmittanceMultiplier;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("Whether or not the celestial body is tidally locked. This means that the same side of the celestial body always faces the planet---for instance, like Earth's moon, Luna.")]
		public bool m_tidallyLocked;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x79")]
		[Tooltip("Whether or not this celestial body receives light.")]
		public bool m_receivesLight;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Celestial body's albedo texture.")]
		public Cubemap m_albedoTexture;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("Rotation of celestial body's albedo texture, specified by euler angles.")]
		public Vector3 m_albedoTextureRotation;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x94")]
		[Tooltip("Tint to celestial body's albedo texture, or just celestial body's color if no texture is selected. Perfect grey (127, 127, 127) specifies no tint.")]
		public Color m_albedoTint;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0xA4")]
		[Tooltip("Instead of using a Lambertian (diffuse) BRDF, uses a BRDF specifically tailored for modeling Earth's moon, Luna.")]
		public bool m_moonMode;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0xA8")]
		[Range(0.001f, 1f)]
		[Tooltip("Retrodirection of Luna BRDF. A good value for the moon is 0.6.")]
		public float m_retrodirection;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0xAC")]
		[Range(-1f, 1f)]
		[Tooltip("Anisotropy of Luna BRDF. A good value for the moon is 0.1.")]
		public float m_anisotropy;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Whether or not celestial body is emissive.")]
		public bool m_emissive;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0xB4")]
		[Min(0f)]
		[Tooltip("Adjustable limb-darkening effect that darkens edges of celestial body. A physically-accurate value is 1, but higher values are often needed for the effect to be visible.")]
		public float m_limbDarkening;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0xB8")]
		[Tooltip("Emission texture for celestial body. Will be multiplied by light intensity to get final displayed color.")]
		public Cubemap m_emissionTexture;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0xC0")]
		[Tooltip("Rotation of celestial body's emission texture, specified by euler angles.")]
		public Vector3 m_emissionTextureRotation;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0xCC")]
		[Tooltip("Tint to celestial body. If an emission texture is present, will tint the texture, but otherwise will just tint the body's light color. A value of perfect white (255, 255, 255) specifies no tint.")]
		public Color m_emissionTint;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0xDC")]
		[Tooltip("Multiplier on emissive color/texture. Often, emission textures will be too blown out if their actual physical light values are used. This is an artistic override to correct that.")]
		[Min(0f)]
		public float m_emissionMultiplier;
	}
}
