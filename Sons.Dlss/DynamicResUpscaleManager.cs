using System;
using System.Collections.Generic;
using Assemblies.Sons.Dlss;
using Il2CppDummyDll;

namespace Sons.Dlss
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public static class DynamicResUpscaleManager
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public static string DynamicResUpscaleSettingDefault
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2F85370", Offset = "0x2F83970", VA = "0x182F85370")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x17000002")]
		public static bool IsOn
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2F85400", Offset = "0x2F83A00", VA = "0x182F85400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2F85450", Offset = "0x2F83A50", VA = "0x182F85450")]
		public static bool IsDlssSupported()
		{
			return default(bool);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2F85490", Offset = "0x2F83A90", VA = "0x182F85490")]
		public static void SetDynamicResolutionEnabled(bool value)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2F85660", Offset = "0x2F83C60", VA = "0x182F85660")]
		public static void EnableTaauSetting()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2F856C0", Offset = "0x2F83CC0", VA = "0x182F856C0")]
		public static void ApplyFsrSetting(string newValue)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2F85920", Offset = "0x2F83F20", VA = "0x182F85920")]
		public static void ApplyDlssSetting(string newValue)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2F85B80", Offset = "0x2F84180", VA = "0x182F85B80")]
		public static void ApplyAntiAliasSetting(string newValue)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2F85DE0", Offset = "0x2F843E0", VA = "0x182F85DE0")]
		private static void CleanUpReceivers()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2F860A0", Offset = "0x2F846A0", VA = "0x182F860A0")]
		private static bool MatchesActiveDlssSetting(string newValue)
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2F86100", Offset = "0x2F84700", VA = "0x182F86100")]
		private static bool MatchesActiveFsrSetting(string newValue)
		{
			return default(bool);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2F86160", Offset = "0x2F84760", VA = "0x182F86160")]
		private static bool MatchesActiveAntiAliasSetting(string newValue)
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2F861C0", Offset = "0x2F847C0", VA = "0x182F861C0")]
		public static bool SettingIsEqual(string settingA, string settingB)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2F86290", Offset = "0x2F84890", VA = "0x182F86290")]
		public static void Register(DynamicResolutionSettingReceiver dynamicResolutionSettingReceiver)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2F864D0", Offset = "0x2F84AD0", VA = "0x182F864D0")]
		public static void Unregister(DynamicResolutionSettingReceiver dynamicResolutionSettingReceiver)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2F86570", Offset = "0x2F84B70", VA = "0x182F86570")]
		public static void SetDynamicResUpscaleFilter(string newValue)
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		public const string DynamicResUpscaleDlssOption = "Dlss";

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		public const string DynamicResUpscaleFsrOption = "Fsr 1.0";

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		public const string DynamicResUpscaleTaauOption = "Taau";

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		public const string DynamicResUpscaleDisabledOption = "Off";

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		public const string DynamicResUpscaleSettingKey = "Graphics.DynamicResUpscale";

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		public const string FsrEnabledString = "Fsr 1.0";

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		public const string DlssDisabledString = "Off";

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		public const string DlssQualityString = "Quality";

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		public const string DlssBalancedString = "Balanced";

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		public const string DlssPerformanceString = "Performance";

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		public const string DlssSettingDefault = "Balanced";

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x0")]
		public static string AntiAliasOffOption;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x8")]
		public static string AntiAliasTaaOption;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		public static string AntiAliasFxaaOption;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		public static string AntiAliasSmaaOption;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		public static readonly List<string> DynamicResUpscaleOptions;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		public static readonly List<string> DlssOptions;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x30")]
		private static string _activeDlssQualitySetting;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x38")]
		private static string _activeFsrSetting;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x40")]
		private static string _activeAntiAliasSetting;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x48")]
		private static List<DynamicResolutionSettingReceiver> _dynamicResolutionSettingReceivers;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x50")]
		private static bool _dynamicResolutionEnabled;
	}
}
