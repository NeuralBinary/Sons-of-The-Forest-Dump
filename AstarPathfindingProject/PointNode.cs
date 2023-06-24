using System;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	public class PointNode : GraphNode
	{
		// Token: 0x0600065E RID: 1630 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x68F7C0", Offset = "0x68DDC0", VA = "0x18068F7C0")]
		public void SetPosition(Int3 value)
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x6649D0", Offset = "0x662FD0", VA = "0x1806649D0")]
		public PointNode(AstarPath astar)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00005054 File Offset: 0x00003254
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x66FB80", Offset = "0x66E180", VA = "0x18066FB80", Slot = "14")]
		public override Vector3 ClosestPointOnNode(Vector3 p)
		{
			return default(Vector3);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x66FEF0", Offset = "0x66E4F0", VA = "0x18066FEF0", Slot = "5")]
		public override void GetConnections(Action<GraphNode> action)
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x6A0F60", Offset = "0x69F560", VA = "0x1806A0F60", Slot = "8")]
		public override void ClearConnections(bool alsoReverse)
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x66FFE0", Offset = "0x66E5E0", VA = "0x18066FFE0", Slot = "4")]
		public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000506C File Offset: 0x0000326C
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x6A10A0", Offset = "0x69F6A0", VA = "0x1806A10A0", Slot = "9")]
		public override bool ContainsConnection(GraphNode node)
		{
			return default(bool);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x6A10F0", Offset = "0x69F6F0", VA = "0x1806A10F0", Slot = "6")]
		public override void AddConnection(GraphNode node, uint cost)
		{
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x6A1590", Offset = "0x69FB90", VA = "0x1806A1590", Slot = "7")]
		public override void RemoveConnection(GraphNode node)
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x6A1800", Offset = "0x69FE00", VA = "0x1806A1800", Slot = "11")]
		public override void Open(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00005084 File Offset: 0x00003284
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x670890", Offset = "0x66EE90", VA = "0x180670890", Slot = "15")]
		public override int GetGizmoHashCode()
		{
			return 0;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x6A1A40", Offset = "0x6A0040", VA = "0x1806A1A40", Slot = "16")]
		public override void SerializeNode(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x6A1B30", Offset = "0x6A0130", VA = "0x1806A1B30", Slot = "17")]
		public override void DeserializeNode(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x6A1C50", Offset = "0x6A0250", VA = "0x1806A1C50", Slot = "18")]
		public override void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x6A1D90", Offset = "0x6A0390", VA = "0x1806A1D90", Slot = "19")]
		public override void DeserializeReferences(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x28")]
		public Connection[] connections;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject gameObject;
	}
}
