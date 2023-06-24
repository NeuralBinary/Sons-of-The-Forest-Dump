using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public enum EDenyReason
	{
		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		k_EDenyInvalid,
		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		k_EDenyInvalidVersion,
		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		k_EDenyGeneric,
		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		k_EDenyNotLoggedOn,
		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		k_EDenyNoLicense,
		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		k_EDenyCheater,
		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		k_EDenyLoggedInElseWhere,
		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		k_EDenyUnknownText,
		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		k_EDenyIncompatibleAnticheat,
		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		k_EDenyMemoryCorruption,
		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		k_EDenyIncompatibleSoftware,
		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		k_EDenySteamConnectionLost,
		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		k_EDenySteamConnectionError,
		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		k_EDenySteamResponseTimedOut,
		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		k_EDenySteamValidationStalled,
		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		k_EDenySteamOwnerLeftGuestUser
	}
}
