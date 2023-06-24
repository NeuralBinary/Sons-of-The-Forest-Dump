using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public interface ITraversalProvider
	{
		// Token: 0x06000440 RID: 1088
		[Token(Token = "0x6000440")]
		bool CanTraverse(Path path, GraphNode node);

		// Token: 0x06000441 RID: 1089
		[Token(Token = "0x6000441")]
		uint GetTraversalCost(Path path, GraphNode node);
	}
}
