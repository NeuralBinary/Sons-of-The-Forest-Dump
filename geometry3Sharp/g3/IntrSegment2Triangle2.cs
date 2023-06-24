using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	public class IntrSegment2Triangle2
	{
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00007FC4 File Offset: 0x000061C4
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E9")]
		public Segment2d Segment
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x5FD4A0", Offset = "0x5FBAA0", VA = "0x1805FD4A0")]
			get
			{
				return default(Segment2d);
			}
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x1FFDAB0", Offset = "0x1FFC0B0", VA = "0x181FFDAB0")]
			set
			{
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00007FDC File Offset: 0x000061DC
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001EA")]
		public Triangle2d Triangle
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x1FFDAE0", Offset = "0x1FFC0E0", VA = "0x181FFDAE0")]
			get
			{
				return default(Triangle2d);
			}
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x1FFDB00", Offset = "0x1FFC100", VA = "0x181FFDB00")]
			set
			{
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00007FF4 File Offset: 0x000061F4
		[Token(Token = "0x170001EB")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x1FF8E60", Offset = "0x1FF7460", VA = "0x181FF8E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x1FFDB20", Offset = "0x1FFC120", VA = "0x181FFDB20")]
		public IntrSegment2Triangle2(Segment2d s, Triangle2d t)
		{
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x1FFDB60", Offset = "0x1FFC160", VA = "0x181FFDB60")]
		public IntrSegment2Triangle2 Compute()
		{
			return null;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0000800C File Offset: 0x0000620C
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x1FFDB80", Offset = "0x1FFC180", VA = "0x181FFDB80")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x10")]
		private Segment2d segment;

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x38")]
		private Triangle2d triangle;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x68")]
		public int Quantity;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x6C")]
		public IntersectionResult Result;

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x70")]
		public IntersectionType Type;

		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0x78")]
		public Vector2d Point0;

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x88")]
		public Vector2d Point1;

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x98")]
		public double Param0;

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0xA0")]
		public double Param1;
	}
}
