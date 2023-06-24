using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	[Flags]
	public enum EItemState
	{
		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x400070E")]
		k_EItemStateNone = 0,
		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		k_EItemStateSubscribed = 1,
		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		k_EItemStateLegacyItem = 2,
		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		k_EItemStateInstalled = 4,
		// Token: 0x04000712 RID: 1810
		[Token(Token = "0x4000712")]
		k_EItemStateNeedsUpdate = 8,
		// Token: 0x04000713 RID: 1811
		[Token(Token = "0x4000713")]
		k_EItemStateDownloading = 16,
		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x4000714")]
		k_EItemStateDownloadPending = 32
	}
}
