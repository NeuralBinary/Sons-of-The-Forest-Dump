using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Voronoi.Legacy
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[Obsolete("Use TriangleNet.Voronoi.StandardVoronoi class instead.")]
	public class SimpleVoronoi : IVoronoi
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x24B0E00", Offset = "0x24AF400", VA = "0x1824B0E00")]
		public SimpleVoronoi(Mesh mesh)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002E")]
		public Point[] Points
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002F")]
		public ICollection<VoronoiRegion> Regions
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x24B0F20", Offset = "0x24AF520", VA = "0x1824B0F20", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000030")]
		public IEnumerable<IEdge> Edges
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x24B0F70", Offset = "0x24AF570", VA = "0x1824B0F70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x24B0F80", Offset = "0x24AF580", VA = "0x1824B0F80")]
		private void Generate()
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x24B1710", Offset = "0x24AFD10", VA = "0x1824B1710")]
		private void ComputeCircumCenters()
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x24B1D30", Offset = "0x24B0330", VA = "0x1824B1D30")]
		private void ConstructCell(VoronoiRegion region)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x24B2EC0", Offset = "0x24B14C0", VA = "0x1824B2EC0")]
		private bool BoxRayIntersection(Point pt, double dx, double dy, out Point intersect)
		{
			return default(bool);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x24B30C0", Offset = "0x24B16C0", VA = "0x1824B30C0")]
		private IEnumerable<IEdge> EnumerateEdges()
		{
			return null;
		}

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x10")]
		private IPredicates predicates;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x18")]
		private Mesh mesh;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x20")]
		private Point[] points;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, VoronoiRegion> regions;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, Point> rayPoints;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x38")]
		private int rayIndex;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x40")]
		private Rectangle bounds;
	}
}
