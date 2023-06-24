using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class DelaunayTriangle
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x28A5500", Offset = "0x28A3B00", VA = "0x1828A5500")]
		public DelaunayTriangle(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public bool IsInterior
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x28A5650", Offset = "0x28A3C50", VA = "0x1828A5650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x28A5660", Offset = "0x28A3C60", VA = "0x1828A5660")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x28A5670", Offset = "0x28A3C70", VA = "0x1828A5670")]
		public int IndexOf(TriangulationPoint p)
		{
			return 0;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x28A5710", Offset = "0x28A3D10", VA = "0x1828A5710")]
		public int IndexCWFrom(TriangulationPoint p)
		{
			return 0;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x28A5740", Offset = "0x28A3D40", VA = "0x1828A5740")]
		public int IndexCCWFrom(TriangulationPoint p)
		{
			return 0;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x28A5770", Offset = "0x28A3D70", VA = "0x1828A5770")]
		public bool Contains(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x28A57C0", Offset = "0x28A3DC0", VA = "0x1828A57C0")]
		private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x28A5890", Offset = "0x28A3E90", VA = "0x1828A5890")]
		public void MarkNeighbor(DelaunayTriangle t)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x28A5B50", Offset = "0x28A4150", VA = "0x1828A5B50")]
		public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p)
		{
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x28A5B90", Offset = "0x28A4190", VA = "0x1828A5B90")]
		public DelaunayTriangle NeighborCWFrom(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x28A5C20", Offset = "0x28A4220", VA = "0x1828A5C20")]
		public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x28A5CB0", Offset = "0x28A42B0", VA = "0x1828A5CB0")]
		public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x28A5D20", Offset = "0x28A4320", VA = "0x1828A5D20")]
		public TriangulationPoint PointCCWFrom(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x28A5D90", Offset = "0x28A4390", VA = "0x1828A5D90")]
		public TriangulationPoint PointCWFrom(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x28A5E00", Offset = "0x28A4400", VA = "0x1828A5E00")]
		private void RotateCW()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x28A5F40", Offset = "0x28A4540", VA = "0x1828A5F40")]
		public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x28A6100", Offset = "0x28A4700", VA = "0x1828A6100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x28A62D0", Offset = "0x28A48D0", VA = "0x1828A62D0")]
		public void MarkNeighborEdges()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x28A6450", Offset = "0x28A4A50", VA = "0x1828A6450")]
		public void MarkEdge(DelaunayTriangle triangle)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x28A6590", Offset = "0x28A4B90", VA = "0x1828A6590")]
		public void MarkEdge(List<DelaunayTriangle> tList)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x28A6790", Offset = "0x28A4D90", VA = "0x1828A6790")]
		public void MarkConstrainedEdge(int index)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x28A6800", Offset = "0x28A4E00", VA = "0x1828A6800")]
		public void MarkConstrainedEdge(DTSweepConstraint edge)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x28A6830", Offset = "0x28A4E30", VA = "0x1828A6830")]
		public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x28A68B0", Offset = "0x28A4EB0", VA = "0x1828A68B0")]
		public double Area()
		{
			return 0.0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x28A6960", Offset = "0x28A4F60", VA = "0x1828A6960")]
		public TriangulationPoint Centroid()
		{
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x28A6A10", Offset = "0x28A5010", VA = "0x1828A6A10")]
		public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2)
		{
			return 0;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x28A6B10", Offset = "0x28A5110", VA = "0x1828A6B10")]
		public bool GetConstrainedEdgeCCW(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x28A6B50", Offset = "0x28A5150", VA = "0x1828A6B50")]
		public bool GetConstrainedEdgeCW(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x28A6B90", Offset = "0x28A5190", VA = "0x1828A6B90")]
		public bool GetConstrainedEdgeAcross(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x28A6BC0", Offset = "0x28A51C0", VA = "0x1828A6BC0")]
		public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x28A6C10", Offset = "0x28A5210", VA = "0x1828A6C10")]
		public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x28A6C60", Offset = "0x28A5260", VA = "0x1828A6C60")]
		public void SetConstrainedEdgeAcross(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x28A6CA0", Offset = "0x28A52A0", VA = "0x1828A6CA0")]
		public bool GetDelaunayEdgeCCW(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x28A6CE0", Offset = "0x28A52E0", VA = "0x1828A6CE0")]
		public bool GetDelaunayEdgeCW(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x28A6D20", Offset = "0x28A5320", VA = "0x1828A6D20")]
		public bool GetDelaunayEdgeAcross(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x28A6D50", Offset = "0x28A5350", VA = "0x1828A6D50")]
		public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x28A6DA0", Offset = "0x28A53A0", VA = "0x1828A6DA0")]
		public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x28A6DF0", Offset = "0x28A53F0", VA = "0x1828A6DF0")]
		public void SetDelaunayEdgeAcross(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		public FixedArray3<TriangulationPoint> Points;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x28")]
		public FixedArray3<DelaunayTriangle> Neighbors;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x40")]
		public FixedBitArray3 EdgeIsConstrained;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x43")]
		public FixedBitArray3 EdgeIsDelaunay;
	}
}
