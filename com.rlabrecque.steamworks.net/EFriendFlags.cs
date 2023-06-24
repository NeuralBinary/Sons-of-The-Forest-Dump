using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	[Flags]
	public enum EFriendFlags
	{
		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		k_EFriendFlagNone = 0,
		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		k_EFriendFlagBlocked = 1,
		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		k_EFriendFlagFriendshipRequested = 2,
		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		k_EFriendFlagImmediate = 4,
		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		k_EFriendFlagClanMember = 8,
		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		k_EFriendFlagOnGameServer = 16,
		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		k_EFriendFlagRequestingFriendship = 128,
		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		k_EFriendFlagRequestingInfo = 256,
		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		k_EFriendFlagIgnored = 512,
		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		k_EFriendFlagIgnoredFriend = 1024,
		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		k_EFriendFlagChatMember = 4096,
		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		k_EFriendFlagAll = 65535
	}
}
