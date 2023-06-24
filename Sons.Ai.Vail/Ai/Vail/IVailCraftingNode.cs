using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	public interface IVailCraftingNode
	{
		// Token: 0x06000599 RID: 1433
		[Token(Token = "0x6000599")]
		bool GetNextItem(out int itemId, out int count);

		// Token: 0x0600059A RID: 1434
		[Token(Token = "0x600059A")]
		bool TryAddItem(int itemId, int count);
	}
}
