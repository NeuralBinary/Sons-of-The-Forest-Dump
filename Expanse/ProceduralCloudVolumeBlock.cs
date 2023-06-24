using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[ExecuteInEditMode]
	[Serializable]
	public class ProceduralCloudVolumeBlock : BaseCloudLayerBlock
	{
		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0xABAC20", Offset = "0xAB9220", VA = "0x180ABAC20")]
		private void Update()
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "4")]
		public override UniversalCloudLayer ToUniversal()
		{
			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0xABBE00", Offset = "0xABA400", VA = "0x180ABBE00", Slot = "5")]
		public override void FromUniversal(UniversalCloudLayer from, bool bypassOffset = false)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x600021C")]
		[Address(RVA = "0xABC640", Offset = "0xABAC40", VA = "0x180ABC640", Slot = "6")]
		public override bool SetTexture(CloudDatatypes.CloudNoiseLayer noiseLayer, Texture texture, int tile)
		{
			return default(bool);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0xABC820", Offset = "0xABAE20", VA = "0x180ABC820")]
		public ProceduralCloudVolumeBlock()
		{
		}

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x20")]
		public string m_name;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x28")]
		private UniversalCloudLayer m_universal;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Whether or not the cloud layer is curved with the surface of the planet.")]
		public bool m_curved;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Origin of this layer's cloud geometry---the center of the cloud volume.")]
		public Vector3 m_origin;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x40")]
		[Min(0f)]
		[Tooltip("X extent---\"width\"---of this cloud layer's geometry.")]
		public float m_XExtent;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x44")]
		[Min(0f)]
		[Tooltip("Y extent---\"thickness\"---of this cloud layer's geometry.")]
		public float m_YExtent;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x48")]
		[Min(0f)]
		[Tooltip("Z extent---\"depth\"---of this cloud layer's geometry.")]
		public float m_ZExtent;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x4C")]
		[Min(0f)]
		[Tooltip("Density over which density is attenuated.")]
		public float m_attenuationDistance;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Density before density attenuation kicks in.")]
		[Min(0f)]
		public float m_attenuationBias;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("Range over which density ramps up to full. Useful as a sort of soft near clipping plane for the clouds.")]
		[MinMaxSlider(0f, 200000f)]
		public Vector2 m_rampUp;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("Quality of procedural noises for this layer. If no procedural noises are enabled, this parameter does not change anything.")]
		public Datatypes.Quality m_noiseTextureQuality;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("How much the coverage noise erodes the base noise.")]
		public float m_coverageIntensity;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x64")]
		[Range(0f, 1f)]
		[Tooltip("How much the structure noise erodes the base noise.")]
		public float m_structureIntensity;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("How much the structure noise multiplies the base noise.")]
		[Range(0f, 1f)]
		public float m_structureMultiply;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		[Tooltip("How much the detail noise erodes the base noise.")]
		public float m_detailIntensity;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		[Tooltip("How much the detail noise multiplies the base noise.")]
		public float m_detailMultiply;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		[Tooltip("How much the base noise is warped by its warp texture.")]
		public float m_baseWarpIntensity;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("How much the detail noise is warped by its warp texture.")]
		[Range(0f, 1f)]
		public float m_detailWarpIntensity;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x7C")]
		[Min(0f)]
		[Tooltip("How much to round off the tops of the clouds.")]
		public float m_rounding;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("The curve of the rounding.")]
		[Min(0f)]
		public float m_roundingShape;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x84")]
		[Tooltip("Bottom of the height gradient.")]
		[MinMaxSlider(0f, 1f)]
		public Vector2 m_heightGradientBottom;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x8C")]
		[Tooltip("Top of the height gradient.")]
		[MinMaxSlider(0f, 1f)]
		public Vector2 m_heightGradientTop;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x94")]
		[Tooltip("Skew over height of the clouds due to wind.")]
		public Vector2 m_windSkew;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0xA0")]
		private string[] kNoiseLayerNames;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0xA8")]
		public ProceduralCloudVolumeBlock.LayerSettings[] m_noiseLayers;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Density of this cloud layer.")]
		[Min(0f)]
		public float m_density;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0xB4")]
		[Tooltip("Extinction coefficients control the absorption of light by the atmosphere.")]
		[ColorUsage(true, true)]
		public Color m_extinctionCoefficients;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0xC4")]
		[Tooltip("Scattering coefficients control the scattering of light by the atmosphere. Should be less than extinction to remain physical.")]
		[ColorUsage(true, true)]
		public Color m_scatteringCoefficients;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0xD4")]
		[Tooltip("Anistropy of cloud scattering. Higher values will give more forward scattering. Lower values will give more backward scattering. A value of zero is neutral---i.e. it will produce \"isotropic\" scattering. Clouds are generally quite anisotropic, so a value of around 0.6 is a good physical approximation.")]
		[Range(-1f, 1f)]
		public float m_anisotropy;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0xD8")]
		[Tooltip("Intensity of cloud silver lining.")]
		[Range(0f, 1f)]
		public float m_silverIntensity;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0xDC")]
		[Tooltip("Spread of cloud silver lining.")]
		[Range(0f, 1f)]
		public float m_silverSpread;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0xE0")]
		[MinMaxSlider(0f, 1f)]
		[Tooltip("Height range of ambient lighting the clouds receive from the sky. The bottom of clouds generally receives less ambient light than the top. Tweaking this can help reveal self-shadowed details.")]
		public Vector2 m_ambientHeightRange;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0xE8")]
		[Tooltip("Strength range of ambient lighting the clouds receive from the sky, applied over the specified height range.")]
		[MinMaxSlider(0f, 5f)]
		public Vector2 m_ambientStrengthRange;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0xF0")]
		[Tooltip("Unit height range to apply vertical in-scattering probability to.")]
		[MinMaxSlider(0f, 1f)]
		public Vector2 m_verticalProbabilityHeightRange;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0xF8")]
		[Tooltip("Strength of vertical in-scattering probablity.")]
		[Min(0f)]
		public float m_verticalProbabilityStrength;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0xFC")]
		[MinMaxSlider(0f, 1f)]
		[Tooltip("Unit height range to apply vertical in-scattering probability to.")]
		public Vector2 m_depthProbabilityHeightRange;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x104")]
		[MinMaxSlider(0f, 5f)]
		[Tooltip("Unit height range to apply vertical in-scattering probability to.")]
		public Vector2 m_depthProbabilityStrengthRange;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x10C")]
		[Min(0f)]
		[Tooltip("Pre-multiplier on density for depth in-scattering probability. Can be useful for bringing the density into a range where the effect is noticeable.")]
		public float m_depthProbabilityDensityMultiplier;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x110")]
		[Range(0f, 1f)]
		[Tooltip("Pre-multiplier on density for depth in-scattering probability. Can be useful for bringing the density into a range where the effect is noticeable.")]
		public float m_depthProbabilityBias;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x114")]
		[Tooltip("Whether or not to use a higher detail version of depth probability. Off by default to accommodate previous presets.")]
		public bool m_depthProbabilityHighDetail;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x115")]
		[Tooltip("Whether or not the clouds cast shadows on themselves.")]
		public bool m_selfShadowing;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x118")]
		[Tooltip("Max distance that clouds can cast shadows onto themselves/each other.")]
		[Range(1f, 10000f)]
		public float m_maxSelfShadowDistance;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x11C")]
		[Range(0f, 1f)]
		[Tooltip("Amount of approximated multiple scattering.")]
		public float m_multipleScatteringAmount;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x120")]
		[Range(0f, 1f)]
		[Tooltip("Bias to approximated multiple scattering.")]
		public float m_multipleScatteringBias;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x124")]
		[Tooltip("How much to ramp down multiple scattering as samples approach the light. This is useful for making sure that denser clouds block enough light when the sun is behind them.")]
		[Range(0f, 1f)]
		public float m_multipleScatteringRampDown;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x128")]
		[Tooltip("How sharply the multiple scattering ramps down as samples approach the light.")]
		[Min(0f)]
		public float m_multipleScatteringRampDownShape;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x12C")]
		[Tooltip("Amount the light pollution affects the clouds. Useful for when light pollution is being used primarily as an artistic effect for the sky.")]
		[Range(0f, 1f)]
		public float m_lightPollutionDimmer;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x130")]
		[Tooltip("Whether to use cel/\"toon\" shading on the clouds.")]
		public bool m_celShade;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x134")]
		[Tooltip("Band above which transmittance is 1, and below which transmittance is zero.")]
		[Min(0f)]
		public float m_celShadeColorBands;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x138")]
		[Tooltip("Band above which lighting is clamped, and below which lighting is zero.")]
		[Range(0f, 1f)]
		public float m_celShadeTransmittanceBands;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x13C")]
		[Tooltip("Whether or not this layer casts shadows on the ground and geometry.")]
		public bool m_castShadows;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x140")]
		[Range(0f, 1f)]
		[Tooltip("The maximum darkness of shadows this cloud layer casts onto geometry and fog.")]
		public float m_maxShadowIntensity;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x144")]
		[Tooltip("Displays sampling offset instead of velocity, for user control.")]
		public bool m_useOffset;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x148")]
		[Tooltip("Velocity of the cloud coverage map. Automates the sampling offset parameter.")]
		public Vector2 m_coverageVelocity;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x150")]
		[Tooltip("Velocity of the cloud base noise. Automates the sampling offset parameter.")]
		public Vector2 m_baseVelocity;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x158")]
		[Tooltip("Velocity of the cloud structure noise. Automates the sampling offset parameter.")]
		public Vector2 m_structureVelocity;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x160")]
		[Tooltip("Velocity of the cloud detail noise. Automates the sampling offset parameter.")]
		public Vector2 m_detailVelocity;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x168")]
		[Tooltip("Velocity of the cloud base warp noise. Automates the sampling offset parameter.")]
		public Vector2 m_baseWarpVelocity;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x170")]
		[Tooltip("Velocity of the cloud detail warp noise. Automates the sampling offset parameter.")]
		public Vector2 m_detailWarpVelocity;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x178")]
		[Tooltip("Sampling offsets for coverage map. Can be animated as an alternative to the velocity parameter.")]
		public Vector2 m_coverageOffset;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x180")]
		[Tooltip("Sampling offsets for base noise. Can be animated as an alternative to the velocity parameter.")]
		public Vector2 m_baseOffset;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x188")]
		[Tooltip("Sampling offsets for coverage map. Can be animated as an alternative to the velocity parameter.")]
		public Vector2 m_structureOffset;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x190")]
		[Tooltip("Sampling offsets for coverage map. Can be animated as an alternative to the velocity parameter.")]
		public Vector2 m_detailOffset;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x198")]
		[Tooltip("Sampling offsets for coverage map. Can be animated as an alternative to the velocity parameter.")]
		public Vector2 m_baseWarpOffset;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x1A0")]
		[Tooltip("Sampling offsets for coverage map. Can be animated as an alternative to the velocity parameter.")]
		public Vector2 m_detailWarpOffset;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x1A8")]
		[Tooltip("Number of history frames to use for reprojection. Increasing can improve performance, but at the cost of quality")]
		[Range(1f, 4f)]
		public int m_reprojectionFrames;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x1AC")]
		[Tooltip("Step number range for coarse ray marching.")]
		[MinMaxSlider(1f, 256f)]
		public Vector2 m_coarseStepRange;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x1B4")]
		[MinMaxSlider(1f, 256f)]
		[Tooltip("Step number range for detail ray marching.")]
		public Vector2 m_detailStepRange;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x1BC")]
		[MinMaxSlider(50f, 200000f)]
		[Tooltip("Distance range over which to apply the step number ranges.")]
		public Vector2 m_stepDistanceRange;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x1C4")]
		[MinMaxSlider(1f, 4096f)]
		[Tooltip("Step range for flythrough ray marching, specified as (min, max) in world units. Reducing the first value can be helpful for reducing artifacts during flythrough, but can also be more expensive.")]
		public Vector2 m_flythroughStepRange;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x1CC")]
		[Tooltip("Distance range over which to apply the flythrough step range.")]
		[MinMaxSlider(0f, 200000f)]
		public Vector2 m_flythroughStepDistanceRange;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x1D4")]
		[Range(0f, 1f)]
		[Tooltip("Threshold below which normalized cloud density is considered to be zero.")]
		public float m_mediaZeroThreshold;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x1D8")]
		[Range(0f, 1f)]
		[Tooltip("Threshold below which cloud transmittance is considered to be zero.")]
		public float m_transmittanceZeroThreshold;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x1DC")]
		[Min(0f)]
		[Tooltip("Max number of consecutive zero samples before detail ray marching switches back to coarse ray marching.")]
		public int m_maxConsecutiveZeroSamples;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x1E0")]
		[Tooltip("Whether or not to use TAA-based denoising to allow fewer samples to be taken per frame.")]
		public bool m_useTemporalDenoising;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x1E4")]
		[Range(1f, 64f)]
		[Tooltip("How many history frames to use for TAA-based denoising. Fewer frames will result in less blurring but more noise. More frames will reduce noise but introduce blurring.")]
		public int m_denoisingHistoryFrames;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x1E8")]
		[Tooltip("Whether or not to apply certain sampling techniques that will reduce reprojection artifacts for cloud flythrough.")]
		public bool m_optimizeForFlythrough;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x1EC")]
		[Range(0f, 1f)]
		[Tooltip("Transmittance threshold for which to \"disable\" reprojection, to help with flythrough artifacts.")]
		public float m_flythroughThreshold;

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		[Serializable]
		public sealed class LayerSettings
		{
			// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600021E")]
			[Address(RVA = "0xABCDE0", Offset = "0xABB3E0", VA = "0x180ABCDE0")]
			public LayerSettings()
			{
			}

			// Token: 0x04000103 RID: 259
			[Token(Token = "0x4000103")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Whether to use procedural noise or a texture this noise layer.")]
			public bool procedural;

			// Token: 0x04000104 RID: 260
			[Token(Token = "0x4000104")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Noise texture for this layer.")]
			public Texture texture;

			// Token: 0x04000105 RID: 261
			[Token(Token = "0x4000105")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Texture generator for this layer---can be used as an alternative to the noise texture.")]
			public BaseTextureGeneratorBlock textureGenerator;

			// Token: 0x04000106 RID: 262
			[Token(Token = "0x4000106")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("Noise type for this layer.")]
			public Datatypes.NoiseType noiseType;

			// Token: 0x04000107 RID: 263
			[Token(Token = "0x4000107")]
			[FieldOffset(Offset = "0x2C")]
			[Tooltip("Scale of 0th octave.")]
			public Vector2 scale;

			// Token: 0x04000108 RID: 264
			[Token(Token = "0x4000108")]
			[FieldOffset(Offset = "0x34")]
			[Range(1f, 8f)]
			[Tooltip("Number of octaves.")]
			public int octaves;

			// Token: 0x04000109 RID: 265
			[Token(Token = "0x4000109")]
			[FieldOffset(Offset = "0x38")]
			[Tooltip("How much to scale each successive octave by.")]
			[Min(0f)]
			public float octaveScale;

			// Token: 0x0400010A RID: 266
			[Token(Token = "0x400010A")]
			[FieldOffset(Offset = "0x3C")]
			[Tooltip("How much to multiply the intensity of each successive octave by.")]
			[Min(0f)]
			public float octaveMultiplier;

			// Token: 0x0400010B RID: 267
			[Token(Token = "0x400010B")]
			[FieldOffset(Offset = "0x40")]
			[Tooltip("Tile factor.")]
			[Min(1f)]
			public int tile;
		}
	}
}
