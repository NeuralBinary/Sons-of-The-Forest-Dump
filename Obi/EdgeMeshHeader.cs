using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	public struct EdgeMeshHeader
	{
		// Token: 0x060006FD RID: 1789 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x27CFF00", Offset = "0x27CE500", VA = "0x1827CFF00")]
		public EdgeMeshHeader(int firstNode, int nodeCount, int firstTriangle, int triangleCount, int firstVertex, int vertexCount)
		{
		}

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x0")]
		public int firstNode;

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x4")]
		public int nodeCount;

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x8")]
		public int firstEdge;

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0xC")]
		public int edgeCount;

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x10")]
		public int firstVertex;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0x14")]
		public int vertexCount;
	}
}
