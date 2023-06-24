using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Save;

namespace Sons.Multiplayer
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public static class CoopSaveUtils
	{
		// Token: 0x06000103 RID: 259 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x30E0510", Offset = "0x30DEB10", VA = "0x1830E0510")]
		public static uint GetSaveIdForGuid(SaveGameType saveGameType, string guid)
		{
			return 0U;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x30E0790", Offset = "0x30DED90", VA = "0x1830E0790")]
		public static HashSet<string> GetAllAvailableSaveGameId(SaveGameType saveGameType)
		{
			return null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x30E0A70", Offset = "0x30DF070", VA = "0x1830E0A70")]
		public static void SavePlayerData()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x30E0C10", Offset = "0x30DF210", VA = "0x1830E0C10")]
		public static void LoadPlayerData()
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x30E0D00", Offset = "0x30DF300", VA = "0x1830E0D00")]
		public static bool GetSaveDetailsForSelectedSaveId(out string guid, out string mode)
		{
			return default(bool);
		}
	}
}
