using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x2000182")]
	public class IntrLine2Segment2
	{
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00007B44 File Offset: 0x00005D44
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001CD")]
		public Line2d Line
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0xEEB890", Offset = "0xEE9E90", VA = "0x180EEB890")]
			get
			{
				return default(Line2d);
			}
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x1FF8CB0", Offset = "0x1FF72B0", VA = "0x181FF8CB0")]
			set
			{
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00007B5C File Offset: 0x00005D5C
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001CE")]
		public Segment2d Segment
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x1FE47D0", Offset = "0x1FE2DD0", VA = "0x181FE47D0")]
			get
			{
				return default(Segment2d);
			}
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x1FF8CD0", Offset = "0x1FF72D0", VA = "0x181FF8CD0")]
			set
			{
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00007B74 File Offset: 0x00005D74
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001CF")]
		public double IntervalThreshold
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x1FF8D00", Offset = "0x1FF7300", VA = "0x181FF8D00")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x1FF8D10", Offset = "0x1FF7310", VA = "0x181FF8D10")]
			set
			{
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00007B8C File Offset: 0x00005D8C
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001D0")]
		public double DotThreshold
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x1FF8DB0", Offset = "0x1FF73B0", VA = "0x181FF8DB0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x1FF8DC0", Offset = "0x1FF73C0", VA = "0x181FF8DC0")]
			set
			{
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00007BA4 File Offset: 0x00005DA4
		[Token(Token = "0x170001D1")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x1FF8E60", Offset = "0x1FF7460", VA = "0x181FF8E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x1FF8E80", Offset = "0x1FF7480", VA = "0x181FF8E80")]
		public IntrLine2Segment2(Line2d line, Segment2d seg)
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x1FF8EC0", Offset = "0x1FF74C0", VA = "0x181FF8EC0")]
		public IntrLine2Segment2 Compute()
		{
			return null;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00007BBC File Offset: 0x00005DBC
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x1FF8EE0", Offset = "0x1FF74E0", VA = "0x181FF8EE0")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x10")]
		private Line2d line;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x30")]
		private Segment2d segment;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x58")]
		private double intervalThresh;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x60")]
		private double dotThresh;

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x68")]
		public int Quantity;

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x6C")]
		public IntersectionResult Result;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x70")]
		public IntersectionType Type;

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x78")]
		public Vector2d Point;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x88")]
		public double Parameter;
	}
}
