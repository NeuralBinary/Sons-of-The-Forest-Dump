using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public class Polygon : Triangulatable
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x28A3A50", Offset = "0x28A2050", VA = "0x1828A3A50")]
		public Polygon(IList<PolygonPoint> points)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x28A3E90", Offset = "0x28A2490", VA = "0x1828A3E90")]
		public Polygon(params PolygonPoint[] points)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x17000001")]
		public TriangulationMode TriangulationMode
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "10")]
			get
			{
				return TriangulationMode.Unconstrained;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x28A3EA0", Offset = "0x28A24A0", VA = "0x1828A3EA0")]
		public void AddSteinerPoint(TriangulationPoint point)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x28A3FD0", Offset = "0x28A25D0", VA = "0x1828A3FD0")]
		public void AddSteinerPoints(List<TriangulationPoint> points)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x28A40D0", Offset = "0x28A26D0", VA = "0x1828A40D0")]
		public void ClearSteinerPoints()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x28A4130", Offset = "0x28A2730", VA = "0x1828A4130")]
		public void AddHole(Polygon poly)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x28A4260", Offset = "0x28A2860", VA = "0x1828A4260")]
		public void InsertPointAfter(PolygonPoint point, PolygonPoint newPoint)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x28A44F0", Offset = "0x28A2AF0", VA = "0x1828A44F0")]
		public void AddPoints(IEnumerable<PolygonPoint> list)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x28A48F0", Offset = "0x28A2EF0", VA = "0x1828A48F0")]
		public void AddPoint(PolygonPoint p)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x28A4AB0", Offset = "0x28A30B0", VA = "0x1828A4AB0")]
		public void RemovePoint(PolygonPoint p)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000002")]
		public IList<TriangulationPoint> Points
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000003")]
		public IList<DelaunayTriangle> Triangles
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000004")]
		public IList<Polygon> Holes
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x28A4BD0", Offset = "0x28A31D0", VA = "0x1828A4BD0", Slot = "7")]
		public void AddTriangle(DelaunayTriangle t)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x28A4C70", Offset = "0x28A3270", VA = "0x1828A4C70", Slot = "8")]
		public void AddTriangles(IEnumerable<DelaunayTriangle> list)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x28A4CE0", Offset = "0x28A32E0", VA = "0x1828A4CE0", Slot = "9")]
		public void ClearTriangles()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x28A4D40", Offset = "0x28A3340", VA = "0x1828A4D40", Slot = "4")]
		public void Prepare(TriangulationContext tcx)
		{
		}

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x10")]
		protected List<TriangulationPoint> _points;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		protected List<TriangulationPoint> _steinerPoints;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x20")]
		protected List<Polygon> _holes;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x28")]
		protected List<DelaunayTriangle> _triangles;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x30")]
		protected PolygonPoint _last;
	}
}
