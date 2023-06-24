using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public static class SteamInput
	{
		// Token: 0x06000243 RID: 579 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x92D910", Offset = "0x92BF10", VA = "0x18092D910")]
		public static bool Init(bool bExplicitlyCallRunFrame)
		{
			return default(bool);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x92D9E0", Offset = "0x92BFE0", VA = "0x18092D9E0")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x92DAA0", Offset = "0x92C0A0", VA = "0x18092DAA0")]
		public static bool SetInputActionManifestFilePath(string pchInputActionManifestAbsolutePath)
		{
			return default(bool);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x92DC90", Offset = "0x92C290", VA = "0x18092DC90")]
		public static void RunFrame(bool bReservedValue = true)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x92DD50", Offset = "0x92C350", VA = "0x18092DD50")]
		public static bool BWaitForData(bool bWaitForever, uint unTimeout)
		{
			return default(bool);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x92DE30", Offset = "0x92C430", VA = "0x18092DE30")]
		public static bool BNewDataAvailable()
		{
			return default(bool);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x92DEF0", Offset = "0x92C4F0", VA = "0x18092DEF0")]
		public static int GetConnectedControllers(InputHandle_t[] handlesOut)
		{
			return 0;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x92E010", Offset = "0x92C610", VA = "0x18092E010")]
		public static void EnableDeviceCallbacks()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x92E0C0", Offset = "0x92C6C0", VA = "0x18092E0C0")]
		public static void EnableActionEventCallbacks(SteamInputActionEventCallbackPointer pCallback)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x92E190", Offset = "0x92C790", VA = "0x18092E190")]
		public static InputActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			return default(InputActionSetHandle_t);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x92E380", Offset = "0x92C980", VA = "0x18092E380")]
		public static void ActivateActionSet(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00004C64 File Offset: 0x00002E64
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x92E450", Offset = "0x92CA50", VA = "0x18092E450")]
		public static InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle)
		{
			return default(InputActionSetHandle_t);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x92E510", Offset = "0x92CB10", VA = "0x18092E510")]
		public static void ActivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x92E5E0", Offset = "0x92CBE0", VA = "0x18092E5E0")]
		public static void DeactivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x92E6B0", Offset = "0x92CCB0", VA = "0x18092E6B0")]
		public static void DeactivateAllActionSetLayers(InputHandle_t inputHandle)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00004C7C File Offset: 0x00002E7C
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x92E770", Offset = "0x92CD70", VA = "0x18092E770")]
		public static int GetActiveActionSetLayers(InputHandle_t inputHandle, InputActionSetHandle_t[] handlesOut)
		{
			return 0;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00004C94 File Offset: 0x00002E94
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x92E8A0", Offset = "0x92CEA0", VA = "0x18092E8A0")]
		public static InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			return default(InputDigitalActionHandle_t);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00004CAC File Offset: 0x00002EAC
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x92EA90", Offset = "0x92D090", VA = "0x18092EA90")]
		public static InputDigitalActionData_t GetDigitalActionData(InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle)
		{
			return default(InputDigitalActionData_t);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x92EB60", Offset = "0x92D160", VA = "0x18092EB60")]
		public static int GetDigitalActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, EInputActionOrigin[] originsOut)
		{
			return 0;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x92ECC0", Offset = "0x92D2C0", VA = "0x18092ECC0")]
		public static string GetStringForDigitalActionName(InputDigitalActionHandle_t eActionHandle)
		{
			return null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00004CDC File Offset: 0x00002EDC
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x92ED90", Offset = "0x92D390", VA = "0x18092ED90")]
		public static InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			return default(InputAnalogActionHandle_t);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x92EF80", Offset = "0x92D580", VA = "0x18092EF80")]
		public static InputAnalogActionData_t GetAnalogActionData(InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle)
		{
			return default(InputAnalogActionData_t);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00004D0C File Offset: 0x00002F0C
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x92F080", Offset = "0x92D680", VA = "0x18092F080")]
		public static int GetAnalogActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, EInputActionOrigin[] originsOut)
		{
			return 0;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x92F1E0", Offset = "0x92D7E0", VA = "0x18092F1E0")]
		public static string GetGlyphPNGForActionOrigin(EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags)
		{
			return null;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x92F2D0", Offset = "0x92D8D0", VA = "0x18092F2D0")]
		public static string GetGlyphSVGForActionOrigin(EInputActionOrigin eOrigin, uint unFlags)
		{
			return null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x92F3B0", Offset = "0x92D9B0", VA = "0x18092F3B0")]
		public static string GetGlyphForActionOrigin_Legacy(EInputActionOrigin eOrigin)
		{
			return null;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x92F480", Offset = "0x92DA80", VA = "0x18092F480")]
		public static string GetStringForActionOrigin(EInputActionOrigin eOrigin)
		{
			return null;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x92F550", Offset = "0x92DB50", VA = "0x18092F550")]
		public static string GetStringForAnalogActionName(InputAnalogActionHandle_t eActionHandle)
		{
			return null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x92F620", Offset = "0x92DC20", VA = "0x18092F620")]
		public static void StopAnalogActionMomentum(InputHandle_t inputHandle, InputAnalogActionHandle_t eAction)
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00004D24 File Offset: 0x00002F24
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x92F6F0", Offset = "0x92DCF0", VA = "0x18092F6F0")]
		public static InputMotionData_t GetMotionData(InputHandle_t inputHandle)
		{
			return default(InputMotionData_t);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x92F7E0", Offset = "0x92DDE0", VA = "0x18092F7E0")]
		public static void TriggerVibration(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x92F8C0", Offset = "0x92DEC0", VA = "0x18092F8C0")]
		public static void TriggerVibrationExtended(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed)
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x92F9D0", Offset = "0x92DFD0", VA = "0x18092F9D0")]
		public static void TriggerSimpleHapticEvent(InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x92FAF0", Offset = "0x92E0F0", VA = "0x18092FAF0")]
		public static void SetLEDColor(InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x92FC00", Offset = "0x92E200", VA = "0x18092FC00")]
		public static void Legacy_TriggerHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x92FCE0", Offset = "0x92E2E0", VA = "0x18092FCE0")]
		public static void Legacy_TriggerRepeatedHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00004D3C File Offset: 0x00002F3C
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x92FE00", Offset = "0x92E400", VA = "0x18092FE00")]
		public static bool ShowBindingPanel(InputHandle_t inputHandle)
		{
			return default(bool);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00004D54 File Offset: 0x00002F54
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x92FED0", Offset = "0x92E4D0", VA = "0x18092FED0")]
		public static ESteamInputType GetInputTypeForHandle(InputHandle_t inputHandle)
		{
			return ESteamInputType.k_ESteamInputType_Unknown;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00004D6C File Offset: 0x00002F6C
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x92FF90", Offset = "0x92E590", VA = "0x18092FF90")]
		public static InputHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			return default(InputHandle_t);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00004D84 File Offset: 0x00002F84
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x930050", Offset = "0x92E650", VA = "0x180930050")]
		public static int GetGamepadIndexForController(InputHandle_t ulinputHandle)
		{
			return 0;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x930110", Offset = "0x92E710", VA = "0x180930110")]
		public static string GetStringForXboxOrigin(EXboxOrigin eOrigin)
		{
			return null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x9301E0", Offset = "0x92E7E0", VA = "0x1809301E0")]
		public static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin)
		{
			return null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00004D9C File Offset: 0x00002F9C
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x9302B0", Offset = "0x92E8B0", VA = "0x1809302B0")]
		public static EInputActionOrigin GetActionOriginFromXboxOrigin(InputHandle_t inputHandle, EXboxOrigin eOrigin)
		{
			return EInputActionOrigin.k_EInputActionOrigin_None;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00004DB4 File Offset: 0x00002FB4
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x930380", Offset = "0x92E980", VA = "0x180930380")]
		public static EInputActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin)
		{
			return EInputActionOrigin.k_EInputActionOrigin_None;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00004DCC File Offset: 0x00002FCC
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x930450", Offset = "0x92EA50", VA = "0x180930450")]
		public static bool GetDeviceBindingRevision(InputHandle_t inputHandle, out int pMajor, out int pMinor)
		{
			return default(bool);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x930540", Offset = "0x92EB40", VA = "0x180930540")]
		public static uint GetRemotePlaySessionID(InputHandle_t inputHandle)
		{
			return 0U;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00004DFC File Offset: 0x00002FFC
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x930600", Offset = "0x92EC00", VA = "0x180930600")]
		public static ushort GetSessionInputConfigurationSettings()
		{
			return 0;
		}
	}
}
