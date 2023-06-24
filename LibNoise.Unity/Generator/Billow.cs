using System;
using Il2CppDummyDll;

namespace LibNoise.Generator
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class Billow : ModuleBase
	{
		// Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2083BD0", Offset = "0x20821D0", VA = "0x182083BD0")]
		public Billow()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2083C30", Offset = "0x2082230", VA = "0x182083C30")]
		public Billow(double frequency, double lacunarity, double persistence, int octaves, int seed, QualityMode quality)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000026FC File Offset: 0x000008FC
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000030")]
		public double Frequency
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002714 File Offset: 0x00000914
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000031")]
		public double Lacunarity
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x5FD5B0", Offset = "0x5FBBB0", VA = "0x1805FD5B0")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000272C File Offset: 0x0000092C
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000032")]
		public QualityMode Quality
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return QualityMode.Low;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002744 File Offset: 0x00000944
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000033")]
		public int OctaveCount
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x2083D10", Offset = "0x2082310", VA = "0x182083D10")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000275C File Offset: 0x0000095C
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000034")]
		public double Persistence
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x1D0B420", Offset = "0x1D09A20", VA = "0x181D0B420")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x1D0B430", Offset = "0x1D09A30", VA = "0x181D0B430")]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002774 File Offset: 0x00000974
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000035")]
		public int Seed
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x9048C0", Offset = "0x902EC0", VA = "0x1809048C0")]
			set
			{
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2083D30", Offset = "0x2082330", VA = "0x182083D30", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x20")]
		private double _frequency;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x28")]
		private double _lacunarity;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x30")]
		private QualityMode _quality;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x34")]
		private int _octaveCount;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x38")]
		private double _persistence;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x40")]
		private int _seed;
	}
}
