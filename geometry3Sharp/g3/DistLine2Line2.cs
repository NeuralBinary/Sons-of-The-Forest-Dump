using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public class DistLine2Line2
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00006A94 File Offset: 0x00004C94
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018D")]
		public Line2d Line
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xEEB890", Offset = "0xEE9E90", VA = "0x180EEB890")]
			get
			{
				return default(Line2d);
			}
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x1FE4330", Offset = "0x1FE2930", VA = "0x181FE4330")]
			set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00006AAC File Offset: 0x00004CAC
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018E")]
		public Line2d Line2
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x1FE4350", Offset = "0x1FE2950", VA = "0x181FE4350")]
			get
			{
				return default(Line2d);
			}
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1FE4370", Offset = "0x1FE2970", VA = "0x181FE4370")]
			set
			{
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x1FE4390", Offset = "0x1FE2990", VA = "0x181FE4390")]
		public DistLine2Line2(Line2d Line1, Line2d Line2)
		{
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00006AC4 File Offset: 0x00004CC4
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x1FE43C0", Offset = "0x1FE29C0", VA = "0x181FE43C0")]
		public static double MinDistance(Line2d line1, Line2d line2)
		{
			return 0.0;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x1FE44A0", Offset = "0x1FE2AA0", VA = "0x181FE44A0")]
		public DistLine2Line2 Compute()
		{
			return null;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00006ADC File Offset: 0x00004CDC
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x1FE44C0", Offset = "0x1FE2AC0", VA = "0x181FE44C0")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00006AF4 File Offset: 0x00004CF4
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x1FE4540", Offset = "0x1FE2B40", VA = "0x181FE4540")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x10")]
		private Line2d line1;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x30")]
		private Line2d line2;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x50")]
		public double DistanceSquared;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x58")]
		public Vector2d Line1Closest;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x68")]
		public Vector2d Line2Closest;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x78")]
		public double Line1Parameter;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x80")]
		public double Line2Parameter;
	}
}
