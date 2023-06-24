using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public interface IWorkItemContext
	{
		// Token: 0x060003E7 RID: 999
		[Token(Token = "0x60003E7")]
		[Obsolete("Avoid using. This will force a full recalculation of the connected components. In most cases the HierarchicalGraph class takes care of things automatically behind the scenes now. In pretty much all cases you should be able to remove the call to this function.")]
		void QueueFloodFill();

		// Token: 0x060003E8 RID: 1000
		[Token(Token = "0x60003E8")]
		void EnsureValidFloodFill();

		// Token: 0x060003E9 RID: 1001
		[Token(Token = "0x60003E9")]
		void SetGraphDirty(NavGraph graph);
	}
}
