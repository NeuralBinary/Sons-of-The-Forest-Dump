using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	public class TriangleMeshNode : MeshNode
	{
		// Token: 0x06000671 RID: 1649 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x6649D0", Offset = "0x662FD0", VA = "0x1806649D0")]
		public TriangleMeshNode(AstarPath astar)
		{
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x6A2050", Offset = "0x6A0650", VA = "0x1806A2050")]
		public static INavmeshHolder GetNavmeshHolder(uint graphIndex)
		{
			return null;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x6A20C0", Offset = "0x6A06C0", VA = "0x1806A20C0")]
		public static void SetNavmeshHolder(int graphIndex, INavmeshHolder graph)
		{
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x6A2450", Offset = "0x6A0A50", VA = "0x1806A2450")]
		public void UpdatePositionFromVertices()
		{
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000509C File Offset: 0x0000329C
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x6A2660", Offset = "0x6A0C60", VA = "0x1806A2660")]
		public int GetVertexIndex(int i)
		{
			return 0;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000050B4 File Offset: 0x000032B4
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x6A2680", Offset = "0x6A0C80", VA = "0x1806A2680")]
		public int GetVertexArrayIndex(int i)
		{
			return 0;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x6A2730", Offset = "0x6A0D30", VA = "0x1806A2730")]
		public void GetVertices(out Int3 v0, out Int3 v1, out Int3 v2)
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x6A2860", Offset = "0x6A0E60", VA = "0x1806A2860")]
		public void GetVerticesInGraphSpace(out Int3 v0, out Int3 v1, out Int3 v2)
		{
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x000050CC File Offset: 0x000032CC
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x6A2990", Offset = "0x6A0F90", VA = "0x1806A2990", Slot = "20")]
		public override Int3 GetVertex(int i)
		{
			return default(Int3);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000050E4 File Offset: 0x000032E4
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x6A2A60", Offset = "0x6A1060", VA = "0x1806A2A60")]
		public Int3 GetVertexInGraphSpace(int i)
		{
			return default(Int3);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000050FC File Offset: 0x000032FC
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "21")]
		public override int GetVertexCount()
		{
			return 0;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00005114 File Offset: 0x00003314
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x6A2B40", Offset = "0x6A1140", VA = "0x1806A2B40", Slot = "14")]
		public override Vector3 ClosestPointOnNode(Vector3 p)
		{
			return default(Vector3);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0000512C File Offset: 0x0000332C
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x6A2DE0", Offset = "0x6A13E0", VA = "0x1806A2DE0")]
		internal Int3 ClosestPointOnNodeXZInGraphSpace(Vector3 p)
		{
			return default(Int3);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00005144 File Offset: 0x00003344
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x6A33B0", Offset = "0x6A19B0", VA = "0x1806A33B0", Slot = "22")]
		public override Vector3 ClosestPointOnNodeXZ(Vector3 p)
		{
			return default(Vector3);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0000515C File Offset: 0x0000335C
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x6A3650", Offset = "0x6A1C50", VA = "0x1806A3650", Slot = "24")]
		public override bool ContainsPoint(Vector3 p)
		{
			return default(bool);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00005174 File Offset: 0x00003374
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x6A37D0", Offset = "0x6A1DD0", VA = "0x1806A37D0", Slot = "25")]
		public override bool ContainsPointInGraphSpace(Int3 p)
		{
			return default(bool);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x6A39A0", Offset = "0x6A1FA0", VA = "0x1806A39A0", Slot = "4")]
		public override void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x6A3AF0", Offset = "0x6A20F0", VA = "0x1806A3AF0", Slot = "11")]
		public override void Open(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0000518C File Offset: 0x0000338C
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x6A3D50", Offset = "0x6A2350", VA = "0x1806A3D50")]
		public int SharedEdge(GraphNode other)
		{
			return 0;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000051A4 File Offset: 0x000033A4
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x6A3DB0", Offset = "0x6A23B0", VA = "0x1806A3DB0", Slot = "10")]
		public override bool GetPortal(GraphNode toNode, List<Vector3> left, List<Vector3> right, bool backwards)
		{
			return default(bool);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000051BC File Offset: 0x000033BC
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x6A3DF0", Offset = "0x6A23F0", VA = "0x1806A3DF0")]
		public bool GetPortal(GraphNode toNode, List<Vector3> left, List<Vector3> right, bool backwards, out int aIndex, out int bIndex)
		{
			return default(bool);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000051D4 File Offset: 0x000033D4
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x6A4550", Offset = "0x6A2B50", VA = "0x1806A4550", Slot = "12")]
		public override float SurfaceArea()
		{
			return 0f;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000051EC File Offset: 0x000033EC
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x6A46D0", Offset = "0x6A2CD0", VA = "0x1806A46D0", Slot = "13")]
		public override Vector3 RandomPointOnSurface()
		{
			return default(Vector3);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x6A4AA0", Offset = "0x6A30A0", VA = "0x1806A4AA0", Slot = "16")]
		public override void SerializeNode(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x6A4B60", Offset = "0x6A3160", VA = "0x1806A4B60", Slot = "17")]
		public override void DeserializeNode(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x30")]
		public int v0;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x34")]
		public int v1;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x38")]
		public int v2;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x0")]
		protected static INavmeshHolder[] _navmeshHolders;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x8")]
		protected static readonly object lockObject;
	}
}
