using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	public class GridNode : GridNodeBase
	{
		// Token: 0x06000628 RID: 1576 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x6649D0", Offset = "0x662FD0", VA = "0x1806649D0")]
		public GridNode(AstarPath astar)
		{
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x69D520", Offset = "0x69BB20", VA = "0x18069D520")]
		public static GridGraph GetGridGraph(uint graphIndex)
		{
			return null;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x69D590", Offset = "0x69BB90", VA = "0x18069D590")]
		public static void SetGridGraph(int graphIndex, GridGraph graph)
		{
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x69D920", Offset = "0x69BF20", VA = "0x18069D920")]
		public static void ClearGridGraph(int graphIndex, GridGraph graph)
		{
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00004E8C File Offset: 0x0000308C
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700010C")]
		internal ushort InternalGridFlags
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x69DA00", Offset = "0x69C000", VA = "0x18069DA00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x69DA10", Offset = "0x69C010", VA = "0x18069DA10")]
			set
			{
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00004EA4 File Offset: 0x000030A4
		[Token(Token = "0x1700010D")]
		public override bool HasConnectionsToAllEightNeighbours
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x69DA20", Offset = "0x69C020", VA = "0x18069DA20", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00004EBC File Offset: 0x000030BC
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x69DA30", Offset = "0x69C030", VA = "0x18069DA30", Slot = "22")]
		public override bool HasConnectionInDirection(int dir)
		{
			return default(bool);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00004ED4 File Offset: 0x000030D4
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x673B80", Offset = "0x672180", VA = "0x180673B80")]
		[Obsolete("Use HasConnectionInDirection")]
		public bool GetConnectionInternal(int dir)
		{
			return default(bool);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x69DA40", Offset = "0x69C040", VA = "0x18069DA40")]
		public void SetConnectionInternal(int dir, bool value)
		{
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x69DAF0", Offset = "0x69C0F0", VA = "0x18069DAF0")]
		public void SetAllConnectionInternal(int connections)
		{
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x69DB80", Offset = "0x69C180", VA = "0x18069DB80")]
		public void ResetConnectionsInternal()
		{
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00004EEC File Offset: 0x000030EC
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700010E")]
		public bool EdgeNode
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x69DC00", Offset = "0x69C200", VA = "0x18069DC00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x69DC10", Offset = "0x69C210", VA = "0x18069DC10")]
			set
			{
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x69DC40", Offset = "0x69C240", VA = "0x18069DC40", Slot = "21")]
		public override GridNodeBase GetNeighbourAlongDirection(int direction)
		{
			return null;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x69DD20", Offset = "0x69C320", VA = "0x18069DD20", Slot = "8")]
		public override void ClearConnections(bool alsoReverse)
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x69DE90", Offset = "0x69C490", VA = "0x18069DE90", Slot = "5")]
		public override void GetConnections(Action<GraphNode> action)
		{
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00004F04 File Offset: 0x00003104
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x69E000", Offset = "0x69C600", VA = "0x18069E000", Slot = "14")]
		public override Vector3 ClosestPointOnNode(Vector3 p)
		{
			return default(Vector3);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00004F1C File Offset: 0x0000311C
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x69E220", Offset = "0x69C820", VA = "0x18069E220", Slot = "10")]
		public override bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards)
		{
			return default(bool);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x69EAE0", Offset = "0x69D0E0", VA = "0x18069EAE0", Slot = "4")]
		public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x69ED80", Offset = "0x69D380", VA = "0x18069ED80", Slot = "11")]
		public override void Open(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x69F050", Offset = "0x69D650", VA = "0x18069F050", Slot = "16")]
		public override void SerializeNode(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x69F160", Offset = "0x69D760", VA = "0x18069F160", Slot = "17")]
		public override void DeserializeNode(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x69F2A0", Offset = "0x69D8A0", VA = "0x18069F2A0", Slot = "6")]
		public override void AddConnection(GraphNode node, uint cost)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x69F420", Offset = "0x69DA20", VA = "0x18069F420", Slot = "7")]
		public override void RemoveConnection(GraphNode node)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x69F590", Offset = "0x69DB90", VA = "0x18069F590")]
		protected void RemoveGridConnection(GridNode node)
		{
		}

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x0")]
		private static GridGraph[] _gridGraphs;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		private const int GridFlagsConnectionOffset = 0;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		private const int GridFlagsConnectionBit0 = 1;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		private const int GridFlagsConnectionMask = 255;

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		private const int GridFlagsEdgeNodeOffset = 10;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		private const int GridFlagsEdgeNodeMask = 1024;
	}
}
