using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	public enum ESteamAPICallFailure
	{
		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		k_ESteamAPICallFailureNone = -1,
		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		k_ESteamAPICallFailureSteamGone,
		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		k_ESteamAPICallFailureNetworkFailure,
		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		k_ESteamAPICallFailureInvalidHandle,
		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		k_ESteamAPICallFailureMismatchedCallback
	}
}
