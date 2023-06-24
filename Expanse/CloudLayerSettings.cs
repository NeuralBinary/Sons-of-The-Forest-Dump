using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[Serializable]
	public class CloudLayerSettings
	{
		// Token: 0x060002ED RID: 749 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xAD9C70", Offset = "0xAD8270", VA = "0x180AD9C70", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xAD9ED0", Offset = "0xAD84D0", VA = "0x180AD9ED0")]
		public CloudLayerSettings()
		{
		}

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Whether or not this cloud layer is enabled.")]
		public BoolParameter enabled;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Type of geometry for this cloud layer.")]
		public EnumParameter<CloudDatatypes.CloudGeometryType> geometryType;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("X extent of this cloud layer's geometry.")]
		public Vector2Parameter geometryXExtent;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Y extent of this cloud layer's geometry.")]
		public Vector2Parameter geometryYExtent;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Z extent of this cloud layer's geometry.")]
		public Vector2Parameter geometryZExtent;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Height of this cloud layer's geometry.")]
		public FloatParameter geometryHeight;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Quality of procedural noises for this layer. If no procedural noises are enabled, this parameter does not change anything.")]
		public EnumParameter<Datatypes.Quality> noiseTextureQuality;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("How much the coverage noise erodes the base noise.")]
		public ClampedFloatParameter coverageIntensity;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("How much the structure noise erodes the base noise.")]
		public ClampedFloatParameter structureIntensity;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("How much the detail noise erodes the base noise.")]
		public ClampedFloatParameter detailIntensity;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("How much the base noise is warped by its warp texture.")]
		public ClampedFloatParameter baseWarpIntensity;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("How much the detail noise is warped by its warp texture.")]
		public ClampedFloatParameter detailWarpIntensity;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Bottom of the height gradient.")]
		public FloatRangeParameter heightGradientBottom;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("Top of the height gradient.")]
		public FloatRangeParameter heightGradientTop;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Controls how much the clouds skew over height, to mimick the effect of the tops of clouds rolling over themselves in the wind. Order is (skew x, skew z).")]
		public Vector2Parameter windSkew;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("Controls how round the tops of clouds are, as opposed to blocky.")]
		public MinFloatParameter rounding;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("Controls the shape of the rounding effect.")]
		public MinFloatParameter roundingShape;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x98")]
		public ObjectParameter<CloudNoiseLayerSettings> coverageNoiseLayer;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0xA0")]
		public ObjectParameter<CloudNoiseLayerSettings> baseNoiseLayer;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0xA8")]
		public ObjectParameter<CloudNoiseLayerSettings> structureNoiseLayer;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0xB0")]
		public ObjectParameter<CloudNoiseLayerSettings> detailNoiseLayer;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0xB8")]
		public ObjectParameter<CloudNoiseLayerSettings> baseWarpNoiseLayer;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0xC0")]
		public ObjectParameter<CloudNoiseLayerSettings> detailWarpNoiseLayer;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0xC8")]
		[Tooltip("Sampling offsets for coverage map.")]
		public Vector3Parameter coverageOffset;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0xD0")]
		[Tooltip("Sampling offsets for base noise.")]
		public Vector3Parameter baseOffset;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0xD8")]
		[Tooltip("Sampling offsets for coverage map.")]
		public Vector3Parameter structureOffset;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0xE0")]
		[Tooltip("Sampling offsets for coverage map.")]
		public Vector3Parameter detailOffset;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0xE8")]
		[Tooltip("Sampling offsets for coverage map.")]
		public Vector3Parameter baseWarpOffset;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0xF0")]
		[Tooltip("Sampling offsets for coverage map.")]
		public Vector3Parameter detailWarpOffset;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0xF8")]
		[Tooltip("Density of this cloud layer.")]
		public MinFloatParameter density;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x100")]
		[Tooltip("Density attenuation distance for this cloud layer.")]
		public MinFloatParameter attenuationDistance;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x108")]
		[Tooltip("Density attenuation bias for this cloud layer.")]
		public MinFloatParameter attenuationBias;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x110")]
		[Tooltip("Beginning and ending distance for density rampup.")]
		public FloatRangeParameter rampUp;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x118")]
		[Tooltip("Extinction coefficients for this cloud layer.")]
		public Vector3Parameter extinctionCoefficients;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x120")]
		[Tooltip("Scattering coefficients for this cloud layer.")]
		public Vector3Parameter scatteringCoefficients;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x128")]
		[Tooltip("Amount of approximated multiple scattering.")]
		public ClampedFloatParameter multipleScatteringAmount;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x130")]
		[Tooltip("Bias to approximated multiple scattering.")]
		public ClampedFloatParameter multipleScatteringBias;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x138")]
		[Tooltip("How much to ramp down multiple scattering as samples approach the light. This is useful for making sure that denser clouds block enough light when the sun is behind them.")]
		public ClampedFloatParameter multipleScatteringRampDown;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x140")]
		[Tooltip("How sharply the multiple scattering ramps down as samples approach the light.")]
		public MinFloatParameter multipleScatteringRampDownShape;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x148")]
		[Tooltip("Spread of cloud silver lining.")]
		public ClampedFloatParameter silverSpread;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x150")]
		[Tooltip("Intensity of cloud silver lining.")]
		public ClampedFloatParameter silverIntensity;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x158")]
		[Tooltip("Anistropy of cloud scattering.")]
		public ClampedFloatParameter anisotropy;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x160")]
		[Tooltip("Ambient lighting the clouds receive from the sky. Expanse doesn't compute self-shadowing of ambient light, so this can help to lower the ambient light contribution to a level that looks more physically correct.")]
		public MinFloatParameter ambient;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x168")]
		[Tooltip("Height range of ambient lighting the clouds receive from the sky. The bottom of clouds generally receives less ambient light than the top. Tweaking this can help reveal self-shadowed details.")]
		public FloatRangeParameter ambientHeightRange;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x170")]
		[Tooltip("Strength range of ambient lighting the clouds receive from the sky, applied over the specified height range.")]
		public FloatRangeParameter ambientStrengthRange;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x178")]
		[Tooltip("Whether to use cel/\"toon\" shading. Good for stylized clouds.")]
		public BoolParameter celShade;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x180")]
		[Tooltip("Band for lighting.")]
		public MinFloatParameter celShadeLightingBands;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x188")]
		[Tooltip("Band for transmittance.")]
		public ClampedFloatParameter celShadeTransmittanceBands;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x190")]
		[Tooltip("Apparent thickness of this 2D cloud layer.")]
		public MinFloatParameter apparentThickness;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x198")]
		[Tooltip("Unit height range to apply vertical in-scattering probability to.")]
		public FloatRangeParameter verticalProbabilityHeightRange;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x1A0")]
		[Tooltip("Strength of vertical in-scattering probablity.")]
		public MinFloatParameter verticalProbabilityStrength;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x1A8")]
		[Tooltip("Unit height range to apply depth in-scattering probability to.")]
		public FloatRangeParameter depthProbabilityHeightRange;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x1B0")]
		[Tooltip("Strength range of depth in-scattering probability, from min height to max height.")]
		public FloatRangeParameter depthProbabilityStrengthRange;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x1B8")]
		[Tooltip("Pre-multiplier on density for depth in-scattering probability. Can be useful for bringing the density into a range where the effect is noticeable.")]
		public MinFloatParameter depthProbabilityDensityMultiplier;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x1C0")]
		[Tooltip("Bias to depth in-scattering probability.")]
		public ClampedFloatParameter depthProbabilityBias;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x1C8")]
		[Tooltip("Whether or not to use a higher detail version of depth probability. Off by default to accommodate previous presets.")]
		public BoolParameter depthProbabilityHighDetail;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x1D0")]
		[Tooltip("Amount the light pollution affects the clouds. Useful for when light pollution is being used primarily as an artistic effect for the sky.")]
		public ClampedFloatParameter lightPollutionDimmer;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x1D8")]
		[Tooltip("Whether or not this layer casts shadows on the ground and geometry.")]
		public BoolParameter castShadows;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x1E0")]
		[Tooltip("How dark the shadows cast by this cloud layer can be.")]
		public ClampedFloatParameter maxShadowIntensity;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x1E8")]
		[Tooltip("Whether or not the clouds cast shadows on themselves.")]
		public BoolParameter selfShadowing;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x1F0")]
		[Tooltip("Determines the quality of the clouds' self shadowing. Note that high quality doesn't always look better---it just uses a higher level of detail when sampling the shadows. It needs to be used carefully in conjunction with the multiple scattering parameters to create a desirable look.")]
		public BoolParameter highQualityShadows;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x1F8")]
		[Tooltip("Max distance that clouds can cast shadows onto themselves/each other.")]
		public ClampedFloatParameter maxSelfShadowDistance;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x200")]
		[Tooltip("Step number range for coarse ray marching.")]
		public FloatRangeParameter coarseStepRange;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x208")]
		[Tooltip("Step number range for detail ray marching.")]
		public FloatRangeParameter detailStepRange;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x210")]
		[Tooltip("Distance range over which to apply the step number ranges.")]
		public FloatRangeParameter stepDistanceRange;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x218")]
		[Tooltip("Min and max step distance for flythrough ray marching.")]
		public FloatRangeParameter flythroughStepRange;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x220")]
		[Tooltip("Distance range over which to apply the step number ranges.")]
		public FloatRangeParameter flythroughStepDistanceRange;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x228")]
		[Tooltip("Threshold below which normalized cloud density is considered to be zero.")]
		public ClampedFloatParameter mediaZeroThreshold;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x230")]
		[Tooltip("Threshold below which cloud transmittance is considered to be zero.")]
		public ClampedFloatParameter transmittanceZeroThreshold;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x238")]
		[Tooltip("Max number of consecutive zero samples before detail ray marching switches back to coarse ray marching.")]
		public MinIntParameter maxConsecutiveZeroSamples;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x240")]
		[Tooltip("Number of history frames to use for reprojection.")]
		public ClampedIntParameter reprojectionFrames;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x248")]
		[Tooltip("Whether or not to use TAA-based denoising to allow fewer samples to be taken per frame.")]
		public BoolParameter useTemporalDenoising;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x250")]
		[Tooltip("How many history frames to use for TAA-based denoising. Fewer frames will result in less blurring but more noise. More frames will reduce noise but introduce blurring.")]
		public ClampedIntParameter denoisingHistoryFrames;
	}
}
