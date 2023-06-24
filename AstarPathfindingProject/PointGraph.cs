using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	[Preserve]
	[JsonOptIn]
	public class PointGraph : NavGraph, IUpdatableGraph
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00005204 File Offset: 0x00003404
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000115")]
		public int nodeCount
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x6A4DA0", Offset = "0x6A33A0", VA = "0x1806A4DA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x6A4DB0", Offset = "0x6A33B0", VA = "0x1806A4DB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0000521C File Offset: 0x0000341C
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x6A4DA0", Offset = "0x6A33A0", VA = "0x1806A4DA0", Slot = "13")]
		public override int CountNodes()
		{
			return 0;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x6A4DC0", Offset = "0x6A33C0", VA = "0x1806A4DC0", Slot = "14")]
		public override void GetNodes(Action<GraphNode> action)
		{
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00005234 File Offset: 0x00003434
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x6A4E40", Offset = "0x6A3440", VA = "0x1806A4E40", Slot = "16")]
		public override NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0000524C File Offset: 0x0000344C
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x6A4EA0", Offset = "0x6A34A0", VA = "0x1806A4EA0", Slot = "17")]
		public override NNInfoInternal GetNearestForce(Vector3 position, NNConstraint constraint)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00005264 File Offset: 0x00003464
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x6A4F00", Offset = "0x6A3500", VA = "0x1806A4F00")]
		private NNInfoInternal GetNearestInternal(Vector3 position, NNConstraint constraint, bool fastCheck)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0000527C File Offset: 0x0000347C
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x6A5510", Offset = "0x6A3B10", VA = "0x1806A5510")]
		private NNInfoInternal FindClosestConnectionPoint(PointNode node, Vector3 position)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x6A5920", Offset = "0x6A3F20", VA = "0x1806A5920")]
		public PointNode AddNode(Int3 position)
		{
			return null;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000694")]
		public T AddNode<T>(T node, Int3 position) where T : PointNode
		{
			return null;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00005294 File Offset: 0x00003494
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x6A59C0", Offset = "0x6A3FC0", VA = "0x1806A59C0")]
		protected static int CountChildren(Transform tr)
		{
			return 0;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x6A5C00", Offset = "0x6A4200", VA = "0x1806A5C00")]
		protected void AddChildren(ref int c, Transform tr)
		{
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x6A6120", Offset = "0x6A4720", VA = "0x1806A6120")]
		public void RebuildNodeLookup()
		{
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x6A6220", Offset = "0x6A4820", VA = "0x1806A6220")]
		public void RebuildConnectionDistanceLookup()
		{
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x6A6390", Offset = "0x6A4990", VA = "0x1806A6390")]
		private void AddToLookup(PointNode node)
		{
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x6A63D0", Offset = "0x6A49D0", VA = "0x1806A63D0")]
		public void RegisterConnectionLength(long sqrLength)
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x6A6440", Offset = "0x6A4A40", VA = "0x1806A6440", Slot = "30")]
		protected virtual PointNode[] CreateNodes(int count)
		{
			return null;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x6A66D0", Offset = "0x6A4CD0", VA = "0x1806A66D0", Slot = "20")]
		protected override IEnumerable<Progress> ScanInternal()
		{
			return null;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x6A6770", Offset = "0x6A4D70", VA = "0x1806A6770")]
		public void ConnectNodes()
		{
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x6A6870", Offset = "0x6A4E70", VA = "0x1806A6870")]
		private IEnumerable<Progress> ConnectNodesAsync()
		{
			return null;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000052AC File Offset: 0x000034AC
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x6A6910", Offset = "0x6A4F10", VA = "0x1806A6910", Slot = "31")]
		public virtual bool IsValidConnection(GraphNode a, GraphNode b, out float dist)
		{
			return default(bool);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000052C4 File Offset: 0x000034C4
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "29")]
		private GraphUpdateThreading CanUpdateAsync(GraphUpdateObject o)
		{
			return GraphUpdateThreading.UnityThread;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		private void UpdateAreaInit(GraphUpdateObject o)
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		private void UpdateAreaPost(GraphUpdateObject o)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x6A7420", Offset = "0x6A5A20", VA = "0x1806A7420", Slot = "26")]
		private void UpdateArea(GraphUpdateObject guo)
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x6A7BA0", Offset = "0x6A61A0", VA = "0x1806A7BA0", Slot = "23")]
		protected override void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x6A7BB0", Offset = "0x6A61B0", VA = "0x1806A7BB0", Slot = "15")]
		public override void RelocateNodes(Matrix4x4 deltaMatrix)
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x6A7C90", Offset = "0x6A6290", VA = "0x1806A7C90", Slot = "24")]
		protected override void DeserializeSettingsCompatibility(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x6A8010", Offset = "0x6A6610", VA = "0x1806A8010", Slot = "21")]
		protected override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x6A8150", Offset = "0x6A6750", VA = "0x1806A8150", Slot = "22")]
		protected override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x6A83C0", Offset = "0x6A69C0", VA = "0x1806A83C0")]
		public PointGraph()
		{
		}

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0xD0")]
		[JsonMember]
		public Transform root;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0xD8")]
		[JsonMember]
		public string searchTag;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0xE0")]
		[JsonMember]
		public float maxDistance;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0xE4")]
		[JsonMember]
		public Vector3 limits;

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0xF0")]
		[JsonMember]
		public bool raycast;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0xF1")]
		[JsonMember]
		public bool use2DPhysics;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0xF2")]
		[JsonMember]
		public bool thickRaycast;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0xF4")]
		[JsonMember]
		public float thickRaycastRadius;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0xF8")]
		[JsonMember]
		public bool recursive;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0xFC")]
		[JsonMember]
		public LayerMask mask;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x100")]
		[JsonMember]
		public bool optimizeForSparseGraph;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x108")]
		private PointKDTree lookupTree;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x110")]
		private long maximumConnectionLength;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x118")]
		public PointNode[] nodes;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x120")]
		[JsonMember]
		public PointGraph.NodeDistanceMode nearestNodeDistanceMode;

		// Token: 0x020000AE RID: 174
		[Token(Token = "0x20000AE")]
		public enum NodeDistanceMode
		{
			// Token: 0x04000434 RID: 1076
			[Token(Token = "0x4000434")]
			Node,
			// Token: 0x04000435 RID: 1077
			[Token(Token = "0x4000435")]
			Connection
		}
	}
}
