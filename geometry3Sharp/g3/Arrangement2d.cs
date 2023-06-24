using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public class Arrangement2d
	{
		// Token: 0x06000163 RID: 355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1E21710", Offset = "0x1E1FD10", VA = "0x181E21710")]
		public Arrangement2d(AxisAlignedBox2d boundsHint)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1E21A60", Offset = "0x1E20060", VA = "0x181E21A60")]
		public void Insert(Vector2d a, Vector2d b, int gid = -1)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1E21AA0", Offset = "0x1E200A0", VA = "0x181E21AA0")]
		public void Insert(Segment2d segment, int gid = -1)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1E21B30", Offset = "0x1E20130", VA = "0x181E21B30")]
		public void Insert(PolyLine2d pline, int gid = -1)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1E21CC0", Offset = "0x1E202C0", VA = "0x181E21CC0")]
		public void Insert(Polygon2d poly, int gid = -1)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1E21E50", Offset = "0x1E20450", VA = "0x181E21E50")]
		public void ConnectOpenBoundaries(double distThresh)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1E22120", Offset = "0x1E20720", VA = "0x181E22120")]
		protected bool insert_segment(ref Vector2d a, ref Vector2d b, int gid = -1, double tol = 0.0)
		{
			return default(bool);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1E230F0", Offset = "0x1E216F0", VA = "0x181E230F0")]
		protected bool insert_segment(Vector2d a, Vector2d b, int gid = -1, double tol = 0.0)
		{
			return default(bool);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1E23120", Offset = "0x1E21720", VA = "0x181E23120")]
		protected Index2i split_segment_at_t(int eid, double t, double tol)
		{
			return default(Index2i);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1E234E0", Offset = "0x1E21AE0", VA = "0x181E234E0")]
		protected int find_existing_vertex(Vector2d pt)
		{
			return 0;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1E23510", Offset = "0x1E21B10", VA = "0x181E23510")]
		protected int find_nearest_vertex(Vector2d pt, double searchRadius, int ignore_vid = -1)
		{
			return 0;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1E23770", Offset = "0x1E21D70", VA = "0x181E23770")]
		protected int find_nearest_boundary_vertex(Vector2d pt, double searchRadius, int ignore_vid = -1)
		{
			return 0;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1E23950", Offset = "0x1E21F50", VA = "0x181E23950")]
		protected bool find_intersecting_edges(ref Vector2d a, ref Vector2d b, List<Arrangement2d.Intersection> hits, double tol = 0.0)
		{
			return default(bool);
		}

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x10")]
		public DGraph2 Graph;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x18")]
		public PointHashGrid2d<int> PointHash;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x20")]
		public double VertexSnapTol;

		// Token: 0x0200004D RID: 77
		[Token(Token = "0x200004D")]
		protected struct SegmentPoint
		{
			// Token: 0x0400019E RID: 414
			[Token(Token = "0x400019E")]
			[FieldOffset(Offset = "0x0")]
			public double t;

			// Token: 0x0400019F RID: 415
			[Token(Token = "0x400019F")]
			[FieldOffset(Offset = "0x8")]
			public int vid;
		}

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		protected struct Intersection
		{
			// Token: 0x040001A0 RID: 416
			[Token(Token = "0x40001A0")]
			[FieldOffset(Offset = "0x0")]
			public int eid;

			// Token: 0x040001A1 RID: 417
			[Token(Token = "0x40001A1")]
			[FieldOffset(Offset = "0x4")]
			public int sidex;

			// Token: 0x040001A2 RID: 418
			[Token(Token = "0x40001A2")]
			[FieldOffset(Offset = "0x8")]
			public int sidey;

			// Token: 0x040001A3 RID: 419
			[Token(Token = "0x40001A3")]
			[FieldOffset(Offset = "0x10")]
			public IntrSegment2Segment2 intr;
		}
	}
}
