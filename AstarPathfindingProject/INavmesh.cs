using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public interface INavmesh
	{
		// Token: 0x06000610 RID: 1552
		[Token(Token = "0x6000610")]
		void GetNodes(Action<GraphNode> del);
	}
}
