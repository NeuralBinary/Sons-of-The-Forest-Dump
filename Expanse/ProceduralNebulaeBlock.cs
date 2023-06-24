using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	[Serializable]
	public class ProceduralNebulaeBlock : MonoBehaviour
	{
		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0xABCE20", Offset = "0xABB420", VA = "0x180ABCE20")]
		private void Start()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0xABCE20", Offset = "0xABB420", VA = "0x180ABCE20")]
		private void OnEnable()
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0xABCF00", Offset = "0xABB500", VA = "0x180ABCF00")]
		private void OnDisable()
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void Update()
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0xABCF50", Offset = "0xABB550", VA = "0x180ABCF50")]
		public ProceduralNebulaeBlock()
		{
		}

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Quality of procedural nebulae texture.")]
		public Datatypes.Quality m_quality;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("When checked, shows seed values for procedural nebulae parameters. Tweaking random seeds can help you get the right flavor of randomness you want.")]
		public bool m_showSeeds;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x28")]
		[Min(0f)]
		[Tooltip("The overall intensity of the nebulae.")]
		public float m_overallIntensity;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x2C")]
		[Min(0f)]
		[Tooltip("Global definition control for the whole nebula texture. This increases saturation and contrast. It's useful to use in tandem with the global intensity control.")]
		public float m_overallDefinition;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Global tint control for the whole nebula texture.")]
		public Color m_overallTint;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("The rotation of the nebulae texture.")]
		public Vector3 m_rotation;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Scale of noise used for determining nebula coverage. If this value is high, there will be lots of little nebulae scattered across the sky. If this value is low, there will be a few huge nebulae.")]
		[Min(0f)]
		public float m_coverageScale;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The seed for the nebula coverage texture.")]
		public Vector3 m_coverageSeed;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x5C")]
		[Min(0f)]
		[Tooltip("Scale of noise used to randomize nebula transmittance.")]
		public float m_transmittanceScale;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x60")]
		[MinMaxSlider(0f, 1f)]
		[Tooltip("Range of transmittance values the nebula can have.")]
		public Vector2 m_transmittanceRange;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("The x seed for the nebula transmittance texture.")]
		public Vector3 m_transmittanceSeedX;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x74")]
		[Tooltip("The y seed for the nebula transmittance texture.")]
		public Vector3 m_transmittanceSeedY;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("The z seed for the nebula transmittance texture.")]
		public Vector3 m_transmittanceSeedZ;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x90")]
		public ProceduralNebulaeBlock.LayerSettings[] m_layers;

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		[Serializable]
		public sealed class LayerSettings
		{
			// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000224")]
			[Address(RVA = "0xABD140", Offset = "0xABB740", VA = "0x180ABD140")]
			public LayerSettings()
			{
			}

			// Token: 0x0400011A RID: 282
			[Token(Token = "0x400011A")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Intensity of layer.")]
			[Min(0f)]
			public float intensity;

			// Token: 0x0400011B RID: 283
			[Token(Token = "0x400011B")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Color of layer.")]
			public Color color;

			// Token: 0x0400011C RID: 284
			[Token(Token = "0x400011C")]
			[FieldOffset(Offset = "0x24")]
			[Tooltip("Type of noise to use for this layer.")]
			public Datatypes.NoiseType noise;

			// Token: 0x0400011D RID: 285
			[Token(Token = "0x400011D")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("Scale of base octave of noise. Smaller values give bigger more global features, larger values give smaller more detailed features.")]
			[Min(1f)]
			public float scale;

			// Token: 0x0400011E RID: 286
			[Token(Token = "0x400011E")]
			[FieldOffset(Offset = "0x2C")]
			[Tooltip("Number of noise octaves. Increasing the number of octaves can dim the overall noise texture, so it is useful to adjust the intensity control in tandem with this parameter.")]
			[Range(1f, 8f)]
			public int octaves;

			// Token: 0x0400011F RID: 287
			[Token(Token = "0x400011F")]
			[FieldOffset(Offset = "0x30")]
			[Min(0f)]
			[Tooltip("Scale multiplier applied to additional octaves of noise. As an example, if this value is 2, each octave will be twice as small as the last octave.")]
			public float octaveScale;

			// Token: 0x04000120 RID: 288
			[Token(Token = "0x4000120")]
			[FieldOffset(Offset = "0x34")]
			[Min(0f)]
			[Tooltip("Intensity multiplier applied to additional octaves of noise. As an example, if this value is 0.5, each octave will be half as intense as the last octave.")]
			public float octaveMultiplier;

			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			[FieldOffset(Offset = "0x38")]
			[Range(0f, 1f)]
			[Tooltip("How much the coverage map effects this layer. A higher value will result in more nebula coverage. A lower value will result in less nebula coverage.")]
			public float coverage;

			// Token: 0x04000122 RID: 290
			[Token(Token = "0x4000122")]
			[FieldOffset(Offset = "0x3C")]
			[Min(0f)]
			[Tooltip("This parameter allows the layer to bleed across the coverage boundary, and is useful for softening edges.")]
			public float spread;

			// Token: 0x04000123 RID: 291
			[Token(Token = "0x4000123")]
			[FieldOffset(Offset = "0x40")]
			[Range(-1f, 1f)]
			[Tooltip("Bias of zero value.")]
			public float bias;

			// Token: 0x04000124 RID: 292
			[Token(Token = "0x4000124")]
			[FieldOffset(Offset = "0x44")]
			[Tooltip("This increases saturation and contrast, generally making the layer punchier. Increasing the definition usually requires also increasing the strength parameter to ensure that the strands can still get through the coverage map.")]
			[Min(0f)]
			public float definition;

			// Token: 0x04000125 RID: 293
			[Token(Token = "0x4000125")]
			[FieldOffset(Offset = "0x48")]
			[Min(0f)]
			[Tooltip("This parameter is meant to be used in tandem with the coverage value. Higher strength values will allow more features to push through the coverage map. The best way to see what this parameter does is to play around with it.")]
			public float strength;

			// Token: 0x04000126 RID: 294
			[Token(Token = "0x4000126")]
			[FieldOffset(Offset = "0x4C")]
			[Tooltip("Scale of the noise used to warp this layer. A higher value gives smaller vortices and tendrils. A lower value gives bigger swirls and arcs.")]
			[Min(1f)]
			public float warpScale;

			// Token: 0x04000127 RID: 295
			[Token(Token = "0x4000127")]
			[FieldOffset(Offset = "0x50")]
			[Range(0f, 1f)]
			[Tooltip("Intensity of warping effect. Nebulae are big bodies of interstellar gas, and so they obey the laws of fluid mechanics. It's important to capture some of the resulting swirly fluid features. Warping the base noise texture can help with that.")]
			public float warpIntensity;

			// Token: 0x04000128 RID: 296
			[Token(Token = "0x4000128")]
			[FieldOffset(Offset = "0x54")]
			[Tooltip("The x seed for the base texture.")]
			public Vector3 baseSeedX;

			// Token: 0x04000129 RID: 297
			[Token(Token = "0x4000129")]
			[FieldOffset(Offset = "0x60")]
			[Tooltip("The y seed for the base texture.")]
			public Vector3 baseSeedY;

			// Token: 0x0400012A RID: 298
			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x6C")]
			[Tooltip("The z seed for the base texture.")]
			public Vector3 baseSeedZ;

			// Token: 0x0400012B RID: 299
			[Token(Token = "0x400012B")]
			[FieldOffset(Offset = "0x78")]
			[Tooltip("The x seed for the nebula big strand warp texture.")]
			public Vector3 warpSeedX;

			// Token: 0x0400012C RID: 300
			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x84")]
			[Tooltip("The y seed for the nebula big strand warp texture.")]
			public Vector3 warpSeedY;

			// Token: 0x0400012D RID: 301
			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x90")]
			[Tooltip("The z seed for the nebula big strand warp texture.")]
			public Vector3 warpSeedZ;

			// Token: 0x0400012E RID: 302
			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x9C")]
			public bool showSeeds;
		}
	}
}
