using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	[Serializable]
	public class AtmosphereLayerBlock : MonoBehaviour
	{
		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xAB5420", Offset = "0xAB3A20", VA = "0x180AB5420")]
		private void OnEnable()
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xAB55A0", Offset = "0xAB3BA0", VA = "0x180AB55A0")]
		private void OnDisable()
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xAB5650", Offset = "0xAB3C50", VA = "0x180AB5650")]
		public AtmosphereLayerBlock()
		{
		}

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		public string m_name;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Density distribution type for this atmosphere layer.")]
		public AtmosphereDatatypes.DensityDistribution m_densityDistribution;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Density of this atmosphere layer.")]
		[Min(0f)]
		public float m_density;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Height of this atmosphere layer in world units.")]
		public float m_height;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x34")]
		[Min(0f)]
		[Tooltip("Thickness of this atmosphere layer in world units.")]
		public float m_thickness;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Extinction coefficients control the absorption of light by the atmosphere.")]
		[ColorUsage(true, true)]
		public Color m_extinctionCoefficients;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x48")]
		[ColorUsage(true, true)]
		[Tooltip("Scattering coefficients control the scattering of light by the atmosphere. Should be less than extinction to remain physical.")]
		public Color m_scatteringCoefficients;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Phase function to use for this atmosphere layer. Isotropic phase functions are useful for modeling simple non-directional scattering. The Rayleigh phase function is useful for modeling air and gases. The Mie phase function is good for modeling smoke, fog, and aerosols.")]
		public AtmosphereDatatypes.PhaseFunction m_phaseFunction;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x5C")]
		[Range(-1f, 1f)]
		[Tooltip("Anisotropy of this atmosphere layer. Higher values will give more forward scattering. Lower values will give more backward scattering. A value of zero is neutral---i.e. it will produce \"isotropic\" scattering.")]
		public float m_anisotropy;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Tint to this atmosphere layer. Artistic override. A tint of perfect grey (127, 127, 127) is neutral. It's often preferable to first adjust the scattering and extinction coefficients, as this will alter the color in a way that is physically-based.")]
		public Color m_tint;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x70")]
		[Min(0f)]
		[Tooltip("Multiple scattering multipler for this atmosphere layer. Artistic override. 1 is a physically accurate value.")]
		public float m_multipleScatteringMultiplier;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("Whether to use proper physical lighting or a cheaper approximation for screenspace distributions.")]
		public bool m_physicalLighting;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x75")]
		[Tooltip("Whether or not to compute screenspace volumetric shadows from geometry for this layer.")]
		public bool m_geometryShadows;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x76")]
		[Tooltip("Whether or not to compute screenspace volumetric shadows from clouds for this layer. Disable if you aren't using any clouds.")]
		public bool m_cloudShadows;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("The maximum occlusion value that volumetric geometry shadows can have. This is useful for allowing some light to leak in and soften the volumetric shadows.")]
		[Range(0f, 1f)]
		public float m_maxGeometryOcclusion;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x7C")]
		[Tooltip("The maximum occlusion value that volumetric cloud shadows can have. This is useful for allowing some light to leak in and soften the volumetric shadows.")]
		[Range(0f, 1f)]
		public float m_maxCloudOcclusion;
	}
}
