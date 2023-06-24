using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public static class SteamUtils
	{
		// Token: 0x0600046C RID: 1132 RVA: 0x0000785C File Offset: 0x00005A5C
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x94FE40", Offset = "0x94E440", VA = "0x18094FE40")]
		public static uint GetSecondsSinceAppActive()
		{
			return 0U;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00007874 File Offset: 0x00005A74
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x94FE90", Offset = "0x94E490", VA = "0x18094FE90")]
		public static uint GetSecondsSinceComputerActive()
		{
			return 0U;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000788C File Offset: 0x00005A8C
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x94FEE0", Offset = "0x94E4E0", VA = "0x18094FEE0")]
		public static EUniverse GetConnectedUniverse()
		{
			return EUniverse.k_EUniverseInvalid;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000078A4 File Offset: 0x00005AA4
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x94FF30", Offset = "0x94E530", VA = "0x18094FF30")]
		public static uint GetServerRealTime()
		{
			return 0U;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x94FF80", Offset = "0x94E580", VA = "0x18094FF80")]
		public static string GetIPCountry()
		{
			return null;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000078BC File Offset: 0x00005ABC
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x94FFD0", Offset = "0x94E5D0", VA = "0x18094FFD0")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x000078D4 File Offset: 0x00005AD4
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x950050", Offset = "0x94E650", VA = "0x180950050")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000078EC File Offset: 0x00005AEC
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x9500D0", Offset = "0x94E6D0", VA = "0x1809500D0")]
		public static byte GetCurrentBatteryPower()
		{
			return 0;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00007904 File Offset: 0x00005B04
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x950120", Offset = "0x94E720", VA = "0x180950120")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000791C File Offset: 0x00005B1C
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x9501F0", Offset = "0x94E7F0", VA = "0x1809501F0")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00007934 File Offset: 0x00005B34
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x950250", Offset = "0x94E850", VA = "0x180950250")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return ESteamAPICallFailure.k_ESteamAPICallFailureSteamGone;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000794C File Offset: 0x00005B4C
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x9502A0", Offset = "0x94E8A0", VA = "0x1809502A0")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00007964 File Offset: 0x00005B64
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x950330", Offset = "0x94E930", VA = "0x180950330")]
		public static uint GetIPCCallCount()
		{
			return 0U;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x950380", Offset = "0x94E980", VA = "0x180950380")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000797C File Offset: 0x00005B7C
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x9503D0", Offset = "0x94E9D0", VA = "0x1809503D0")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00007994 File Offset: 0x00005B94
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x950420", Offset = "0x94EA20", VA = "0x180950420")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000079AC File Offset: 0x00005BAC
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x950470", Offset = "0x94EA70", VA = "0x180950470")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000079C4 File Offset: 0x00005BC4
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x9505B0", Offset = "0x94EBB0", VA = "0x1809505B0")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000079DC File Offset: 0x00005BDC
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x950790", Offset = "0x94ED90", VA = "0x180950790")]
		public static uint GetEnteredGamepadTextLength()
		{
			return 0U;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000079F4 File Offset: 0x00005BF4
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x9507E0", Offset = "0x94EDE0", VA = "0x1809507E0")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x950940", Offset = "0x94EF40", VA = "0x180950940")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00007A0C File Offset: 0x00005C0C
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x950990", Offset = "0x94EF90", VA = "0x180950990")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x9509E0", Offset = "0x94EFE0", VA = "0x1809509E0")]
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00007A24 File Offset: 0x00005C24
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x950A40", Offset = "0x94F040", VA = "0x180950A40")]
		public static bool IsSteamInBigPictureMode()
		{
			return default(bool);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x950A90", Offset = "0x94F090", VA = "0x180950A90")]
		public static void StartVRDashboard()
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00007A3C File Offset: 0x00005C3C
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x950AE0", Offset = "0x94F0E0", VA = "0x180950AE0")]
		public static bool IsVRHeadsetStreamingEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x950B30", Offset = "0x94F130", VA = "0x180950B30")]
		public static void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00007A54 File Offset: 0x00005C54
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x950B80", Offset = "0x94F180", VA = "0x180950B80")]
		public static bool IsSteamChinaLauncher()
		{
			return default(bool);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00007A6C File Offset: 0x00005C6C
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x950BD0", Offset = "0x94F1D0", VA = "0x180950BD0")]
		public static bool InitFilterText(uint unFilterOptions = 0U)
		{
			return default(bool);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00007A84 File Offset: 0x00005C84
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x950C20", Offset = "0x94F220", VA = "0x180950C20")]
		public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText)
		{
			return 0;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00007A9C File Offset: 0x00005C9C
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x950E50", Offset = "0x94F450", VA = "0x180950E50")]
		public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol)
		{
			return ESteamIPv6ConnectivityState.k_ESteamIPv6ConnectivityState_Unknown;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00007AB4 File Offset: 0x00005CB4
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x950EA0", Offset = "0x94F4A0", VA = "0x180950EA0")]
		public static bool IsSteamRunningOnSteamDeck()
		{
			return default(bool);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00007ACC File Offset: 0x00005CCC
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x950EF0", Offset = "0x94F4F0", VA = "0x180950EF0")]
		public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight)
		{
			return default(bool);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x950F80", Offset = "0x94F580", VA = "0x180950F80")]
		public static void SetGameLauncherMode(bool bLauncherMode)
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00007AE4 File Offset: 0x00005CE4
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x950FD0", Offset = "0x94F5D0", VA = "0x180950FD0")]
		public static bool DismissFloatingGamepadTextInput()
		{
			return default(bool);
		}
	}
}
