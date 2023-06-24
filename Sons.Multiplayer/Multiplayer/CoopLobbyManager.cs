using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public static class CoopLobbyManager
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public static event Action OnActiveGameStarted
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x30D7980", Offset = "0x30D5F80", VA = "0x1830D7980")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x30D7AD0", Offset = "0x30D60D0", VA = "0x1830D7AD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public static event Action OnActiveLobbyMembersUpdated
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x30D7C20", Offset = "0x30D6220", VA = "0x1830D7C20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x30D7D70", Offset = "0x30D6370", VA = "0x1830D7D70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public static event Action OnHostLeftLobby
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x30D7EC0", Offset = "0x30D64C0", VA = "0x1830D7EC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x30D8010", Offset = "0x30D6610", VA = "0x1830D8010")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public static event Action OnPlayerLeaveRequested
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x30D8160", Offset = "0x30D6760", VA = "0x1830D8160")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x30D82B0", Offset = "0x30D68B0", VA = "0x1830D82B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public static event Action<PersonaStateChange_t> OnPersonaStateChanged
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x30D8400", Offset = "0x30D6A00", VA = "0x1830D8400")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x30D85C0", Offset = "0x30D6BC0", VA = "0x1830D85C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		private static event Action<CoopLobby[]> _lobbyMatchCallback
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x30D8780", Offset = "0x30D6D80", VA = "0x1830D8780")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x30D8940", Offset = "0x30D6F40", VA = "0x1830D8940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x1700002A")]
		public static CSteamID AutoJoin
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x30D8B00", Offset = "0x30D7100", VA = "0x1830D8B00")]
			get
			{
				return default(CSteamID);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x30D8B60", Offset = "0x30D7160", VA = "0x1830D8B60")]
		public static void SetAutoJoin(CSteamID lobbyId)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x30D8BC0", Offset = "0x30D71C0", VA = "0x1830D8BC0")]
		public static void LeaveActive()
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x30D8DB0", Offset = "0x30D73B0", VA = "0x1830D8DB0")]
		public static bool CanShowInvite(bool checkInLobby)
		{
			return default(bool);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x30D8F60", Offset = "0x30D7560", VA = "0x1830D8F60")]
		public static void SetActiveClientInstance(CoopLobby lobby)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x30D90C0", Offset = "0x30D76C0", VA = "0x1830D90C0")]
		public static void SetActiveServerInstance(CoopLobby lobby)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x30D9680", Offset = "0x30D7C80", VA = "0x1830D9680")]
		private static bool IsInLobby(CSteamID lobbyId)
		{
			return default(bool);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x30D9740", Offset = "0x30D7D40", VA = "0x1830D9740")]
		public static void ClearHostGuid()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x30D9810", Offset = "0x30D7E10", VA = "0x1830D9810")]
		public static CoopLobby GetActiveInstance()
		{
			return null;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002B")]
		public static IEnumerable<CoopLobby> Lobbies
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x30D9870", Offset = "0x30D7E70", VA = "0x1830D9870")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x30D98D0", Offset = "0x30D7ED0", VA = "0x1830D98D0")]
		public static void AddLobbyQueryCallback(Action<CoopLobby[]> resultAction)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x30D9920", Offset = "0x30D7F20", VA = "0x1830D9920")]
		public static void RemoveLobbyQueryCallback(Action<CoopLobby[]> resultAction)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x30D9970", Offset = "0x30D7F70", VA = "0x1830D9970")]
		public static void DoLobbyRefresh(string queryFilter)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x30D99C0", Offset = "0x30D7FC0", VA = "0x1830D99C0")]
		public static void QueryList(string queryFilter)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x30DA0D0", Offset = "0x30D86D0", VA = "0x1830DA0D0")]
		public static void Create(string name, int memberLimit, bool isPrivate, Action callback, Action callbackFail)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x30DA3B0", Offset = "0x30D89B0", VA = "0x1830DA3B0")]
		public static void Join(ulong lobbyId, Action callback, Action<string> callbackFail)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x30DA6D0", Offset = "0x30D8CD0", VA = "0x1830DA6D0")]
		public static void Join(CoopLobby info, Action callback, Action<string> callbackFail)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x30DA750", Offset = "0x30D8D50", VA = "0x1830DA750")]
		public static CoopLobby FindLobby(ulong id)
		{
			return null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x30DA7A0", Offset = "0x30D8DA0", VA = "0x1830DA7A0")]
		public static CoopLobby FindLobby(CSteamID id)
		{
			return null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x30DA8A0", Offset = "0x30D8EA0", VA = "0x1830DA8A0")]
		public static void RemoveLobby(CSteamID id)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x30DA9A0", Offset = "0x30D8FA0", VA = "0x1830DA9A0")]
		private static void LobbyEnter(LobbyEnter_t param)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x30DB070", Offset = "0x30D9670", VA = "0x1830DB070")]
		private static void LobbyCreated(LobbyCreated_t param)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x30DB5F0", Offset = "0x30D9BF0", VA = "0x1830DB5F0")]
		private static void LobbyChatUpdate(LobbyChatUpdate_t param)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x30DB910", Offset = "0x30D9F10", VA = "0x1830DB910")]
		private static bool IsLeavingEvent(LobbyChatUpdate_t param)
		{
			return default(bool);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x30DB960", Offset = "0x30D9F60", VA = "0x1830DB960")]
		private static void LobbyGameCreated(LobbyGameCreated_t param)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x30DBBC0", Offset = "0x30DA1C0", VA = "0x1830DBBC0")]
		private static void LobbyDataUpdate(LobbyDataUpdate_t param)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x30DBE20", Offset = "0x30DA420", VA = "0x1830DBE20")]
		private static void LobbyMatchList(LobbyMatchList_t param)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x30DC0D0", Offset = "0x30DA6D0", VA = "0x1830DC0D0")]
		public static CoopLobby GetOrAddLobby(ulong id, bool update = true)
		{
			return null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x30DC130", Offset = "0x30DA730", VA = "0x1830DC130")]
		public static CoopLobby GetOrAddLobby(CSteamID id, bool update = true)
		{
			return null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x30DC250", Offset = "0x30DA850", VA = "0x1830DC250")]
		public static void Initialize()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x30DD240", Offset = "0x30DB840", VA = "0x1830DD240")]
		public static void RequestPlayerLeave(CSteamID id)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x30DD430", Offset = "0x30DBA30", VA = "0x1830DD430")]
		private static void LobbyChatMessage(LobbyChatMsg_t param)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x30DD720", Offset = "0x30DBD20", VA = "0x1830DD720")]
		public static void Shutdown()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x30DDE80", Offset = "0x30DC480", VA = "0x1830DDE80")]
		private static uint GetSaveIdForActiveLobby()
		{
			return 0U;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x30DDF00", Offset = "0x30DC500", VA = "0x1830DDF00")]
		private static void PersonaStateChange(PersonaStateChange_t param)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x30DE0B0", Offset = "0x30DC6B0", VA = "0x1830DE0B0")]
		private static CoopLobbyMember GetMemberDetails(CSteamID id, bool forceRefresh = false)
		{
			return null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x30DE720", Offset = "0x30DCD20", VA = "0x1830DE720")]
		private static Texture2D GetSteamImageAsTexture2D(int handle)
		{
			return null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x30DEC10", Offset = "0x30DD210", VA = "0x1830DEC10")]
		public static bool IsInLobby()
		{
			return default(bool);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x30DED00", Offset = "0x30DD300", VA = "0x1830DED00")]
		public static CSteamID ActiveServerId()
		{
			return default(CSteamID);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x30DEDA0", Offset = "0x30DD3A0", VA = "0x1830DEDA0")]
		public static CSteamID ActiveLobbyId()
		{
			return default(CSteamID);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x30DEE30", Offset = "0x30DD430", VA = "0x1830DEE30")]
		public static CSteamID ActiveOwnerSteamId()
		{
			return default(CSteamID);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x30DEEE0", Offset = "0x30DD4E0", VA = "0x1830DEEE0")]
		public static int ActiveMemberLimit()
		{
			return 0;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x30DEF70", Offset = "0x30DD570", VA = "0x1830DEF70")]
		public static int ActiveMemberCount()
		{
			return 0;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x30DF020", Offset = "0x30DD620", VA = "0x1830DF020")]
		public static string ActiveName()
		{
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x30DF0D0", Offset = "0x30DD6D0", VA = "0x1830DF0D0")]
		public static string ActiveGuid()
		{
			return null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x30DF160", Offset = "0x30DD760", VA = "0x1830DF160")]
		public static bool ActiveIsValid()
		{
			return default(bool);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x30DF1F0", Offset = "0x30DD7F0", VA = "0x1830DF1F0")]
		public static bool ActiveIsDestroyed()
		{
			return default(bool);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x30DF280", Offset = "0x30DD880", VA = "0x1830DF280")]
		public static bool ActiveIsOwner()
		{
			return default(bool);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x30DF310", Offset = "0x30DD910", VA = "0x1830DF310")]
		public static void SetActiveServer(CSteamID getSteamID)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x30DF470", Offset = "0x30DDA70", VA = "0x1830DF470")]
		public static IEnumerable<CSteamID> GetActiveMembers()
		{
			return null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x30DF510", Offset = "0x30DDB10", VA = "0x1830DF510")]
		public static IEnumerable<CoopLobbyMember> GetActiveMembersDetails()
		{
			return null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x30DF6F0", Offset = "0x30DDCF0", VA = "0x1830DF6F0")]
		public static void DestroyActive()
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x30DF810", Offset = "0x30DDE10", VA = "0x1830DF810")]
		public static void SetActiveGuid(string guid)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x30DFB10", Offset = "0x30DE110", VA = "0x1830DFB10")]
		public static void SetActiveCurrentMembers(int value)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x30DFBB0", Offset = "0x30DE1B0", VA = "0x1830DFBB0")]
		public static void SetActivePrefabDbVersion(string value)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x30DFD80", Offset = "0x30DE380", VA = "0x1830DFD80")]
		private static void GetBytes(byte[] buffer, int index, ulong value)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x30DFE50", Offset = "0x30DE450", VA = "0x1830DFE50")]
		private static ulong ToUInt64(byte[] buffer, int index)
		{
			return 0UL;
		}

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] _inviteSceneWhitelist;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		public const string FULL_KEY = "FULL";

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x8")]
		private static bool runInit;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x38")]
		private static Action enterCallback;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x40")]
		private static Action<string> enterFailCallback;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x48")]
		private static Action createCallback;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x50")]
		private static Action createFailCallback;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x58")]
		private static CoopLobby createValues;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x60")]
		private static Callback<LobbyMatchList_t> LobbyMatchList_Callback;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x68")]
		private static Callback<LobbyDataUpdate_t> LobbyDataUpdate_Callback;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x70")]
		private static Callback<LobbyCreated_t> LobbyCreated_Callback;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x78")]
		private static Callback<LobbyEnter_t> LobbyEnter_Callback;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x80")]
		private static Callback<LobbyGameCreated_t> LobbyGameCreated_Callback;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x88")]
		private static Callback<LobbyChatUpdate_t> LobbyChatUpdate_Callback;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x90")]
		private static Callback<PersonaStateChange_t> PersonaStateChange_Callback;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x98")]
		private static Callback<LobbyChatMsg_t> LobbyChatMsg_Callback;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0xA0")]
		private static List<CoopLobby> LobbyMatchList_Result;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0xA8")]
		private static CSteamID _autoJoin;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0xB0")]
		private static CoopLobby _activeInstance;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0xC0")]
		private static Dictionary<int, Texture2D> _avatarCached;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0xC8")]
		private static Dictionary<ulong, CoopLobbyMember> _membersCached;
	}
}
