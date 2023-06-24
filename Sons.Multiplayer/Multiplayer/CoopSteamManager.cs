using System;
using Il2CppDummyDll;
using Sons.Gui;
using Steamworks;

namespace Sons.Multiplayer
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public static class CoopSteamManager
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x30E16A0", Offset = "0x30DFCA0", VA = "0x1830E16A0")]
		public static void Initialize()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x30E2160", Offset = "0x30E0760", VA = "0x1830E2160")]
		private static void GameRichPresenceJoinRequested(GameRichPresenceJoinRequested_t param)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x30E2260", Offset = "0x30E0860", VA = "0x1830E2260")]
		public static void ShowDedicatedServerInviteDialog(CSteamID steamFriendId)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x30E2690", Offset = "0x30E0C90", VA = "0x1830E2690")]
		public static string BuildServerGameTags()
		{
			return null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x30E28C0", Offset = "0x30E0EC0", VA = "0x1830E28C0")]
		public static bool ParseVersionMatch(string tags)
		{
			return default(bool);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x30E2950", Offset = "0x30E0F50", VA = "0x1830E2950")]
		public static string ParseGameGuid(string tags)
		{
			return null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x30E2A20", Offset = "0x30E1020", VA = "0x1830E2A20")]
		public static bool ParsePasswordProtected(string tags)
		{
			return default(bool);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x30E2A70", Offset = "0x30E1070", VA = "0x1830E2A70")]
		public static int ParseWeakPasswordHash(string tags)
		{
			return 0;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x30E2C00", Offset = "0x30E1200", VA = "0x1830E2C00")]
		private static void GameLobbyJoinRequested(GameLobbyJoinRequested_t param)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x30E2D20", Offset = "0x30E1320", VA = "0x1830E2D20")]
		private static void LobbyInvite(LobbyInvite_t param)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x30E2E50", Offset = "0x30E1450", VA = "0x1830E2E50")]
		public static void ShowLobbyInviteDialog(ModalDialogManager.Dialog dialogType, CSteamID lobbyId)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x30E30E0", Offset = "0x30E16E0", VA = "0x1830E30E0")]
		private static void GameServerChangeRequested(GameServerChangeRequested_t param)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x30E31C0", Offset = "0x30E17C0", VA = "0x1830E31C0")]
		public static void Shutdown()
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x30E3630", Offset = "0x30E1C30", VA = "0x1830E3630")]
		public static void Dump(string tag, P2PSessionState_t s)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x30E3860", Offset = "0x30E1E60", VA = "0x1830E3860")]
		private static void P2PSessionConnectFail(P2PSessionConnectFail_t param)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x30E3BD0", Offset = "0x30E21D0", VA = "0x1830E3BD0")]
		private static void P2PSessionRequest(P2PSessionRequest_t param)
		{
		}

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x0")]
		private static bool runInit;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x8")]
		private static Callback<GameServerChangeRequested_t> GameServerChangeRequested_Callback;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x10")]
		private static Callback<LobbyInvite_t> LobbyInvite_Callback;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x18")]
		private static Callback<GameLobbyJoinRequested_t> LobbyJoin_Callback;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x20")]
		private static Callback<P2PSessionRequest_t> P2PSessionRequest_Callback;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x28")]
		private static Callback<P2PSessionConnectFail_t> P2PSessionConnectFail_Callback;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x30")]
		private static Callback<GameRichPresenceJoinRequested_t> DedicatedJoin_Callback;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		private const string GuidMatchPattern = "G:([a-f\\d]{8}-[a-f\\d]{4}-[a-f\\d]{4}-[a-f\\d]{4}-[a-f\\d]{12})";

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		private const string WeakPasswordMatchPattern = "Pwd:([0-9]{1,3})";
	}
}
