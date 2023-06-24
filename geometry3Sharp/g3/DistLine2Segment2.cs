using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	public class DistLine2Segment2
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00006B0C File Offset: 0x00004D0C
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018F")]
		public Line2d Line
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0xEEB890", Offset = "0xEE9E90", VA = "0x180EEB890")]
			get
			{
				return default(Line2d);
			}
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x1FE47B0", Offset = "0x1FE2DB0", VA = "0x181FE47B0")]
			set
			{
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00006B24 File Offset: 0x00004D24
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000190")]
		public Segment2d Segment
		{
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x1FE47D0", Offset = "0x1FE2DD0", VA = "0x181FE47D0")]
			get
			{
				return default(Segment2d);
			}
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x1FE47F0", Offset = "0x1FE2DF0", VA = "0x181FE47F0")]
			set
			{
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x1FE4820", Offset = "0x1FE2E20", VA = "0x181FE4820")]
		public DistLine2Segment2(Line2d LineIn, Segment2d SegmentIn)
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00006B3C File Offset: 0x00004D3C
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x1FE4860", Offset = "0x1FE2E60", VA = "0x181FE4860")]
		public static double MinDistance(Line2d line, Segment2d segment)
		{
			return 0.0;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x1FE4950", Offset = "0x1FE2F50", VA = "0x181FE4950")]
		public DistLine2Segment2 Compute()
		{
			return null;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00006B54 File Offset: 0x00004D54
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x1FE4970", Offset = "0x1FE2F70", VA = "0x181FE4970")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00006B6C File Offset: 0x00004D6C
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x1FE49F0", Offset = "0x1FE2FF0", VA = "0x181FE49F0")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x10")]
		private Line2d line;

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x30")]
		private Segment2d segment;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x58")]
		public double DistanceSquared;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x60")]
		public Vector2d LineClosest;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x70")]
		public double LineParameter;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x78")]
		public Vector2d SegmentClosest;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x88")]
		public double SegmentParameter;
	}
}
