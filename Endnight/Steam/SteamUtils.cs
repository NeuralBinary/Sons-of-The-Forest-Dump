using System;
using Il2CppDummyDll;

namespace Endnight.Steam
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public static class SteamUtils
	{
		// Token: 0x060002AE RID: 686 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xA91580", Offset = "0xA8FB80", VA = "0x180A91580")]
		public static bool IsSteamRunningOnSteamDeck()
		{
			return default(bool);
		}

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		private const string SteamDeckEnvString = "SteamDeck";

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		private const string SteamOsEnvString = "SteamOS";
	}
}
