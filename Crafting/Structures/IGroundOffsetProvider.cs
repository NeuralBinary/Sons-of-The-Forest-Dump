using System;
using Il2CppDummyDll;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007C1 RID: 1985
	[Token(Token = "0x20007C1")]
	public interface IGroundOffsetProvider
	{
		// Token: 0x0600346D RID: 13421
		[Token(Token = "0x600346D")]
		bool TryCalculateMinHeight(out float height);
	}
}
