using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000180")]
	public class Intersector1
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1FF82B0", Offset = "0x1FF68B0", VA = "0x181FF82B0")]
		public Intersector1(double u0, double u1, double v0, double v1)
		{
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x1FF8350", Offset = "0x1FF6950", VA = "0x181FF8350")]
		public Intersector1(Interval1d u, Interval1d v)
		{
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00007A6C File Offset: 0x00005C6C
		[Token(Token = "0x170001C8")]
		public bool Test
		{
			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x1FF83D0", Offset = "0x1FF69D0", VA = "0x181FF83D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00007A84 File Offset: 0x00005C84
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1FF83F0", Offset = "0x1FF69F0", VA = "0x181FF83F0")]
		public double GetIntersection(int i)
		{
			return 0.0;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00007A9C File Offset: 0x00005C9C
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1FF8400", Offset = "0x1FF6A00", VA = "0x181FF8400")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x10")]
		public Interval1d U;

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x20")]
		public Interval1d V;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x30")]
		public int NumIntersections;

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0x38")]
		private Interval1d Intersections;
	}
}
