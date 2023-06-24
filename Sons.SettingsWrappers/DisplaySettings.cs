using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sons.Settings
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[AddComponentMenu("Sons/Settings/DisplaySettings")]
	public class DisplaySettings : MonoBehaviour
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x3139B40", Offset = "0x3138140", VA = "0x183139B40")]
		private void Awake()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x3139B80", Offset = "0x3138180", VA = "0x183139B80")]
		private void OnEnable()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x3139C20", Offset = "0x3138220", VA = "0x183139C20")]
		private IEnumerator DelaySetup()
		{
			return null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x3139CB0", Offset = "0x31382B0", VA = "0x183139CB0")]
		private void SetupCallbacks()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x313A010", Offset = "0x3138610", VA = "0x18313A010")]
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x313A2E0", Offset = "0x31388E0", VA = "0x18313A2E0")]
		private void BrightnessChanged(float value)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x313A400", Offset = "0x3138A00", VA = "0x18313A400")]
		private void GammaChanged(float value)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x313A520", Offset = "0x3138B20", VA = "0x18313A520")]
		public static void SetTargetFrameRate(float value)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x313A6B0", Offset = "0x3138CB0", VA = "0x18313A6B0")]
		public static string ResolutionToString(Resolution res)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x313A860", Offset = "0x3138E60", VA = "0x18313A860")]
		private static int GetGreatestCommonDivisor(int a, int b)
		{
			return 0;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x313A8F0", Offset = "0x3138EF0", VA = "0x18313A8F0")]
		private static string GetGreatestCommonDivisorString(Resolution res, string prefix, string suffix)
		{
			return null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x313AB30", Offset = "0x3139130", VA = "0x18313AB30")]
		public static string GetDefaultResolution()
		{
			return null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x313ABD0", Offset = "0x31391D0", VA = "0x18313ABD0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x313ACD0", Offset = "0x31392D0", VA = "0x18313ACD0")]
		private static void SetScreenResolution(int width, int height)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x313AD60", Offset = "0x3139360", VA = "0x18313AD60")]
		public static void ResolutionChanged(string screenResolutionString)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x313AEC0", Offset = "0x31394C0", VA = "0x18313AEC0")]
		private static int[] ConvertResolution(string resString)
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x313B0F0", Offset = "0x31396F0", VA = "0x18313B0F0")]
		private void VSyncChanged(string vsyncValue)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x313B290", Offset = "0x3139890", VA = "0x18313B290")]
		private void FullscreenModeChanged(string fullscreenMode)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x313B460", Offset = "0x3139A60", VA = "0x18313B460")]
		public static void RestoreResolution()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x313B640", Offset = "0x3139C40", VA = "0x18313B640")]
		public DisplaySettings()
		{
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<object> _registeredActionPairs;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		public const string ResolutionSettingKey = "Display.Resolution";

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		public const string BrightnessSettingKey = "Display.Brightness";

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		public const string GammaSettingKey = "Display.Gamma";

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		public const string FullscreenSettingKey = "Display.Fullscreen";

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		public const string VSyncSettingKey = "Display.VSync";

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		public const string TargetFrameRateSettingKey = "Display.TargetFrameRate";

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float BrightnessSettingDefault;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x4")]
		public static readonly float GammaSettingDefault;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x8")]
		private static readonly char[] ResolutionSplitChars;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		public const string VSyncSettingDefault = "Disabled";

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		public const float TargetFrameRateSettingDefault = 240f;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		public const float TargetFrameRateSettingMin = 20f;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		public const float TargetFrameRateSettingMax = 240f;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x10")]
		public static readonly List<string> VSyncSettingOptions;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		public const string FullscreenSettingDefault = "Exclusive FullScreen";

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x18")]
		public static readonly List<string> FullscreenSettingOptions;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x20")]
		public static FullScreenMode[] FullscreenModeValues;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		private const string RatioPrefix = " (";

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		private const string RatioSuffix = ")";
	}
}
