using System;
using Il2CppDummyDll;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006CC RID: 1740
	[Token(Token = "0x20006CC")]
	public interface IGroundOffsetProvider
	{
		// Token: 0x06002DE7 RID: 11751
		[Token(Token = "0x6002DE7")]
		bool TryCalculateMinHeight(out float height);
	}
}
