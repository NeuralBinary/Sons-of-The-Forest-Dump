using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[Preserve]
	public class LayerGridGraph : GridGraph, IUpdatableGraph
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x68A3A0", Offset = "0x6889A0", VA = "0x18068A3A0", Slot = "18")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x68A550", Offset = "0x688B50", VA = "0x18068A550")]
		private void RemoveGridGraphFromStatic()
		{
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x170000FB")]
		public override bool uniformWidthDepthGrid
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00004A24 File Offset: 0x00002C24
		[Token(Token = "0x170000FC")]
		public override int LayerCount
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x68A5C0", Offset = "0x688BC0", VA = "0x18068A5C0", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00004A3C File Offset: 0x00002C3C
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x68A5D0", Offset = "0x688BD0", VA = "0x18068A5D0", Slot = "13")]
		public override int CountNodes()
		{
			return 0;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x68A630", Offset = "0x688C30", VA = "0x18068A630", Slot = "14")]
		public override void GetNodes(Action<GraphNode> action)
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x68A6C0", Offset = "0x688CC0", VA = "0x18068A6C0", Slot = "48")]
		protected override List<GraphNode> GetNodesInRegion(Bounds b, GraphUpdateShape shape)
		{
			return null;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x68AA50", Offset = "0x689050", VA = "0x18068AA50", Slot = "49")]
		public override List<GraphNode> GetNodesInRegion(IntRect rect)
		{
			return null;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00004A54 File Offset: 0x00002C54
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x68ACC0", Offset = "0x6892C0", VA = "0x18068ACC0", Slot = "50")]
		public override int GetNodesInRegion(IntRect rect, GridNodeBase[] buffer)
		{
			return 0;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x684E90", Offset = "0x683490", VA = "0x180684E90", Slot = "51")]
		public override GridNodeBase GetNode(int x, int z)
		{
			return null;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x68AF60", Offset = "0x689560", VA = "0x18068AF60")]
		public GridNodeBase GetNode(int x, int z, int layer)
		{
			return null;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x68AFE0", Offset = "0x6895E0", VA = "0x18068AFE0", Slot = "26")]
		private void UpdateArea(GraphUpdateObject o)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x68BD00", Offset = "0x68A300", VA = "0x18068BD00", Slot = "20")]
		protected override IEnumerable<Progress> ScanInternal()
		{
			return null;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x68BDA0", Offset = "0x68A3A0", VA = "0x18068BDA0")]
		protected static LayerGridGraph.HeightSample[] SampleHeights(GraphCollision collision, float mergeSpanRange, Vector3 position, out int numHits)
		{
			return null;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x68C3A0", Offset = "0x68A9A0", VA = "0x18068C3A0", Slot = "41")]
		public override void RecalculateCell(int x, int z, bool resetPenalties = true, bool resetTags = true)
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x68CC20", Offset = "0x68B220", VA = "0x18068CC20")]
		private void AddLayers(int count)
		{
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x68CF00", Offset = "0x68B500", VA = "0x18068CF00", Slot = "42")]
		protected override bool ErosionAnyFalseConnections(GraphNode baseNode)
		{
			return default(bool);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x68D080", Offset = "0x68B680", VA = "0x18068D080", Slot = "45")]
		public override void CalculateConnections(GridNodeBase baseNode)
		{
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x68D130", Offset = "0x68B730", VA = "0x18068D130")]
		[Obsolete("Use CalculateConnections(x,z,layerIndex) or CalculateConnections(node) instead")]
		public void CalculateConnections(int x, int z, int layerIndex, LevelGridNode node)
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x68D140", Offset = "0x68B740", VA = "0x18068D140", Slot = "47")]
		public override void CalculateConnections(int x, int z)
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x68D1B0", Offset = "0x68B7B0", VA = "0x18068D1B0")]
		public void CalculateConnections(int x, int z, int layerIndex)
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00004A84 File Offset: 0x00002C84
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x68D7F0", Offset = "0x68BDF0", VA = "0x18068D7F0", Slot = "16")]
		public override NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x68DAD0", Offset = "0x68C0D0", VA = "0x18068DAD0", Slot = "38")]
		protected override GridNodeBase GetNearestFromGraphSpace(Vector3 positionGraphSpace)
		{
			return null;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x68DBD0", Offset = "0x68C1D0", VA = "0x18068DBD0")]
		private GridNodeBase GetNearestNode(Vector3 position, int x, int z, NNConstraint constraint)
		{
			return null;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x68DD70", Offset = "0x68C370", VA = "0x18068DD70")]
		[Obsolete("Use node.HasConnectionInDirection instead")]
		public static bool CheckConnection(LevelGridNode node, int dir)
		{
			return default(bool);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x68DDA0", Offset = "0x68C3A0", VA = "0x18068DDA0", Slot = "21")]
		protected override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x68DF00", Offset = "0x68C500", VA = "0x18068DF00", Slot = "22")]
		protected override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x68E180", Offset = "0x68C780", VA = "0x18068E180", Slot = "23")]
		protected override void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x68E3C0", Offset = "0x68C9C0", VA = "0x18068E3C0")]
		public LayerGridGraph()
		{
		}

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x190")]
		[JsonMember]
		internal int layerCount;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x194")]
		[JsonMember]
		public float mergeSpanRange;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x198")]
		[JsonMember]
		public float characterHeight;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x19C")]
		internal int lastScannedWidth;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x1A0")]
		internal int lastScannedDepth;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly LayerGridGraph.HitComparer comparer;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x8")]
		private static LayerGridGraph.HeightSample[] heightSampleBuffer;

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x200009B")]
		protected struct HeightSample
		{
			// Token: 0x040003C8 RID: 968
			[Token(Token = "0x40003C8")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			// Token: 0x040003C9 RID: 969
			[Token(Token = "0x40003C9")]
			[FieldOffset(Offset = "0xC")]
			public RaycastHit hit;

			// Token: 0x040003CA RID: 970
			[Token(Token = "0x40003CA")]
			[FieldOffset(Offset = "0x38")]
			public float height;

			// Token: 0x040003CB RID: 971
			[Token(Token = "0x40003CB")]
			[FieldOffset(Offset = "0x3C")]
			public bool walkable;
		}

		// Token: 0x0200009C RID: 156
		[Token(Token = "0x200009C")]
		private class HitComparer : IComparer<RaycastHit>
		{
			// Token: 0x060005A7 RID: 1447 RVA: 0x00004AB4 File Offset: 0x00002CB4
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x68E640", Offset = "0x68CC40", VA = "0x18068E640", Slot = "4")]
			public int Compare(RaycastHit a, RaycastHit b)
			{
				return 0;
			}

			// Token: 0x060005A8 RID: 1448 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public HitComparer()
			{
			}
		}
	}
}
