using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	public class PointKDTree
	{
		// Token: 0x0600072E RID: 1838 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x6B8220", Offset = "0x6B6820", VA = "0x1806B8220")]
		public PointKDTree()
		{
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x6B84E0", Offset = "0x6B6AE0", VA = "0x1806B84E0")]
		public void Add(GraphNode node)
		{
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x6B8510", Offset = "0x6B6B10", VA = "0x1806B8510")]
		public void Rebuild(GraphNode[] nodes, int start, int end)
		{
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x6B8720", Offset = "0x6B6D20", VA = "0x1806B8720")]
		private GraphNode[] GetOrCreateList()
		{
			return null;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000056B4 File Offset: 0x000038B4
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x6B87A0", Offset = "0x6B6DA0", VA = "0x1806B87A0")]
		private int Size(int index)
		{
			return 0;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x6B8830", Offset = "0x6B6E30", VA = "0x1806B8830")]
		private void CollectAndClear(int index, List<GraphNode> buffer)
		{
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000056CC File Offset: 0x000038CC
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x6B8A60", Offset = "0x6B7060", VA = "0x1806B8A60")]
		private static int MaxAllowedSize(int numNodes, int depth)
		{
			return 0;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x6B8AE0", Offset = "0x6B70E0", VA = "0x1806B8AE0")]
		private void Rebalance(int index)
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x6B8B70", Offset = "0x6B7170", VA = "0x1806B8B70")]
		private void EnsureSize(int index)
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x6B8C70", Offset = "0x6B7270", VA = "0x1806B8C70")]
		private void Build(int index, List<GraphNode> nodes, int start, int end)
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x6B9350", Offset = "0x6B7950", VA = "0x1806B9350")]
		private void Add(GraphNode point, int index, int depth = 0)
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x6B96F0", Offset = "0x6B7CF0", VA = "0x1806B96F0")]
		public GraphNode GetNearest(Int3 point, NNConstraint constraint)
		{
			return null;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x6B9750", Offset = "0x6B7D50", VA = "0x1806B9750")]
		private void GetNearestInternal(int index, Int3 point, NNConstraint constraint, ref GraphNode best, ref long bestSqrDist)
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x6B99A0", Offset = "0x6B7FA0", VA = "0x1806B99A0")]
		public GraphNode GetNearestConnection(Int3 point, NNConstraint constraint, long maximumSqrConnectionLength)
		{
			return null;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x6B9A10", Offset = "0x6B8010", VA = "0x1806B9A10")]
		private void GetNearestConnectionInternal(int index, Int3 point, NNConstraint constraint, ref GraphNode best, ref long bestSqrDist, long distanceThresholdOffset)
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x6B9FC0", Offset = "0x6B85C0", VA = "0x1806B9FC0")]
		public void GetInRange(Int3 point, long sqrRadius, List<GraphNode> buffer)
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x6BA000", Offset = "0x6B8600", VA = "0x1806BA000")]
		private void GetInRangeInternal(int index, Int3 point, long sqrRadius, List<GraphNode> buffer)
		{
		}

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		public const int LeafSize = 10;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		public const int LeafArraySize = 21;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x10")]
		private PointKDTree.Node[] tree;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x18")]
		private int numNodes;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<GraphNode> largeList;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x28")]
		private readonly Stack<GraphNode[]> arrayCache;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IComparer<GraphNode>[] comparers;

		// Token: 0x020000C4 RID: 196
		[Token(Token = "0x20000C4")]
		private struct Node
		{
			// Token: 0x040004C0 RID: 1216
			[Token(Token = "0x40004C0")]
			[FieldOffset(Offset = "0x0")]
			public GraphNode[] data;

			// Token: 0x040004C1 RID: 1217
			[Token(Token = "0x40004C1")]
			[FieldOffset(Offset = "0x8")]
			public int split;

			// Token: 0x040004C2 RID: 1218
			[Token(Token = "0x40004C2")]
			[FieldOffset(Offset = "0xC")]
			public ushort count;

			// Token: 0x040004C3 RID: 1219
			[Token(Token = "0x40004C3")]
			[FieldOffset(Offset = "0xE")]
			public byte splitAxis;
		}

		// Token: 0x020000C5 RID: 197
		[Token(Token = "0x20000C5")]
		private class CompareX : IComparer<GraphNode>
		{
			// Token: 0x06000740 RID: 1856 RVA: 0x000056E4 File Offset: 0x000038E4
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x6BA3F0", Offset = "0x6B89F0", VA = "0x1806BA3F0", Slot = "4")]
			public int Compare(GraphNode lhs, GraphNode rhs)
			{
				return 0;
			}

			// Token: 0x06000741 RID: 1857 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CompareX()
			{
			}
		}

		// Token: 0x020000C6 RID: 198
		[Token(Token = "0x20000C6")]
		private class CompareY : IComparer<GraphNode>
		{
			// Token: 0x06000742 RID: 1858 RVA: 0x000056FC File Offset: 0x000038FC
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x6BA430", Offset = "0x6B8A30", VA = "0x1806BA430", Slot = "4")]
			public int Compare(GraphNode lhs, GraphNode rhs)
			{
				return 0;
			}

			// Token: 0x06000743 RID: 1859 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CompareY()
			{
			}
		}

		// Token: 0x020000C7 RID: 199
		[Token(Token = "0x20000C7")]
		private class CompareZ : IComparer<GraphNode>
		{
			// Token: 0x06000744 RID: 1860 RVA: 0x00005714 File Offset: 0x00003914
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x6BA470", Offset = "0x6B8A70", VA = "0x1806BA470", Slot = "4")]
			public int Compare(GraphNode lhs, GraphNode rhs)
			{
				return 0;
			}

			// Token: 0x06000745 RID: 1861 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CompareZ()
			{
			}
		}
	}
}
