using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public static class SteamGameServer
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x917A40", Offset = "0x916040", VA = "0x180917A40")]
		public static void SetProduct(string pszProduct)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x917C10", Offset = "0x916210", VA = "0x180917C10")]
		public static void SetGameDescription(string pszGameDescription)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x917DE0", Offset = "0x9163E0", VA = "0x180917DE0")]
		public static void SetModDir(string pszModDir)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x917FB0", Offset = "0x9165B0", VA = "0x180917FB0")]
		public static void SetDedicatedServer(bool bDedicated)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x918070", Offset = "0x916670", VA = "0x180918070")]
		public static void LogOn(string pszToken)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x918240", Offset = "0x916840", VA = "0x180918240")]
		public static void LogOnAnonymous()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x9182F0", Offset = "0x9168F0", VA = "0x1809182F0")]
		public static void LogOff()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x9183A0", Offset = "0x9169A0", VA = "0x1809183A0")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x918450", Offset = "0x916A50", VA = "0x180918450")]
		public static bool BSecure()
		{
			return default(bool);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x918500", Offset = "0x916B00", VA = "0x180918500")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x9185F0", Offset = "0x916BF0", VA = "0x1809185F0")]
		public static bool WasRestartRequested()
		{
			return default(bool);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9186A0", Offset = "0x916CA0", VA = "0x1809186A0")]
		public static void SetMaxPlayerCount(int cPlayersMax)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x918760", Offset = "0x916D60", VA = "0x180918760")]
		public static void SetBotPlayerCount(int cBotplayers)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x918820", Offset = "0x916E20", VA = "0x180918820")]
		public static void SetServerName(string pszServerName)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x9189F0", Offset = "0x916FF0", VA = "0x1809189F0")]
		public static void SetMapName(string pszMapName)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x918BC0", Offset = "0x9171C0", VA = "0x180918BC0")]
		public static void SetPasswordProtected(bool bPasswordProtected)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x918C80", Offset = "0x917280", VA = "0x180918C80")]
		public static void SetSpectatorPort(ushort unSpectatorPort)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x918D40", Offset = "0x917340", VA = "0x180918D40")]
		public static void SetSpectatorServerName(string pszSpectatorServerName)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x918F10", Offset = "0x917510", VA = "0x180918F10")]
		public static void ClearAllKeyValues()
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x918FC0", Offset = "0x9175C0", VA = "0x180918FC0")]
		public static void SetKeyValue(string pKey, string pValue)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x919270", Offset = "0x917870", VA = "0x180919270")]
		public static void SetGameTags(string pchGameTags)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x919440", Offset = "0x917A40", VA = "0x180919440")]
		public static void SetGameData(string pchGameData)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x919610", Offset = "0x917C10", VA = "0x180919610")]
		public static void SetRegion(string pszRegion)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x9197E0", Offset = "0x917DE0", VA = "0x1809197E0")]
		public static void SetAdvertiseServerActive(bool bActive)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x9198A0", Offset = "0x917EA0", VA = "0x1809198A0")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(HAuthTicket);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x9199C0", Offset = "0x917FC0", VA = "0x1809199C0")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return EBeginAuthSessionResult.k_EBeginAuthSessionResultOK;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x919AB0", Offset = "0x9180B0", VA = "0x180919AB0")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x919B70", Offset = "0x918170", VA = "0x180919B70")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x919C30", Offset = "0x918230", VA = "0x180919C30")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return EUserHasLicenseForAppResult.k_EUserHasLicenseResultHasLicense;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x919D00", Offset = "0x918300", VA = "0x180919D00")]
		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
		{
			return default(bool);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x919DD0", Offset = "0x9183D0", VA = "0x180919DD0")]
		public static void GetGameplayStats()
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x919E80", Offset = "0x918480", VA = "0x180919E80")]
		public static SteamAPICall_t GetServerReputation()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x919F70", Offset = "0x918570", VA = "0x180919F70")]
		public static SteamIPAddress_t GetPublicIP()
		{
			return default(SteamIPAddress_t);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x91A040", Offset = "0x918640", VA = "0x18091A040")]
		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort)
		{
			return default(bool);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x91A140", Offset = "0x918740", VA = "0x18091A140")]
		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
		{
			return 0;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x91A240", Offset = "0x918840", VA = "0x18091A240")]
		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x91A330", Offset = "0x918930", VA = "0x18091A330")]
		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x91A420", Offset = "0x918A20", VA = "0x18091A420")]
		public static bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
		{
			return default(bool);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x91A520", Offset = "0x918B20", VA = "0x18091A520")]
		public static CSteamID CreateUnauthenticatedUserConnection()
		{
			return default(CSteamID);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x91A610", Offset = "0x918C10", VA = "0x18091A610")]
		public static void SendUserDisconnect_DEPRECATED(CSteamID steamIDUser)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x91A6D0", Offset = "0x918CD0", VA = "0x18091A6D0")]
		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
		{
			return default(bool);
		}
	}
}
