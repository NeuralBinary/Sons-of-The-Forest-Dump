using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public enum EChatEntryType
	{
		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		k_EChatEntryTypeInvalid,
		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		k_EChatEntryTypeChatMsg,
		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		k_EChatEntryTypeTyping,
		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		k_EChatEntryTypeInviteGame,
		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		k_EChatEntryTypeEmote,
		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		k_EChatEntryTypeLeftConversation = 6,
		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		k_EChatEntryTypeEntered,
		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		k_EChatEntryTypeWasKicked,
		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		k_EChatEntryTypeWasBanned,
		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		k_EChatEntryTypeDisconnected,
		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		k_EChatEntryTypeHistoricalChat,
		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		k_EChatEntryTypeLinkBlocked = 14
	}
}
