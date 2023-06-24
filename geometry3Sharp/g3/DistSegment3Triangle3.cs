using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	public class DistSegment3Triangle3
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x000070AC File Offset: 0x000052AC
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A9")]
		public Segment3d Segment
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x1B17510", Offset = "0x1B15B10", VA = "0x181B17510")]
			get
			{
				return default(Segment3d);
			}
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x1FEA5D0", Offset = "0x1FE8BD0", VA = "0x181FEA5D0")]
			set
			{
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x000070C4 File Offset: 0x000052C4
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001AA")]
		public Triangle3d Triangle
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x1FEA610", Offset = "0x1FE8C10", VA = "0x181FEA610")]
			get
			{
				return default(Triangle3d);
			}
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x1FEA640", Offset = "0x1FE8C40", VA = "0x181FEA640")]
			set
			{
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600096C")]
		[Address(RVA = "0x1FEA680", Offset = "0x1FE8C80", VA = "0x181FEA680")]
		public DistSegment3Triangle3(Segment3d SegmentIn, Triangle3d TriangleIn)
		{
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1FEA6F0", Offset = "0x1FE8CF0", VA = "0x181FEA6F0")]
		public DistSegment3Triangle3 Compute()
		{
			return null;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000070DC File Offset: 0x000052DC
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x1FEA710", Offset = "0x1FE8D10", VA = "0x181FEA710")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000070F4 File Offset: 0x000052F4
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1FEA790", Offset = "0x1FE8D90", VA = "0x181FEA790")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x10")]
		private Segment3d segment;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x48")]
		private Triangle3d triangle;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x90")]
		public double DistanceSquared;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x98")]
		public Vector3d SegmentClosest;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0xB0")]
		public double SegmentParam;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0xB8")]
		public Vector3d TriangleClosest;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0xD0")]
		public Vector3d TriangleBaryCoords;
	}
}
