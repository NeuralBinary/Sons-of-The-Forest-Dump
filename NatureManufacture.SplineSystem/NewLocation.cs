using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	internal class NewLocation
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2490730", Offset = "0x248ED30", VA = "0x182490730")]
		public NewLocation(Mesh mesh, IPredicates predicates)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2490CC0", Offset = "0x248F2C0", VA = "0x182490CC0")]
		public Point FindLocation(Vertex org, Vertex dest, Vertex apex, ref double xi, ref double eta, bool offcenter, Otri badotri)
		{
			return null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2490D80", Offset = "0x248F380", VA = "0x182490D80")]
		private Point FindNewLocationWithoutMaxAngle(Vertex torg, Vertex tdest, Vertex tapex, ref double xi, ref double eta, bool offcenter, Otri badotri)
		{
			return null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2492260", Offset = "0x2490860", VA = "0x182492260")]
		private Point FindNewLocation(Vertex torg, Vertex tdest, Vertex tapex, ref double xi, ref double eta, bool offcenter, Otri badotri)
		{
			return null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2496390", Offset = "0x2494990", VA = "0x182496390")]
		private int LongestShortestEdge(double aodist, double dadist, double dodist)
		{
			return 0;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x24963E0", Offset = "0x24949E0", VA = "0x1824963E0")]
		private int DoSmoothing(Otri badotri, Vertex torg, Vertex tdest, Vertex tapex, ref double[] newloc)
		{
			return 0;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2496930", Offset = "0x2494F30", VA = "0x182496930")]
		private int GetStarPoints(Otri badotri, Vertex p, Vertex q, Vertex r, int whichPoint, ref double[] points)
		{
			return 0;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2496DA0", Offset = "0x24953A0", VA = "0x182496DA0")]
		private bool GetNeighborsVertex(Otri badotri, double first_x, double first_y, double second_x, double second_y, ref double[] thirdpoint, ref Otri neighotri)
		{
			return default(bool);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2497390", Offset = "0x2495990", VA = "0x182497390")]
		private bool GetWedgeIntersectionWithoutMaxAngle(int numpoints, double[] points, ref double[] newloc)
		{
			return default(bool);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x24984F0", Offset = "0x2496AF0", VA = "0x1824984F0")]
		private bool GetWedgeIntersection(int numpoints, double[] points, ref double[] newloc)
		{
			return default(bool);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x249B4C0", Offset = "0x2499AC0", VA = "0x18249B4C0")]
		private bool ValidPolygonAngles(int numpoints, double[] points)
		{
			return default(bool);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x249B690", Offset = "0x2499C90", VA = "0x18249B690")]
		private bool IsBadPolygonAngle(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			return default(bool);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x249B830", Offset = "0x2499E30", VA = "0x18249B830")]
		private void LineLineIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, ref double[] p)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x249BAD0", Offset = "0x249A0D0", VA = "0x18249BAD0")]
		private int HalfPlaneIntersection(int numvertices, ref double[] convexPoly, double x1, double y1, double x2, double y2)
		{
			return 0;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x249BE00", Offset = "0x249A400", VA = "0x18249BE00")]
		private int SplitConvexPolygon(int numvertices, double[] convexPoly, double x1, double y1, double x2, double y2, double[][] polys)
		{
			return 0;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x249C7F0", Offset = "0x249ADF0", VA = "0x18249C7F0")]
		private int LinePointLocation(double x1, double y1, double x2, double y2, double x, double y)
		{
			return 0;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x249C9C0", Offset = "0x249AFC0", VA = "0x18249C9C0")]
		private void LineLineSegmentIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, ref double[] p)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x249CC70", Offset = "0x249B270", VA = "0x18249CC70")]
		private void FindPolyCentroid(int numpoints, double[] points, ref double[] centroid)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x249CD80", Offset = "0x249B380", VA = "0x18249CD80")]
		private void CircleLineIntersection(double x1, double y1, double x2, double y2, double x3, double y3, double r, ref double[] p)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x249D160", Offset = "0x249B760", VA = "0x18249D160")]
		private bool ChooseCorrectPoint(double x1, double y1, double x2, double y2, double x3, double y3, bool isObtuse)
		{
			return default(bool);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x249D1B0", Offset = "0x249B7B0", VA = "0x18249D1B0")]
		private void PointBetweenPoints(double x1, double y1, double x2, double y2, double x, double y, ref double[] p)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x249D330", Offset = "0x249B930", VA = "0x18249D330")]
		private bool IsBadTriangleAngle(double x1, double y1, double x2, double y2, double x3, double y3)
		{
			return default(bool);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x249D5B0", Offset = "0x249BBB0", VA = "0x18249D5B0")]
		private double MinDistanceToNeighbor(double newlocX, double newlocY, ref Otri searchtri)
		{
			return 0.0;
		}

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		private const double EPS = 1E-50;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x10")]
		private IPredicates predicates;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x18")]
		private Mesh mesh;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x20")]
		private Behavior behavior;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x28")]
		private double[] petalx;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x30")]
		private double[] petaly;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x38")]
		private double[] petalr;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x40")]
		private double[] wedges;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x48")]
		private double[] initialConvexPoly;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x50")]
		private double[] points_p;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x58")]
		private double[] points_q;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x60")]
		private double[] points_r;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x68")]
		private double[] poly1;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x70")]
		private double[] poly2;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x78")]
		private double[][] polys;
	}
}
