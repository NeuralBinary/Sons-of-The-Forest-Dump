using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200037E RID: 894
	[Token(Token = "0x200037E")]
	public interface IMultigridIndexer3
	{
		// Token: 0x06001D56 RID: 7510
		[Token(Token = "0x6001D56")]
		GridLevelIndex ToBlock(Vector3i outer_index);

		// Token: 0x06001D57 RID: 7511
		[Token(Token = "0x6001D57")]
		Vector3i ToBlockIndex(Vector3i outer_index);

		// Token: 0x06001D58 RID: 7512
		[Token(Token = "0x6001D58")]
		Vector3i ToBlockLocal(Vector3i outer_index);

		// Token: 0x06001D59 RID: 7513
		[Token(Token = "0x6001D59")]
		Vector3i FromBlock(Vector3i block_idx);
	}
}
