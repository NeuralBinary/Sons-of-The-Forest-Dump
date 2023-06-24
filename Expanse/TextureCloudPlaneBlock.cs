using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[ExecuteInEditMode]
	[Serializable]
	public class TextureCloudPlaneBlock : BaseCloudLayerBlock
	{
		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xABE930", Offset = "0xABCF30", VA = "0x180ABE930")]
		private void Update()
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "4")]
		public override UniversalCloudLayer ToUniversal()
		{
			return null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xABEF80", Offset = "0xABD580", VA = "0x180ABEF80", Slot = "5")]
		public override void FromUniversal(UniversalCloudLayer from, bool bypassOffset = false)
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x600023B")]
		[Address(RVA = "0xABF280", Offset = "0xABD880", VA = "0x180ABF280", Slot = "6")]
		public override bool SetTexture(CloudDatatypes.CloudNoiseLayer noiseLayer, Texture texture, int tile)
		{
			return default(bool);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xABF390", Offset = "0xABD990", VA = "0x180ABF390")]
		public TextureCloudPlaneBlock()
		{
		}

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x20")]
		public string m_name;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x28")]
		private UniversalCloudLayer m_universal;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Texture to use as the density field.")]
		public Texture m_texture;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("How many times to tile the texture.")]
		[Min(1f)]
		public int m_tile;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Whether or not the cloud layer is curved with the surface of the planet.")]
		public bool m_curved;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("X extent of this cloud layer's geometry.")]
		public Vector2 m_geometryXExtent;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Z extent of this cloud layer's geometry.")]
		public Vector2 m_geometryZExtent;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Height of this cloud layer's geometry.")]
		public float m_geometryHeight;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("Density over which density is attenuated.")]
		[Min(0f)]
		public float m_attenuationDistance;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Density before density attenuation kicks in.")]
		[Min(0f)]
		public float m_attenuationBias;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("Range over which density ramps up to full. Useful as a sort of soft near clipping plane for the clouds.")]
		[MinMaxSlider(0f, 200000f)]
		public Vector2 m_rampUp;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("Density of this cloud layer.")]
		[Min(0f)]
		public float m_density;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x68")]
		[Min(1f)]
		[Tooltip("Apparent thickness of this 2D cloud layer. Pushing this value too high can give strange results.")]
		public float m_apparentThickness;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x6C")]
		[ColorUsage(true, true)]
		[Tooltip("Extinction coefficients control the absorption of light by the atmosphere.")]
		public Color m_extinctionCoefficients;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x7C")]
		[ColorUsage(true, true)]
		[Tooltip("Scattering coefficients control the scattering of light by the atmosphere. Should be less than extinction to remain physical.")]
		public Color m_scatteringCoefficients;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x8C")]
		[Range(-1f, 1f)]
		[Tooltip("Anistropy of cloud scattering. Higher values will give more forward scattering. Lower values will give more backward scattering. A value of zero is neutral---i.e. it will produce \"isotropic\" scattering. Clouds are generally quite anisotropic, so a value of around 0.6 is a good physical approximation.")]
		public float m_anisotropy;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("Intensity of cloud silver lining.")]
		[Range(0f, 1f)]
		public float m_silverIntensity;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x94")]
		[Tooltip("Spread of cloud silver lining.")]
		[Range(0f, 1f)]
		public float m_silverSpread;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x98")]
		[Min(0f)]
		[Tooltip("Ambient lighting the clouds receive from the sky. Expanse doesn't compute self-shadowing of ambient light, so this can help to lower the ambient light contribution to a level that looks more physically correct.")]
		public float m_ambient;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x9C")]
		[Tooltip("Whether or not the clouds cast shadows on themselves.")]
		public bool m_selfShadowing;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0xA0")]
		[Range(0f, 1f)]
		[Tooltip("Amount of approximated multiple scattering.")]
		public float m_multipleScatteringAmount;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0xA4")]
		[Tooltip("Bias to approximated multiple scattering.")]
		[Range(0f, 1f)]
		public float m_multipleScatteringBias;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0xA8")]
		[Range(0f, 1f)]
		[Tooltip("How much to ramp down multiple scattering as samples approach the light. This is useful for making sure that denser clouds block enough light when the sun is behind them.")]
		public float m_multipleScatteringRampDown;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0xAC")]
		[Tooltip("How sharply the multiple scattering ramps down as samples approach the light.")]
		[Min(0f)]
		public float m_multipleScatteringRampDownShape;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Whether to use cel/\"toon\" shading on the clouds.")]
		public bool m_celShade;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0xB4")]
		[Tooltip("Specifies the number of color bands to use.")]
		[Min(0f)]
		public float m_celShadeColorBands;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0xB8")]
		[Tooltip("Specifies the constant transmittance band to use.")]
		[Range(0f, 1f)]
		public float m_celShadeTransmittanceBands;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0xBC")]
		[Tooltip("Whether or not this layer casts shadows on the ground and geometry.")]
		public bool m_castShadows;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0xC0")]
		[Tooltip("The maximum darkness of shadows this cloud layer casts onto geometry and fog.")]
		[Range(0f, 1f)]
		public float m_maxShadowIntensity;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0xC4")]
		[Range(0f, 1f)]
		[Tooltip("Amount the light pollution affects the clouds. Useful for when light pollution is being used primarily as an artistic effect for the sky.")]
		public float m_lightPollutionDimmer;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0xC8")]
		[Tooltip("Displays sampling offset instead of velocity, for user control.")]
		public bool m_useOffset;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0xCC")]
		[Tooltip("Velocity of the clouds. Automates the sampling offset parameter.")]
		public Vector2 m_velocity;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0xD4")]
		[Tooltip("Sampling offset of the clouds. Can be animated as an alternative to the velocity parameter.")]
		public Vector2 m_samplingOffset;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0xDC")]
		[Range(1f, 4f)]
		[Tooltip("Number of history frames to use for reprojection. Increasing can improve performance, but at the cost of quality")]
		public int m_reprojectionFrames;
	}
}
