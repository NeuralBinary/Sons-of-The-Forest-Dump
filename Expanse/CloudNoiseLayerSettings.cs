using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[Serializable]
	public class CloudNoiseLayerSettings
	{
		// Token: 0x060002EB RID: 747 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xAD9280", Offset = "0xAD7880", VA = "0x180AD9280", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xAD9680", Offset = "0xAD7C80", VA = "0x180AD9680")]
		public CloudNoiseLayerSettings()
		{
		}

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Whether to use procedural noise or a texture this noise layer.")]
		public BoolParameter procedural;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Noise texture for this layer.")]
		public TextureParameter noiseTexture2D;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Noise texture for this layer.")]
		public TextureParameter noiseTexture3D;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Noise type for this layer.")]
		public EnumParameter<Datatypes.NoiseType> noiseType;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Scale of 0th octave.")]
		public Vector2Parameter scale;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Number of octaves.")]
		public ClampedIntParameter octaves;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("How much to scale each successive octave by.")]
		public MinFloatParameter octaveScale;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("How much to multiply the intensity of each successive octave by.")]
		public MinFloatParameter octaveMultiplier;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Tile factor.")]
		public MinIntParameter tile;
	}
}
