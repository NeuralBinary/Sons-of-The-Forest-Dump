using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Voronoi.Legacy
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[Obsolete("Use TriangleNet.Voronoi.BoundedVoronoi class instead.")]
	public class BoundedVoronoiLegacy : IVoronoi
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x24ACF40", Offset = "0x24AB540", VA = "0x1824ACF40")]
		public BoundedVoronoiLegacy(Mesh mesh)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x24AD060", Offset = "0x24AB660", VA = "0x1824AD060")]
		public BoundedVoronoiLegacy(Mesh mesh, bool includeBoundary)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000028")]
		public Point[] Points
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000029")]
		public ICollection<VoronoiRegion> Regions
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002A")]
		public IEnumerable<IEdge> Edges
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x24AD180", Offset = "0x24AB780", VA = "0x1824AD180", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x24AD190", Offset = "0x24AB790", VA = "0x1824AD190")]
		private void Generate()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x24AD8C0", Offset = "0x24ABEC0", VA = "0x1824AD8C0")]
		private void ComputeCircumCenters()
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x24ADE10", Offset = "0x24AC410", VA = "0x1824ADE10")]
		private void TagBlindTriangles()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x24AE750", Offset = "0x24ACD50", VA = "0x1824AE750")]
		private bool TriangleIsBlinded(ref Otri tri, ref Osub seg)
		{
			return default(bool);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x24AE8F0", Offset = "0x24ACEF0", VA = "0x1824AE8F0")]
		private void ConstructCell(Vertex vertex)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x24AF330", Offset = "0x24AD930", VA = "0x1824AF330")]
		private void ConstructBoundaryCell(Vertex vertex)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x24B06B0", Offset = "0x24AECB0", VA = "0x1824B06B0")]
		private bool SegmentsIntersect(Point p1, Point p2, Point p3, Point p4, out Point p, bool strictIntersect)
		{
			return default(bool);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x24B0A20", Offset = "0x24AF020", VA = "0x1824B0A20")]
		private IEnumerable<IEdge> EnumerateEdges()
		{
			return null;
		}

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x10")]
		private IPredicates predicates;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x18")]
		private Mesh mesh;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x20")]
		private Point[] points;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x28")]
		private List<VoronoiRegion> regions;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x30")]
		private List<Point> segPoints;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x38")]
		private int segIndex;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, SubSegment> subsegMap;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x48")]
		private bool includeBoundary;
	}
}
