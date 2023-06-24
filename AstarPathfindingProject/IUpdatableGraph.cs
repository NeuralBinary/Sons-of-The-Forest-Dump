using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public interface IUpdatableGraph
	{
		// Token: 0x060001DE RID: 478
		[Token(Token = "0x60001DE")]
		void UpdateArea(GraphUpdateObject o);

		// Token: 0x060001DF RID: 479
		[Token(Token = "0x60001DF")]
		void UpdateAreaInit(GraphUpdateObject o);

		// Token: 0x060001E0 RID: 480
		[Token(Token = "0x60001E0")]
		void UpdateAreaPost(GraphUpdateObject o);

		// Token: 0x060001E1 RID: 481
		[Token(Token = "0x60001E1")]
		GraphUpdateThreading CanUpdateAsync(GraphUpdateObject o);
	}
}
