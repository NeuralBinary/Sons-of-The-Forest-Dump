using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000189 RID: 393
	[Token(Token = "0x2000189")]
	public class IntrSegment2Segment2
	{
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00007F34 File Offset: 0x00006134
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E4")]
		public Segment2d Segment1
		{
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x5FD4A0", Offset = "0x5FBAA0", VA = "0x1805FD4A0")]
			get
			{
				return default(Segment2d);
			}
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x1FFD420", Offset = "0x1FFBA20", VA = "0x181FFD420")]
			set
			{
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00007F4C File Offset: 0x0000614C
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E5")]
		public Segment2d Segment2
		{
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1FE9AD0", Offset = "0x1FE80D0", VA = "0x181FE9AD0")]
			get
			{
				return default(Segment2d);
			}
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x1FFD450", Offset = "0x1FFBA50", VA = "0x181FFD450")]
			set
			{
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00007F64 File Offset: 0x00006164
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E6")]
		public double IntervalThreshold
		{
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x1FF8DB0", Offset = "0x1FF73B0", VA = "0x181FF8DB0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x1FFD480", Offset = "0x1FFBA80", VA = "0x181FFD480")]
			set
			{
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00007F7C File Offset: 0x0000617C
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E7")]
		public double DotThreshold
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x1FFD520", Offset = "0x1FFBB20", VA = "0x181FFD520")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x1FFD530", Offset = "0x1FFBB30", VA = "0x181FFD530")]
			set
			{
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00007F94 File Offset: 0x00006194
		[Token(Token = "0x170001E8")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x1FF9FA0", Offset = "0x1FF85A0", VA = "0x181FF9FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x1FFD5D0", Offset = "0x1FFBBD0", VA = "0x181FFD5D0")]
		public IntrSegment2Segment2(Segment2d seg1, Segment2d seg2)
		{
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x1FFD620", Offset = "0x1FFBC20", VA = "0x181FFD620")]
		public IntrSegment2Segment2 Compute()
		{
			return null;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00007FAC File Offset: 0x000061AC
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x1FFD640", Offset = "0x1FFBC40", VA = "0x181FFD640")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0xE42230", Offset = "0xE40830", VA = "0x180E42230")]
		private void sanity_check()
		{
		}

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x10")]
		private Segment2d segment1;

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x38")]
		private Segment2d segment2;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x60")]
		private double intervalThresh;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x68")]
		private double dotThresh;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x70")]
		public int Quantity;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x74")]
		public IntersectionResult Result;

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x78")]
		public IntersectionType Type;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x80")]
		public Vector2d Point0;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x90")]
		public Vector2d Point1;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0xA0")]
		public double Parameter0;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0xA8")]
		public double Parameter1;
	}
}
