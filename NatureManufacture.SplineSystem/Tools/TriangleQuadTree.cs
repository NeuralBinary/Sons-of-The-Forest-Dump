using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Tools
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	public class TriangleQuadTree
	{
		// Token: 0x06000214 RID: 532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x24BFE40", Offset = "0x24BE440", VA = "0x1824BFE40")]
		public TriangleQuadTree(Mesh mesh, int maxDepth = 10, int sizeBound = 10)
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x24C0020", Offset = "0x24BE620", VA = "0x1824C0020")]
		public ITriangle Query(double x, double y)
		{
			return null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x24C0390", Offset = "0x24BE990", VA = "0x1824C0390")]
		internal static bool IsPointInTriangle(Point p, Point t0, Point t1, Point t2)
		{
			return default(bool);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x24C05E0", Offset = "0x24BEBE0", VA = "0x1824C05E0")]
		internal static double DotProduct(Point p, Point q)
		{
			return 0.0;
		}

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x10")]
		private TriangleQuadTree.QuadNode root;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x18")]
		internal ITriangle[] triangles;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x20")]
		internal int sizeBound;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x24")]
		internal int maxDepth;

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		private class QuadNode
		{
			// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x24C0620", Offset = "0x24BEC20", VA = "0x1824C0620")]
			public QuadNode(Rectangle box, TriangleQuadTree tree)
			{
			}

			// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x24C0640", Offset = "0x24BEC40", VA = "0x1824C0640")]
			public QuadNode(Rectangle box, TriangleQuadTree tree, bool init)
			{
			}

			// Token: 0x0600021A RID: 538 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x24C0A20", Offset = "0x24BF020", VA = "0x1824C0A20")]
			public List<int> FindTriangles(Point searchPoint)
			{
				return null;
			}

			// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x24C0AB0", Offset = "0x24BF0B0", VA = "0x1824C0AB0")]
			public void CreateSubRegion(int currentDepth)
			{
			}

			// Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x24C1460", Offset = "0x24BFA60", VA = "0x1824C1460")]
			private void AddTriangleToRegion(Point[] triangle, int index)
			{
			}

			// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x24C16F0", Offset = "0x24BFCF0", VA = "0x1824C16F0")]
			private void FindTriangleIntersections(Point[] triangle, int index)
			{
			}

			// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x24C1810", Offset = "0x24BFE10", VA = "0x1824C1810")]
			private void FindIntersectionsWithX(double dx, double dy, Point[] triangle, int index, int k)
			{
			}

			// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x24C1A80", Offset = "0x24C0080", VA = "0x1824C1A80")]
			private void FindIntersectionsWithY(double dx, double dy, Point[] triangle, int index, int k)
			{
			}

			// Token: 0x06000220 RID: 544 RVA: 0x00002CD0 File Offset: 0x00000ED0
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x24C1CF0", Offset = "0x24C02F0", VA = "0x1824C1CF0")]
			private int FindRegion(Point point)
			{
				return 0;
			}

			// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x24C1D40", Offset = "0x24C0340", VA = "0x1824C1D40")]
			private void AddToRegion(int index, int region)
			{
			}

			// Token: 0x04000278 RID: 632
			[Token(Token = "0x4000278")]
			private const int SW = 0;

			// Token: 0x04000279 RID: 633
			[Token(Token = "0x4000279")]
			private const int SE = 1;

			// Token: 0x0400027A RID: 634
			[Token(Token = "0x400027A")]
			private const int NW = 2;

			// Token: 0x0400027B RID: 635
			[Token(Token = "0x400027B")]
			private const int NE = 3;

			// Token: 0x0400027C RID: 636
			[Token(Token = "0x400027C")]
			private const double EPS = 1E-06;

			// Token: 0x0400027D RID: 637
			[Token(Token = "0x400027D")]
			[FieldOffset(Offset = "0x0")]
			private static readonly byte[] BITVECTOR;

			// Token: 0x0400027E RID: 638
			[Token(Token = "0x400027E")]
			[FieldOffset(Offset = "0x10")]
			private Rectangle bounds;

			// Token: 0x0400027F RID: 639
			[Token(Token = "0x400027F")]
			[FieldOffset(Offset = "0x18")]
			private Point pivot;

			// Token: 0x04000280 RID: 640
			[Token(Token = "0x4000280")]
			[FieldOffset(Offset = "0x20")]
			private TriangleQuadTree tree;

			// Token: 0x04000281 RID: 641
			[Token(Token = "0x4000281")]
			[FieldOffset(Offset = "0x28")]
			private TriangleQuadTree.QuadNode[] regions;

			// Token: 0x04000282 RID: 642
			[Token(Token = "0x4000282")]
			[FieldOffset(Offset = "0x30")]
			private List<int> triangles;

			// Token: 0x04000283 RID: 643
			[Token(Token = "0x4000283")]
			[FieldOffset(Offset = "0x38")]
			private byte bitRegions;
		}
	}
}
