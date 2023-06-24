using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	public struct TriangleMeshHeader
	{
		// Token: 0x0600071D RID: 1821 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x27CFF00", Offset = "0x27CE500", VA = "0x1827CFF00")]
		public TriangleMeshHeader(int firstNode, int nodeCount, int firstTriangle, int triangleCount, int firstVertex, int vertexCount)
		{
		}

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x0")]
		public int firstNode;

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x4")]
		public int nodeCount;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0x8")]
		public int firstTriangle;

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0xC")]
		public int triangleCount;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x10")]
		public int firstVertex;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x14")]
		public int vertexCount;
	}
}
