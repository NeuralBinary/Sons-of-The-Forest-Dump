using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public static class SteamParties
	{
		// Token: 0x060002DD RID: 733 RVA: 0x0000563C File Offset: 0x0000383C
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x937990", Offset = "0x935F90", VA = "0x180937990")]
		public static uint GetNumActiveBeacons()
		{
			return 0U;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00005654 File Offset: 0x00003854
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x937A40", Offset = "0x936040", VA = "0x180937A40")]
		public static PartyBeaconID_t GetBeaconByIndex(uint unIndex)
		{
			return default(PartyBeaconID_t);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000566C File Offset: 0x0000386C
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x937B40", Offset = "0x936140", VA = "0x180937B40")]
		public static bool GetBeaconDetails(PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, out string pchMetadata, int cchMetadata)
		{
			return default(bool);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00005684 File Offset: 0x00003884
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x937D40", Offset = "0x936340", VA = "0x180937D40")]
		public static SteamAPICall_t JoinParty(PartyBeaconID_t ulBeaconID)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000569C File Offset: 0x0000389C
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x937E40", Offset = "0x936440", VA = "0x180937E40")]
		public static bool GetNumAvailableBeaconLocations(out uint puNumLocations)
		{
			return default(bool);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000056B4 File Offset: 0x000038B4
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x937F10", Offset = "0x936510", VA = "0x180937F10")]
		public static bool GetAvailableBeaconLocations(SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations)
		{
			return default(bool);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000056CC File Offset: 0x000038CC
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x937FF0", Offset = "0x9365F0", VA = "0x180937FF0")]
		public static SteamAPICall_t CreateBeacon(uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x9382F0", Offset = "0x9368F0", VA = "0x1809382F0")]
		public static void OnReservationCompleted(PartyBeaconID_t ulBeacon, CSteamID steamIDUser)
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x9383C0", Offset = "0x9369C0", VA = "0x1809383C0")]
		public static void CancelReservation(PartyBeaconID_t ulBeacon, CSteamID steamIDUser)
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000056E4 File Offset: 0x000038E4
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x938490", Offset = "0x936A90", VA = "0x180938490")]
		public static SteamAPICall_t ChangeNumOpenSlots(PartyBeaconID_t ulBeacon, uint unOpenSlots)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000056FC File Offset: 0x000038FC
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x9385A0", Offset = "0x936BA0", VA = "0x1809385A0")]
		public static bool DestroyBeacon(PartyBeaconID_t ulBeacon)
		{
			return default(bool);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00005714 File Offset: 0x00003914
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x938670", Offset = "0x936C70", VA = "0x180938670")]
		public static bool GetBeaconLocationData(SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, out string pchDataStringOut, int cchDataStringOut)
		{
			return default(bool);
		}
	}
}
