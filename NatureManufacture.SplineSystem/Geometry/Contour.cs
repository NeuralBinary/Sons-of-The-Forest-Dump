using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TriangleNet.Geometry
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public class Contour
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008E")]
		public List<Vertex> Points
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x24E7FB0", Offset = "0x24E65B0", VA = "0x1824E7FB0")]
		public Contour(IEnumerable<Vertex> points)
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x24E7FE0", Offset = "0x24E65E0", VA = "0x1824E7FE0")]
		public Contour(IEnumerable<Vertex> points, int marker)
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x24E8010", Offset = "0x24E6610", VA = "0x1824E8010")]
		public Contour(IEnumerable<Vertex> points, int marker, bool convex)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x24E8050", Offset = "0x24E6650", VA = "0x1824E8050")]
		public List<ISegment> GetSegments()
		{
			return null;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x24E82F0", Offset = "0x24E68F0", VA = "0x1824E82F0")]
		public Point FindInteriorPoint(int limit = 5, double eps = 2E-05)
		{
			return null;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x24E8460", Offset = "0x24E6A60", VA = "0x1824E8460")]
		private void AddPoints(IEnumerable<Vertex> points)
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x24E85E0", Offset = "0x24E6BE0", VA = "0x1824E85E0")]
		private static Point FindPointInPolygon(List<Vertex> contour, int limit, double eps)
		{
			return null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x24E8BC0", Offset = "0x24E71C0", VA = "0x1824E8BC0")]
		private static bool IsPointInPolygon(Point point, List<Vertex> poly)
		{
			return default(bool);
		}

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x10")]
		private int marker;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x14")]
		private bool convex;
	}
}
