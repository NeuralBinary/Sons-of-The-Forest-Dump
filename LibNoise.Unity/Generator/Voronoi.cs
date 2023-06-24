using System;
using Il2CppDummyDll;

namespace LibNoise.Generator
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public class Voronoi : ModuleBase
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2084BF0", Offset = "0x20831F0", VA = "0x182084BF0")]
		public Voronoi()
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2084C30", Offset = "0x2083230", VA = "0x182084C30")]
		public Voronoi(double frequency, double displacement, int seed, bool distance)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000029CC File Offset: 0x00000BCC
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000047")]
		public double Displacement
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000029E4 File Offset: 0x00000BE4
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000048")]
		public double Frequency
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x5FD5B0", Offset = "0x5FBBB0", VA = "0x1805FD5B0")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000029FC File Offset: 0x00000BFC
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000049")]
		public int Seed
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002A14 File Offset: 0x00000C14
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004A")]
		public bool UseDistance
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x2084CB0", Offset = "0x20832B0", VA = "0x182084CB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x2084CC0", Offset = "0x20832C0", VA = "0x182084CC0")]
			set
			{
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2084CD0", Offset = "0x20832D0", VA = "0x182084CD0", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x20")]
		private double _displacement;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x28")]
		private double _frequency;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x30")]
		private int _seed;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x34")]
		private bool _distance;
	}
}
