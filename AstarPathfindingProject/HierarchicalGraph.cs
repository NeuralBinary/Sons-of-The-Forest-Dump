using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Util;

namespace Pathfinding
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	public class HierarchicalGraph
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00003AAC File Offset: 0x00001CAC
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000A3")]
		public int version
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x65D110", Offset = "0x65B710", VA = "0x18065D110")]
		public HierarchicalGraph()
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x65D570", Offset = "0x65BB70", VA = "0x18065D570")]
		private void Grow()
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x65DBC0", Offset = "0x65C1C0", VA = "0x18065DBC0")]
		private int GetHierarchicalNodeIndex()
		{
			return 0;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x65DC30", Offset = "0x65C230", VA = "0x18065DC30")]
		internal void OnCreatedNode(GraphNode node)
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x65DD60", Offset = "0x65C360", VA = "0x18065DD60")]
		public void AddDirtyNode(GraphNode node)
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00003ADC File Offset: 0x00001CDC
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000A4")]
		public int NumConnectedComponents
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x65E0E0", Offset = "0x65C6E0", VA = "0x18065E0E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x65E0F0", Offset = "0x65C6F0", VA = "0x18065E0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x65E100", Offset = "0x65C700", VA = "0x18065E100")]
		public uint GetConnectedComponent(int hierarchicalNodeIndex)
		{
			return 0U;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x65E130", Offset = "0x65C730", VA = "0x18065E130")]
		private void RemoveHierarchicalNode(int hierarchicalNode, bool removeAdjacentSmallNodes)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x65E430", Offset = "0x65CA30", VA = "0x18065E430")]
		public void RecalculateIfNecessary()
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x65E6A0", Offset = "0x65CCA0", VA = "0x18065E6A0")]
		public void RecalculateAll()
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x65E7D0", Offset = "0x65CDD0", VA = "0x18065E7D0")]
		private void FloodFill()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x65EA00", Offset = "0x65D000", VA = "0x18065EA00")]
		private void FindHierarchicalNodeChildren(int hierarchicalNode, GraphNode startNode)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x65ED90", Offset = "0x65D390", VA = "0x18065ED90")]
		public void OnDrawGizmos(RetainedGizmos gizmos)
		{
		}

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		private const int Tiling = 16;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		private const int MaxChildrenPerNode = 256;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		private const int MinChildrenPerNode = 128;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x10")]
		private List<GraphNode>[] children;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x18")]
		private List<int>[] connections;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x20")]
		private int[] areas;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x28")]
		private byte[] dirty;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x38")]
		public Action onConnectedComponentsChanged;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x40")]
		private Action<GraphNode> connectionCallback;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x48")]
		private Queue<GraphNode> temporaryQueue;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x50")]
		private List<GraphNode> currentChildren;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x58")]
		private List<int> currentConnections;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x60")]
		private int currentHierarchicalNodeIndex;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x68")]
		private Stack<int> temporaryStack;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x70")]
		private int numDirtyNodes;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x78")]
		private GraphNode[] dirtyNodes;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x80")]
		private Stack<int> freeNodeIndices;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x88")]
		private int gizmoVersion;
	}
}
