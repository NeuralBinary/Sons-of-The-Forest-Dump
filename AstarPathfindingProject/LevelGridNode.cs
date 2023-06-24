using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	public class LevelGridNode : GridNodeBase
	{
		// Token: 0x060005B1 RID: 1457 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x6649D0", Offset = "0x662FD0", VA = "0x1806649D0")]
		public LevelGridNode(AstarPath astar)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x68F2E0", Offset = "0x68D8E0", VA = "0x18068F2E0")]
		public static LayerGridGraph GetGridGraph(uint graphIndex)
		{
			return null;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x68F350", Offset = "0x68D950", VA = "0x18068F350")]
		public static void SetGridGraph(int graphIndex, LayerGridGraph graph)
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x68F710", Offset = "0x68DD10", VA = "0x18068F710")]
		public void ResetAllGridConnections()
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00004AFC File Offset: 0x00002CFC
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x68F790", Offset = "0x68DD90", VA = "0x18068F790")]
		public bool HasAnyGridConnections()
		{
			return default(bool);
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00004B14 File Offset: 0x00002D14
		[Token(Token = "0x170000FF")]
		public override bool HasConnectionsToAllEightNeighbours
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00004B2C File Offset: 0x00002D2C
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000100")]
		public int LayerCoordinateInGrid
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x68F7A0", Offset = "0x68DDA0", VA = "0x18068F7A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x68F7B0", Offset = "0x68DDB0", VA = "0x18068F7B0")]
			set
			{
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x68F7C0", Offset = "0x68DDC0", VA = "0x18068F7C0")]
		public void SetPosition(Int3 position)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00004B44 File Offset: 0x00002D44
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x68F7D0", Offset = "0x68DDD0", VA = "0x18068F7D0", Slot = "15")]
		public override int GetGizmoHashCode()
		{
			return 0;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x68F8B0", Offset = "0x68DEB0", VA = "0x18068F8B0", Slot = "21")]
		public override GridNodeBase GetNeighbourAlongDirection(int direction)
		{
			return null;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x68F9B0", Offset = "0x68DFB0", VA = "0x18068F9B0", Slot = "8")]
		public override void ClearConnections(bool alsoReverse)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x68FBC0", Offset = "0x68E1C0", VA = "0x18068FBC0", Slot = "5")]
		public override void GetConnections(Action<GraphNode> action)
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00004B5C File Offset: 0x00002D5C
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x68FD70", Offset = "0x68E370", VA = "0x18068FD70")]
		[Obsolete("Use HasConnectionInDirection instead")]
		public bool GetConnection(int i)
		{
			return default(bool);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00004B74 File Offset: 0x00002D74
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x68FD70", Offset = "0x68E370", VA = "0x18068FD70", Slot = "22")]
		public override bool HasConnectionInDirection(int direction)
		{
			return default(bool);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x68FD90", Offset = "0x68E390", VA = "0x18068FD90")]
		public void SetConnectionValue(int dir, int value)
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00004B8C File Offset: 0x00002D8C
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x68FE50", Offset = "0x68E450", VA = "0x18068FE50")]
		public int GetConnectionValue(int dir)
		{
			return 0;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x68FE70", Offset = "0x68E470", VA = "0x18068FE70", Slot = "6")]
		public override void AddConnection(GraphNode node, uint cost)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x68FFF0", Offset = "0x68E5F0", VA = "0x18068FFF0", Slot = "7")]
		public override void RemoveConnection(GraphNode node)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x690160", Offset = "0x68E760", VA = "0x180690160")]
		protected void RemoveGridConnection(LevelGridNode node)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x690260", Offset = "0x68E860", VA = "0x180690260", Slot = "10")]
		public override bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards)
		{
			return default(bool);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x690680", Offset = "0x68EC80", VA = "0x180690680", Slot = "4")]
		public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x690950", Offset = "0x68EF50", VA = "0x180690950", Slot = "11")]
		public override void Open(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x690C80", Offset = "0x68F280", VA = "0x180690C80", Slot = "14")]
		public override Vector3 ClosestPointOnNode(Vector3 p)
		{
			return default(Vector3);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x690EB0", Offset = "0x68F4B0", VA = "0x180690EB0", Slot = "16")]
		public override void SerializeNode(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x690FE0", Offset = "0x68F5E0", VA = "0x180690FE0", Slot = "17")]
		public override void DeserializeNode(GraphSerializationContext ctx)
		{
		}

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x0")]
		private static LayerGridGraph[] _gridGraphs;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x38")]
		public ulong gridConnections;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x8")]
		protected static LayerGridGraph[] gridGraphs;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		public const int NoConnection = 255;

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		public const int ConnectionMask = 255;

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		private const int ConnectionStride = 8;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		public const int MaxLayerCount = 255;
	}
}
