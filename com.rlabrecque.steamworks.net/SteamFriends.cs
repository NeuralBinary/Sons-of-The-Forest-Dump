using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public static class SteamFriends
	{
		// Token: 0x06000049 RID: 73 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x912D10", Offset = "0x911310", VA = "0x180912D10")]
		public static string GetPersonaName()
		{
			return null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x912DD0", Offset = "0x9113D0", VA = "0x180912DD0")]
		public static SteamAPICall_t SetPersonaName(string pchPersonaName)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x912FE0", Offset = "0x9115E0", VA = "0x180912FE0")]
		public static EPersonaState GetPersonaState()
		{
			return EPersonaState.k_EPersonaStateOffline;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x913090", Offset = "0x911690", VA = "0x180913090")]
		public static int GetFriendCount(EFriendFlags iFriendFlags)
		{
			return 0;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x913150", Offset = "0x911750", VA = "0x180913150")]
		public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags)
		{
			return default(CSteamID);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000266C File Offset: 0x0000086C
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x913250", Offset = "0x911850", VA = "0x180913250")]
		public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend)
		{
			return EFriendRelationship.k_EFriendRelationshipNone;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x913310", Offset = "0x911910", VA = "0x180913310")]
		public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend)
		{
			return EPersonaState.k_EPersonaStateOffline;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x9133D0", Offset = "0x9119D0", VA = "0x1809133D0")]
		public static string GetFriendPersonaName(CSteamID steamIDFriend)
		{
			return null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x9134A0", Offset = "0x911AA0", VA = "0x1809134A0")]
		public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo)
		{
			return default(bool);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x913570", Offset = "0x911B70", VA = "0x180913570")]
		public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName)
		{
			return null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x913650", Offset = "0x911C50", VA = "0x180913650")]
		public static int GetFriendSteamLevel(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x913710", Offset = "0x911D10", VA = "0x180913710")]
		public static string GetPlayerNickname(CSteamID steamIDPlayer)
		{
			return null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x9137E0", Offset = "0x911DE0", VA = "0x1809137E0")]
		public static int GetFriendsGroupCount()
		{
			return 0;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x913890", Offset = "0x911E90", VA = "0x180913890")]
		public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
		{
			return default(FriendsGroupID_t);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x913980", Offset = "0x911F80", VA = "0x180913980")]
		public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
		{
			return null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000026FC File Offset: 0x000008FC
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x913A50", Offset = "0x912050", VA = "0x180913A50")]
		public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
		{
			return 0;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x913B10", Offset = "0x912110", VA = "0x180913B10")]
		public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x913C00", Offset = "0x912200", VA = "0x180913C00")]
		public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags)
		{
			return default(bool);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000272C File Offset: 0x0000092C
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x913CD0", Offset = "0x9122D0", VA = "0x180913CD0")]
		public static int GetClanCount()
		{
			return 0;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002744 File Offset: 0x00000944
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x913D80", Offset = "0x912380", VA = "0x180913D80")]
		public static CSteamID GetClanByIndex(int iClan)
		{
			return default(CSteamID);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x913E70", Offset = "0x912470", VA = "0x180913E70")]
		public static string GetClanName(CSteamID steamIDClan)
		{
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x913F40", Offset = "0x912540", VA = "0x180913F40")]
		public static string GetClanTag(CSteamID steamIDClan)
		{
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000275C File Offset: 0x0000095C
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x914010", Offset = "0x912610", VA = "0x180914010")]
		public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting)
		{
			return default(bool);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x914110", Offset = "0x912710", VA = "0x180914110")]
		public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x914220", Offset = "0x912820", VA = "0x180914220")]
		public static int GetFriendCountFromSource(CSteamID steamIDSource)
		{
			return 0;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x9142E0", Offset = "0x9128E0", VA = "0x1809142E0")]
		public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend)
		{
			return default(CSteamID);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x9143E0", Offset = "0x9129E0", VA = "0x1809143E0")]
		public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource)
		{
			return default(bool);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x9144B0", Offset = "0x912AB0", VA = "0x1809144B0")]
		public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x914580", Offset = "0x912B80", VA = "0x180914580")]
		public static void ActivateGameOverlay(string pchDialog)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x914750", Offset = "0x912D50", VA = "0x180914750")]
		public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x914930", Offset = "0x912F30", VA = "0x180914930")]
		public static void ActivateGameOverlayToWebPage(string pchURL, EActivateGameOverlayToWebPageMode eMode = EActivateGameOverlayToWebPageMode.k_EActivateGameOverlayToWebPageMode_Default)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x914B10", Offset = "0x913110", VA = "0x180914B10")]
		public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x914BE0", Offset = "0x9131E0", VA = "0x180914BE0")]
		public static void SetPlayedWith(CSteamID steamIDUserPlayedWith)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x914CA0", Offset = "0x9132A0", VA = "0x180914CA0")]
		public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x914D60", Offset = "0x913360", VA = "0x180914D60")]
		public static int GetSmallFriendAvatar(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x914E20", Offset = "0x913420", VA = "0x180914E20")]
		public static int GetMediumFriendAvatar(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x914EE0", Offset = "0x9134E0", VA = "0x180914EE0")]
		public static int GetLargeFriendAvatar(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x914FA0", Offset = "0x9135A0", VA = "0x180914FA0")]
		public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly)
		{
			return default(bool);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x915070", Offset = "0x913670", VA = "0x180915070")]
		public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x915160", Offset = "0x913760", VA = "0x180915160")]
		public static CSteamID GetClanOwner(CSteamID steamIDClan)
		{
			return default(CSteamID);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250")]
		public static int GetClanOfficerCount(CSteamID steamIDClan)
		{
			return 0;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x915310", Offset = "0x913910", VA = "0x180915310")]
		public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer)
		{
			return default(CSteamID);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x915410", Offset = "0x913A10", VA = "0x180915410")]
		public static uint GetUserRestrictions()
		{
			return 0U;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x9154C0", Offset = "0x913AC0", VA = "0x1809154C0")]
		public static bool SetRichPresence(string pchKey, string pchValue)
		{
			return default(bool);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x915780", Offset = "0x913D80", VA = "0x180915780")]
		public static void ClearRichPresence()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x915830", Offset = "0x913E30", VA = "0x180915830")]
		public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey)
		{
			return null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x915A30", Offset = "0x914030", VA = "0x180915A30")]
		public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x915AF0", Offset = "0x9140F0", VA = "0x180915AF0")]
		public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey)
		{
			return null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x915BD0", Offset = "0x9141D0", VA = "0x180915BD0")]
		public static void RequestFriendRichPresence(CSteamID steamIDFriend)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x915C90", Offset = "0x914290", VA = "0x180915C90")]
		public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString)
		{
			return default(bool);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x915E80", Offset = "0x914480", VA = "0x180915E80")]
		public static int GetCoplayFriendCount()
		{
			return 0;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x915F30", Offset = "0x914530", VA = "0x180915F30")]
		public static CSteamID GetCoplayFriend(int iCoplayFriend)
		{
			return default(CSteamID);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x916020", Offset = "0x914620", VA = "0x180916020")]
		public static int GetFriendCoplayTime(CSteamID steamIDFriend)
		{
			return 0;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x9160E0", Offset = "0x9146E0", VA = "0x1809160E0")]
		public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend)
		{
			return default(AppId_t);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x9161D0", Offset = "0x9147D0", VA = "0x1809161D0")]
		public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x9162C0", Offset = "0x9148C0", VA = "0x1809162C0")]
		public static bool LeaveClanChatRoom(CSteamID steamIDClan)
		{
			return default(bool);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x916380", Offset = "0x914980", VA = "0x180916380")]
		public static int GetClanChatMemberCount(CSteamID steamIDClan)
		{
			return 0;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x916440", Offset = "0x914A40", VA = "0x180916440")]
		public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser)
		{
			return default(CSteamID);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x916540", Offset = "0x914B40", VA = "0x180916540")]
		public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText)
		{
			return default(bool);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x916730", Offset = "0x914D30", VA = "0x180916730")]
		public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter)
		{
			return 0;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x916920", Offset = "0x914F20", VA = "0x180916920")]
		public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser)
		{
			return default(bool);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x9169F0", Offset = "0x914FF0", VA = "0x1809169F0")]
		public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x916AB0", Offset = "0x9150B0", VA = "0x180916AB0")]
		public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x916B70", Offset = "0x915170", VA = "0x180916B70")]
		public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x916C30", Offset = "0x915230", VA = "0x180916C30")]
		public static bool SetListenForFriendsMessages(bool bInterceptEnabled)
		{
			return default(bool);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x916CF0", Offset = "0x9152F0", VA = "0x180916CF0")]
		public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend)
		{
			return default(bool);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x916EE0", Offset = "0x9154E0", VA = "0x180916EE0")]
		public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return 0;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x9170C0", Offset = "0x9156C0", VA = "0x1809170C0")]
		public static SteamAPICall_t GetFollowerCount(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x9171B0", Offset = "0x9157B0", VA = "0x1809171B0")]
		public static SteamAPICall_t IsFollowing(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x9172A0", Offset = "0x9158A0", VA = "0x1809172A0")]
		public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x917390", Offset = "0x915990", VA = "0x180917390")]
		public static bool IsClanPublic(CSteamID steamIDClan)
		{
			return default(bool);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x917450", Offset = "0x915A50", VA = "0x180917450")]
		public static bool IsClanOfficialGameGroup(CSteamID steamIDClan)
		{
			return default(bool);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x917510", Offset = "0x915B10", VA = "0x180917510")]
		public static int GetNumChatsWithUnreadPriorityMessages()
		{
			return 0;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x9175C0", Offset = "0x915BC0", VA = "0x1809175C0")]
		public static void ActivateGameOverlayRemotePlayTogetherInviteDialog(CSteamID steamIDLobby)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x917680", Offset = "0x915C80", VA = "0x180917680")]
		public static bool RegisterProtocolInOverlayBrowser(string pchProtocol)
		{
			return default(bool);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x917870", Offset = "0x915E70", VA = "0x180917870")]
		public static void ActivateGameOverlayInviteDialogConnectString(string pchConnectString)
		{
		}
	}
}
