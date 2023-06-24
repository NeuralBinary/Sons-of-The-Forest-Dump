using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public class DistSegment2Segment2
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00007034 File Offset: 0x00005234
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A7")]
		public Segment2d Segment1
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x5FD4A0", Offset = "0x5FBAA0", VA = "0x1805FD4A0")]
			get
			{
				return default(Segment2d);
			}
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x1FE9AA0", Offset = "0x1FE80A0", VA = "0x181FE9AA0")]
			set
			{
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0000704C File Offset: 0x0000524C
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A8")]
		public Segment2d Segment2
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x1FE9AD0", Offset = "0x1FE80D0", VA = "0x181FE9AD0")]
			get
			{
				return default(Segment2d);
			}
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x1FE9AF0", Offset = "0x1FE80F0", VA = "0x181FE9AF0")]
			set
			{
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x1FE9B20", Offset = "0x1FE8120", VA = "0x181FE9B20")]
		public DistSegment2Segment2(Segment2d Segment1, Segment2d Segment2)
		{
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00007064 File Offset: 0x00005264
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x1FE9B70", Offset = "0x1FE8170", VA = "0x181FE9B70")]
		public static double MinDistance(Segment2d Segment1, Segment2d Segment2)
		{
			return 0.0;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x1FE9C70", Offset = "0x1FE8270", VA = "0x181FE9C70")]
		public DistSegment2Segment2 Compute()
		{
			return null;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0000707C File Offset: 0x0000527C
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x1FE9C90", Offset = "0x1FE8290", VA = "0x181FE9C90")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00007094 File Offset: 0x00005294
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x1FE9D10", Offset = "0x1FE8310", VA = "0x181FE9D10")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x10")]
		private Segment2d segment0;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x38")]
		private Segment2d segment1;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x60")]
		public double DistanceSquared;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x68")]
		public Vector2d Segment1Closest;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x78")]
		public Vector2d Segment2Closest;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x88")]
		public double Segment1Parameter;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x90")]
		public double Segment2Parameter;
	}
}
