using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	public interface IPlacementModeGroup
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060006D7 RID: 1751
		[Token(Token = "0x1700022A")]
		int Mode { [Token(Token = "0x60006D7")] get; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060006D8 RID: 1752
		[Token(Token = "0x1700022B")]
		bool BlockedPlacement { [Token(Token = "0x60006D8")] get; }

		// Token: 0x060006D9 RID: 1753
		[Token(Token = "0x60006D9")]
		bool TryToggleMode();

		// Token: 0x060006DA RID: 1754
		[Token(Token = "0x60006DA")]
		void SetBlockedPlacement();

		// Token: 0x060006DB RID: 1755
		[Token(Token = "0x60006DB")]
		void UnsetBlockedPlacement();
	}
}
