using System;
using Il2CppDummyDll;

namespace TriangleNet.Tools
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	public class Statistic
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x1700005C")]
		public double ShortestEdge
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x1240170", Offset = "0x123E770", VA = "0x181240170")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x1700005D")]
		public double LongestEdge
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x5FD5E0", Offset = "0x5FBBE0", VA = "0x1805FD5E0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x1700005E")]
		public double ShortestAltitude
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x1700005F")]
		public double LargestAspectRatio
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x17000060")]
		public double SmallestArea
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x1FE2E00", Offset = "0x1FE1400", VA = "0x181FE2E00")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x17000061")]
		public double LargestArea
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x1D0B420", Offset = "0x1D09A20", VA = "0x181D0B420")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x17000062")]
		public double SmallestAngle
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x151E5F0", Offset = "0x151CBF0", VA = "0x18151E5F0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x17000063")]
		public double LargestAngle
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x20845E0", Offset = "0x2082BE0", VA = "0x1820845E0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000064")]
		public int[] AngleHistogram
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000065")]
		public int[] MinAngleHistogram
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000066")]
		public int[] MaxAngleHistogram
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x24BE200", Offset = "0x24BC800", VA = "0x1824BE200")]
		private void GetAspectHistogram(Mesh mesh)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x24BEA40", Offset = "0x24BD040", VA = "0x1824BEA40")]
		public void Update(Mesh mesh, int sampleDegrees)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Statistic()
		{
		}

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x0")]
		public static long InCircleCount;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x8")]
		public static long InCircleAdaptCount;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x10")]
		public static long CounterClockwiseCount;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x18")]
		public static long CounterClockwiseAdaptCount;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x20")]
		public static long Orient3dCount;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x28")]
		public static long HyperbolaCount;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x30")]
		public static long CircumcenterCount;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x38")]
		public static long CircleTopCount;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x40")]
		public static long RelocationCount;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x10")]
		private double minEdge;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x18")]
		private double maxEdge;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x20")]
		private double minAspect;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x28")]
		private double maxAspect;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x30")]
		private double minArea;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x38")]
		private double maxArea;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x40")]
		private double minAngle;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x48")]
		private double maxAngle;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x50")]
		private int[] angleTable;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x58")]
		private int[] minAngles;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x60")]
		private int[] maxAngles;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x48")]
		private static readonly int[] plus1Mod3;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x50")]
		private static readonly int[] minus1Mod3;
	}
}
