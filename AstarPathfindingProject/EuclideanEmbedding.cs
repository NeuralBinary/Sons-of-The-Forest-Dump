using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	[Serializable]
	public class EuclideanEmbedding
	{
		// Token: 0x0600070D RID: 1805 RVA: 0x00005624 File Offset: 0x00003824
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x6B3C30", Offset = "0x6B2230", VA = "0x1806B3C30")]
		private uint GetRandom()
		{
			return 0U;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x6B3C40", Offset = "0x6B2240", VA = "0x1806B3C40")]
		private void EnsureCapacity(int index)
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0000563C File Offset: 0x0000383C
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x6B3F00", Offset = "0x6B2500", VA = "0x1806B3F00")]
		public uint GetHeuristic(int nodeIndex1, int nodeIndex2)
		{
			return 0U;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x6B4020", Offset = "0x6B2620", VA = "0x1806B4020")]
		private void GetClosestWalkableNodesToChildrenRecursively(Transform tr, List<GraphNode> nodes)
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x6B43E0", Offset = "0x6B29E0", VA = "0x1806B43E0")]
		private void PickNRandomNodes(int count, List<GraphNode> buffer)
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x6B45E0", Offset = "0x6B2BE0", VA = "0x1806B45E0")]
		private GraphNode PickAnyWalkableNode()
		{
			return null;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x6B47A0", Offset = "0x6B2DA0", VA = "0x1806B47A0")]
		public void RecalculatePivots()
		{
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x6B4C90", Offset = "0x6B3290", VA = "0x1806B4C90")]
		public void RecalculateCosts()
		{
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x6B50A0", Offset = "0x6B36A0", VA = "0x1806B50A0")]
		private void ApplyGridGraphEndpointSpecialCase()
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x6B55C0", Offset = "0x6B3BC0", VA = "0x1806B55C0")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x6B57B0", Offset = "0x6B3DB0", VA = "0x1806B57B0")]
		public EuclideanEmbedding()
		{
		}

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x10")]
		public HeuristicOptimizationMode mode;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x14")]
		public int seed;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x18")]
		public Transform pivotPointRoot;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x20")]
		public int spreadOutCount;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x24")]
		[NonSerialized]
		public bool dirty;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x28")]
		private uint[] costs;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x30")]
		private int maxNodeIndex;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x34")]
		private int pivotCount;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x38")]
		private GraphNode[] pivots;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		private const uint ra = 12820163U;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		private const uint rc = 1140671485U;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x40")]
		private uint rval;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x48")]
		private object lockObj;
	}
}
