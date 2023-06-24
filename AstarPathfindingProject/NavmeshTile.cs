using System;
using Il2CppDummyDll;
using Pathfinding.Util;

namespace Pathfinding
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	public class NavmeshTile : INavmeshHolder, ITransformedGraph, INavmesh
	{
		// Token: 0x06000723 RID: 1827 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x6B6530", Offset = "0x6B4B30", VA = "0x1806B6530", Slot = "7")]
		public void GetTileCoordinates(int tileIndex, out int x, out int z)
		{
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00005654 File Offset: 0x00003854
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x691500", Offset = "0x68FB00", VA = "0x180691500", Slot = "6")]
		public int GetVertexArrayIndex(int index)
		{
			return 0;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0000566C File Offset: 0x0000386C
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x6B6540", Offset = "0x6B4B40", VA = "0x1806B6540", Slot = "4")]
		public Int3 GetVertex(int index)
		{
			return default(Int3);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00005684 File Offset: 0x00003884
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x6B6590", Offset = "0x6B4B90", VA = "0x1806B6590", Slot = "5")]
		public Int3 GetVertexInGraphSpace(int index)
		{
			return default(Int3);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000129")]
		public GraphTransform transform
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x6B65E0", Offset = "0x6B4BE0", VA = "0x1806B65E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x6B6600", Offset = "0x6B4C00", VA = "0x1806B6600", Slot = "9")]
		public void GetNodes(Action<GraphNode> action)
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public NavmeshTile()
		{
		}

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x10")]
		public int[] tris;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x18")]
		public Int3[] verts;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x20")]
		public Int3[] vertsInGraphSpace;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x28")]
		public int x;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x2C")]
		public int z;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x30")]
		public int w;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x34")]
		public int d;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x38")]
		public TriangleMeshNode[] nodes;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x40")]
		public BBTree bbTree;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x48")]
		public bool flag;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x50")]
		public NavmeshBase graph;
	}
}
