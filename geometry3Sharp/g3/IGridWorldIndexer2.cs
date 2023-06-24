using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	public interface IGridWorldIndexer2
	{
		// Token: 0x06001D6E RID: 7534
		[Token(Token = "0x6001D6E")]
		Vector2i ToGrid(Vector2d pointf);

		// Token: 0x06001D6F RID: 7535
		[Token(Token = "0x6001D6F")]
		Vector2d FromGrid(Vector2i gridpoint);

		// Token: 0x06001D70 RID: 7536
		[Token(Token = "0x6001D70")]
		Vector2d FromGrid(Vector2d gridpointf);
	}
}
