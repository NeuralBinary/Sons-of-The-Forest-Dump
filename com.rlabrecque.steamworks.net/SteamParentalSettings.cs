using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public static class SteamParentalSettings
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00006314 File Offset: 0x00004514
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x93EA30", Offset = "0x93D030", VA = "0x18093EA30")]
		public static bool BIsParentalLockEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000632C File Offset: 0x0000452C
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x93EAF0", Offset = "0x93D0F0", VA = "0x18093EAF0")]
		public static bool BIsParentalLockLocked()
		{
			return default(bool);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00006344 File Offset: 0x00004544
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x93EBB0", Offset = "0x93D1B0", VA = "0x18093EBB0")]
		public static bool BIsAppBlocked(AppId_t nAppID)
		{
			return default(bool);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000635C File Offset: 0x0000455C
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x93EC70", Offset = "0x93D270", VA = "0x18093EC70")]
		public static bool BIsAppInBlockList(AppId_t nAppID)
		{
			return default(bool);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00006374 File Offset: 0x00004574
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x93ED30", Offset = "0x93D330", VA = "0x18093ED30")]
		public static bool BIsFeatureBlocked(EParentalFeature eFeature)
		{
			return default(bool);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000638C File Offset: 0x0000458C
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x93EDF0", Offset = "0x93D3F0", VA = "0x18093EDF0")]
		public static bool BIsFeatureInBlockList(EParentalFeature eFeature)
		{
			return default(bool);
		}
	}
}
