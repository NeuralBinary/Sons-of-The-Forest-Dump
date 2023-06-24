using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	[Flags]
	public enum ERemoteStoragePlatform
	{
		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		k_ERemoteStoragePlatformNone = 0,
		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		k_ERemoteStoragePlatformWindows = 1,
		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		k_ERemoteStoragePlatformOSX = 2,
		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		k_ERemoteStoragePlatformPS3 = 4,
		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		k_ERemoteStoragePlatformLinux = 8,
		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		k_ERemoteStoragePlatformSwitch = 16,
		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		k_ERemoteStoragePlatformAndroid = 32,
		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		k_ERemoteStoragePlatformIOS = 64,
		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		k_ERemoteStoragePlatformAll = -1
	}
}
