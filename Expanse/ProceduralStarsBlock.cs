using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[Serializable]
	public class ProceduralStarsBlock : MonoBehaviour
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0xABE450", Offset = "0xABCA50", VA = "0x180ABE450")]
		private void Start()
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0xABE450", Offset = "0xABCA50", VA = "0x180ABE450")]
		private void OnEnable()
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000233")]
		[Address(RVA = "0xABE530", Offset = "0xABCB30", VA = "0x180ABE530")]
		private void OnDisable()
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xABE580", Offset = "0xABCB80", VA = "0x180ABE580")]
		public ProceduralStarsBlock()
		{
		}

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The intensity of the stars.")]
		public float m_intensity;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Tint to the stars.")]
		public Color m_tint;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("The rotation of the stars.")]
		public Vector3 m_rotation;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Quality of star texture.")]
		public Datatypes.Quality m_quality;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("When checked, shows seed values for procedural star parameters. Tweaking random seeds can help you get the right flavor of randomness you want.")]
		public bool m_showSeeds;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x45")]
		[Tooltip("Activates high density mode, which layers a second detail star texture on top of the primary one. Dense star fields are important for imparting a sense of realism in scenes with minimal light pollution, but can be too much for more stylized skies.")]
		public bool m_highDensityMode;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("Density of stars.")]
		public float m_density;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Seed for star density variation.")]
		public Vector3 m_densitySeed;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x58")]
		[MinMaxSlider(0.0001f, 1f)]
		[Tooltip("Range of random star sizes.")]
		public Vector2 m_sizeRange;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Biases star sizes toward one end of the range. 0 is biased toward the minimum size. 1 is biased toward the maximum size.")]
		[Range(0f, 1f)]
		public float m_sizeBias;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("Seed for star size variation.")]
		public Vector3 m_sizeSeed;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Range of random star brightnesses.")]
		[MinMaxSlider(0.0001f, 100f)]
		public Vector2 m_intensityRange;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		[Tooltip("Biases star intensity toward one end of the range. 0 is biased toward the minimum intensity. 1 is biased toward the maximum intensity.")]
		public float m_intensityBias;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x7C")]
		[Tooltip("Seed for star brightness variation.")]
		public Vector3 m_intensitySeed;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("Range of random star temperatures, in Kelvin. The accuracy of the blackbody model diminishes for temperatures above 20000K, use at your own discretion.")]
		[MinMaxSlider(1500f, 30000f)]
		public Vector2 m_temperatureRange;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("Biases star temperature toward one end of the range. 0 is biased toward the minimum temperature. 1 is biased toward the maximum temperature.")]
		[Range(0f, 1f)]
		public float m_temperatureBias;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x94")]
		[Tooltip("Seed for star temperature variation.")]
		public Vector3 m_temperatureSeed;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0xA0")]
		[Tooltip("Whether or not to use star twinkle effect.")]
		public bool m_twinkle;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0xA4")]
		[Tooltip("Brightness threshold for twinkle effect to be applied.")]
		[Min(0f)]
		public float m_twinkleThreshold;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("Range of randomly generated twinkle frequencies. Higher values will make the stars twinkle faster. Lower values will make them twinkle slower. A value of zero will result in no twinkling at all.")]
		[MinMaxSlider(0f, 50f)]
		public Vector2 m_twinkleFrequencyRange;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Bias to twinkle effect. Negative values increase the time when the star is not visible.")]
		public float m_twinkleBias;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0xB4")]
		[Min(0f)]
		[Tooltip("Intensity of smoother twinkle effect.")]
		public float m_twinkleSmoothAmplitude;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0xB8")]
		[Tooltip("Intensity of more chaotic twinkle effect.")]
		[Min(0f)]
		public float m_twinkleChaoticAmplitude;
	}
}
