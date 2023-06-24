using System;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public static class DTSweep
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x28A7350", Offset = "0x28A5950", VA = "0x1828A7350")]
		public static void Triangulate(DTSweepContext tcx)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x28A73A0", Offset = "0x28A59A0", VA = "0x1828A73A0")]
		private static void Sweep(DTSweepContext tcx)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x28A7610", Offset = "0x28A5C10", VA = "0x1828A7610")]
		private static void FinalizationConvexHull(DTSweepContext tcx)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x28A7FC0", Offset = "0x28A65C0", VA = "0x1828A7FC0")]
		private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x28A8180", Offset = "0x28A6780", VA = "0x1828A8180")]
		private static void FinalizationPolygon(DTSweepContext tcx)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x28A83E0", Offset = "0x28A69E0", VA = "0x1828A83E0")]
		private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x28A86F0", Offset = "0x28A6CF0", VA = "0x1828A86F0")]
		private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node)
		{
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x28A8A60", Offset = "0x28A7060", VA = "0x1828A8A60")]
		private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x28A8C10", Offset = "0x28A7210", VA = "0x1828A8C10")]
		private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x28A8EB0", Offset = "0x28A74B0", VA = "0x1828A8EB0")]
		private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x28A8FD0", Offset = "0x28A75D0", VA = "0x1828A8FD0")]
		private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x28A91F0", Offset = "0x28A77F0", VA = "0x1828A91F0")]
		private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x28A9400", Offset = "0x28A7A00", VA = "0x1828A9400")]
		private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x28A9560", Offset = "0x28A7B60", VA = "0x1828A9560")]
		private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x28A9780", Offset = "0x28A7D80", VA = "0x1828A9780")]
		private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x28A98A0", Offset = "0x28A7EA0", VA = "0x1828A98A0")]
		private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x28A9AB0", Offset = "0x28A80B0", VA = "0x1828A9AB0")]
		private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x28A9C10", Offset = "0x28A8210", VA = "0x1828A9C10")]
		private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq)
		{
			return default(bool);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x28A9D10", Offset = "0x28A8310", VA = "0x1828A9D10")]
		private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x28A9F70", Offset = "0x28A8570", VA = "0x1828A9F70")]
		private static void SplitEdge(TriangulationPoint ep, TriangulationPoint eq, TriangulationPoint p)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x28AA0F0", Offset = "0x28A86F0", VA = "0x1828AA0F0")]
		private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x28AA530", Offset = "0x28A8B30", VA = "0x1828AA530")]
		private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op)
		{
			return null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x28AA690", Offset = "0x28A8C90", VA = "0x1828AA690")]
		private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op)
		{
			return null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x28AA800", Offset = "0x28A8E00", VA = "0x1828AA800")]
		private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x28AAA40", Offset = "0x28A9040", VA = "0x1828AAA40")]
		private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x28AABF0", Offset = "0x28A91F0", VA = "0x1828AABF0")]
		private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x28AB050", Offset = "0x28A9650", VA = "0x1828AB050")]
		private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x28AB250", Offset = "0x28A9850", VA = "0x1828AB250")]
		private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node)
		{
			return default(bool);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x28AB2B0", Offset = "0x28A98B0", VA = "0x1828AB2B0")]
		private static double HoleAngle(AdvancingFrontNode node)
		{
			return 0.0;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x28AB3D0", Offset = "0x28A99D0", VA = "0x1828AB3D0")]
		private static double BasinAngle(AdvancingFrontNode node)
		{
			return 0.0;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x28AB480", Offset = "0x28A9A80", VA = "0x1828AB480")]
		private static void Fill(DTSweepContext tcx, AdvancingFrontNode node)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x28AB6D0", Offset = "0x28A9CD0", VA = "0x1828AB6D0")]
		private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t)
		{
			return default(bool);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x28AB950", Offset = "0x28A9F50", VA = "0x1828AB950")]
		private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op)
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		private const double PI_div2 = 1.5707963267948966;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		private const double PI_3div4 = 2.356194490192345;
	}
}
