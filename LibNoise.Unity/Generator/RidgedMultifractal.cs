using System;
using Il2CppDummyDll;

namespace LibNoise.Generator
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public class RidgedMultifractal : ModuleBase
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2084390", Offset = "0x2082990", VA = "0x182084390")]
		public RidgedMultifractal()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2084480", Offset = "0x2082A80", VA = "0x182084480")]
		public RidgedMultifractal(double frequency, double lacunarity, int octaves, int seed, QualityMode quality)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000028C4 File Offset: 0x00000AC4
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003E")]
		public double Frequency
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000028DC File Offset: 0x00000ADC
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003F")]
		public double Lacunarity
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x20845D0", Offset = "0x2082BD0", VA = "0x1820845D0")]
			set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000028F4 File Offset: 0x00000AF4
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000040")]
		public QualityMode Quality
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return QualityMode.Low;
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
			set
			{
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000290C File Offset: 0x00000B0C
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000041")]
		public int OctaveCount
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2083D10", Offset = "0x2082310", VA = "0x182083D10")]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002924 File Offset: 0x00000B24
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000042")]
		public double SpectralWeightsExponent
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x1D0B420", Offset = "0x1D09A20", VA = "0x181D0B420")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1D0B430", Offset = "0x1D09A30", VA = "0x181D0B430")]
			set
			{
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000293C File Offset: 0x00000B3C
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000043")]
		public double Gain
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x151E5F0", Offset = "0x151CBF0", VA = "0x18151E5F0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x151E600", Offset = "0x151CC00", VA = "0x18151E600")]
			set
			{
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002954 File Offset: 0x00000B54
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000044")]
		public double Offset
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x20845E0", Offset = "0x2082BE0", VA = "0x1820845E0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x20845F0", Offset = "0x2082BF0", VA = "0x1820845F0")]
			set
			{
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000296C File Offset: 0x00000B6C
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000045")]
		public int Seed
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x9AF280", Offset = "0x9AD880", VA = "0x1809AF280")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x6FF660", Offset = "0x6FDC60", VA = "0x1806FF660")]
			set
			{
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2084600", Offset = "0x2082C00", VA = "0x182084600")]
		private void UpdateWeights()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x20848A0", Offset = "0x2082EA0", VA = "0x1820848A0", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x20")]
		private double _frequency;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x28")]
		private double _lacunarity;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x30")]
		private QualityMode _quality;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x34")]
		private int _octaveCount;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x38")]
		private double _exponent;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x40")]
		private double _gain;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x48")]
		private double _offset;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x50")]
		private int _seed;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x58")]
		private readonly double[] _weights;
	}
}
