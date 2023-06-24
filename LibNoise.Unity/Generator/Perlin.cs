using System;
using Il2CppDummyDll;

namespace LibNoise.Generator
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public class Perlin : ModuleBase
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2083BD0", Offset = "0x20821D0", VA = "0x182083BD0")]
		public Perlin()
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2083C30", Offset = "0x2082230", VA = "0x182083C30")]
		public Perlin(double frequency, double lacunarity, double persistence, int octaves, int seed, QualityMode quality)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000281C File Offset: 0x00000A1C
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000038")]
		public double Frequency
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00002834 File Offset: 0x00000A34
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000039")]
		public double Lacunarity
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x5FD5B0", Offset = "0x5FBBB0", VA = "0x1805FD5B0")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000284C File Offset: 0x00000A4C
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003A")]
		public QualityMode Quality
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return QualityMode.Low;
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002864 File Offset: 0x00000A64
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003B")]
		public int OctaveCount
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x2083D10", Offset = "0x2082310", VA = "0x182083D10")]
			set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000287C File Offset: 0x00000A7C
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003C")]
		public double Persistence
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x1D0B420", Offset = "0x1D09A20", VA = "0x181D0B420")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x1D0B430", Offset = "0x1D09A30", VA = "0x181D0B430")]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002894 File Offset: 0x00000A94
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003D")]
		public int Seed
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x9048C0", Offset = "0x902EC0", VA = "0x1809048C0")]
			set
			{
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2084210", Offset = "0x2082810", VA = "0x182084210", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x20")]
		private double _frequency;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x28")]
		private double _lacunarity;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x30")]
		private QualityMode _quality;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x34")]
		private int _octaveCount;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x38")]
		private double _persistence;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x40")]
		private int _seed;
	}
}
