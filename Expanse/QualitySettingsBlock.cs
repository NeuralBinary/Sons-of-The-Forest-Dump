using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[ExecuteInEditMode]
	[Serializable]
	public class QualitySettingsBlock : MonoBehaviour
	{
		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0xABE740", Offset = "0xABCD40", VA = "0x180ABE740")]
		private void OnEnable()
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000236")]
		[Address(RVA = "0xABE820", Offset = "0xABCE20", VA = "0x180ABE820")]
		private void OnDisable()
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000237")]
		[Address(RVA = "0xABE870", Offset = "0xABCE70", VA = "0x180ABE870")]
		public QualitySettingsBlock()
		{
		}

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Whether or not to use MSAA 8x anti-aliasing. Expanse uses conditional MSAA, only multisampling on the edges of celestial bodies and the ground, so enabling this should not cause much of a performance hit.")]
		public bool m_antiAlias;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x21")]
		[Tooltip("Whether or not to use dithering, to reduce color banding. Since expanse computes everything in floating point HDR values, this is more of a de-band operation than a true dither, and you may be better off using a dither post-process step on your camera.")]
		public bool m_dither;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Specifies resolution to render clouds at, as a function of the camera resolution. 1 means full resolution. 0.5 means half resolution.")]
		[Range(0.25f, 1f)]
		public float m_cloudSubresolution;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Uses cloud layer height, instead of per-pixel logic, to determine composition order of cloud layers. This is an optimization for rendering many cloud layers from the ground and will produce inconsistent results when the camera is between, above, or inside cloud layers.")]
		public bool m_compositeCloudsByHeight;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Size of cloud shadow map film plane. This limits how far out cloud shadows can extend.")]
		[Min(0f)]
		public float m_cloudShadowMapFilmPlaneScale;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Quality of cloud shadowmap texture. Increasing this will reduce performance.")]
		public Datatypes.Quality m_cloudShadowMapQuality;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Quality of atmosphere lookup textures.")]
		public Datatypes.Quality m_atmosphereTextureQuality;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Quality of screenspace fog textures.")]
		public Datatypes.Quality m_screenspaceFogQuality;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x3C")]
		[Range(1f, 256f)]
		[Tooltip("The number of samples used when computing transmittance lookup tables. With importance sampling turned on, a value of as low as 10 gives near-perfect results on the ground. A value as low as 4 is ok if some visible inaccuracy is tolerable. Without importantance sampling, a value of 32 or higher is recommended.")]
		public int m_transmittanceSamples;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("The number of samples used when computing light pollution. With importance sampling turned on, a value of as low as 10 gives near-perfect results on the ground. A value as low as 8 is ok if some visible inaccuracy is tolerable. Without importantance sampling, a value of 64 or higher is recommended.")]
		[Range(1f, 256f)]
		public int m_aerialPerspectiveSamples;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x44")]
		[Range(1f, 256f)]
		[Tooltip("The number of samples used when computing single scattering. With importance sampling turned on, a value of as low as 10 gives near-perfect results on the ground. A value as low as 5 is ok if some visible inaccuracy is tolerable. Without importantance sampling, a value of 32 or higher is recommended.")]
		public int m_singleScatteringSamples;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x48")]
		[Range(1f, 256f)]
		[Tooltip("The number of samples to use when computing the initial isotropic estimate of multiple scattering. Importance sampling does not apply here. To get a near-perfect result, around 15 samples is necessary. But it is a fairly subtle effect, so as low as 6 samples gives a decent result.")]
		public int m_multipleScatteringSamples;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("The number of samples to use when computing the actual accumulated estimate of multiple scattering from the isotropic estimate. The number of samples to use when computing the initial isotropic estimate of multiple scattering. With importance sample, 8 samples gives a near-perfect result. However, multiple scattering is a fairly subtle effect, so as low as 3 samples gives a decent result. Without importance sampling, a value of 32 or higher is necessary for near perfect results, but a value of 4 is sufficient for most needs.")]
		[Range(1f, 256f)]
		public int m_multipleScatteringAccumulationSamples;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The number of samples to use when computing physical scattering for screenspace layers. If no screenspace layers use physical lighting, then this parameter has no effect.")]
		[Range(1f, 128f)]
		public int m_screenspaceScatteringSamples;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("The number of samples to use when computing the occlusion estimate for screenspace layers.")]
		[Range(1f, 128f)]
		public int m_screenspaceOcclusionSamples;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("Whether or not to use importance sampling for all atmosphere calculations except aerial perspective. Importance sampling is a sample distribution strategy that increases fidelity given a limited budget of samples. It is recommended to turn it on, as it doesn't decrease fidelity, but does allow for fewer samples to be taken, boosting performance. However, for outer-space perspectives, it can sometimes introduce inaccuracies, so it can be useful to increase sample counts and turn off importance sampling in those cases.")]
		public bool m_importanceSampleAtmosphere;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x59")]
		[Tooltip("Whether or not to use importance sampling for aerial perspective. Importance sampling is a sample distribution strategy that increases fidelity given a limited budget of samples. However, it can sometimes cause artifacts or perform poorly when computing aerial perspective, so the option to turn it off for aerial perspective only is provided.")]
		public bool m_importanceSampleAerialPerspective;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("Skews precomputed aerial perspective samples to be further from the camera (if less than 1) or closer to the camera (if greater than 1). This is useful for environments with very heavy fog, where it can be more important to capture scattering close to the camera.")]
		[Range(0.25f, 30f)]
		public float m_aerialPerspectiveDepthSkew;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Skews screenspace fog samples to be further from the camera (if less than 1) or closer to the camera (if greater than 1). This is useful for environments with very heavy fog, where it can be more important to capture scattering close to the camera.")]
		[Range(0.25f, 30f)]
		public float m_screenspaceFogDepthSkew;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("Downscale factor for depth buffer used for occlusion in screenspace atmosphere layers. If this factor is lower, performance is worse but the volumetric shadows are sharper and more accurate. If it's higher, performance is better, but the shadows are lower quality.")]
		[Range(1f, 8f)]
		public int m_screenspaceDepthDownscale;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Whether or not to use temporal denoising to denoise the screenspace atmosphere layers.")]
		public bool m_fogUseTemporalDenoising;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x6C")]
		[Range(1f, 64f)]
		[Tooltip("How many history frames to use for denoising the fog.")]
		public int m_fogDenoisingHistoryFrames;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Whether or not to use importance sampling to sample physically-lit screenspace layers. Only has an effect if a physically-lit screenspace atmosphere layer is enabled.")]
		public bool m_screenspaceImportanceSample;
	}
}
