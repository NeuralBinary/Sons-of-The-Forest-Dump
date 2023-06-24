using System;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public abstract class MeshNode : GraphNode
	{
		// Token: 0x0600042F RID: 1071 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x6649D0", Offset = "0x662FD0", VA = "0x1806649D0")]
		protected MeshNode(AstarPath astar)
		{
		}

		// Token: 0x06000430 RID: 1072
		[Token(Token = "0x6000430")]
		public abstract Int3 GetVertex(int i);

		// Token: 0x06000431 RID: 1073
		[Token(Token = "0x6000431")]
		public abstract int GetVertexCount();

		// Token: 0x06000432 RID: 1074
		[Token(Token = "0x6000432")]
		public abstract Vector3 ClosestPointOnNodeXZ(Vector3 p);

		// Token: 0x06000433 RID: 1075 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x66FDC0", Offset = "0x66E3C0", VA = "0x18066FDC0", Slot = "8")]
		public override void ClearConnections(bool alsoReverse)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x66FEF0", Offset = "0x66E4F0", VA = "0x18066FEF0", Slot = "5")]
		public override void GetConnections(Action<GraphNode> action)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000425C File Offset: 0x0000245C
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x66FF80", Offset = "0x66E580", VA = "0x18066FF80", Slot = "9")]
		public override bool ContainsConnection(GraphNode node)
		{
			return default(bool);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x66FFE0", Offset = "0x66E5E0", VA = "0x18066FFE0", Slot = "4")]
		public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x670130", Offset = "0x66E730", VA = "0x180670130", Slot = "6")]
		public override void AddConnection(GraphNode node, uint cost)
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x670150", Offset = "0x66E750", VA = "0x180670150")]
		public void AddConnection(GraphNode node, uint cost, byte shapeEdge)
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x670540", Offset = "0x66EB40", VA = "0x180670540", Slot = "7")]
		public override void RemoveConnection(GraphNode node)
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00004274 File Offset: 0x00002474
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x670800", Offset = "0x66EE00", VA = "0x180670800", Slot = "23")]
		public virtual bool ContainsPoint(Int3 point)
		{
			return default(bool);
		}

		// Token: 0x0600043B RID: 1083
		[Token(Token = "0x600043B")]
		public abstract bool ContainsPoint(Vector3 point);

		// Token: 0x0600043C RID: 1084
		[Token(Token = "0x600043C")]
		public abstract bool ContainsPointInGraphSpace(Int3 point);

		// Token: 0x0600043D RID: 1085 RVA: 0x0000428C File Offset: 0x0000248C
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x670890", Offset = "0x66EE90", VA = "0x180670890", Slot = "15")]
		public override int GetGizmoHashCode()
		{
			return 0;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x670960", Offset = "0x66EF60", VA = "0x180670960", Slot = "18")]
		public override void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x670AE0", Offset = "0x66F0E0", VA = "0x180670AE0", Slot = "19")]
		public override void DeserializeReferences(GraphSerializationContext ctx)
		{
		}

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x28")]
		public Connection[] connections;
	}
}
