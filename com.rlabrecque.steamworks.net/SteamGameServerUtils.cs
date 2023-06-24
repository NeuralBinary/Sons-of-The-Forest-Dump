using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public static class SteamGameServerUtils
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x0000467C File Offset: 0x0000287C
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x928C80", Offset = "0x927280", VA = "0x180928C80")]
		public static uint GetSecondsSinceAppActive()
		{
			return 0U;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00004694 File Offset: 0x00002894
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x928CD0", Offset = "0x9272D0", VA = "0x180928CD0")]
		public static uint GetSecondsSinceComputerActive()
		{
			return 0U;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000046AC File Offset: 0x000028AC
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x928D20", Offset = "0x927320", VA = "0x180928D20")]
		public static EUniverse GetConnectedUniverse()
		{
			return EUniverse.k_EUniverseInvalid;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000046C4 File Offset: 0x000028C4
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x928D70", Offset = "0x927370", VA = "0x180928D70")]
		public static uint GetServerRealTime()
		{
			return 0U;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x928DC0", Offset = "0x9273C0", VA = "0x180928DC0")]
		public static string GetIPCountry()
		{
			return null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000046DC File Offset: 0x000028DC
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x928E10", Offset = "0x927410", VA = "0x180928E10")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000046F4 File Offset: 0x000028F4
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x928E90", Offset = "0x927490", VA = "0x180928E90")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000470C File Offset: 0x0000290C
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x928F10", Offset = "0x927510", VA = "0x180928F10")]
		public static byte GetCurrentBatteryPower()
		{
			return 0;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00004724 File Offset: 0x00002924
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x928F60", Offset = "0x927560", VA = "0x180928F60")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x928FE0", Offset = "0x9275E0", VA = "0x180928FE0")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000473C File Offset: 0x0000293C
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x929030", Offset = "0x927630", VA = "0x180929030")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00004754 File Offset: 0x00002954
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x929090", Offset = "0x927690", VA = "0x180929090")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return ESteamAPICallFailure.k_ESteamAPICallFailureSteamGone;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000476C File Offset: 0x0000296C
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x9290E0", Offset = "0x9276E0", VA = "0x1809290E0")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00004784 File Offset: 0x00002984
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x929170", Offset = "0x927770", VA = "0x180929170")]
		public static uint GetIPCCallCount()
		{
			return 0U;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x9291C0", Offset = "0x9277C0", VA = "0x1809291C0")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000479C File Offset: 0x0000299C
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x929210", Offset = "0x927810", VA = "0x180929210")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000047B4 File Offset: 0x000029B4
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x929260", Offset = "0x927860", VA = "0x180929260")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000047CC File Offset: 0x000029CC
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x9292B0", Offset = "0x9278B0", VA = "0x1809292B0")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000047E4 File Offset: 0x000029E4
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x9293F0", Offset = "0x9279F0", VA = "0x1809293F0")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000047FC File Offset: 0x000029FC
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x9295D0", Offset = "0x927BD0", VA = "0x1809295D0")]
		public static uint GetEnteredGamepadTextLength()
		{
			return 0U;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00004814 File Offset: 0x00002A14
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x929620", Offset = "0x927C20", VA = "0x180929620")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x929780", Offset = "0x927D80", VA = "0x180929780")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000482C File Offset: 0x00002A2C
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x9297D0", Offset = "0x927DD0", VA = "0x1809297D0")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x929820", Offset = "0x927E20", VA = "0x180929820")]
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00004844 File Offset: 0x00002A44
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x929880", Offset = "0x927E80", VA = "0x180929880")]
		public static bool IsSteamInBigPictureMode()
		{
			return default(bool);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x9298D0", Offset = "0x927ED0", VA = "0x1809298D0")]
		public static void StartVRDashboard()
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000485C File Offset: 0x00002A5C
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x929920", Offset = "0x927F20", VA = "0x180929920")]
		public static bool IsVRHeadsetStreamingEnabled()
		{
			return default(bool);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x929970", Offset = "0x927F70", VA = "0x180929970")]
		public static void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00004874 File Offset: 0x00002A74
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x9299C0", Offset = "0x927FC0", VA = "0x1809299C0")]
		public static bool IsSteamChinaLauncher()
		{
			return default(bool);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000488C File Offset: 0x00002A8C
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x929A10", Offset = "0x928010", VA = "0x180929A10")]
		public static bool InitFilterText(uint unFilterOptions = 0U)
		{
			return default(bool);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000048A4 File Offset: 0x00002AA4
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x929A60", Offset = "0x928060", VA = "0x180929A60")]
		public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText)
		{
			return 0;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000048BC File Offset: 0x00002ABC
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x929C90", Offset = "0x928290", VA = "0x180929C90")]
		public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol)
		{
			return ESteamIPv6ConnectivityState.k_ESteamIPv6ConnectivityState_Unknown;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000048D4 File Offset: 0x00002AD4
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x929CE0", Offset = "0x9282E0", VA = "0x180929CE0")]
		public static bool IsSteamRunningOnSteamDeck()
		{
			return default(bool);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000048EC File Offset: 0x00002AEC
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x929D30", Offset = "0x928330", VA = "0x180929D30")]
		public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight)
		{
			return default(bool);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x929DC0", Offset = "0x9283C0", VA = "0x180929DC0")]
		public static void SetGameLauncherMode(bool bLauncherMode)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00004904 File Offset: 0x00002B04
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x929E10", Offset = "0x928410", VA = "0x180929E10")]
		public static bool DismissFloatingGamepadTextInput()
		{
			return default(bool);
		}
	}
}
