using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class RobustPredicates : IPredicates
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000021")]
		public static RobustPredicates Default
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x249DB80", Offset = "0x249C180", VA = "0x18249DB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x249E0D0", Offset = "0x249C6D0", VA = "0x18249E0D0")]
		public RobustPredicates()
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x249E0E0", Offset = "0x249C6E0", VA = "0x18249E0E0", Slot = "4")]
		public double CounterClockwise(Point pa, Point pb, Point pc)
		{
			return 0.0;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x249E2F0", Offset = "0x249C8F0", VA = "0x18249E2F0", Slot = "5")]
		public double InCircle(Point pa, Point pb, Point pc, Point pd)
		{
			return 0.0;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x249E680", Offset = "0x249CC80", VA = "0x18249E680")]
		public double NonRegular(Point pa, Point pb, Point pc, Point pd)
		{
			return 0.0;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x249E690", Offset = "0x249CC90", VA = "0x18249E690", Slot = "7")]
		public Point FindCircumcenter(Point org, Point dest, Point apex, ref double xi, ref double eta, double offconstant)
		{
			return null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x249EB20", Offset = "0x249D120", VA = "0x18249EB20", Slot = "6")]
		public Point FindCircumcenter(Point org, Point dest, Point apex, ref double xi, ref double eta)
		{
			return null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x249EDF0", Offset = "0x249D3F0", VA = "0x18249EDF0")]
		private int FastExpansionSumZeroElim(int elen, double[] e, int flen, double[] f, double[] h)
		{
			return 0;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x249F1A0", Offset = "0x249D7A0", VA = "0x18249F1A0")]
		private int ScaleExpansionZeroElim(int elen, double[] e, double b, double[] h)
		{
			return 0;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x249F4C0", Offset = "0x249DAC0", VA = "0x18249F4C0")]
		private double Estimate(int elen, double[] e)
		{
			return 0.0;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x249F510", Offset = "0x249DB10", VA = "0x18249F510")]
		private double CounterClockwiseAdapt(Point pa, Point pb, Point pc, double detsum)
		{
			return 0.0;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x24A0080", Offset = "0x249E680", VA = "0x1824A0080")]
		private double InCircleAdapt(Point pa, Point pb, Point pc, Point pd, double permanent)
		{
			return 0.0;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x24A6670", Offset = "0x24A4C70", VA = "0x1824A6670")]
		private void AllocateWorkspace()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void ClearWorkspace()
		{
		}

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object creationLock;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x8")]
		private static RobustPredicates _default;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x10")]
		private static double epsilon;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x18")]
		private static double splitter;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x20")]
		private static double resulterrbound;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x28")]
		private static double ccwerrboundA;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x30")]
		private static double ccwerrboundB;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x38")]
		private static double ccwerrboundC;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x40")]
		private static double iccerrboundA;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x48")]
		private static double iccerrboundB;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x50")]
		private static double iccerrboundC;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x10")]
		private double[] fin1;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x18")]
		private double[] fin2;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x20")]
		private double[] abdet;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x28")]
		private double[] axbc;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x30")]
		private double[] axxbc;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x38")]
		private double[] aybc;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x40")]
		private double[] ayybc;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x48")]
		private double[] adet;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x50")]
		private double[] bxca;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x58")]
		private double[] bxxca;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x60")]
		private double[] byca;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x68")]
		private double[] byyca;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x70")]
		private double[] bdet;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x78")]
		private double[] cxab;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x80")]
		private double[] cxxab;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x88")]
		private double[] cyab;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x90")]
		private double[] cyyab;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x98")]
		private double[] cdet;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0xA0")]
		private double[] temp8;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0xA8")]
		private double[] temp16a;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0xB0")]
		private double[] temp16b;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0xB8")]
		private double[] temp16c;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0xC0")]
		private double[] temp32a;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0xC8")]
		private double[] temp32b;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0xD0")]
		private double[] temp48;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0xD8")]
		private double[] temp64;
	}
}
