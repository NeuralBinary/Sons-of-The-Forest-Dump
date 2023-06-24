using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000385 RID: 901
	[Token(Token = "0x2000385")]
	public interface IMultigridIndexer2
	{
		// Token: 0x06001D71 RID: 7537
		[Token(Token = "0x6001D71")]
		GridLevelIndex2 ToBlock(Vector2i outer_index);

		// Token: 0x06001D72 RID: 7538
		[Token(Token = "0x6001D72")]
		Vector2i ToBlockIndex(Vector2i outer_index);

		// Token: 0x06001D73 RID: 7539
		[Token(Token = "0x6001D73")]
		Vector2i ToBlockLocal(Vector2i outer_index);

		// Token: 0x06001D74 RID: 7540
		[Token(Token = "0x6001D74")]
		Vector2i FromBlock(Vector2i block_idx);
	}
}
