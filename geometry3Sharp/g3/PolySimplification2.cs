using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	public class PolySimplification2
	{
		// Token: 0x060008B5 RID: 2229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1FDF1C0", Offset = "0x1FDD7C0", VA = "0x181FDF1C0")]
		public PolySimplification2(Polygon2d polygon)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1FDF2F0", Offset = "0x1FDD8F0", VA = "0x181FDF2F0")]
		public PolySimplification2(PolyLine2d polycurve)
		{
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x1FDF420", Offset = "0x1FDDA20", VA = "0x181FDF420")]
		public static void Simplify(GeneralPolygon2d solid, double deviationThresh)
		{
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x1FDF800", Offset = "0x1FDDE00", VA = "0x181FDF800")]
		public void Simplify()
		{
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1FDFA30", Offset = "0x1FDE030", VA = "0x181FDFA30")]
		private void find_constrained_segments(List<Vector2d> vertices, bool[] markers)
		{
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1FDFB70", Offset = "0x1FDE170", VA = "0x181FDFB70")]
		private List<Vector2d> collapse_by_deviation_tol(List<Vector2d> input, bool[] keep_segments, double offset_threshold)
		{
			return null;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x1FE07B0", Offset = "0x1FDEDB0", VA = "0x181FE07B0")]
		private List<Vector2d> handle_tiny_case(List<Vector2d> result, List<Vector2d> input, bool[] keep_segments, double offset_threshold)
		{
			return null;
		}

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x10")]
		private List<Vector2d> Vertices;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x18")]
		private bool IsLoop;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x20")]
		public double StraightLineDeviationThreshold;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x28")]
		public double PreserveStraightSegLen;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x30")]
		public double SimplifyDeviationThreshold;

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x38")]
		public List<Vector2d> Result;
	}
}
