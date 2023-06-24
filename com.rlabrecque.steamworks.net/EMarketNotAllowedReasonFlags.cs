using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	[Flags]
	public enum EMarketNotAllowedReasonFlags
	{
		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		k_EMarketNotAllowedReason_None = 0,
		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		k_EMarketNotAllowedReason_TemporaryFailure = 1,
		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		k_EMarketNotAllowedReason_AccountDisabled = 2,
		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		k_EMarketNotAllowedReason_AccountLockedDown = 4,
		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x4000861")]
		k_EMarketNotAllowedReason_AccountLimited = 8,
		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x4000862")]
		k_EMarketNotAllowedReason_TradeBanned = 16,
		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x4000863")]
		k_EMarketNotAllowedReason_AccountNotTrusted = 32,
		// Token: 0x04000864 RID: 2148
		[Token(Token = "0x4000864")]
		k_EMarketNotAllowedReason_SteamGuardNotEnabled = 64,
		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x4000865")]
		k_EMarketNotAllowedReason_SteamGuardOnlyRecentlyEnabled = 128,
		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		k_EMarketNotAllowedReason_RecentPasswordReset = 256,
		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		k_EMarketNotAllowedReason_NewPaymentMethod = 512,
		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		k_EMarketNotAllowedReason_InvalidCookie = 1024,
		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		k_EMarketNotAllowedReason_UsingNewDevice = 2048,
		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		k_EMarketNotAllowedReason_RecentSelfRefund = 4096,
		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		k_EMarketNotAllowedReason_NewPaymentMethodCannotBeVerified = 8192,
		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		k_EMarketNotAllowedReason_NoRecentPurchases = 16384,
		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		k_EMarketNotAllowedReason_AcceptedWalletGift = 32768
	}
}
