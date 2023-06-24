using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[Serializable]
	public class ProceduralCloudPlaneBlock : BaseCloudLayerBlock
	{
		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0xAB9720", Offset = "0xAB7D20", VA = "0x180AB9720")]
		private void Update()
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "4")]
		public override UniversalCloudLayer ToUniversal()
		{
			return null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0xABA090", Offset = "0xAB8690", VA = "0x180ABA090", Slot = "5")]
		public override void FromUniversal(UniversalCloudLayer from, bool bypassOffset = false)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x6000216")]
		[Address(RVA = "0xABA620", Offset = "0xAB8C20", VA = "0x180ABA620", Slot = "6")]
		public override bool SetTexture(CloudDatatypes.CloudNoiseLayer noiseLayer, Texture texture, int tile)
		{
			return default(bool);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0xABA7F0", Offset = "0xAB8DF0", VA = "0x180ABA7F0")]
		public ProceduralCloudPlaneBlock()
		{
		}

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x20")]
		public string m_name;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x28")]
		private UniversalCloudLayer m_universal;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Whether or not the cloud layer is curved with the surface of the planet.")]
		public bool m_curved;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("X extent of this cloud layer's geometry.")]
		public Vector2 m_geometryXExtent;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Z extent of this cloud layer's geometry.")]
		public Vector2 m_geometryZExtent;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Height of this cloud layer's geometry.")]
		public float m_geometryHeight;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Density over which density is attenuated.")]
		[Min(0f)]
		public float m_attenuationDistance;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x4C")]
		[Min(0f)]
		[Tooltip("Density before density attenuation kicks in.")]
		public float m_attenuationBias;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Range over which density ramps up to full. Useful as a sort of soft near clipping plane for the clouds.")]
		[MinMaxSlider(0f, 200000f)]
		public Vector2 m_rampUp;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Quality of procedural noises for this layer. If no procedural noises are enabled, this parameter does not change anything.")]
		public Datatypes.Quality m_noiseTextureQuality;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		[Tooltip("How much the coverage noise erodes the base noise.")]
		public float m_coverageIntensity;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("How much the structure noise erodes the base noise.")]
		public float m_structureIntensity;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("How much the structure noise multiplies the base noise.")]
		[Range(0f, 1f)]
		public float m_structureMultiply;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("How much the detail noise erodes the base noise.")]
		[Range(0f, 1f)]
		public float m_detailIntensity;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x6C")]
		[Tooltip("How much the detail noise multiplies the base noise.")]
		[Range(0f, 1f)]
		public float m_detailMultiply;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		[Tooltip("How much the base noise is warped by its warp texture.")]
		public float m_baseWarpIntensity;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		[Tooltip("How much the detail noise is warped by its warp texture.")]
		public float m_detailWarpIntensity;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x78")]
		private string[] kNoiseLayerNames;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x80")]
		public ProceduralCloudPlaneBlock.LayerSettings[] m_noiseLayers;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x88")]
		[Min(0f)]
		[Tooltip("Density of this cloud layer.")]
		public float m_density;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x8C")]
		[Min(1f)]
		[Tooltip("Apparent thickness of this 2D cloud layer. Pushing this value too high can give strange results.")]
		public float m_apparentThickness;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("Extinction coefficients control the absorption of light by the atmosphere.")]
		[ColorUsage(true, true)]
		public Color m_extinctionCoefficients;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0xA0")]
		[Tooltip("Scattering coefficients control the scattering of light by the atmosphere. Should be less than extinction to remain physical.")]
		[ColorUsage(true, true)]
		public Color m_scatteringCoefficients;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Anistropy of cloud scattering. Higher values will give more forward scattering. Lower values will give more backward scattering. A value of zero is neutral---i.e. it will produce \"isotropic\" scattering. Clouds are generally quite anisotropic, so a value of around 0.6 is a good physical approximation.")]
		[Range(-1f, 1f)]
		public float m_anisotropy;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0xB4")]
		[Tooltip("Intensity of cloud silver lining.")]
		[Range(0f, 1f)]
		public float m_silverIntensity;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0xB8")]
		[Range(0f, 1f)]
		[Tooltip("Spread of cloud silver lining.")]
		public float m_silverSpread;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0xBC")]
		[Min(0f)]
		[Tooltip("Ambient lighting the clouds receive from the sky. Expanse doesn't compute self-shadowing of ambient light, so this can help to lower the ambient light contribution to a level that looks more physically correct.")]
		public float m_ambient;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0xC0")]
		[Tooltip("Whether or not the clouds cast shadows on themselves.")]
		public bool m_selfShadowing;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0xC4")]
		[Range(0f, 1f)]
		[Tooltip("Amount of approximated multiple scattering.")]
		public float m_multipleScatteringAmount;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0xC8")]
		[Range(0f, 1f)]
		[Tooltip("Bias to approximated multiple scattering.")]
		public float m_multipleScatteringBias;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0xCC")]
		[Tooltip("How much to ramp down multiple scattering as samples approach the light. This is useful for making sure that denser clouds block enough light when the sun is behind them.")]
		[Range(0f, 1f)]
		public float m_multipleScatteringRampDown;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0xD0")]
		[Min(0f)]
		[Tooltip("How sharply the multiple scattering ramps down as samples approach the light.")]
		public float m_multipleScatteringRampDownShape;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0xD4")]
		[Tooltip("Amount the light pollution affects the clouds. Useful for when light pollution is being used primarily as an artistic effect for the sky.")]
		[Range(0f, 1f)]
		public float m_lightPollutionDimmer;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0xD8")]
		[Tooltip("Whether to use cel/\"toon\" shading on the clouds.")]
		public bool m_celShade;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0xDC")]
		[Tooltip("Band above which transmittance is 1, and below which transmittance is zero.")]
		[Min(0f)]
		public float m_celShadeColorBands;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0xE0")]
		[Tooltip("Band above which lighting is clamped, and below which lighting is zero.")]
		[Range(0f, 1f)]
		public float m_celShadeTransmittanceBands;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0xE4")]
		[Tooltip("Whether or not this layer casts shadows on the ground and geometry.")]
		public bool m_castShadows;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0xE8")]
		[Range(0f, 1f)]
		[Tooltip("The maximum darkness of shadows this cloud layer casts onto geometry and fog.")]
		public float m_maxShadowIntensity;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0xEC")]
		[Tooltip("Displays sampling offset instead of velocity, for user control.")]
		public bool m_useOffset;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0xF0")]
		[Tooltip("Velocity of the clouds. Automates the sampling offset parameter.")]
		public Vector2 m_velocity;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0xF8")]
		[Tooltip("Sampling offset of the clouds. Can be animated as an alternative to the velocity parameter.")]
		public Vector2 m_samplingOffset;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x100")]
		[Range(1f, 4f)]
		[Tooltip("Number of history frames to use for reprojection. Increasing can improve performance, but at the cost of quality")]
		public int m_reprojectionFrames;

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		[Serializable]
		public sealed class LayerSettings
		{
			// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000218")]
			[Address(RVA = "0xABABE0", Offset = "0xAB91E0", VA = "0x180ABABE0")]
			public LayerSettings()
			{
			}

			// Token: 0x040000AD RID: 173
			[Token(Token = "0x40000AD")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Whether to use procedural noise or a texture this noise layer.")]
			public bool procedural;

			// Token: 0x040000AE RID: 174
			[Token(Token = "0x40000AE")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Noise texture for this layer.")]
			public Texture texture;

			// Token: 0x040000AF RID: 175
			[Token(Token = "0x40000AF")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Noise type for this layer.")]
			public Datatypes.NoiseType noiseType;

			// Token: 0x040000B0 RID: 176
			[Token(Token = "0x40000B0")]
			[FieldOffset(Offset = "0x24")]
			[Tooltip("Scale of 0th octave.")]
			public Vector2 scale;

			// Token: 0x040000B1 RID: 177
			[Token(Token = "0x40000B1")]
			[FieldOffset(Offset = "0x2C")]
			[Tooltip("Number of octaves.")]
			[Range(1f, 8f)]
			public int octaves;

			// Token: 0x040000B2 RID: 178
			[Token(Token = "0x40000B2")]
			[FieldOffset(Offset = "0x30")]
			[Min(0f)]
			[Tooltip("How much to scale each successive octave by.")]
			public float octaveScale;

			// Token: 0x040000B3 RID: 179
			[Token(Token = "0x40000B3")]
			[FieldOffset(Offset = "0x34")]
			[Min(0f)]
			[Tooltip("How much to multiply the intensity of each successive octave by.")]
			public float octaveMultiplier;

			// Token: 0x040000B4 RID: 180
			[Token(Token = "0x40000B4")]
			[FieldOffset(Offset = "0x38")]
			[Tooltip("Tile factor.")]
			[Min(1f)]
			public int tile;
		}
	}
}
