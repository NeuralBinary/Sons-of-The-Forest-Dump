using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public enum EChatRoomEnterResponse
	{
		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		k_EChatRoomEnterResponseSuccess = 1,
		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		k_EChatRoomEnterResponseDoesntExist,
		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		k_EChatRoomEnterResponseNotAllowed,
		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		k_EChatRoomEnterResponseFull,
		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		k_EChatRoomEnterResponseError,
		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x4000832")]
		k_EChatRoomEnterResponseBanned,
		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		k_EChatRoomEnterResponseLimited,
		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		k_EChatRoomEnterResponseClanDisabled,
		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		k_EChatRoomEnterResponseCommunityBan,
		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		k_EChatRoomEnterResponseMemberBlockedYou,
		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		k_EChatRoomEnterResponseYouBlockedMember,
		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		k_EChatRoomEnterResponseRatelimitExceeded = 15
	}
}
