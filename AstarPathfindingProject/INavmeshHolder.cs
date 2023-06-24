using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	public interface INavmeshHolder : ITransformedGraph, INavmesh
	{
		// Token: 0x0600066D RID: 1645
		[Token(Token = "0x600066D")]
		Int3 GetVertex(int i);

		// Token: 0x0600066E RID: 1646
		[Token(Token = "0x600066E")]
		Int3 GetVertexInGraphSpace(int i);

		// Token: 0x0600066F RID: 1647
		[Token(Token = "0x600066F")]
		int GetVertexArrayIndex(int index);

		// Token: 0x06000670 RID: 1648
		[Token(Token = "0x6000670")]
		void GetTileCoordinates(int tileIndex, out int x, out int z);
	}
}
