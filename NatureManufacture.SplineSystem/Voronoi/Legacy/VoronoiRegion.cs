using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Voronoi.Legacy
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public class VoronoiRegion
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x17000031")]
		public int ID
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000032")]
		public Point Generator
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000033")]
		public ICollection<Point> Vertices
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002718 File Offset: 0x00000918
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public bool Bounded
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
			set
			{
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x24B3510", Offset = "0x24B1B10", VA = "0x1824B3510")]
		public VoronoiRegion(Vertex generator)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x24B36C0", Offset = "0x24B1CC0", VA = "0x1824B36C0")]
		public void Add(Point point)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x24B3760", Offset = "0x24B1D60", VA = "0x1824B3760")]
		public void Add(List<Point> points)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x24B37D0", Offset = "0x24B1DD0", VA = "0x1824B37D0")]
		public VoronoiRegion GetNeighbor(Point p)
		{
			return null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x24B3850", Offset = "0x24B1E50", VA = "0x1824B3850")]
		internal void AddNeighbor(int id, VoronoiRegion neighbor)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x24B38D0", Offset = "0x24B1ED0", VA = "0x1824B38D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x10")]
		private int id;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x18")]
		private Point generator;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x20")]
		private List<Point> vertices;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x28")]
		private bool bounded;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, VoronoiRegion> neighbors;
	}
}
