using System;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public abstract class GridNodeBase : GraphNode
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x6649D0", Offset = "0x662FD0", VA = "0x1806649D0")]
		protected GridNodeBase(AstarPath astar)
		{
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00004F34 File Offset: 0x00003134
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700010F")]
		public int NodeInGridIndex
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x69F740", Offset = "0x69DD40", VA = "0x18069F740")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x69F750", Offset = "0x69DD50", VA = "0x18069F750")]
			set
			{
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00004F4C File Offset: 0x0000314C
		[Token(Token = "0x17000110")]
		public int XCoordinateInGrid
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x69F760", Offset = "0x69DD60", VA = "0x18069F760")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00004F64 File Offset: 0x00003164
		[Token(Token = "0x17000111")]
		public int ZCoordinateInGrid
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x69F7E0", Offset = "0x69DDE0", VA = "0x18069F7E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00004F7C File Offset: 0x0000317C
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000112")]
		public bool WalkableErosion
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x69F860", Offset = "0x69DE60", VA = "0x18069F860")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x69F870", Offset = "0x69DE70", VA = "0x18069F870")]
			set
			{
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00004F94 File Offset: 0x00003194
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000113")]
		public bool TmpWalkable
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x69F8A0", Offset = "0x69DEA0", VA = "0x18069F8A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x69F8B0", Offset = "0x69DEB0", VA = "0x18069F8B0")]
			set
			{
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600064C RID: 1612
		[Token(Token = "0x17000114")]
		public abstract bool HasConnectionsToAllEightNeighbours { [Token(Token = "0x600064C")] get; }

		// Token: 0x0600064D RID: 1613 RVA: 0x00004FAC File Offset: 0x000031AC
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x69F8E0", Offset = "0x69DEE0", VA = "0x18069F8E0", Slot = "12")]
		public override float SurfaceArea()
		{
			return 0f;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00004FC4 File Offset: 0x000031C4
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x69F950", Offset = "0x69DF50", VA = "0x18069F950", Slot = "13")]
		public override Vector3 RandomPointOnSurface()
		{
			return default(Vector3);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00004FDC File Offset: 0x000031DC
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x69FB70", Offset = "0x69E170", VA = "0x18069FB70")]
		public Vector2 NormalizePoint(Vector3 worldPoint)
		{
			return default(Vector2);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00004FF4 File Offset: 0x000031F4
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x69FC70", Offset = "0x69E270", VA = "0x18069FC70")]
		public Vector3 UnNormalizePoint(Vector2 normalizedPointOnSurface)
		{
			return default(Vector3);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0000500C File Offset: 0x0000320C
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x69FE20", Offset = "0x69E420", VA = "0x18069FE20", Slot = "15")]
		public override int GetGizmoHashCode()
		{
			return 0;
		}

		// Token: 0x06000652 RID: 1618
		[Token(Token = "0x6000652")]
		public abstract GridNodeBase GetNeighbourAlongDirection(int direction);

		// Token: 0x06000653 RID: 1619 RVA: 0x00005024 File Offset: 0x00003224
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x69FEF0", Offset = "0x69E4F0", VA = "0x18069FEF0", Slot = "22")]
		public virtual bool HasConnectionInDirection(int direction)
		{
			return default(bool);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000503C File Offset: 0x0000323C
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x69FF20", Offset = "0x69E520", VA = "0x18069FF20", Slot = "9")]
		public override bool ContainsConnection(GraphNode node)
		{
			return default(bool);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x69FFC0", Offset = "0x69E5C0", VA = "0x18069FFC0")]
		public void ClearCustomConnections(bool alsoReverse)
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x6A0110", Offset = "0x69E710", VA = "0x1806A0110", Slot = "8")]
		public override void ClearConnections(bool alsoReverse)
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x6A0120", Offset = "0x69E720", VA = "0x1806A0120", Slot = "5")]
		public override void GetConnections(Action<GraphNode> action)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x6A01B0", Offset = "0x69E7B0", VA = "0x1806A01B0", Slot = "4")]
		public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x6A02B0", Offset = "0x69E8B0", VA = "0x1806A02B0", Slot = "11")]
		public override void Open(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x6A04C0", Offset = "0x69EAC0", VA = "0x1806A04C0", Slot = "6")]
		public override void AddConnection(GraphNode node, uint cost)
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x6A0820", Offset = "0x69EE20", VA = "0x1806A0820", Slot = "7")]
		public override void RemoveConnection(GraphNode node)
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x6A0A90", Offset = "0x69F090", VA = "0x1806A0A90", Slot = "18")]
		public override void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x6A0BD0", Offset = "0x69F1D0", VA = "0x1806A0BD0", Slot = "19")]
		public override void DeserializeReferences(GraphSerializationContext ctx)
		{
		}

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		private const int GridFlagsWalkableErosionOffset = 8;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		private const int GridFlagsWalkableErosionMask = 256;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		private const int GridFlagsWalkableTmpOffset = 9;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		private const int GridFlagsWalkableTmpMask = 512;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		protected const int NodeInGridIndexLayerOffset = 24;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		protected const int NodeInGridIndexMask = 16777215;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x28")]
		protected int nodeInGridIndex;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x2C")]
		protected ushort gridFlags;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x30")]
		public Connection[] connections;
	}
}
