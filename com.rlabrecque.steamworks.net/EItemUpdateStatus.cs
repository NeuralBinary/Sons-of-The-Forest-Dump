using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000135 RID: 309
	[Token(Token = "0x2000135")]
	public enum EItemUpdateStatus
	{
		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x4000707")]
		k_EItemUpdateStatusInvalid,
		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x4000708")]
		k_EItemUpdateStatusPreparingConfig,
		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		k_EItemUpdateStatusPreparingContent,
		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		k_EItemUpdateStatusUploadingContent,
		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		k_EItemUpdateStatusUploadingPreviewFile,
		// Token: 0x0400070C RID: 1804
		[Token(Token = "0x400070C")]
		k_EItemUpdateStatusCommittingChanges
	}
}
